namespace Classes
{
    public class RealizarPedidoControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public RealizarPedidoControle() : base()
      {
        NomeDaTabela = "RealizarPedido";
      }

      //----------------------------------------------------------------------------

      public virtual Cadastro? Ler(int idRealizarPedido)
      {
        var collection = liteDB.GetCollection<RealizarPedido>(NomeDaTabela);
        return collection.FindOne(d => d.Id == idRealizarPedido);
      }

      //----------------------------------------------------------------------------

      public virtual List<RealizarPedido>? LerTodos()
      {
        var tabela = liteDB.GetCollection<RealizarPedido>(NomeDaTabela);
        return new List<RealizarPedido>(tabela.FindAll().OrderBy(d => d.RealizaçãodoPedido));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idRealizarPedido)
      {
        var collection = liteDB.GetCollection<RealizarPedido>(NomeDaTabela);
        collection.Delete(idRealizarPedido);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(RealizarPedido realizarpedido)
      {
        var collection = liteDB.GetCollection<RealizarPedido>(NomeDaTabela);
        collection.Upsert(realizarpedido);
      }

      //----------------------------------------------------------------------------
    }

    public class Cadastro
    {
    }
}