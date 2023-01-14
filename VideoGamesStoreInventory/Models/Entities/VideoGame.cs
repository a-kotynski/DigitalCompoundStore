namespace VideoGamesStoreInventory.Models.Entities;

public class VideoGame
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Developer { get; set; }
    public string? Publisher { get; set; }
    public string ConditionDescription { get; set; }
    public GamePlatform GamePlatform { get; set; } // each video game copy works on only one platform
    public DateTime? DateBought { get; set; } // add popup callendar in the future
    public DateTime? DateSold { get; set; }
    public decimal PriceBuyLow { get; set; }
    public decimal PriceBuyHigh { get; set; }
    public decimal PriceSellLow { get; set; }
    public decimal PriceSellHigh { get; set; }
    public int FacilityId { get; set; }
    public virtual Facility Facility { get; set; } // property is virtual for future implementation of Lazy Loading (EF)
}
