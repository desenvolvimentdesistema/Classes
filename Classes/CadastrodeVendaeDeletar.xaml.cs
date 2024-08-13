namespace Classes
{
    public partial class  MainPage : ContentPage
    {
        public CadastroVendaPage()
        {

        }

        private void Salvar_Clicked(object sender, EventArgs e)
        {
            string valorVenda = ValorVendaEntry.Text;
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

