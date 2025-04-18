﻿namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCel01_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Samsung";
            celular.Numero = 1598456217;
            celular.Operadora = "LaeleInter";
            celular.Modelo = "Galaxy S99 Supremo";
            celular.Preco = 27000;

            Navigation.PushAsync(new NewPage1() { BindingContext = celular });
        }
        private void btnCel02_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Tectoy";
            celular.Numero = 4458641877;
            celular.Operadora = "LaeleInter";
            celular.Modelo = "Zengloing";
            celular.Preco = 4000;

            Navigation.PushAsync(new CelPage2() { BindingContext = celular });
        }

        private void btnCel03_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Nokia";
            celular.Numero = 9937379190;
            celular.Operadora = "Calabreso";
            celular.Modelo = "Rogerio S43 Plus";
            celular.Preco = 13000;

            Navigation.PushAsync(new CelPage3() { BindingContext = celular });

        }

        private void btnCel04_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Suansoang";
            celular.Numero = 9568760990;
            celular.Operadora = "Toscana";
            celular.Modelo = "Xenofone Z7 Ultra Max";
            celular.Preco = 1900;

            Navigation.PushAsync(new CelPage4() { BindingContext = celular });
        }

        private void btnLista_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagListaProduto());
        }
    }

}
