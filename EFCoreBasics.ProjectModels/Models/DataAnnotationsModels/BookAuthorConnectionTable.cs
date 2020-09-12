﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.ProjectModels.Models.DataAnnotationsModels
{
    public class BookAuthorConnectionTable
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }  
    }
}
