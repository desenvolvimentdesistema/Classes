namespace Classess
{
    
        public partial class  MainPage : ContentPage
        {
        public object ClienteEntry { get; private set; }
        public object IdProdutoEntry { get; private set; }
        public object IdClienteEntry { get; private set; }
        public object DataVendaPicker { get; private set; }

        public MainPage()
            {
                InitializeComponent();
            }

            private async void Procurar_Clicked(object sender, EventArgs e)
            {
                string idProduto = IdProdutoEntry.Text;
                string cliente = ClienteEntry.Text;
                string idCliente = IdClienteEntry.Text;
                DateTime dataVenda = DataVendaPicker.Date;

                var resultados = await BuscarVendasAsync(idProduto, cliente, idCliente, dataVenda);

            }

            private async Task<List<Venda>> BuscarVendasAsync(string idProduto, string cliente, string idCliente, DateTime dataVenda)
            {
                return new List<Venda>();
            }
        }

    internal class Venda
    {
    }
}