using System.Collections.Generic;

public partial class DocumentName
{
    public DocumentName()
    {
        this.Document = new HashSet<Document>();
    }

    public int DocNameId { get; set; }
    public string DocName { get; set; }

    public virtual ICollection<Document> Document { get; set; }
}