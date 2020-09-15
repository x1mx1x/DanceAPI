namespace DanceAPIDataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            Competitor = new HashSet<Competitor>();
            Organizer = new HashSet<Organizer>();
            Trainer = new HashSet<Trainer>();
        }

        public int DocumentId { get; set; }

        public int DocNameId { get; set; }

        [StringLength(2)]
        public string DocSeries { get; set; }

        public int DocNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime WhenIssues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competitor> Competitor { get; set; }

        public virtual DocumentName DocumentName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organizer> Organizer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trainer> Trainer { get; set; }
    }
}
