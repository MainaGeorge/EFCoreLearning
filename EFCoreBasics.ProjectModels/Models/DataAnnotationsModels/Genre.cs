using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.ProjectModels.Models.DataAnnotationsModels
{
    [Table("tb_genres")]
    public class Genre
    {
        public int GenreId { get; set; }

        [Column("Name")]
        public string GenreName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
