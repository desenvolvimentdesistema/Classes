namespace Classes;

    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private async void OnSalvarDadosClicked(object sender, EventArgs e)
  {
    if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
    {
      // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
      var cliente = new Modelos.Cliente();
      if (!String.IsNullOrEmpty(IdLabel.Text))
        cliente.Id      = int.Parse(IdLabel.Text);
      else
        cliente.Id      = 0;
      cliente.Nome      = Nome.Text;
      cliente.Sobrenome = Telefone.Text;
      cliente.Endereço = Endereço.Text;
      cliente.Email  = Email.Text;
      cliente.CPF  = CPF.Text;
     

      // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
      clienteControle.CriarOuAtualizar(cliente);
      // Mostra a mensagem de sucesso
      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
    }
  }

  //--------------------------------------------------------------------------------------------------
  // Esse método pode ser escrito de várias maneiras. A idéia é que você valide os dados antes de 
  // preencher o objeto (Modelo). 
  // Perceba que além da retornar false (para indicar erro), também mostra qual o erro
  private async Task<bool> VerificaSeDadosEstaoCorretos()
  {
    // Verifica se a Entry do Nome está vazia
    if (String.IsNullOrEmpty(Nome.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Telefone está vazia
    else if (String.IsNullOrEmpty(Telefone.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Endereço está vazia
    else if (String.IsNullOrEmpty(Endereço.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
      return false;
    }

    // Verifica se a Entry do Email está vazia
    else if (String.IsNullOrEmpty(Email.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
      return false;
    }

    // Verifica se a Entry do CPF está vazia
    else if (String.IsNullOrEmpty(CPF.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
      return false;
    }
    else
      return true;
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