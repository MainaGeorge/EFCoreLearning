using System;

namespace EFCoreBasics.ProjectModels
{
    public abstract class Person
    {
        public abstract string FirstName { get; set; }   
        public abstract string LastName { get; set; }
        public  abstract DateTime BirthDate { get; set; }
        public abstract int Id { get; set; } 
    }
}
