namespace Classes
{
    public class ProcuraVendaControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public ProcuraVendaControle() : base()
      {
        NomeDaTabela = "ProcuraVenda";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idProcuraVenda)
      {
        var collection = liteDB.GetCollection<ProcuraVenda>(NomeDaTabela);
        return collection.FindOne(k => k.Id == idProcuraVenda);
      }

      //----------------------------------------------------------------------------

      public virtual List<ProcuraVenda>? LerTodos()
      {
        var tabela = liteDB.GetCollection<ProcuraVenda>(NomeDaTabela);
        return new List<ProcuraVenda>(tabela.FindAll().OrderBy(k => k.DataVenda));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idProcuraVenda)
      {
        var collection = liteDB.GetCollection<ProcuraVenda>(NomeDaTabela);
        collection.Delete(idProcuraVenda);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(ProcuraVenda procuravenda)
      {
        var collection = liteDB.GetCollection<ProcuraVenda>(NomeDaTabela);
        collection.Upsert(procuravenda);
      }

      //----------------------------------------------------------------------------
    }
}
public class Registro
{
}