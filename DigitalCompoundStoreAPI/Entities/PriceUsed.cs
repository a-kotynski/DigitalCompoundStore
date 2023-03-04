namespace DigitalCompoundStoreAPI.Entities;

public class PriceUsed
{
    public int Id { get; set; }
    public decimal PriceBuyLow { get; set; } // change to PriceBuy and delete PriceBuyHigh
    public decimal PriceBuyHigh { get; set; }
    public decimal PriceSellLow { get; set; }
    public decimal PriceSellHigh { get; set; }
}
