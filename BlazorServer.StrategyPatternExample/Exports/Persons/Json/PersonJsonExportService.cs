using BlazorServer.StrategyPatternExample.Domain.Models;
using Newtonsoft.Json;

namespace BlazorServer.StrategyPatternExample.Exports.Persons.Json
{
    public class PersonJsonExportService : ExportServiceBase<Person>, IPersonJsonExportService
    {
        public PersonJsonExportService(IEnumerable<Person> list) : base(list)
        {
        }

        public override void Export()
        {
            string JsonString = ConvertListToJson();
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", $"PersonJson_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.json");
            File.WriteAllText(path, JsonString);
        }

        private string ConvertListToJson()
        {
            return JsonConvert.SerializeObject(List, Formatting.Indented);
        }
    }
}
