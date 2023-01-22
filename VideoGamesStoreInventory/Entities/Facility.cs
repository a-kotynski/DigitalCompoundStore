using System.Net;

namespace VideoGamesStoreInventory.Entities;

public class Facility
{
    public int Id { get; set; }
    public string Name { get; set; }
    public FacilityType FacilityType { get; set; }
    public int AddressId { get; set; } // one to one
    public int VideoGameId { get; set; }
    public virtual Address Address { get; set; } // property is virtual for future implementation of Lazy Loading (EF)
    //public int VideoGameId { get; set; } // one to many - how to represent one to many in EF?
    public List<VideoGame> VideoGames { get; set; }
}
