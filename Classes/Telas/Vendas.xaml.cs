namespace Classes;

    public partial class Vendas : ContentPage
{
    internal object nome;

    public Vendas()
    {
        InitializeComponent();
    }

    private async void ConsultarVendasClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Consultar Vendas", "Funcionalidade em desenvolvimento", "OK");
    }

    private async void ProcessarVendasClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Processar Vendas", "Funcionalidade em desenvolvimento", "OK");
    }

    private async void ProcurarVendasClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Procurar Vendas", "Funcionalidade em desenvolvimento", "OK");
    }

}