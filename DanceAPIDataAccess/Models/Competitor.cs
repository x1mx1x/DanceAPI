using System.Collections.Generic;

public partial class Competitor
{
    public Competitor()
    {
        this.Nomination = new HashSet<Nomination>();
    }

    public int CompetitorId { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }
    public int? PhoneNumber { get; set; }
    public int DocId { get; set; }
    public int? TrainerId { get; set; }

    public virtual Document Document { get; set; }
    public virtual Trainer Trainer { get; set; }
    public virtual ICollection<Nomination> Nomination { get; set; }
}