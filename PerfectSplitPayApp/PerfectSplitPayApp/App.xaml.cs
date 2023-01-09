using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
namespace PerfectSplitPayApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        AppCenter.Start("ios=0d6aba52 - 2672 - 4cf4 - aab0 - 56c1c6ab4956 ;macos=0d6aba52 - 2672 - 4cf4 - aab0 - 56c1c6ab4956 ;android=0d6aba52 - 2672 - 4cf4 - aab0 - 56c1c6ab4956  ", typeof(Analytics), typeof(Crashes));
        MainPage = new MainPage();
	}
}

