using System;

namespace EFCoreBasics.ProjectModels.Models.FluentApiModels
{
    public class Movie
    {
        public int MovieId { get; set; }
        public DateTime DateReleased { get; set; }
        public decimal BudgetAllocated { get; set; }    
        public decimal ActualBudget { get; set; }
    }
}
