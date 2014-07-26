using BasicRepositoryPattern.Business.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRepositoryPattern.Business.Repositories
{
    public abstract class BaseRepository
    {
        protected MyModelContainer Context;

        public BaseRepository(MyModelContainer context)
        {
            this.Context = context;
        }

        public async Task<TEntity> GetAsync<TEntity>(int id) where TEntity : class, new()
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }
    }
}
