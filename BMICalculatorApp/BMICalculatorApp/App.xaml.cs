namespace BMICalculatorApp;
using BMICalculatorApp.MVVM.Views;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new BMIView();
	}
}

