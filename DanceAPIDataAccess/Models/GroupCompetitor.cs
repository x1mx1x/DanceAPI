using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceAPIDataAccess.Models
{
    public class GroupCompetitor
    {
        public int GroupId { get; set; }
        public int CompetitorId { get; set; }
        public int Id { get; set; }

        public virtual Groups Groups { get; set; }
        public virtual Competitor Competitor { get; set; }
    }
}
