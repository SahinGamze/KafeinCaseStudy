using KafeinExample.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeinExample.DATA.Abstract
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        protected readonly KafeinDbContext DatabaseContext;

        public Repository(KafeinDbContext context)
        {
            this.DatabaseContext = context;
        }

        public void Add(TModel entity)
        {
            DatabaseContext.Set<TModel>().Add(entity);
        }

        public TModel Get(int id)
        {
            return DatabaseContext.Set<TModel>().Find(id);
        }

        public IEnumerable<TModel> GetAll()
        {
            return DatabaseContext.Set<TModel>().ToList();
        }

        public void Remove(TModel entity)
        {
            DatabaseContext.Set<TModel>().Remove(entity);
        }
    }
}
