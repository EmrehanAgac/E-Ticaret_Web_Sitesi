using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Divisima.BL.Repositories
{
    public interface IRepository<T>
    {
        public IQueryable<T> GetAll();
        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        public T  GetBy(Expression<Func<T, bool>> expression);

    }
}
