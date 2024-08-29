namespace Classes
{
    public class EscolherQuantidadeControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public EscolherQuantidadeControle() : base()
      {
        NomeDaTabela = "EscolherQuantidade";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idEscolherQuantidade)
      {
        var collection = liteDB.GetCollection<EscolherQuantidade>(NomeDaTabela);
        return collection.FindOne(f => fs.Id == idEscolherQuantidade);
      }

      //----------------------------------------------------------------------------

      public virtual List<EscolherQuantidade>? LerTodos()
      {
        var tabela = liteDB.GetCollection<EscolherQuantidade>(NomeDaTabela);
        return new List<EscolherQuantidade>(tabela.FindAll().OrderBy(f => f.Quantia));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idEscolherQuantidade)
      {
        var collection = liteDB.GetCollection<EscolherQuantidade>(NomeDaTabela);
        collection.Delete(idEscolherQuantidade);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(EscolherQuantidade escolherquantidade)
      {
        var collection = liteDB.GetCollection<EscolherQuantidade>(NomeDaTabela);
        collection.Upsert(escolherquantidade);
      }

      //----------------------------------------------------------------------------
    }
}