namespace MauiAppHotel.Views;

public partial class HospetagemContratada : ContentPage
{
	public HospetagemContratada()
	{
		InitializeComponent();
	}

    
    private void Button_Clicked_2(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch(Exception ex)
        {
            DisplayAlertAsync("Ops", ex.Message, "OK");
        }
    }
}