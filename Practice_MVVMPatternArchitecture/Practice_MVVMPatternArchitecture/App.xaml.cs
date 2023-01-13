namespace Practice_MVVMPatternArchitecture;
using Practice_MVVMPatternArchitecture.MVVM.Views;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new FodyDemoView();
	}
}

