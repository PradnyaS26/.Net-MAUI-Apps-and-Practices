using System;
namespace BMICalculatorApp.MVVM.ViewModels;
using MVVM.Models;

	public class BMIViewModel
	{
		public BMIModel BMI { get; set; }

        public BMIViewModel()
		{
		BMI = new BMIModel();
		BMI.Height = 149;
		BMI.Weight = 89;
		}
	}


