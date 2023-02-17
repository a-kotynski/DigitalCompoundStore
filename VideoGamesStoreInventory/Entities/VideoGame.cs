namespace VideoGamesStoreInventory.Entities;

public class VideoGame
{
    public int Id { get; set; }
    public string Developer { get; set; }
    public string Publisher { get; set; }
    public string ConditionDescription { get; set; }
    public VideoGamePlatform VideoGamePlatform { get; set; } // each video game copy works on only one platform
    // products can change price due to defects noticed by a customer
    public decimal PriceBuyLow { get; set; }
    public decimal PriceBuyHigh { get; set; }
    public decimal PriceSellLow { get; set; }
    public decimal PriceSellHigh { get; set; }
    public virtual Facility Facility { get; set; } // property is virtual for future implementation of Lazy Loading (EF)
}
