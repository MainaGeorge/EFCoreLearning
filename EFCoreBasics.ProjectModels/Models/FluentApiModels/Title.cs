namespace EFCoreBasics.ProjectModels.Models.FluentApiModels
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }

        public Movie Movie { get; set; }    
    }
}
