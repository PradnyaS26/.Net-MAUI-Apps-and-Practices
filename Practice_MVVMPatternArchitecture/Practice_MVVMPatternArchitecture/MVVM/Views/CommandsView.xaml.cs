namespace Practice_MVVMPatternArchitecture.MVVM.Views;
using MVVM.ViewModels;
public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
	}
}
