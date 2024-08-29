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
        return collection.FindOne(m => m.Id == idVendas);
      }

      //----------------------------------------------------------------------------

      public virtual List<Vendas>? LerTodos()
      {
        var tabela = liteDB.GetCollection<Vendas>(NomeDaTabela);
        return new List<Vendas>(tabela.FindAll().OrderBy(m => m.Vendas));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idVendas)
      {
        var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
        collection.Delete(idVendas);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Vendas vendas)
      {
        var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
        collection.Upsert(vendas);
      }

      //----------------------------------------------------------------------------
    }
}