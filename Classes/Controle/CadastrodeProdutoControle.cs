namespace Classes
{
    public class CadastrodeProdutoControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public CadastrodeProdutoControle() : base()
      {
        NomeDaTabela = "Clientes";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idCadastrodeProduto)
      {
        var collection = liteDB.GetCollection<CadastrodeProduto>(NomeDaTabela);
        return collection.FindOne(a => a.Id == idCadastrodeProduto);
      }

      //----------------------------------------------------------------------------

      public virtual List<CadastrodeProduto>? LerTodos()
      {
        var tabela = liteDB.GetCollection<CadastrodeProduto>(NomeDaTabela);
        return new List<CadastrodeProduto>(tabela.FindAll().OrderBy(a => a.CadastrodeProduto));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idCadastrodeProduto)
      {
        var collection = liteDB.GetCollection<CadastrodeProduto>(NomeDaTabela);
        collection.Delete(idCadastrodeProduto);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(CadastrodeProduto cadastrodeproduto)
      {
        var collection = liteDB.GetCollection<CadastrodeProduto>(NomeDaTabela);
        collection.Upsert(CadastrodeProduto);
      }

      //----------------------------------------------------------------------------
    }
}