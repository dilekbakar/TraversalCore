using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.DataAccess.Abstract;
using TraversalCore.DataAccess.Concrete;

namespace TraversalCore.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using var c = new Context();
            c.Remove(entity);
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return  c.Set<T>().ToList();    
        }

        public void Insert(T entity)
        {
            using var c = new Context();
            c.Add(entity);
        }

        public void Update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
        }
    }
}
