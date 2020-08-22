﻿
using System.Linq;

namespace DanceAPIDataAccess
{
    public interface IRepository<T, K>
                where T : class
    {
        IQueryable<T> GetAll();
        T Get(K id);
        void Create(T item);
        void Delete(K id);
    }
}
