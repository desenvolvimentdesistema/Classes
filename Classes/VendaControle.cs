using LiteDB;

namespace Classes
{
    public class VendaControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public VendaControle() : base()
      {
        NomeDaTabela = "Vendas";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idVendas)
      {
        var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
        return collection.FindOne(d => d.Id == idVendas);
      }

      //----------------------------------------------------------------------------

      public virtual List<Vendas>? LerTodos()
      {
        var tabela = liteDB.GetCollection<Vendas>(NomeDaTabela);
        return new List<Vendas>(tabela.FindAll().OrderBy(d => d.Vendas));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idVenda)
      {
        var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
        collection.Delete(idVenda);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Cliente cliente)
      {
        var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
        collection.Upsert(cliente);
      }

      //----------------------------------------------------------------------------
    }
}