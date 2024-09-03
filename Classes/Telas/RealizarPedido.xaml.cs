namespace Classes;

    public partial class RealizarPedido : ContentPage
{
    internal object nome;

    public RealizarPedido()
    {
        InitializeComponent();
    }

    private async void EscolherQuantidadeClicked(object sender, EventArgs e)
    {
        await DisplayAlert("EscolherQuantidade", "Funcionalidade em desenvolvimento", "OK");
    }
    private async void EscolherCorClicked(object sender, EventArgs e)
    {
        await DisplayAlert("CadastrodeCliente", "Funcionalidade em desenvolvimento", "OK");
    }
     private async void EscolherTamanhoClicked(object sender, EventArgs e)
    {
        await DisplayAlert("CadastrodeCliente", "Funcionalidade em desenvolvimento", "OK");
    }
}