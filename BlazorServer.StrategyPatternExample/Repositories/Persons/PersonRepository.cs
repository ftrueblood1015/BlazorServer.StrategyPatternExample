using BlazorServer.StrategyPatternExample.Domain.Models;
using BlazorServer.StrategyPatternExample.Infrastructure;

namespace BlazorServer.StrategyPatternExample.Repositories.Persons
{
    public class PersonRepository : RepositoryBase<Person, StrategyPatternContext>, IPersonRepository
    {
        public PersonRepository(StrategyPatternContext context) : base(context)
        {
        }
    }
}
