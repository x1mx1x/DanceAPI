namespace DanceAPIDataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nomination")]
    public partial class Nomination
    {
        public int NominationId { get; set; }

        public int CompId { get; set; }

        public int CategoryId { get; set; }

        public int? GroupId { get; set; }

        public int? DuetId { get; set; }

        public int? CompetitorId { get; set; }

        public int? Place { get; set; }

        public virtual Category Category { get; set; }

        public virtual CompetitionCatalog CompetitionCatalog { get; set; }

        public virtual Competitor Competitor { get; set; }

        public virtual Duets Duets { get; set; }

        public virtual Groups Groups { get; set; }
    }
}
