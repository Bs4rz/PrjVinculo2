namespace PrjVinculo;

public partial class CelPage4 : ContentPage
{
	public CelPage4()
	{
		InitializeComponent();
	}

    private void btnMenu4_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}