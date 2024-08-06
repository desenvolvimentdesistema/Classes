namespace Classes
{
    public partial class  MainPage : ContentPage
    {
        public CadastroVendaPage()
        {
            InitializeComponent();
        }

        private void Salvar_Clicked(object sender, EventArgs e)
        {
            // Lógica para salvar a venda
            // ...
            // Exemplo de como obter os valores dos campos:
            string valorVenda = ValorVendaEntry.Text;
            int quantidade = int.Parse(QuantidadeEntry.Text);
            // ... outros campos ...
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            // Lógica para cancelar o cadastro
            // ...
            // Exemplo:
            Navigation.PopAsync();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            // Lógica para lidar com a data selecionada
        }
    }
}

