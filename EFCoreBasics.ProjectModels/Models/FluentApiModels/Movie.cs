using System;
using System.Collections.Generic;

namespace EFCoreBasics.ProjectModels.Models.FluentApiModels
{
    public class Movie
    {
        public int MovieId { get; set; }
        public DateTime DateReleased { get; set; }
        public decimal BudgetAllocated { get; set; }    
        public decimal ActualBudget { get; set; }

        public int TitleId { get; set; }    
        public Title Title { get; set; }

        public int ProducingCompanyId { get; set; }

        public ProducingCompany ProducingCompany { get; set; }  
        public ICollection<MoviesActorsJoiningTable> Actors { get; set; }
    }
}
