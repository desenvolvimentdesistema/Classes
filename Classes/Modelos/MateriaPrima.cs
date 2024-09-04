using LiteDB;

namespace Classes.Modelos;

public class MateriaPrima : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }

  public object TipodeMateriaPrima { get; set; }
  public object Fornecedor { get; set; }
  public object Quantidade { get; set; }
  public object Cor { get; set; }

}