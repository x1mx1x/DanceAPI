using System.Collections.Generic;

public partial class City
{
    public City()
    {
        this.CompetitionCatalog = new HashSet<CompetitionCatalog>();
    }

    public int CityId { get; set; }
    public string CityName { get; set; }

    public virtual ICollection<CompetitionCatalog> CompetitionCatalog { get; set; }
}