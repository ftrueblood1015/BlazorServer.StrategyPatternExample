using BlazorServer.StrategyPatternExample.Domain.Models;
using BlazorServer.StrategyPatternExample.Repositories;

namespace BlazorServer.StrategyPatternExample.Services
{
    public class ServiceBase<T, TRepo> : IServiceBase<T> 
        where T : ModelBase
        where TRepo : IRepositoryBase<T>
    {
        private readonly IRepositoryBase<T> Repo;

        public ServiceBase(IRepositoryBase<T> repo)
        {
            Repo = repo;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return Repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex}");
            }
        }
    }
}
