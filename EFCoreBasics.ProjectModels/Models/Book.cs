using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.ProjectModels.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(15)]
        public string ISBN { get; set; }

        [Required]
        public double Price { get; set; }

        [NotMapped]
        public string PriceRange { get; set; }

    }
}
