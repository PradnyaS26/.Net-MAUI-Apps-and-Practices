namespace CalculatorApp.MVVM.Views;
using CalculatorApp.MVVM.ViewModels;
public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
		InitializeComponent();
		BindingContext = new CalculatorViewModel();
	}
}
