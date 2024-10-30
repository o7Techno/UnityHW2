public class GameResource
{
    public enum Resource
    {
        Humans,
        Food,
        Wood,
        Stone,
        Gold
    }
    
    public Resource resource { get; set; }
    public ObservableInt HumansProdLvl { get; set; }
    public ObservableInt FoodProdLvl { get; set; }
    public ObservableInt WoodProdLvl { get; set; }
    public ObservableInt StoneProdLvl { get; set; }
    public ObservableInt GoldProdLvl { get; set; }
    
    public GameResource(Resource r)
    {
        HumansProdLvl = new ObservableInt();
        FoodProdLvl = new ObservableInt();
        WoodProdLvl = new ObservableInt();
        StoneProdLvl = new ObservableInt();
        GoldProdLvl = new ObservableInt();
        resource = r;
    }
}
