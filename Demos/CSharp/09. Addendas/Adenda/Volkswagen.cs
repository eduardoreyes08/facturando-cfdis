using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Volkswagen.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Volkswagen(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Volkswagen addenda = new HyperSoft.ElectronicDocumentLibrary.Volkswagen.Addenda.Volkswagen();

      addenda.Data.Version.Value = "1.0";
      addenda.Data.TipoDocumentoVwm.Value = "PSV";
      addenda.Data.TipoDocumentoFiscal.Value = "FA";
      addenda.Data.Division.Value = "VM";

      addenda.Data.Cancelaciones.CancelaSustituye.Value = "a";

      addenda.Data.Moneda.CodigoImpuesto.Value = "a";
      addenda.Data.Moneda.TipoMoneda.Value = "aaa";
      addenda.Data.Moneda.TipoCambio.Value = 123;

      addenda.Data.Proveedor.Codigo.Value = "0000000000";
      addenda.Data.Proveedor.CorreoContacto.Value = "a";
      addenda.Data.Proveedor.Nombre.Value = "aaa";

      addenda.Data.Origen.Codigo.Value = "0000000000";
      addenda.Data.Origen.Nombre.Value = "aaa";

      addenda.Data.Destino.Codigo.Value = "0000000000";
      addenda.Data.Destino.NaveReciboMaterial.Value = "aaa";

      addenda.Data.Medidas.PesoBruto.Value = 1;
      addenda.Data.Medidas.PesoNeto.Value = 2;
      addenda.Data.Medidas.Volumen.Value = 3;
      addenda.Data.Medidas.NumeroPiezas.Value = 4;
      addenda.Data.Medidas.Descripcion.Value = "Descripcion";

      addenda.Data.Referencias.NumeroAsn.Value = "a";
      addenda.Data.Referencias.ReferenciaProveedor.Value = "b";
      addenda.Data.Referencias.UnidadNegocios.Value = "c";
      addenda.Data.Referencias.Remision.Value = "d";

      addenda.Data.Solicitante.Correo.Value = "a";
      addenda.Data.Solicitante.Nombre.Value = "b";

      addenda.Data.Notas.Add().Text.Value = "a";
      addenda.Data.Notas.Add().Text.Value = "archivo";

      Archivo archivo = addenda.Data.Archivos.Add();
      archivo.Datos.Value = "string";
      archivo.Tipo.Value = "string";

      Parte parte = addenda.Data.Partes.Add();
      parte.CodigoImpuesto.Value = "aa";
      parte.NumeroMaterial.Value = "a";
      parte.Posicion.Value = 1;
      parte.MontoLinea.Value = 2;
      parte.PrecioUnitario.Value = 3;
      parte.DescripcionMaterial.Value = "b";
      parte.CantidadMaterial.Value = 4;
      parte.PesoNeto.Value = 5;
      parte.UnidadMedida.Value = "c";

      parte.Referencias.OrdenCompra.Value = "aaaaaaaaaa";

      parte.Notas.Add().Text.Value = "d";
      parte.Notas.Add().Text.Value = "e";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Volkswagen.xml", out fileName);
    }
  }
}