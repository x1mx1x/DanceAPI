
using DanceAPIDataAccess;
using System.Linq;

namespace StudySierrDataAccess.Domain.Repository
{
    public class CompetitionRepository : IRepository<CompetitionCatalog, int>
    {
        #region 

        private readonly DanceAPIDataContext context;

        #endregion

        public CompetitionRepository(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public void Create(CompetitionCatalog item)
        {
            context.CompetitionCatalog.Add(item);
        }

        public void Delete(int id)
        {
            CompetitionCatalog deleted = context.CompetitionCatalog.Find(id);

            if (deleted != null)
            {
                context.CompetitionCatalog.Remove(deleted);
            }
        }

        public CompetitionCatalog Get(int id)
        {
            return context.CompetitionCatalog
                .FirstOrDefault(p => p.CompId == id);
        }

        public IQueryable<CompetitionCatalog> GetAll()
        {
            return context.CompetitionCatalog;
        }
    }
}
