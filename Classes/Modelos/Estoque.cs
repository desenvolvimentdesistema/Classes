using LiteDB;

namespace Classes.Modelos;

public class Estoque : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }

  public object NomedoProduto { get; set; }
  public object CódigoInterno { get; set; }
  public object CódigodeBarra { get; set; }
  public object QuantidadedoProduto { get; set; }

}