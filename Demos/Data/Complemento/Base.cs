using System;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Document;

// ReSharper disable LocalizableElement
namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class Base
  {
    #region Vars

    private static string directorioSalida;
    
    #endregion

    #region Methods

    public static void SetConfiguration(string directorio)
    {
      directorioSalida = directorio;      
    }

    internal static bool Save(ElectronicDocument electronicDocument, string fileName, out string fullFileName)
    {
      string errorMessage;
      fullFileName = Path.Combine(directorioSalida, fileName);

      if (System.IO.File.Exists(fullFileName))
        HyperSoft.Shared.File.Instance.DeleteFile(fullFileName, out errorMessage);


      using (MemoryStream stream = new MemoryStream())
      {
        // Se ejecuta el proceso de generación
        if (electronicDocument.SaveToStream(stream) == false)
        {
          errorMessage = string.Format("Se generó un error al crear el XML.{0}{0}ERROR{0}{1}", Environment.NewLine, electronicDocument.ErrorText);
          MessageBox.Show(errorMessage, "Complementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }

        try
        {
          System.IO.File.WriteAllBytes(fullFileName, stream.ToArray());
          return true;
        }
        catch (Exception e)
        {
          errorMessage = string.Format("Se generó un error al guardar el archivo XML.{0}{0}ARCHIVO{0}{1}{0}{0}ERROR{0}{2}", Environment.NewLine, fullFileName, e.Message);
          MessageBox.Show(errorMessage, "Complementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }      
    }

    internal static void Comprobante(ElectronicDocumentLibrary.Document.Data data)
    {
      data.Clear();

      data.Version.Value = "4.0";
      data.Serie.Value = "CFDI40";
      data.Folio.Value = "1";
      data.Fecha.Value = DateTime.Now;
      data.FormaPago.Value = "01";
      data.CondicionesPago.Value = "Efectivo";
      data.SubTotal.Value = 1000.00;
      data.Moneda.Value = "MXN";
      data.Total.Value = 1000.00;
      data.TipoComprobante.Value = "I";
      data.Exportacion.Value = "01";
      data.MetodoPago.Value = "PUE";
      data.LugarExpedicion.Value = "89400";
    }

    internal static void Emisor(Emisor data)
    {
      data.Rfc.Value = "EKU9003173C9";
      data.Nombre.Value = "ESCUELA KEMPER URGATE SA DE CV";
      data.RegimenFiscal.Value = "601";
    }

    internal static void Receptor(Receptor data)
    {
      data.Rfc.Value = "AAAD770905441";
      data.Nombre.Value = "DARIO ALVAREZ ARANDA";
      data.RegimenFiscalReceptor.Value = "612";
      data.DomicilioFiscalReceptor.Value = "07300";
      data.UsoCfdi.Value = "G03";
    }

    #endregion
  }
}