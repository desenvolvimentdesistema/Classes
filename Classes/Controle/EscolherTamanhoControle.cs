namespace Classes;

public class EscolherTamanhoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EscolherTamanhoControle() : base()
  {
    NomeDaTabela = "EscolherTamanho";
  }

  //----------------------------------------------------------------------------

  public virtual Cadastro? Ler(int idEscolherTamanho)
  {
    var collection = liteDB.GetCollection<EscolherTamanho>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idEscolherTamanho);
  }

  //----------------------------------------------------------------------------

  public virtual List<EscolherTamanho>? LerTodos()
  {
    var tabela = liteDB.GetCollection<EscolherTamanho>(NomeDaTabela);
    return new List<EscolherTamanho>(tabela.FindAll().OrderBy(d => d.Tamanho));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idEscolherTamanho)
  {
    var collection = liteDB.GetCollection<EscolherTamanho>(NomeDaTabela);
    collection.Delete(idEscolherTamanho);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(EscolherTamanho escolhertamanho )
  {
    var collection = liteDB.GetCollection<EscolherTamanho>(NomeDaTabela);
    collection.Upsert(escolhertamanho);
  }

  //----------------------------------------------------------------------------
}