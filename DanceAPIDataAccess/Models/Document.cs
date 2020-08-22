using System.Collections.Generic;

public partial class Document
{
    public Document()
    {
        this.Competitor = new HashSet<Competitor>();
        this.Organizer = new HashSet<Organizer>();
        this.Trainer = new HashSet<Trainer>();
    }

    public int DocId { get; set; }
    public int DocNameId { get; set; }
    public string DocSeries { get; set; }
    public int DocNumber { get; set; }
    public System.DateTime WhenIssues { get; set; }

    public virtual ICollection<Competitor> Competitor { get; set; }
    public virtual DocumentName DocumentName { get; set; }
    public virtual ICollection<Organizer> Organizer { get; set; }
    public virtual ICollection<Trainer> Trainer { get; set; }
}