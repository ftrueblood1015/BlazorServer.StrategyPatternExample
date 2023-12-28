using BlazorServer.StrategyPatternExample.Domain.Models;
using BlazorServer.StrategyPatternExample.Repositories;
using BlazorServer.StrategyPatternExample.Repositories.ExportTypes;

namespace BlazorServer.StrategyPatternExample.Services.ExportTypes
{
    public class ExportTypeService : ServiceBase<ExportType, IExportTypeRepository>, IExportTypeService
    {
        public ExportTypeService(IRepositoryBase<ExportType> repo) : base(repo)
        {
        }
    }
}
