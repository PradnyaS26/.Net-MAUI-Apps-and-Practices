namespace BMICalculatorApp.MVVM.Views;
using MVVM.ViewModels;
public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}
