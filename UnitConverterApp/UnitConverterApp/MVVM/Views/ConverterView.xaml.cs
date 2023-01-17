namespace UnitConverterApp.MVVM.Views;
using MVVM.ViewModels;
public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		//BindingContext = new ConverterViewModel();
	}

    void Picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
		var viewModel = (ConverterViewModel)BindingContext;
		viewModel.Convert();
    }

    
}
