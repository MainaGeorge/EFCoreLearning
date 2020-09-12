using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.ProjectModels.Models
{
    public class Author
    {
        [Key]
        // [DatabaseGenerated(databaseGeneratedOption:DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Location { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
