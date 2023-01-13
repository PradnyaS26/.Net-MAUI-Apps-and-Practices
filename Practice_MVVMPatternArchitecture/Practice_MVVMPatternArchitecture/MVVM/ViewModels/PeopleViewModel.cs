using System;
using Practice_MVVMPatternArchitecture.MVVM.Models;
namespace Practice_MVVMPatternArchitecture.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> People { get; set; } = new List<Person>();
        public PeopleViewModel()
        {
            People.Add(new Person()
            {
                Name = "Pradnya",
                Age = 25,
                Married = false,
                BirthDate = new DateTime(1997, 06, 02),
                Weight = 80,
                LunchTime = new TimeSpan(10, 0, 0)
            });

            People.Add(new Person()
            {
                Name = "John",
                Age = 25,
                Married = false,
                BirthDate = new DateTime(1997, 06, 02),
                Weight = 80,
                LunchTime = new TimeSpan(10, 0, 0)
            });

            People.Add(new Person()
            {
                Name = "Bob",
                Age = 25,
                Married = false,
                BirthDate = new DateTime(1997, 06, 02),
                Weight = 80,
                LunchTime = new TimeSpan(10, 0, 0)
            });

            //People = new List<string>
            //{
            //    "Pradnya",
            //    "Ajay",
            //    "Rushi",
            //    "Meena"
            //};
        }
    }
}

