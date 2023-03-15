using System.ComponentModel.DataAnnotations;
using System.Net;

namespace DigitalCompoundStoreAPI.Entities;

public class Facility
{
    public int Id { get; set; }
    public string Name { get; set; }
    public FacilityType FacilityType { get; set; }

    // Navigation properties
    public int AddressId { get; set; } // one to one
    public virtual Address Address { get; set; } // property is virtual for future implementation of Lazy Loading (EF)
    public List<Product> Products { get; set; }
    public List<VideoGame> VideoGames { get; set; }
}
