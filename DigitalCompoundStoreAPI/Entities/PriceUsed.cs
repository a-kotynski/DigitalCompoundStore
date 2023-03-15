using Microsoft.EntityFrameworkCore;

namespace DigitalCompoundStoreAPI.Entities;

public class PriceUsed
{
    public int Id { get; set; }

    [Precision(18, 2)]
    public decimal PriceBuy { get; set; }
    [Precision(18, 2)]
    public decimal PriceSellLow { get; set; }
    [Precision(18, 2)]
    public decimal PriceSellHigh { get; set; }
}
