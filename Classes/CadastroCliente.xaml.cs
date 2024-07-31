using Microsoft.Maui.Controls;
namespace Classes;
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Lógica para salvar os dados
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a operação
            Nome.Entry.Text = string.Empty;
            Telefone.Entry.Text = string.Empty;
            Endereço.Entry.Text = string.Empty;
            Email.Entry.Text = string.Empty;
            CPF.Entry.Text = string.Empty;
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Lógica para deletar os dados
        }
    }
