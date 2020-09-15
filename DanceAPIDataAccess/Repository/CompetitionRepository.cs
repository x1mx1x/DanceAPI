
using DanceAPIDataAccess.Models;
using System.Linq;

namespace DanceAPIDataAccess.Repository
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
                .FirstOrDefault(p => p.CompetitionCatalogId == id);
        }

        public IQueryable<CompetitionCatalog> GetAll()
        {
            return (IQueryable<CompetitionCatalog>)context.CompetitionCatalog;
        }
    }
}
