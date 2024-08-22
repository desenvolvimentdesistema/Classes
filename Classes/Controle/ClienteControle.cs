using LiteDB;
namespace Classes
{
    public class ClienteControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public ClienteControle() : base()
      {
        NomeDaTabela = "Clientes";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idClientes)
      {
        var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
        return collection.FindOne(d => d.Id == idClientes);
      }

      //----------------------------------------------------------------------------

      public virtual List<Clientes>? LerTodos()
      {
        var tabela = liteDB.GetCollection<Clientes>(NomeDaTabela);
        return new List<Clientes>(tabela.FindAll().OrderBy(d => d.Clientes));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idClientes)
      {
        var collection = liteDB.GetCollection<Clientes>(NomeDaTabela);
        collection.Delete(idClientes);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Clientes clientes)
      {
        var collection = liteDB.GetCollection<Clientes>(NomeDaTabela);
        collection.Upsert(clientes);
      }

      //----------------------------------------------------------------------------
    }
}