namespace Classes;
{
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
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
}
