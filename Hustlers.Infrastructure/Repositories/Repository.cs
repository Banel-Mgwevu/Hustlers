using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.infrastructure.DbContexts;
using System.Collections.Generic;
using System.Linq;

namespace Hustlers.Infrastructure.Repositories
{
    public  class Repository<T> : IRepository<T> where T :  HustlersEntity
    {
        protected readonly HustlersContext context;

        public Repository(HustlersContext context)
        {
            this.context = context;
        }

        public bool Delete(string id)
        {
            var item = context.Set<T>().Find(id);
            if (item != null)
            {
                this.context.Update(item);
                return true;
            }
            return false;
        }

        public virtual T Get(string id)
        {
            var item = context.Set<T>().Where(x => x.Id == id && x.IsActive).FirstOrDefault();
            return item;
        }

        public virtual IList<T> Get( int pageSize, int pageNumber, string searchText=null)
        {
            var item = context.Set<T>().Where(x => x.IsActive);
            var results = item.Take(pageSize).Skip(pageSize * pageNumber - 1).ToList();
            return results;
        }

        public virtual IList<T> Get()
        {
            var item = context.Set<T>().Where(x => x.IsActive);
            return item.ToList();
        }

        public  void Insert(T item)
        {
            context.Set<T>().Add(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            var results = context.Set<T>().Find(item.Id);

            if (results != null)
            {
                this.context.Update(item);
                this.context.SaveChanges();
            }
        }
    }
}
