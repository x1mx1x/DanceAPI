using System.Collections.Generic;

public partial class Organizer
{
    public Organizer()
    {
        this.CompetitionCatalog = new HashSet<CompetitionCatalog>();
    }

    public int OrgId { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }
    public int? PhoneNumber { get; set; }
    public int DocId { get; set; }

    public virtual ICollection<CompetitionCatalog> CompetitionCatalog { get; set; }
    public virtual Document Document { get; set; }
}