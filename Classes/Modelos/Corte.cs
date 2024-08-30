using LiteDB;

namespace Classes.Modelos;

public class Corte : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome {get; set ;}
}