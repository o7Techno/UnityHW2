using UnityEngine;

public class GameManager : MonoBehaviour
{
    ResourceBank _resourceBank = new ResourceBank();
    public ResourceBank resourceBank
    {
        get
        {
            return _resourceBank;
        }
    }
    private void Awake()
    {
        resourceBank.resourceAmounts[resourceBank.GetGameResource(GameResource.Resource.Humans)].Value = 10;
        resourceBank.resourceAmounts[resourceBank.GetGameResource(GameResource.Resource.Food)].Value = 5;
        resourceBank.resourceAmounts[resourceBank.GetGameResource(GameResource.Resource.Wood)].Value = 5;
    }
}
