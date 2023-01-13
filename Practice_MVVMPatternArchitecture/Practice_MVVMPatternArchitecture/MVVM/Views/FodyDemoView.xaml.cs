namespace Practice_MVVMPatternArchitecture.MVVM.Views;
using MVVM.ViewModels;
public partial class FodyDemoView : ContentPage
{
	public FodyDemoView()
	{
		InitializeComponent();
		BindingContext = new FodyDemoViewModel();
	}
}
