namespace PracticeDataBinding;
using Models;
public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var person = new Person
		{
			Name = "Pradnya",
			Phone = "9999",
			Address = "Pune"

		};
		BindingContext = person;
		//txtName.BindingContext = person;
		//txtName.SetBinding(Label.TextProperty, "Name");

		//Binding personBinding = new Binding();
		//personBinding.Source = person;
		//personBinding.Path = "Name";
		//txtName.SetBinding(Label.TextProperty, personBinding);
	}
}


