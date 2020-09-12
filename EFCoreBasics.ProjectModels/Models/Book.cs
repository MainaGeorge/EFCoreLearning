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

        [ForeignKey("Category")]
        public int CategoryId { get; set; } 

        [ForeignKey("BookDetail")]
        public int BookDetailId { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }    
        public BookDetail BookDetail { get; set; }
        public Category Category { get; set; }


    }
}
