using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Pepsico.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Pepsico(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Pepsico addenda = HyperSoft.ElectronicDocumentLibrary.Pepsico.Addenda.Pepsico.NewEntity();

      addenda.Data.Tipo.Value = "AddendaPCO";
      addenda.Data.Version.Value = "2.0";
      addenda.Data.IdPedido.Value = "1234567890";
      addenda.Data.IdSolicitudPago.Value = "1234567890";

      addenda.Data.Documento.Referencia.Value = "Referencia";
      addenda.Data.Documento.FolioUuid.Value = "FolioUuid";
      addenda.Data.Documento.TipoDocumento.Value = 1;

      addenda.Data.Proveedor.Id.Value = 1234567890;

      ElectronicDocumentLibrary.Pepsico.Addenda.Recepcion recepcion = addenda.Data.Recepciones.Add();
      recepcion.Id.Value = 1234567890;

      ElectronicDocumentLibrary.Pepsico.Addenda.Concepto concepto = recepcion.Conceptos.Add();
      concepto.Cantidad.Value = 1;
      concepto.Unidad.Value = "Unidad";
      concepto.Descripcion.Value = "Descripcion";
      concepto.ValorUnitario.Value = 2;
      concepto.Importe.Value = 3;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Pepsico.xml", out fileName);
    }
  }
}