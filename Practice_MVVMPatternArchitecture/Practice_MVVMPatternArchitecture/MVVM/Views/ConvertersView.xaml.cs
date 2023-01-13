namespace Practice_MVVMPatternArchitecture.MVVM.Views;
using MVVM.ViewModels;
public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();
		BindingContext = new ConvertersViewModel();
	}
}
