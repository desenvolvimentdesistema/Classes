namespace Classes;

    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
     
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            Nome.Text = string.Empty;
            Telefone.Text = string.Empty;
            Endereço.Text = string.Empty;
            Email.Text = string.Empty;
            CPF.Text = string.Empty;
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {

        }
    }