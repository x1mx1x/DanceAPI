
using DanceAPIDataAccess.Models;
using System.Linq;

namespace DanceAPIDataAccess.Repository
{
    public class CategoryRepository : IRepository<Category, int>
    {
        #region 

        private readonly DanceAPIDataContext context;

        #endregion

        public CategoryRepository(DanceAPIDataContext context)
        {
            this.context = context;
        }

        public void Create(Category item)
        {
            context.Category.Add(item);
        }

        public void Delete(int id)
        {
            Category deleted = context.Category.Find(id);

            if (deleted != null)
            {
                context.Category.Remove(deleted);
            }
        }

        public Category Get(int id)
        {
            return context.Category
                .FirstOrDefault(p => p.CategoryId == id);
        }

        public IQueryable<Category> GetAll()
        {
            return context.Category;
        }
    }
}
