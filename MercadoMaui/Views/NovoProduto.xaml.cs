using MercadoMaui.Models;

namespace MercadoMaui.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text),
			};
		}catch (Exception ex) 
		{
			await DisplayAlert("OPS", ex.Message, "OK");
		}
    }
}