using System;
using System.Collections.Generic;

public partial class Category
{
    public Category()
    {
        this.Nomination = new HashSet<Nomination>();
    }

    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public int DanceGroupId { get; set; }
    public int DanceFormId { get; set; }
    public int AgeCategoryId { get; set; }

    public virtual AgeCategory AgeCategory { get; set; }
    public virtual DanceForm DanceForm { get; set; }
    public virtual DanceGroup DanceGroup { get; set; }
    public virtual ICollection<Nomination> Nomination { get; set; }
}