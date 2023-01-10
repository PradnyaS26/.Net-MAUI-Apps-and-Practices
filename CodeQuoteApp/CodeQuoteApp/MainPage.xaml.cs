namespace CodeQuoteApp;

public partial class MainPage : ContentPage
{
	Random random = new Random();
	List<string> quotes = new List<string>();

	public MainPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await LoadMauiAsset();
    }
    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("quotes.txt");
        using var reader = new StreamReader(stream);

		while (reader.Peek() != -1)
		{
             quotes.Add(reader.ReadLine());
        }
        
    }
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		var startColor = System.Drawing.Color.FromArgb(
			random.Next(0, 256),
			random.Next(0, 256),
			random.Next(0, 256));
        var endColor = System.Drawing.Color.FromArgb(
            random.Next(0, 256),
            random.Next(0, 256),
            random.Next(0, 256));

        var color = ColorUtility.ColorControls.GetColorGradient(startColor,endColor,6);


		float stopOffSet = .0f;
		var stops = new GradientStopCollection();
		foreach(var c in color)
		{
			stops.Add(new GradientStop(Color.FromArgb(c.Name),stopOffSet));
			stopOffSet += .2f;
		}
		var gradient = new LinearGradientBrush(stops, new Point(0, 0), new Point(1, 1));
		background.Background = gradient;


		//#changing quotes

		int index = random.Next(quotes.Count);
		lblquote.Text = quotes[index];
	}

}


