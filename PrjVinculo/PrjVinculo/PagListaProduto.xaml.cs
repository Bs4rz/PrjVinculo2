namespace PrjVinculo;

public partial class PagListaProduto : ContentPage
{
	public PagListaProduto()
	{
		InitializeComponent();
		List<Produto> lista = new List<Produto>();

		lista.Add(new Produto
		{
			Categoria = "Informática",
			Descricao = "Caixa de som",
			Preco = 350
		}
		);
		lista.Add(new Produto
		{
			Categoria = "Comida",
			Descricao = "Cafézin",
			Preco = 30
		}
		);
		lista.Add(new Produto
		{
			Categoria = "Mecânica",
			Descricao = "Injeção eletrônica",
			Preco = 950
		}
		);
		lista.Add(new Produto
		{
			Categoria = "Comida",
			Descricao = "Churros",
			Preco = 3.5
		}
		);
		lista.Add(new Produto
		{
			Categoria = "Mecânica",
			Descricao = "Farol",
			Preco = 999
		}
		);
		lstProduto.ItemsSource = lista;
	}

    private void ViewCell_Tapped(object sender, EventArgs e)
    {
		var context = (sender as ViewCell).BindingContext;
		Navigation.PushAsync(new PagProduto { BindingContext = context });
    }
}