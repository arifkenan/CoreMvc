using Northwind.BL.Abstract;
using Northwind.DAL.Abstract;
using Northwind.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : class, new()
    {
        protected IRepositoryBase<T> repository;
        public ManagerBase()
        {
            repository = new RepositoryBase<T>();
        }
        public int Add(T input)
        {
            return repository.Add(input);
        }

        public int Delete(T input)
        {
            return repository.Delete(input);        
        }

        public T Find(int id)
        {
            return (T) repository.Find(id);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            return repository.GetAllInclude(filter, include);
        }

        public int Update(T input)
        {
            return repository.Update(input);
        }
    }
}
