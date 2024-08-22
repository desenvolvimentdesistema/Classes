namespace Classes
{
    public class CadastrodeVendaeDeletarControle : BaseControle
    {
      //----------------------------------------------------------------------------

      public CadastrodeVendaeDeletarControle() : base()
      {
        NomeDaTabela = "CadastrodeVendaeDeletar";
      }

      //----------------------------------------------------------------------------

      public virtual Registro? Ler(int idCadastrodeVendaeDeletar)
      {
        var collection = liteDB.GetCollection<CadastrodeVendaeDeletar>(NomeDaTabela);
        return collection.FindOne(d => d.Id == idCadastrodeVendaeDeletar);
      }

      //----------------------------------------------------------------------------

      public virtual List<CadastrodeVendaeDeletar>? LerTodos()
      {
        var tabela = liteDB.GetCollection<CadastrodeVendaeDeletar>(NomeDaTabela);
        return new List<CadastrodeVendaeDeletar>(tabela.FindAll().OrderBy(d => d.CadastrodeVendaedeletar));
      }

      //----------------------------------------------------------------------------

      public virtual void Apagar(int idCadastrodeVendaeDeletar)
      {
        var collection = liteDB.GetCollection<CadastrodeVendaeDeletar>(NomeDaTabela);
        collection.Delete(idCadastrodeVendaeDeletar);
      }

      //----------------------------------------------------------------------------

      public virtual void CriarOuAtualizar(CadastrodeVendaeDeletar cadastrodevendaeDeletar)
      {
        var collection = liteDB.GetCollection<CadastrodeVendaeDeletar>(NomeDaTabela);
        collection.Upsert(cadastrodevendaeDeletar);
      }

      //----------------------------------------------------------------------------
    }
}