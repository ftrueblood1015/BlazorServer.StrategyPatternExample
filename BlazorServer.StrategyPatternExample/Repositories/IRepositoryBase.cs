using BlazorServer.StrategyPatternExample.Domain.Models;

namespace BlazorServer.StrategyPatternExample.Repositories
{
    public interface IRepositoryBase<T> where T : ModelBase
    {
        IEnumerable<T> GetAll();
    }
}
