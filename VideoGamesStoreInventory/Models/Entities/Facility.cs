using System.Net;

namespace VideoGamesStoreInventory.Models.Entities;

public class Facility
{
    public int Id { get; set; }
    public string Name { get; set; }
    public FacilityTypeId FacilityType { get; set; }
    public int AddressId { get; set; } // one to one
    public Address Address { get; set; } // virtual?
    //public int VideoGameId { get; set; } // one to many - how to represent one to many in EF?
    public List<VideoGame> VideoGames { get; set; }
}
