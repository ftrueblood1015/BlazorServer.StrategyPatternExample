using BlazorServer.StrategyPatternExample.Domain.Models;
using BlazorServer.StrategyPatternExample.Repositories;
using BlazorServer.StrategyPatternExample.Repositories.Persons;
using MudBlazor;

namespace BlazorServer.StrategyPatternExample.Services.Persons
{
    public class PersonService : ServiceBase<Person, IPersonRepository>, IPersonService
    {
        public PersonService(IRepositoryBase<Person> repo) : base(repo)
        {
        }
    }
}
