using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.ProjectModels.Models.DataAnnotationsModels
{
    public class Author
    {
        [Key]
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

        public ICollection<BookAuthorConnectionTable> BooksAuthored { get; set; }    
    }
}
