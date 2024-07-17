using System.ComponentModel.DataAnnotations;

namespace Projekt_Zespolowy.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
