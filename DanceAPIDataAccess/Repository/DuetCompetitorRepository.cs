
using DanceAPIDataAccess.Models;
using System.Linq;

namespace DanceAPIDataAccess.Repository
{
    public class DuetCompetitorRepository : IRepository<DuetCompetitor, int>
    {
        #region 

        private readonly DanceAPIDataContext context;

        #endregion

        public DuetCompetitorRepository(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public void Create(DuetCompetitor item)
        {
            context.DuetCompetitor.Add(item);
        }

        public IQueryable<DuetCompetitor> GetAll()
        {
            return context.DuetCompetitor;
        }
        

        //unworking methods
        public void Delete(int id)
        {
            DuetCompetitor deleted = context.DuetCompetitor.Find(id);

            if (deleted != null)
            {
                context.DuetCompetitor.Remove(deleted);
            }
        }

        public DuetCompetitor Get(int id)
        {
            return context.DuetCompetitor
                .FirstOrDefault(p => p.DuetId == id);
        }

    }
}
