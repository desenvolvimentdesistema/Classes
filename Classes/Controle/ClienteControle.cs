using Classes.Modelos;
using LiteDB;
namespace Classes
{
    public class ClienteControle : BaseControle
    {
        private Cliente cliente;

        //----------------------------------------------------------------------------

        public ClienteControle() : base()
      {
        NomeDaTabela = "Cliente";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idCliente)
      {
        var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
        return collection.FindOne(c => c.Id == idCliente);
      }

      //----------------------------------------------------------------------------

      public virtual List<Cliente>? LerTodos()
      {
        var tabela = liteDB.GetCollection<Cliente>(NomeDaTabela);
        return new List<Cliente>(tabela.FindAll().OrderBy(c => c.Cliente));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idCliente)
      {
        var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
        collection.Delete(idCliente);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Cliente clientes)
      {
        var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
        collection.Upsert(cliente);
      }

      //----------------------------------------------------------------------------
    }
}