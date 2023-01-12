namespace PracticeDataBinding;

using Models;
public partial class MainPage : ContentPage
{
	Person person = new Person();

	public MainPage()
	{
		InitializeComponent();
        person = new Person
        {
            Name = "Pradnya",
            Phone = "9999",
            Address = "Pune"

        };
        BindingContext = person;

    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		person.Name = "Ajay";
		person.Phone = "1111";
		person.Address = "Pune";
		 
		//txtName.BindingContext = person;
		//txtName.SetBinding(Label.TextProperty, "Name");

		//Binding personBinding = new Binding();
		//personBinding.Source = person;
		//personBinding.Path = "Name";
		//txtName.SetBinding(Label.TextProperty, personBinding);
	}
}

