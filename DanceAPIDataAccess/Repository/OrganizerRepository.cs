
using DanceAPIDataAccess.Models;
using System.Linq;

namespace DanceAPIDataAccess.Repository
{
    public class OrganizerRepository : IRepository<Organizer, int>
    {
        #region 

        private readonly DanceAPIDataContext context;

        #endregion

        public OrganizerRepository(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public void Create(Organizer item)
        {
            context.Organizer.Add(item);
        }

        public void Delete(int id)
        {
            Organizer deleted = context.Organizer.Find(id);

            if (deleted != null)
            {
                context.Organizer.Remove(deleted);
            }
        }

        public Organizer Get(int id)
        {
            return context.Organizer
                .FirstOrDefault(p => p.OrganizerId == id);
        }

        public IQueryable<Organizer> GetAll()
        {
            return context.Organizer;
        }
    }
}
