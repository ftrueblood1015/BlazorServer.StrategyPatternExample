using BlazorServer.StrategyPatternExample.Domain.Models;
using BlazorServer.StrategyPatternExample.Infrastructure;

namespace BlazorServer.StrategyPatternExample.Repositories.ExportTypes
{
    public class ExportTypeRepository : RepositoryBase<ExportType, StrategyPatternContext>, IExportTypeRepository
    {
        public ExportTypeRepository(StrategyPatternContext context) : base(context)
        {
        }
    }
}
