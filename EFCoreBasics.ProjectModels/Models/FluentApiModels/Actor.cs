using System;
using System.Collections.Generic;

namespace EFCoreBasics.ProjectModels.Models.FluentApiModels
{
    public class Actor : Person
    {
        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public override DateTime BirthDate { get; set; }

        public override int Id { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public ICollection<MoviesActorsJoiningTable> Movies { get; set; }
    }
}
