using System;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Axxa.Addenda.Autos;
using HyperSoft.ElectronicDocumentLibrary.Axxa.Addenda.GastosMedicos;
using HyperSoft.ElectronicDocumentLibrary.Coppel.Addenda;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.EnvasesUniversalesMexico.Addenda;
using HyperSoft.ElectronicDocumentLibrary.Soriana.Remision.Addenda;
using HyperSoft.ElectronicDocumentLibrary.Soriana.Servicio.Addenda;
using HyperSoft.Shared;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    #region Vars

    private static string directorioSalida;
    private static ElectronicDocument electronicDocument;

    #endregion

    #region Methods

    internal static void SetConfiguration(string directorio, ElectronicDocument electronic)
    {
      directorioSalida = directorio;
      electronicDocument = electronic;
    }

    private static bool Save(string fileName, out string fullFileName)
    {
      string errorMessage;
      fullFileName = Path.Combine(directorioSalida, fileName);

      if (System.IO.File.Exists(fullFileName))
        Shared.File.Instance.DeleteFile(fullFileName, out errorMessage);


      using (MemoryStream stream = new MemoryStream())
      {
        // Se ejecuta el proceso de generación
        if (electronicDocument.SaveToStream(stream) == false)
        {
          errorMessage = string.Format("Se generó un error al crear el XML.{0}{0}ERROR{0}{1}", Environment.NewLine, electronicDocument.ErrorText);
          MessageBox.Show(errorMessage, "Adenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
          MessageBox.Show(errorMessage, "Adenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
    }

    internal static string GetAddendaVersion(int index)
    {
      using (new WaitCursor())
      {
        switch (index)
        {
          case 0: return ElectronicDocumentLibrary.Aba.Addenda.Aba.Version();
          case 1: return ElectronicDocumentLibrary.Ado.Addenda.Ado.Version();
          case 2: return ElectronicDocumentLibrary.AlSuper.Addenda.AlSuper.Version();
          case 3: return ElectronicDocumentLibrary.AltosHornosMexico.Addenda.AltosHornosMexico.Version();
          case 4: return ElectronicDocumentLibrary.Aluprint.Addenda.Aluprint.Version();
          case 5: return ElectronicDocumentLibrary.Amece.Addenda.Amece.Version();
          case 6: return ElectronicDocumentLibrary.Amis.Addenda.Amis.Version();
          case 7: return ElectronicDocumentLibrary.Asofarma.Asonioscoc.Addenda.Asonioscoc.Version();
          case 8: return Autos.Version();
          case 9: return GastosMedicos.Version();
          case 10: return ElectronicDocumentLibrary.Bbva.Addenda.Bbva.Version;
          case 11: return ElectronicDocumentLibrary.Bexel.Addenda.Bexel.Version();
          case 12: return ElectronicDocumentLibrary.BrudiFarma.Addenda.BrudiFarma.Version();          
          case 13: return ElectronicDocumentLibrary.CapaOzono.Addenda.CapaOzono.Version();
          case 14: return ElectronicDocumentLibrary.Chrysler.Addenda.Chrysler.Version();
          case 15: return ElectronicDocumentLibrary.Comex.Addenda.Comex.Version();
          case 16: return ElectronicDocumentLibrary.ContinentalTire.Addenda.ContinentalTire.Version();
          case 17: return Coppel.Version();
          case 18: return ElectronicDocumentLibrary.CorporateTravelServices.Addenda.CorporateTravelServices.Version();
          case 19: return ElectronicDocumentLibrary.Disney.Addenda.Disney.Version();
          case 20: return ElectronicDocumentLibrary.Elektra.Addenda.Elektra.Version();
          case 21: return ElectronicDocumentLibrary.Emerson.Addenda.Emerson.Version();
          case 22: return ElectronicDocumentLibrary.Emsur.Addenda.EmSur.Version();
          case 23: return EnvasesUniversalesMexico.Version();
          case 24: return ElectronicDocumentLibrary.Femsa.Addenda.Femsa.Version();
          case 25: return ElectronicDocumentLibrary.FerroMexicana.Addenda.FerroMexicana.Version();
          case 26: return ElectronicDocumentLibrary.Fuller.Addenda.Fuller.Version();
          case 27: return ElectronicDocumentLibrary.Gayosso.Addenda.Gayosso.Version();
          case 28: return ElectronicDocumentLibrary.GeneralMotors.Addenda.GeneralMotors.Version();
          case 29: return ElectronicDocumentLibrary.Gomsa.Addenda.Gomsa.Version;
          case 30: return ElectronicDocumentLibrary.GrupoModelo.Addenda.GrupoModelo.Version();
          case 31: return ElectronicDocumentLibrary.Heb.Addenda.Heb.Version();
          case 32: return ElectronicDocumentLibrary.Inbursa.Addenda.Inbursa.Version();
          case 33: return ElectronicDocumentLibrary.Itsb.Addenda.ItSmartBusiness.Version();
          case 34: return ElectronicDocumentLibrary.Iusacell.Addenda.Iusacell.Version();
          case 35: return ElectronicDocumentLibrary.Kuehne.Addenda.Kuehne.Version();
          case 36: return ElectronicDocumentLibrary.Lamosa.Addenda.Lamosa.Version();
          case 37: return ElectronicDocumentLibrary.Landsteiner.Addenda.Landsteiner.Version();
          case 38: return ElectronicDocumentLibrary.Loreal.Addenda.Loreal.Version();
          case 39: return ElectronicDocumentLibrary.Lowes.Addenda.Lowes.Version();
          case 40: return ElectronicDocumentLibrary.Mabe.Addenda.Mabe.Version();
          case 41: return ElectronicDocumentLibrary.Maersk.Addenda.Maersk.Version();
          case 42: return ElectronicDocumentLibrary.MultiPack.Addenda.MultiPack.Version();
          case 43: return ElectronicDocumentLibrary.Oxxo.Addenda.Oxxo.Version();
          case 44: return ElectronicDocumentLibrary.Pemex.Addenda.PemexExploracion.Version();
          case 45: return ElectronicDocumentLibrary.Pemex.Addenda.PemexExploracion.Version();
          case 46: return ElectronicDocumentLibrary.Pepsico.Addenda.Pepsico.Version();
          case 47: return ElectronicDocumentLibrary.Pilgrims.Addenda.Pilgrims.Version();
          case 48: return ElectronicDocumentLibrary.Prolec.Addenda.Prolec.Version();
          case 49: return ElectronicDocumentLibrary.Sanmina.Addenda.Sanmina.Version();
          case 50: return ElectronicDocumentLibrary.Santander.Addenda.Santander.Version();
          case 51: return ElectronicDocumentLibrary.SectorPrimario.Addenda.SectorPrimario.Version();
          case 52: return ElectronicDocumentLibrary.SevenEleven.Addenda.SevenEleven.Version();
          case 53: return ElectronicDocumentLibrary.SolerPalau.Addenda.SolerPalau.Version();
          case 54: return CargaRemision.Version();
          case 55: return Servicio.Version();
          case 56: return ElectronicDocumentLibrary.TiendasNeto.Addenda.TiendasNeto.Version();
          case 57: return ElectronicDocumentLibrary.TransportesCastores.Addenda.TransportesCastores.Version();
          case 58: return ElectronicDocumentLibrary.TresM.Addenda.TresM.Version;          
          case 59: return ElectronicDocumentLibrary.TvAzteca.Addenda.TvAzteca.Version();
          case 60: return ElectronicDocumentLibrary.Viscofan.Addenda.Viscofan.Version;
          case 61: return ElectronicDocumentLibrary.Volkswagen.Addenda.Volkswagen.Version();
          case 62: return ElectronicDocumentLibrary.WalMart.Addenda.WalMart.Version;
          case 63: return ElectronicDocumentLibrary.ZfMexico.Addenda.ZfMexico.Version();
        }

        return string.Empty;
      }
    }

    #endregion
  }
}