namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
           

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

      

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "RTX 9999";
            produto.Preco = 70000;
            produto.Categoria = "Hardware";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto});
           
        }

        private void btnMisterioso_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Porta Kwanzas";
            produto.Preco = 30;
            produto.Categoria = "Acessório";

            Navigation.PushAsync(new MisteryusPage() { BindingContext = produto });
        }
    }

}
