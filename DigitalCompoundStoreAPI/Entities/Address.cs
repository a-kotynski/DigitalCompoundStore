namespace DigitalCompoundStoreAPI.Entities;

public class Address
{
    public int Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string ContactNumber { get; set; }
    public string ContactEmail { get; set; }

    // Navigation properties
    public int FacilityId { get; set; }
    public virtual Facility Facility { get; set; } // property is virtual for future implementation of Lazy Loading (EF)
}
