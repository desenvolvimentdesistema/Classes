namespace Classes
{
    public partial class CadastrodeProduto : ContentPage
    {
        // public object ValordaVendaEntry { get; private set; }
        // public object QuantidadeEntry { get; private set; }

        public CadastrodeProduto()
        {
            InitializeComponent();
        }

        private void Salvar_Clicked(object sender, EventArgs e)
        {
            string valorVenda = ValordaVendaEntry.Text;
            int quantidade = int.Parse(QuantidadeEntry.Text);
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}