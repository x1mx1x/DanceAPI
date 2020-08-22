using System.Collections.Generic;

public partial class Duets
{
    public Duets()
    {
        this.Nomination = new HashSet<Nomination>();
    }

    public int DuetId { get; set; }
    public string DuetName { get; set; }
    public int? TrainerId { get; set; }

    public virtual Trainer Trainer { get; set; }
    public virtual ICollection<Nomination> Nomination { get; set; }
}