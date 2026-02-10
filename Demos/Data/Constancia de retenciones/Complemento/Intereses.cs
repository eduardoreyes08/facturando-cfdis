using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class Intereses
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.Intereses);
      ElectronicDocumentLibrary.ConstanciaRetenciones.Intereses.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.Intereses.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.SistemaFinanciero.Value = "SI";
      data.Retiro.Value = "NO";
      data.OperacionesDerivadas.Value = "SI";
      data.MontoNominal.Value = 1500;
      data.MontoReal.Value = 1000.12;
      data.Perdida.Value = 500.1234;

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Intereses.xml", out fileName);
    }
  }
}
