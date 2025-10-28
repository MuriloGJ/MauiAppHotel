namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ContratacaoHospedagem());
    }
}
