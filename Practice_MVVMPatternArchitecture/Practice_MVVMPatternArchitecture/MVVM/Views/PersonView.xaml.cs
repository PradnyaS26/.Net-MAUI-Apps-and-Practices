
namespace Practice_MVVMPatternArchitecture.MVVM.Views;
using MVVM.Models;
using MVVM.ViewModels;
public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		
		BindingContext = new PersonViewModel();
	}
}
