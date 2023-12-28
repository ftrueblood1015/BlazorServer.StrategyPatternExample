using BlazorServer.StrategyPatternExample.Domain.Models;
using System.Reflection;

namespace BlazorServer.StrategyPatternExample.Exports.Persons.Text
{
    public class PersonTextExportService : ExportServiceBase<Person>, IPersonTextExportService
    {
        public PersonTextExportService(IEnumerable<Person> list) : base(list)
        {
        }

        public override void Export()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", $"PersonTxt_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.txt");
            CreateTXT(List, path);
        }

        private void CreateHeader<Person>(IEnumerable<Person> enumerable, StreamWriter sw)
        {
            PropertyInfo[] properties = typeof(Person).GetProperties();
            for (int i = 0; i < properties.Length - 1; i++)
            {
                sw.Write(properties[i].Name + " ");
            }
            var lastProp = properties[properties.Length - 1].Name;
            sw.Write(lastProp + sw.NewLine);
        }

        private void CreateRows<Person>(IEnumerable<Person> enumerable, StreamWriter sw)
        {
            foreach (var item in enumerable)
            {
                PropertyInfo[] properties = typeof(Person).GetProperties();
                for (int i = 0; i < properties.Length - 1; i++)
                {
                    var prop = properties[i];
                    sw.Write(prop.GetValue(item) + " ");
                }
                var lastProp = properties[properties.Length - 1];
                sw.Write(lastProp.GetValue(item) + sw.NewLine);
            }
        }

        public void CreateTXT<Person>(IEnumerable<Person> enumerable, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                CreateHeader(enumerable, sw);
                CreateRows(enumerable, sw);
            }
        }
    }
}
