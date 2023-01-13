using System;
using Practice_MVVMPatternArchitecture.MVVM.Models;
namespace Practice_MVVMPatternArchitecture.MVVM.ViewModels
{
	public class ConvertersViewModel
	{
		public Data Data { get; set; }
		public ConvertersViewModel()
		{
			Data = new Data
			{
				Married = "YES"
			};
		}
	}
}

