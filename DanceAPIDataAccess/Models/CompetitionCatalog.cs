namespace DanceAPIDataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompetitionCatalog")]
    public partial class CompetitionCatalog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompetitionCatalog()
        {
            Nomination = new HashSet<Nomination>();
        }

        public int CompetitionCatalogId { get; set; }

        [Required]
        [StringLength(100)]
        public string CompName { get; set; }

        public int CityId { get; set; }

        [Required]
        [StringLength(30)]
        public string StreetName { get; set; }

        public int HouseNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime CompDate { get; set; }

        public int OrgId { get; set; }

        public virtual City City { get; set; }

        public virtual Organizer Organizer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nomination> Nomination { get; set; }
    }
}
