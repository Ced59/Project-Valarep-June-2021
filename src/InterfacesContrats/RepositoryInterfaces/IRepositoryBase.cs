using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContrats.RepositoryInterfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool tracked);

        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expr, bool tracked);

        void Create(T entite);

        void Update(T entite);

        void Delete(T entite);
    }
}