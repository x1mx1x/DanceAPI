
using DanceAPIDataAccess.Models;
using System.Linq;

namespace DanceAPIDataAccess.Repository
{
    public class NominationRepository : IRepository<Nomination, int>
    {
        #region 

        private readonly DanceAPIDataContext context;

        #endregion

        public NominationRepository(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public void Create(Nomination item)
        {
            context.Nomination.Add(item);
        }

        public void Delete(int id)
        {
            Nomination deleted = context.Nomination.Find(id);

            if (deleted != null)
            {
                context.Nomination.Remove(deleted);
            }
        }

        public Nomination Get(int id)
        {
            return context.Nomination
                .FirstOrDefault(p => p.NominationId == id);
        }

        public IQueryable<Nomination> GetAll()
        {
            return context.Nomination;
        }
    }
}
