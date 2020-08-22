using System.Collections.Generic;

public partial class Trainer
{
    public Trainer()
    {
        this.Competitor = new HashSet<Competitor>();
        this.Duets = new HashSet<Duets>();
        this.Groups = new HashSet<Groups>();
    }

    public int TrainerId { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }
    public int DocId { get; set; }

    public virtual ICollection<Competitor> Competitor { get; set; }
    public virtual Document Document { get; set; }
    public virtual ICollection<Duets> Duets { get; set; }
    public virtual ICollection<Groups> Groups { get; set; }
}