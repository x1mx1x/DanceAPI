using System.Collections.Generic;

public partial class DanceForm
{
    public DanceForm()
    {
        this.Category = new HashSet<Category>();
    }

    public int DanceFormId { get; set; }
    public string DanceformName { get; set; }

    public virtual ICollection<Category> Category { get; set; }
}