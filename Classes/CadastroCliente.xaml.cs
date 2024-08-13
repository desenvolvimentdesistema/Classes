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
         
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            Nome.Entry.Text = string.Empty;
            Telefone.Entry.Text = string.Empty;
            Endereço.Entry.Text = string.Empty;
            Email.Entry.Text = string.Empty;
            CPF.Entry.Text = string.Empty;
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {

        }
    }
