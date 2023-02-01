namespace TaskerApp.MVVM.Views;
using MVVM.ViewModels;
public partial class MainView : ContentPage
{
	private MainViewModel mainViewModel = new MainViewModel();
	public MainView()
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}

    void checkBox_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
		mainViewModel.UpdateData();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		var taskView = new NewTaskView
		{
			BindingContext = new NewTaskViewModel
			{
				Tasks = mainViewModel.Tasks,
				Categories = mainViewModel.Categories,
			}
		};

		Navigation.PushAsync(taskView);
    }
}
