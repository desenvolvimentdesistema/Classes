using LiteDB;

namespace Classes.Modelos;

public class ProcuraVenda : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }

  public object ClienteEntry { get; set; }
  public object IdProdutoEntry { get; set; }
  public object IdClienteEntry { get; set; }
  public object DataVenda { get; set; }

}