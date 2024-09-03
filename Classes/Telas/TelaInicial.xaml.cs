namespace Classes;

    public partial class TelaInicial : ContentPage
{
    internal object nome;

    public TelaInicial()
    {
        InitializeComponent();
    }

    private async void CadastroClicked(object sender, EventArgs e)
    {
        await DisplayAlert("CadastrodeCliente", "Funcionalidade em desenvolvimento", "OK");
    }
     private async void RealizarPedidoClicked(object sender, EventArgs e)
    {
        await DisplayAlert("RealizarPedido", "Funcionalidade em desenvolvimento", "OK");
    }
    private async void EstoqueClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Estoque", "Funcionalidade em desenvolvimento", "OK");
    }
    private async void ControledeQualidadeClicked(object sender, EventArgs e)
    {
        await DisplayAlert("ControledeQualidade", "Funcionalidade em desenvolvimento", "OK");
    }
     private async void FeedbackdoClienteClicked(object sender, EventArgs e)
    {
        await DisplayAlert("FeedbackdoCliente", "Funcionalidade em desenvolvimento", "OK");
    }
}