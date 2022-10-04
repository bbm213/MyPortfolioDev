using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces //the interface contain just a concret operations
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id); // the id is object to remove his association of any type int guid ... 
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
    }
}
