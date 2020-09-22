
using DanceAPIDataAccess.Models;
using System.Linq;

namespace DanceAPIDataAccess.Repository
{
    public class GroupCompetitorRepository : IRepository<GroupCompetitor, int>
    {
        #region 

        private readonly DanceAPIDataContext context;

        #endregion

        public GroupCompetitorRepository(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public void Create(GroupCompetitor item)
        {
            context.GroupCompetitor.Add(item);
        }

        public IQueryable<GroupCompetitor> GetAll()
        {
            return context.GroupCompetitor;
        }


        //unworking methods
        public void Delete(int id)
        {
            GroupCompetitor deleted = context.GroupCompetitor.Find(id);

            if (deleted != null)
            {
                context.GroupCompetitor.Remove(deleted);
            }
        }

        public GroupCompetitor Get(int id)
        {
            return context.GroupCompetitor
                .FirstOrDefault(p => p.GroupId == id);
        }

    }
}
