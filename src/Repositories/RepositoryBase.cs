using Entities.Repo;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepoContext Context;

        public RepositoryBase(RepoContext context)
        {
            Context = context;
        }

        public void Create(T entite)
        {
            Context.Set<T>().Add(entite);
        }

        public void Delete(T entite)
        {
            Context.Set<T>().Remove(entite);
        }

        public IQueryable<T> FindAll(bool tracked)
        {
            return tracked ? Context.Set<T>() : Context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expr, bool tracked)
        {
            return tracked ? Context.Set<T>().Where(expr) : Context.Set<T>().Where(expr).AsNoTracking();
        }

        public void Update(T entite)
        {
            Context.Set<T>().Update(entite);
        }
    }
}