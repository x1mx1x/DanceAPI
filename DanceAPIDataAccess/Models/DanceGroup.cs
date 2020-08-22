using System.Collections.Generic;

public partial class DanceGroup
{
    public DanceGroup()
    {
        this.Category = new HashSet<Category>();
    }

    public int DanceGroupId { get; set; }
    public string DanceGroupName { get; set; }

    public virtual ICollection<Category> Category { get; set; }
}