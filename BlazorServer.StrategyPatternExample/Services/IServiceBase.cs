using BlazorServer.StrategyPatternExample.Domain.Models;

namespace BlazorServer.StrategyPatternExample.Services
{
    public interface IServiceBase<T> where T : ModelBase
    {
        IEnumerable<T> GetAll();
    }
}
