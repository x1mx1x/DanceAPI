using DanceAPIDataAccess;
using DanceAPIServices.Services.Interfaces;
using System;
using System.Linq;

namespace DanceAPIServices.Services
{
    public class CompetitionService : ICompetitionService
    {
        #region Private members

        private readonly UnitOfWork uow;

        #endregion

        public CompetitionService(UnitOfWork uow)
        {
            this.uow = uow;
        }

        public object GetAll()
        {

            return  (
                from comp in uow.CompetitionCatalogs.GetAll()
                join city in uow.City.GetAll() on comp.CityId equals city.CityId
                select new { comp.CompName,city.CityName, comp.CompDate}
            ).ToList();
            /*return (from competition in context.CompetitionCatalog
                    join city in context.City on competition.CityId equals city.CityId
                    select new { competition.CompName, competition.CompDate, }).ToList();*/
        }
    }
}