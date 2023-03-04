namespace DigitalCompoundStoreAPI.Entities;

public class PriceUsed
{
    public int Id { get; set; }
    public decimal PriceBuy { get; set; }
    public decimal PriceSellLow { get; set; }
    public decimal PriceSellHigh { get; set; }
}
