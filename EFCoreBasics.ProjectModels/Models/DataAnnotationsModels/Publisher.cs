using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.ProjectModels.Models.DataAnnotationsModels
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        [Column("Name")]
        [Required]
        public string PublisherName { get; set; }

        [Required]
        public string Location { get; set; }

        public ICollection<Book> BooksPublished { get; set; }   
    }
}
