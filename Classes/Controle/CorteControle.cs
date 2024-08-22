namespace Classes
{
    public class CorteControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public CorteControle() : base()
      {
        NomeDaTabela = "Corte";
      }

      //----------------------------------------------------------------------------

      public virtual Cadastro? Ler(int idCorte)
      {
        var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
        return collection.FindOne(d => d.Id == idCorte);
      }

      //----------------------------------------------------------------------------

      public virtual List<Corte>? LerTodos()
      {
        var tabela = liteDB.GetCollection<Cliente>(NomeDaTabela);
        return new List<Corte>(tabela.FindAll().OrderBy(d => d.Corte));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idCorte)
      {
        var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
        collection.Delete(idCorte);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Corte corte)
      {
        var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
        collection.Upsert(corte);
      }

      //----------------------------------------------------------------------------
    }
}