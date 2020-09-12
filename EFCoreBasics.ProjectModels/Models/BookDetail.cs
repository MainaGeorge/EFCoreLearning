using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreBasics.ProjectModels.Models
{
    public class BookDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookDetailId { get; set; }
        [Required]
        public int NumberOfChapters { get; set; }
        [Required]
        public int NumberOfPages { get; set; }

        public double BookWeight { get; set; }

        public Book Book { get; set; }  
    }
}
