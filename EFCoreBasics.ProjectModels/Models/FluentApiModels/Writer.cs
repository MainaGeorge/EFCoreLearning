using System;

namespace EFCoreBasics.ProjectModels.Models.FluentApiModels
{
    public class Writer : Person
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override DateTime BirthDate { get; set; }
        public override int Id { get; set; }
    }
}
