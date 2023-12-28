using BlazorServer.StrategyPatternExample.Domain.Models;

namespace BlazorServer.StrategyPatternExample.Exports.Persons.Csv
{
    public interface IPersonCsvExportService : IExportServiceBase<Person>
    {
    }
}
