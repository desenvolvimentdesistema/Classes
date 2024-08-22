namespace Classes
{
    public class EstoqueControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public EstoqueControle() : base()
      {
        NomeDaTabela = "Estoque";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idEstoque)
      {
        var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
        return collection.FindOne(d => d.Id == idEstoque);
      }

      //----------------------------------------------------------------------------

      public virtual List<Estoque>? LerTodos()
      {
        var tabela = liteDB.GetCollection<Estoque>(NomeDaTabela);
        return new List<Estoque>(tabela.FindAll().OrderBy(d => d.Estoque));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idEstoque)
      {
        var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
        collection.Delete(idEstoque);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(Estoque estoque)
      {
        var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
        collection.Upsert(estoque);
      }

      //----------------------------------------------------------------------------
    }
}