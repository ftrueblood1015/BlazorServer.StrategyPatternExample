using BlazorServer.StrategyPatternExample.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.StrategyPatternExample.Infrastructure
{
    public class StrategyPatternContext : DbContext
    {
        public StrategyPatternContext(DbContextOptions<StrategyPatternContext> options) : base(options) { }

        DbSet<Person> Persons => Set<Person>();
        DbSet<ExportType> ExportTypes => Set<ExportType>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Description = "6 foot 3 inches", IsActive = true, Name = "Billy " },
                new Person { Id = 2, Description = "6 foot 2 inches", IsActive = true, Name = "Fred " },
                new Person { Id = 3, Description = "Blonde", IsActive = true, Name = "Bob " },
                new Person { Id = 4, Description = "Bernet", IsActive = true, Name = "Jen " },
                new Person { Id = 5, Description = "Skinny", IsActive = true, Name = "Penny " },
                new Person { Id = 6, Description = "Pudgey", IsActive = true, Name = "Wilma " },
                new Person { Id = 7, Description = "Nerd", IsActive = true, Name = "Todd " },
                new Person { Id = 8, Description = "Jock", IsActive = true, Name = "Chad " },
                new Person { Id = 9, Description = "Engineer", IsActive = true, Name = "Ellen " },
                new Person { Id = 10, Description = "Poet", IsActive = true, Name = "Lou " }
            );

            modelBuilder.Entity<ExportType>().HasData(
                new Person { Id = 1, Description = "CSV", IsActive = true, Name = "CSV " },
                new Person { Id = 2, Description = "Text", IsActive = true, Name = "TEXT " },
                new Person { Id = 3, Description = "JSON", IsActive = true, Name = "JSON " }
            );
        }
    }
}
