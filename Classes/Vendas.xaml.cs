namespace Classes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ConsultarVendas_Clicked(object sender, EventArgs e)
        {
            // Lógica para consultar as vendas
            await DisplayAlert("Consultar Vendas", "Funcionalidade em desenvolvimento", "OK");
        }

        private async void ProcessarVenda_Clicked(object sender, EventArgs e)
        {
            // Lógica para processar uma venda
            await DisplayAlert("Processar Venda", "Funcionalidade em desenvolvimento", "OK");
        }
    }
}
