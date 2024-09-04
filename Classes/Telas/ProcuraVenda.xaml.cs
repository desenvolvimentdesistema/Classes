namespace Classes;
        public partial class  ProcuraVenda : ContentPage
        {
        public ProcuraVenda()
            {
                InitializeComponent();
            }

            private async void Procurar_Clicked(object sender, EventArgs e)
            {
                string idProduto = IdProduto.Text;
                string cliente = Cliente.Text;
                string idCliente = IdCliente.Text;
                DateTime dataVenda = DataVendaPicker.Date;

                var resultados = await ProcuraVendasAsync(idProduto, cliente, idCliente, dataVenda);

            }

            private Task<List<Venda>> ProcuraVendasAsync(string idProduto, string cliente, string idCliente, DateTime dataVenda)
            {
                return Task.FromResult(new List<Venda>());
            }
        }

    internal class Venda
    {
    }