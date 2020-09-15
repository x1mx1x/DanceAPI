namespace DanceAPIDataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgeCategory")]
    public partial class AgeCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgeCategory()
        {
            Category = new HashSet<Category>();
        }

        public int AgeCategoryId { get; set; }

        [Required]
        [StringLength(20)]
        public string AgeCategoryName { get; set; }

        public int LowerAgeLimit { get; set; }

        public int UpperAgeLimit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Category { get; set; }
    }
}
