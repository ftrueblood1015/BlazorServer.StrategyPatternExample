using BlazorServer.StrategyPatternExample.Domain.Models;
using BlazorServer.StrategyPatternExample.Exports;
using BlazorServer.StrategyPatternExample.Exports.Persons.Csv;
using BlazorServer.StrategyPatternExample.Exports.Persons.Json;
using BlazorServer.StrategyPatternExample.Exports.Persons.Text;
using BlazorServer.StrategyPatternExample.Services;
using BlazorServer.StrategyPatternExample.Services.Persons;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorServer.StrategyPatternExample.Pages.Persons
{
    public partial class Persons
    {
        [Inject]
        private IPersonService? Service { get; set; }

        [Inject]
        private NavigationManager? NavigationManager { get; set; }

        [Inject]
        private ISnackbar? SnackbarService { get; set; }

        [Inject]
        private IExportServiceBase<Person>? ExportService { get; set; }

        public List<Person>? Entities { get; set; }

        public ExportType? ExportType { get; set; }

        private string? SearchString { get; set; }

        public string? Title = "Persons";

        protected override async Task OnInitializedAsync()
        {
            ExportType = new ExportType();
            GetData();
        }

        public void GetData()
        {
            if (Service == null)
            {
                throw new Exception($"{nameof(Service)}  is null!");
            }
            var Response = Service.GetAll();
            Entities = Response != null ? Response.ToList() : new List<Person>();
            ShowSnackbarMessage("Loaded Persons", Color.Success);
            StateHasChanged();
        }

        private Func<Person, bool> QuickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(SearchString))
                return true;

            if (x.Description!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.IsActive}".Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        };

        public void ShowSnackbarMessage(string Message, MudBlazor.Color Color)
        {
            if (SnackbarService == null)
            {
                throw new ArgumentNullException(nameof(SnackbarService));
            }

            SnackbarService.Add<MudChip>(new Dictionary<string, object>() {
                { "Text", $"{Message}" },
                { "Color", Color }
            });
        }

        public async Task ExportChange(int? Id)
        {
            ExportType!.Id = (int)Id!;

            if (Entities == null)
            {
                return;
            }

            // Not ideal but will work as I know which Id belongs to each type
            switch (Id)
            {
                default:
                    ExportService = new PersonCsvExportService(Entities);
                    return;
                case 1:
                    ExportService = new PersonCsvExportService(Entities);
                    return;
                case 2:
                    ExportService = new PersonTextExportService(Entities);
                    return;
                case 3:
                    ExportService = new PersonJsonExportService(Entities);
                    return;
            }
        }

        public void Export()
        {
            if (ExportService == null) 
            {
                ShowSnackbarMessage("Export Service Eas Null!", Color.Error);
                return; 
            }

            try
            {
                ExportService.Export();
                ShowSnackbarMessage("Exported Data", Color.Success);
            }
            catch (Exception ex)
            {
                ShowSnackbarMessage($"Data Not Exported {ex}", Color.Error);
            }
        }
    }
}
