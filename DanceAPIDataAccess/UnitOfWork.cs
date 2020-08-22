using StudySierrDataAccess.Domain.Repository;
using System;

namespace DanceAPIDataAccess
{
    public class UnitOfWork
    {
        #region privateMembers

        private DanceAPIDataContext context;


        private IRepository<CompetitionCatalog, int> competitionRepository;

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
