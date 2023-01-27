namespace CalculatorApp;
using CalculatorApp.MVVM.Views;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculatorView();
	}
}

