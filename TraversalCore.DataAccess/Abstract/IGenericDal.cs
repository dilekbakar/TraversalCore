using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCore.DataAccess.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T entity);
        void Delete(T entity);  
        void Update(T entity);
        List<T> GetList();
        T GetById(int id);
    }
}
