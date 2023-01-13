using System;
namespace Practice_MVVMPatternArchitecture.MVVM.ViewModels;
    using MVVM.Models;

	public class PersonViewModel
	{
        public Person Person { get; set; } 
		public PersonViewModel()
		{
            Person = new Person()
            {
                Name = "Pradnya",
                Age = 25,
                Married = false,
                BirthDate = new DateTime(1997, 06, 02),
                Weight = 80,
                LunchTime= new TimeSpan(10,0,0)
            };
        }
	}


