using UnityEngine;

public class UpgradeFunctionality : MonoBehaviour
{
    [SerializeField]
    GameResource.Resource resourceType;
    [SerializeField]
    GameManager gameManager;
    GameResource resource;

    private void Awake()
    {
        resource = gameManager.resourceBank.GetGameResource(resourceType);
    }
    public void AddLvl()
    {
        if (resourceType == GameResource.Resource.Humans)
        {
            if (resource.HumansProdLvl.Value < 99)
            {
                resource.HumansProdLvl.Value += 1;
            }
        }
        else if (resourceType == GameResource.Resource.Food)
        {
            if (resource.FoodProdLvl.Value < 99)
            {
                resource.FoodProdLvl.Value += 1;
            }
        }
        else if (resourceType == GameResource.Resource.Wood)
        {
            if (resource.WoodProdLvl.Value < 99)
            {
                resource.WoodProdLvl.Value += 1;
            }
        }
        else if (resourceType == GameResource.Resource.Stone)
        {
            if (resource.StoneProdLvl.Value < 99)
            {
                resource.StoneProdLvl.Value += 1;
            }
        }
        else if (resourceType == GameResource.Resource.Gold)
        {
            if (resource.GoldProdLvl.Value < 99)
            {
                resource.GoldProdLvl.Value += 1;
            }
        }
    }
}
