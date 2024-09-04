using Classes.Modelos;

namespace Classes;
public partial class ListaCliente : ContentPage
{
  ClienteControle clienteControle = new ClienteControle();
  Cliente cliente;

  // public static object ItemsSource { get; private set; }

  public ListaCliente()
  {
    InitializeComponent();
    cliente = new Cliente();
  
    ListaCliente.ItemsSource = clienteControle.LerTodos();
  }

    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new CadastroCliente();

    page.cliente = e.SelectedItem as Cliente;

    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastroCliente();
  }
}


