using BlazorServer.StrategyPatternExample.Domain.Models;

namespace BlazorServer.StrategyPatternExample.Exports
{
    public class ExportServiceBase<T> : IExportServiceBase<T> where T : ModelBase
    {
        protected readonly IEnumerable<T> List;
        public ExportServiceBase(IEnumerable<T> list)
        {
            List = list;
        }

        public virtual void Export()
        {
            throw new NotImplementedException();
        }
    }
}
