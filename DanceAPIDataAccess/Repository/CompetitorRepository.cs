
using DanceAPIDataAccess.Models;
using System.Linq;

namespace DanceAPIDataAccess.Repository
{
    public class CompetitorRepository : IRepository<Competitor, int>
    {
        #region 

        private readonly DanceAPIDataContext context;

        #endregion

        public CompetitorRepository(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public void Create(Competitor item)
        {
            context.Competitor.Add(item);
        }

        public void Delete(int id)
        {
            Competitor deleted = context.Competitor.Find(id);

            if (deleted != null)
            {
                context.Competitor.Remove(deleted);
            }
        }

        public Competitor Get(int id)
        {
            return context.Competitor
                .FirstOrDefault(p => p.CompetitorId == id);
        }

        public IQueryable<Competitor> GetAll()
        {
            return context.Competitor;
        }
    }
}
