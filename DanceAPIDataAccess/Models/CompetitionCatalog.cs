using System.Collections.Generic;

public partial class CompetitionCatalog
{
    public CompetitionCatalog()
    {
        this.Nomination = new HashSet<Nomination>();
    }

    public int CompId { get; set; }
    public string CompName { get; set; }
    public int CityId { get; set; }
    public string StreetName { get; set; }
    public int HouseNumber { get; set; }
    public System.DateTime CompDate { get; set; }
    public int OrgId { get; set; }

    public virtual City City { get; set; }
    public virtual Organizer Organizer { get; set; }
    public virtual ICollection<Nomination> Nomination { get; set; }
}