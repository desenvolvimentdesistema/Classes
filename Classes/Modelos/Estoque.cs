using LiteDB;

namespace Classes.Modelos;

public class Estoque : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome {get; set ;}
}