namespace DigitalCompoundStoreAPI.Entities;

public class VideoGame
{
    public int Id { get; set; }
    public string Developer { get; set; }
    public string Publisher { get; set; }
    public string ConditionDescription { get; set; }
    public VideoGamePlatform VideoGamePlatform { get; set; } // each video game copy works on only one platform
    public virtual Facility Facility { get; set; } // property is virtual for future implementation of Lazy Loading (EF)
}
