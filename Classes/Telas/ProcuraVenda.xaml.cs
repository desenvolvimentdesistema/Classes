namespace Classes;
        public partial class  ProcuraVenda : ContentPage
        {
        public object ClienteEntry { get; private set; }
        public object IdProdutoEntry { get; private set; }
        public object IdClienteEntry { get; private set; }
        public object DataVenda { get; private set; }

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