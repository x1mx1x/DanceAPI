using System.Collections.Generic;

public partial class Groups
{
    public Groups()
    {
        this.Nomination = new HashSet<Nomination>();
    }

    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public int? TrainerId { get; set; }

    public virtual Trainer Trainer { get; set; }
    public virtual ICollection<Nomination> Nomination { get; set; }
}