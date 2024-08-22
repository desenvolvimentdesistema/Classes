using LiteDB;
namespace Classes
{
    public class PedidoControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public PedidoControle() : base()
      {
        NomeDaTabela = "Pedidos";
      }

      //----------------------------------------------------------------------------

      public virtual Cadastro? Ler(int idPedidos)
      {
        var collection = liteDB.GetCollection<Pedidos>(NomeDaTabela);
        return collection.FindOne(d => d.Id == idPedidos);
      }

      //----------------------------------------------------------------------------

      public virtual List<Pedidos>? LerTodos()
      {
        var tabela = liteDB.GetCollection<Pedidos>(NomeDaTabela);
        return new List<Pedidos>(tabela.FindAll().OrderBy(d => d.Pedidos));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idPedidos)
      {
        var collection = liteDB.GetCollection<Pedidos>(NomeDaTabela);
        collection.Delete(idPedidos);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Pedidos pedidos)
      {
        var collection = liteDB.GetCollection<Pedidos>(NomeDaTabela);
        collection.Upsert(pedidos);
      }

      //----------------------------------------------------------------------------
    }
}