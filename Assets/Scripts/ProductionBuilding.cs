using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ProductionBuilding : MonoBehaviour
{
    [SerializeField]
    GameResource.Resource resourceType;
    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    float ProductionTime;
    [SerializeField]
    Slider slider;
    GameResource resource;
    Button button;

    private void Awake()
    {
        if (!TryGetComponent<Button>(out button))
        {
            Debug.LogError("Button was not found.");
        }
        resource = gameManager.resourceBank.GetGameResource(resourceType);
    }

    IEnumerator ProgressCoroutine(float t)
    {
        float i = 0;
        slider.gameObject.SetActive(true);
        button.interactable = false;
        while (i < t)
        {
            i += Time.deltaTime;
            slider.value = i / t;
            yield return null;
        }
        slider.gameObject.SetActive(false);
        button.interactable = true;
        gameManager.resourceBank.ChangeResource(resource, 1);
    }


    public void StartProducing()
    {
        float productionLvl = 0;
        if (resourceType == GameResource.Resource.Humans)
        {
            productionLvl = resource.HumansProdLvl.Value;
        }
        else if (resourceType == GameResource.Resource.Food)
        {
            productionLvl = resource.FoodProdLvl.Value;
        }
        else if (resourceType == GameResource.Resource.Wood)
        {
            productionLvl = resource.WoodProdLvl.Value;
        }
        else if (resourceType == GameResource.Resource.Stone)
        {
            productionLvl = resource.StoneProdLvl.Value;
        }
        else if (resourceType == GameResource.Resource.Gold)
        {
            productionLvl = resource.GoldProdLvl.Value;
        }
        float time = ProductionTime * (1 - productionLvl / 100);
        StartCoroutine(ProgressCoroutine(time));
    }

}
