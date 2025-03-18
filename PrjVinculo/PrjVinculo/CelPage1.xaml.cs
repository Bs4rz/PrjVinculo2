namespace PrjVinculo;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void btnMenu1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}