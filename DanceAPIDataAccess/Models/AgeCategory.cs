
    using System;
    using System.Collections.Generic;

    public partial class AgeCategory
    {
        public AgeCategory()
        {
            this.Category = new HashSet<Category>();
        }

        public int AgeCategoryId { get; set; }
        public string AgeCategoryName { get; set; }
        public int LowerAgeLimit { get; set; }
        public int UpperAgeLimit { get; set; }

        public virtual ICollection<Category> Category { get; set; }
    }