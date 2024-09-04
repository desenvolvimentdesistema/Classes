using LiteDB;

namespace Classes.Modelos;

public class Costura : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public object Quantidade { get; set; }
  public object CordaCostura { get; set; }
  public object FormatodaCostura { get; set; }
}