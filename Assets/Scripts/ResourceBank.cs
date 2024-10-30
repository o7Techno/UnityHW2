using System.Collections.Generic;

public class ResourceBank
{
    public Dictionary<GameResource, ObservableInt> resourceAmounts = new Dictionary<GameResource, ObservableInt>();

    public ResourceBank()
    {
        foreach (GameResource.Resource r in System.Enum.GetValues(typeof(GameResource.Resource)))
        {
            resourceAmounts.Add(new GameResource(r), new ObservableInt());
        }
    }

    public void ChangeResource(GameResource r, int v)
    {
        resourceAmounts[r].Value += v;
    }

    public ObservableInt GetResource(GameResource r)
    {
        return resourceAmounts[r];
    }

    public GameResource GetGameResource(GameResource.Resource r)
    {
        foreach (var gameResource in resourceAmounts)
        {
            if (gameResource.Key.resource == r)
            {
                return gameResource.Key;
            }
        }
        return null;
    }
}
