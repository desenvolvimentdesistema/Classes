namespace Classes
{
    public class CosturaControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public CosturaControle() : base()
      {
        NomeDaTabela = "Costura";
      }

      //----------------------------------------------------------------------------

      public virtual Cadastro? Ler(int idCostura)
      {
        var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
        return collection.FindOne(d => d.Id == idCostura);
      }

      //----------------------------------------------------------------------------

      public virtual List<Costura>? LerTodos()
      {
        var tabela = liteDB.GetCollection<Costura>(NomeDaTabela);
        return new List<Costura>(tabela.FindAll().OrderBy(d => d.Costura));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idCostura)
      {
        var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
        collection.Delete(idCostura);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Costura costura)
      {
        var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
        collection.Upsert(costura);
      }

      //----------------------------------------------------------------------------
    }
}