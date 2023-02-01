namespace TaskerApp;
using TaskerApp.MVVM.Views;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainView());
	}
}

