using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class LvlVisual : MonoBehaviour
{
    [SerializeField]
    GameResource.Resource resourceType;
    GameResource resource;
    [SerializeField]
    GameManager gameManager;
    TextMeshProUGUI Text;
    ObservableInt amount;

    private void Awake()
    {
        if (!TryGetComponent<TextMeshProUGUI>(out Text))
        {
            Debug.LogError("Text was not found");
        }
        resource = gameManager.resourceBank.GetGameResource(resourceType);
        
        if (resourceType == GameResource.Resource.Humans)
        {
            amount = resource.HumansProdLvl;
        }
        else if (resourceType == GameResource.Resource.Food)
        {
            amount = resource.FoodProdLvl;
        }
        else if (resourceType == GameResource.Resource.Wood)
        {
            amount = resource.WoodProdLvl;
        }
        else if (resourceType == GameResource.Resource.Stone)
        {
            amount = resource.StoneProdLvl;
        }
        else if (resourceType == GameResource.Resource.Gold)
        {
            amount = resource.GoldProdLvl;
        }
    }

    private void OnEnable()
    {
        amount.OnValueChanged += ChangeAmount;
    }

    private void OnDisable()
    {
        amount.OnValueChanged -= ChangeAmount;
    }

    private void ChangeAmount(int val)
    {
        Text.text = $"LVL {val}";
    }
}
