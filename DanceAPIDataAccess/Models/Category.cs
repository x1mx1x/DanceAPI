namespace DanceAPIDataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Nomination = new HashSet<Nomination>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public int DanceGroupId { get; set; }

        public int DanceFormId { get; set; }

        public int AgeCategoryId { get; set; }

        public virtual AgeCategory AgeCategory { get; set; }

        public virtual DanceForm DanceForm { get; set; }

        public virtual DanceGroup DanceGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nomination> Nomination { get; set; }
    }
}
