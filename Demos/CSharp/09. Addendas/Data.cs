namespace HyperSoft.Ejemplo.Adendas
{
  public delegate bool Ejecutar(out string fileName); 

  public class Data
  {
    public string Version { get; set; }

    public Ejecutar Metodo { get; set; }
  }
}