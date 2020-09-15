
using DanceAPIDataAccess.Models;
using System.Linq;

namespace DanceAPIDataAccess.Repository
{
    public class CityRepository : IRepository<City, int>
    {
        #region 

        private readonly DanceAPIDataContext context;

        #endregion

        public CityRepository(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public void Create(City item)
        {
            context.City.Add(item);
        }

        public void Delete(int id)
        {
            City deleted = context.City.Find(id);

            if (deleted != null)
            {
                context.City.Remove(deleted);
            }
        }

        public City Get(int id)
        {
            return context.City
                .FirstOrDefault(p => p.CityId == id);
        }

        public IQueryable<City> GetAll()
        {
            return context.City;
        }
    }
}
