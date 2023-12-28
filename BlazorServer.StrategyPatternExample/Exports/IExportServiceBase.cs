using BlazorServer.StrategyPatternExample.Domain.Models;

namespace BlazorServer.StrategyPatternExample.Exports
{
    public interface IExportServiceBase<T> where T : ModelBase
    {
        public void Export();
    }
}
