using DanceAPIDataAccess;
using DanceAPIDataAccess.ViewModels;
using DanceAPIServices.Services.Interfaces;
using System;
using System.Linq;
using System.Security.Cryptography;

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
            return (
                from comp in uow.CompetitionCatalog.GetAll()
                join city in uow.City.GetAll() on comp.CityId equals city.CityId
                select new { comp.CompetitionCatalogId, comp.CompName, city.CityName, comp.CompDate }
            ).ToList();
        }
        public CompetitionPageViewModel GetCompetitionById(int id) {
            CompetitionPageViewModel competition = new CompetitionPageViewModel();
            competition.Categories = (from nom in uow.Nomination.GetAll()
                                      join cat in uow.Category.GetAll() on nom.CategoryId equals cat.CategoryId
                                      where nom.CompId == id
                                      select cat.CategoryName).ToList();
            competition.CompDate = (from comp in uow.CompetitionCatalog.GetAll()
                                    where comp.CompetitionCatalogId == id
                                    select comp.CompDate).FirstOrDefault();
            competition.Id = id;
            competition.CompetitionName = (from comp in uow.CompetitionCatalog.GetAll()
                                           where comp.CompetitionCatalogId == id
                                           select comp.CompName).FirstOrDefault();
            competition.Organizer = (from org in uow.Organizer.GetAll()
                                     join comp in uow.CompetitionCatalog.GetAll() on org.OrganizerId equals comp.OrgId
                                     where comp.CompetitionCatalogId == id
                                     select org).FirstOrDefault();
            //neccessary to add distinct
            competition.Competitiors = (from nom in uow.Nomination.GetAll()
                                        join gc in uow.GroupCompetitor.GetAll() on nom.GroupId equals gc.GroupId
                                        join competitor in uow.Competitor.GetAll() on gc.CompetitorId equals competitor.CompetitorId
                                        where nom.GroupId != null
                                        select competitor
                                        ).ToList();
            return competition;
        }
    }
}