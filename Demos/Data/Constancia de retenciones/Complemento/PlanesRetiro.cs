using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones.PlanesRetiro;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class PlanesRetiro
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.PlanesRetiro);
      ElectronicDocumentLibrary.ConstanciaRetenciones.PlanesRetiro.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.PlanesRetiro.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.1";
      data.SistemaFinanciero.Value = "SI";
      data.MontoTotalAportaciones.Value = 15000;
      data.MontoInteresesReales.Value = 2000;
      data.HuboRetirosAnioAnteriorPermanencia.Value = "SI";
      data.MontoTotalRetiro.Value = 15000;
      data.MontoTotalExentoRetiro.Value = 10000;
      data.MontoTotalExedente.Value = 5000;
      data.HuboRetirosAnioInmediatoAnterior.Value = "SI";
      data.MontTotalRetirado.Value = 2000;
      data.MontoTotalExentoRetiro.Value = 3000;
      data.MontoTotalExedente.Value = 4000;
      data.HuboRetirosAnioInmediatoAnterior.Value = "SI";
      data.NumeroReferencia.Value = "0001";

      AportacionDeposito deposito = data.AportacionesDepositos.Add();
      deposito.Tipo.Value = "a";
      deposito.Monto.Value = 100;
      deposito.RfcFiduciaria.Value = "AAA010101AAA";

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Planes_De_Retiro.xml", out fileName);
    }
  }
}