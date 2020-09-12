using System.Collections.Generic;

namespace EFCoreBasics.ProjectModels.Models.FluentApiModels
{
    public class ProducingCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Movie> MoviesProduced { get; set; }
    }
}
