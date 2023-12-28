using BlazorServer.StrategyPatternExample.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.StrategyPatternExample.Repositories
{
    public class RepositoryBase<T, TContext> : IRepositoryBase<T>
        where T : ModelBase
        where TContext : DbContext
    {
        protected readonly TContext Context;

        public RepositoryBase(TContext context)
        {
            Context = context;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return Context.Set<T>();
            }
            catch(Exception ex)
            {
                throw new Exception($"{ex}");
            }
        }
    }
}
