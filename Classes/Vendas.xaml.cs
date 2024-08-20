namespace Classes;
{
    public partial class Vendas : ContentPage
    {
    public Vendas()
    {
        InitializeComponent();
    }

    private async void ConsultarVendas_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Consultar Vendas", "Funcionalidade em desenvolvimento", "OK");
        }

        private async void ProcessarVenda_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Processar Venda", "Funcionalidade em desenvolvimento", "OK");
        }
    }
}