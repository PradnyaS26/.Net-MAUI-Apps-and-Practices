namespace Practice_Styles;

public partial class DynamicStylesView : ContentPage
{
	public DynamicStylesView()
	{
		InitializeComponent();
	}

    void Button_Pressed(System.Object sender, System.EventArgs e)
    {
        //RunTime Dynamic Styling
        Application.Current.Resources.TryGetValue("SpecialButton", out var returnValue);
        Resources["dynamicStyle"] = (Style)returnValue;

        //RunTime Dynamic Styling
        //Resources["dynamicStyle"] = Resources["greenStyle"];
    }
}
