using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceAPIDataAccess.Models
{
    public class DuetCompetitor
    {
        public int DuetId { get; set; }
        public int CompetitorId { get; set; }
        public int Id { get; set; }

        public virtual Duets Duets { get; set; }
        public virtual Competitor Competitor { get; set; }
    }
}



