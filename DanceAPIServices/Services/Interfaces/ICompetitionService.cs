using DanceAPIDataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceAPIServices.Services.Interfaces
{
    public interface ICompetitionService
    {
        object GetAll();
        CompetitionPageViewModel GetCompetitionById(int id);
    }
}
