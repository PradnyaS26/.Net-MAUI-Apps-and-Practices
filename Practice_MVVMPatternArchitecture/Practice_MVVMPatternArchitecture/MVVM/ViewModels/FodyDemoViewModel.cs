using System;
using System.Windows.Input;
using PropertyChanged;
namespace Practice_MVVMPatternArchitecture.MVVM.ViewModels;
	[AddINotifyPropertyChangedInterface]
	public class FodyDemoViewModel
	{
		public int num1 { get; set; }
		public int num2 { get; set; }
		public int Result { get; set; }
		public ICommand AddCommand => new Command(() => Result = num1 + num2 );
        public FodyDemoViewModel()
		{
		}
	}


