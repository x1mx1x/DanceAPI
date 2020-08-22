using DanceAPIDataAccess;
using DanceAPIServices.Services.Interfaces;
using StudySierrDataAccess.Domain.Repository;
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
           
            var comps =  (
                from comp in uow.CompetitionCatalogs.GetAll()
                select new { comp.CompName, comp.City, comp.CompDate }
            ).ToList();

            return new object();
            /*return (from competition in context.CompetitionCatalog
                    join city in context.City on competition.CityId equals city.CityId
                    select new { competition.CompName, competition.CompDate, }).ToList();*/
        }
    }
}