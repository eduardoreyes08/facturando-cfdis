using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class Premios
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.Premios);
      ElectronicDocumentLibrary.ConstanciaRetenciones.Premios.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.Premios.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.EntidadFederativa.Value = "24";
      data.MontoTotalPago.Value = 10000;
      data.MontoTotalPagoGravado.Value = 6500;
      data.MontoTotalPagoExento.Value = 3500;

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Premios.xml", out fileName);
    }
  }
}
