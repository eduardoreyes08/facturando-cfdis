using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.ContinentalTire.Addenda;
using HyperSoft.ElectronicDocumentLibrary.ContinentalTire.OrdenCompra;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool ContinentalTire(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      ContinentalTire addenda = new ContinentalTire();

      addenda.Data.OrdenCompra.Value = "a";
      addenda.Data.Pedido.Value = 1;
      addenda.Data.TipoProveedor.Value = "1";

      Posicion posicion = addenda.Data.PosicionesOrdenCompra.Add();
      posicion.Descripcion.Value = "1";
      posicion.Numero.Value = 2;
      posicion.Embarque.Value = 3;
      posicion.TasaRetencionIsr.Value = 4;
      posicion.TasaRetencionIva.Value = 5;

      posicion = addenda.Data.PosicionesOrdenCompra.Add();
      posicion.Descripcion.Value = "1";
      posicion.Numero.Value = 2;
      posicion.Embarque.Value = 3;
      posicion.TasaRetencionIsr.Value = 4;
      posicion.TasaRetencionIva.Value = 5;

      addenda.Data.CodigoCompania.Value = 6;
      addenda.Data.ReferenciaOrdenCompra.Value = 7;
      addenda.Data.ReferenciaOtros.Value = "8";
      addenda.Data.CentroCostos.Value = "9";
      addenda.Data.Solicitante.Value = "10";
      addenda.Data.Embarque.Value = 11;

      ElectronicDocumentLibrary.ContinentalTire.Posicion valores = addenda.Data.Posiciones.Add();
      valores.Descripcion.Value = "ZS";
      valores.TasaRetencionIsr.Value = 4;
      valores.TasaRetencionIva.Value = 5;


      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Continental_Tire.xml", out fileName);
    }
  }
}