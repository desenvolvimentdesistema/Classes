namespace Classes
{
    public class MateriaPrimaControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public MateriaPrimaControle() : base()
      {
        NomeDaTabela = "MateriaPrima";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idMateriaPrima)
      {
        var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
        return collection.FindOne(i => i.Id == idMateriaPrima);
      }

      //----------------------------------------------------------------------------

      public virtual List<MateriaPrima>? LerTodos()
      {
        var tabela = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
        return new List<MateriaPrima>(tabela.FindAll().OrderBy(i => i.MateriaPrima));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idMateriaPrima)
      {
        var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
        collection.Delete(idMateriaPrima);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(MateriaPrima materiaprima)
      {
        var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
        collection.Upsert(materiaprima);
      }

      //----------------------------------------------------------------------------
    }
}