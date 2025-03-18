namespace PrjVinculo;

public partial class CelPage3 : ContentPage
{
	public CelPage3()
	{
		InitializeComponent();
	}

    private void btnMenu3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}