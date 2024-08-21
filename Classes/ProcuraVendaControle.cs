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
        return collection.FindOne(d => d.Id == idProcuraVenda);
      }

      //----------------------------------------------------------------------------

      public virtual List<ProcuraVenda>? LerTodos()
      {
        var tabela = liteDB.GetCollection<ProcuraVenda>(NomeDaTabela);
        return new List<ProcuraVenda>(tabela.FindAll().OrderBy(d => d.Sobrenome));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idProcuraVenda)
      {
        var collection = liteDB.GetCollection<ProcuraVenda>(NomeDaTabela);
        collection.Delete(idProcuraVenda);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Cliente cliente)
      {
        var collection = liteDB.GetCollection<ProcuraVenda>(NomeDaTabela);
        collection.Upsert(cliente);
      }

      //----------------------------------------------------------------------------
    }
}
public class Registro
{
}