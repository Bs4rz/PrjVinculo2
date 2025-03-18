namespace PrjVinculo;

public partial class CelPage2 : ContentPage
{
	public CelPage2()
	{
		InitializeComponent();
	}

    private void btnMenu2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}