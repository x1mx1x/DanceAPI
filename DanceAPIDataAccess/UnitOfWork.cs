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

        private bool disposed = false;

        #endregion


        public IRepository<CompetitionCatalog, int> CompetitionCatalogs
        {
            get
            {
                if (competitionRepository == null)
                    competitionRepository = new CompetitionRepository(context);

                return competitionRepository;
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
