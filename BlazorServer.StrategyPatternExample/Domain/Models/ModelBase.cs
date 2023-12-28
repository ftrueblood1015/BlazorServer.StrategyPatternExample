using System.ComponentModel.DataAnnotations;

namespace BlazorServer.StrategyPatternExample.Domain.Models
{
    public class ModelBase
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool? IsActive { get; set; }
    }
}
