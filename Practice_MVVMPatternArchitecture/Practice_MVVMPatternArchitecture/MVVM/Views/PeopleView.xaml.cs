namespace Practice_MVVMPatternArchitecture.MVVM.Views;
using MVVM.ViewModels;
public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		BindingContext = new PeopleViewModel();
	}
}
