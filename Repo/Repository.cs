using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GlobalDev.entitiy;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly GDevContext Context;
        public Repository(GDevContext context)
        {
            Context = context;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }


    }

}
