namespace PerfectSplitPayApp;

public partial class MainPage : ContentPage
{
    decimal bill;
    int tip, noPersons = 1;


    public MainPage()
	{
		InitializeComponent();
	}

    private void CalculateTotal()
    {
        var totalTip = (bill * tip) / 100;

        var tipByPerson = (totalTip / noPersons);
        tipByPerson = decimal.Round(tipByPerson, 2, MidpointRounding.AwayFromZero);
        lblTipByPerson.Text = $"{tipByPerson}";

        var subtotal = (bill / noPersons);
        subtotal = decimal.Round(subtotal, 2, MidpointRounding.AwayFromZero);
        lblSubtotal.Text = $"{subtotal}";

        var totalByPerson = ((bill + totalTip) / noPersons);
        totalByPerson = decimal.Round(totalByPerson, 2, MidpointRounding.AwayFromZero);
        lblTotal.Text = $"{totalByPerson}";

    }
    void txtBill_Completed(System.Object sender, System.EventArgs e)
    {
        if (txtBill.Text != "")
        {
            bill = decimal.Parse(txtBill.Text);
            CalculateTotal();
        }
    }

    void sldTip_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        tip = (int)sldTip.Value;
        lblTip.Text = $"Tip : {tip}%";
        CalculateTotal();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        if (sender is Button)
        {
            var btn = (Button)sender;
            var percentage = int.Parse(btn.Text.Replace("%", ""));
            sldTip.Value = percentage;
        }
    }

    void stpSplit_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        noPersons = (int)stpSplit.Value;
        CalculateTotal();
    }
}


