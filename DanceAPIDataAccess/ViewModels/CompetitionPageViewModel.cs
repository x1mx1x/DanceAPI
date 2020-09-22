using DanceAPIDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceAPIDataAccess.ViewModels
{
    public class CompetitionPageViewModel
    {
        public int Id { get; set; }
        public string CompetitionName { get; set; }
        public DateTime CompDate { get; set; }
        public List<string> Categories { get; set; }
        public List<Competitor> Competitiors { get; set; }
        public Organizer Organizer{ get; set; }


    }
}
