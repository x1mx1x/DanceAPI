using DanceAPIDataAccess.Models;
using DanceAPIDataAccess.Repository;
using System;

namespace DanceAPIDataAccess
{
    public class UnitOfWork
    {
        #region privateMembers

        private DanceAPIDataContext context;


        private IRepository<CompetitionCatalog, int> competitionRepository;
        private IRepository<City, int> cityRepository;
        private IRepository<Nomination, int> nominationRepository;
        private IRepository<Category, int> categoryRepository;
        private IRepository<Organizer, int> organizerRepository;
        private IRepository<Competitor, int> competitorRepository;
        private IRepository<GroupCompetitor, int> groupCompetitorRepository;
        private IRepository<DuetCompetitor, int> duetCompetitorRepository;

        private bool disposed = false;

        #endregion


        public IRepository<Competitor, int> Competitor
        {
            get
            {
                if (competitorRepository == null)
                    competitorRepository = new CompetitorRepository(context);

                return competitorRepository;
            }
        }
        public IRepository<GroupCompetitor, int> GroupCompetitor
        {
            get
            {
                if (groupCompetitorRepository == null)
                    groupCompetitorRepository = new GroupCompetitorRepository(context);

                return groupCompetitorRepository;
            }
        }
        public IRepository<DuetCompetitor, int> DuetCompetitor
        {
            get
            {
                if (duetCompetitorRepository == null)
                    duetCompetitorRepository = new DuetCompetitorRepository(context);

                return duetCompetitorRepository;
            }
        }
        public IRepository<CompetitionCatalog, int> CompetitionCatalog
        {
            get
            {
                if (competitionRepository == null)
                    competitionRepository = new CompetitionRepository(context);

                return competitionRepository;
            }
        }
        public IRepository<Organizer, int> Organizer
        {
            get
            {
                if (organizerRepository == null)
                    organizerRepository = new OrganizerRepository(context);

                return organizerRepository;
            }
        }
        public IRepository<Category, int> Category
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(context);

                return categoryRepository;
            }
        }
        public IRepository<Nomination, int> Nomination
        {
            get
            {
                if (nominationRepository == null)
                    nominationRepository = new NominationRepository(context);

                return nominationRepository;
            }
        }
        public IRepository<City, int> City
        {
            get
            {
                if (cityRepository == null)
                    cityRepository = new CityRepository(context);

                return cityRepository;
            }
        }

        public UnitOfWork(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
