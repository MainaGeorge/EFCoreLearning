using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.ProjectModels.Models
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
    }
}
