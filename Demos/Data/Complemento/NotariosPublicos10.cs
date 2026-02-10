using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class NotariosPublicos10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.NotariosPublicos);
      HyperSoft.ElectronicDocumentLibrary.Complemento.NotariosPublicos.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.NotariosPublicos.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";

      #region Datos del inmueble

      ElectronicDocumentLibrary.Complemento.NotariosPublicos.Inmueble inmueble = data.Inmuebles.Add();
      inmueble.Tipo.Value = "01";
      inmueble.Calle.Value = "Calle";
      inmueble.NumeroExterior.Value = "NumeroExterior";
      inmueble.NumeroInterior.Value = "NumeroInterior";
      inmueble.Colonia.Value = "Colonia";
      inmueble.Localidad.Value = "Localidad";
      inmueble.Referencia.Value = "Referencia";
      inmueble.Municipio.Value = "Municipio";
      inmueble.Estado.Value = "01";
      inmueble.Pais.Value = "MEX";
      inmueble.CodigoPostal.Value = "00000";

      inmueble = data.Inmuebles.Add();
      inmueble.Tipo.Value = "02";
      inmueble.Calle.Value = "Acapulco";
      inmueble.NumeroExterior.Value = "100";
      inmueble.NumeroInterior.Value = "2";
      inmueble.Colonia.Value = "Cuathemoc";
      inmueble.Localidad.Value = "XXX";
      inmueble.Municipio.Value = "Municipio";
      inmueble.Estado.Value = "02";
      inmueble.Pais.Value = "MEX";
      inmueble.CodigoPostal.Value = "11111";

      #endregion

      #region Datos de la operación

      data.Operacion.NumeroInstrumentoNotarial.Value = 1;
      data.Operacion.FechaInstrumentoNotarial.Value = DateTime.Now;
      data.Operacion.MontoOperacion.Value = 123456789;
      data.Operacion.SubTotal.Value = 123456;
      data.Operacion.Iva.Value = 1236987;

      #endregion

      #region Datos del notario

      data.Notario.Curp.Value = "UXBA000419HYNVRDA3";
      data.Notario.NumeroNotaria.Value = 2;
      data.Notario.EntidadFederativa.Value = "03";
      data.Notario.Adscripcion.Value = "ABC";

      #endregion

      #region Datos del Enajenante

      data.Enajenante.CopropiedadSociedadConyugal.Value = "Si";

      //data.Enajenante.UnEnajenante.Nombre.Value = "ABC";
      //data.Enajenante.UnEnajenante.ApellidoPaterno.Value = "DEF";
      //data.Enajenante.UnEnajenante.ApellidoMaterno.Value = "BEF";
      //data.Enajenante.UnEnajenante.Rfc.Value = "AAA010101AAA";
      //data.Enajenante.UnEnajenante.Curp.Value = "UXBA000419HYNVRDA3";

      ElectronicDocumentLibrary.Complemento.NotariosPublicos.EnajenanteCopropiedad copropiedad = data.Enajenante.EnajenantesCopropiedades.Add();
      copropiedad.Nombre.Value = "FTG";
      copropiedad.ApellidoPaterno.Value = "PÑL";
      copropiedad.ApellidoMaterno.Value = "MJY";
      copropiedad.Rfc.Value = "AAA010101AA1";
      copropiedad.Curp.Value = "BADD110313HCMLNS07";
      copropiedad.Porcentaje.Value = 10;

      copropiedad = data.Enajenante.EnajenantesCopropiedades.Add();
      copropiedad.Nombre.Value = "POI";
      copropiedad.ApellidoPaterno.Value = "ÑLK";
      copropiedad.ApellidoMaterno.Value = "MNB";
      copropiedad.Rfc.Value = "AAA010101AA2";
      copropiedad.Curp.Value = "BADD110313HCMLNS06";
      copropiedad.Porcentaje.Value = 85;

      copropiedad = data.Enajenante.EnajenantesCopropiedades.Add();
      copropiedad.Nombre.Value = "ASD";
      copropiedad.ApellidoPaterno.Value = "ZXC";
      copropiedad.ApellidoMaterno.Value = "QWE";
      copropiedad.Rfc.Value = "AAA010101AA3";
      copropiedad.Curp.Value = "BADD110313HCMLNS05";
      copropiedad.Porcentaje.Value = 5;

      #endregion

      #region Datos del Adquiriente

      data.Adquiriente.CopropiedadSociedadConyugal.Value = "No";

      //data.Adquiriente.UnAdquiriente.Nombre.Value = "ÑLK";
      //data.Adquiriente.UnAdquiriente.ApellidoPaterno.Value = "ZXC";
      //data.Adquiriente.UnAdquiriente.ApellidoMaterno.Value = "MNB";
      //data.Adquiriente.UnAdquiriente.Rfc.Value = "AAA010101AA2";
      //data.Adquiriente.UnAdquiriente.Curp.Value = "BADD110313HCMLNS07";

      ElectronicDocumentLibrary.Complemento.NotariosPublicos.AdquirienteCopropiedad adquirienteCopropiedad = data.Adquiriente.AdquirientesCopropiedades.Add();
      adquirienteCopropiedad.Nombre.Value = "FTG";
      adquirienteCopropiedad.ApellidoPaterno.Value = "PÑL";
      adquirienteCopropiedad.ApellidoMaterno.Value = "MJY";
      adquirienteCopropiedad.Rfc.Value = "AAA010101AA1";
      adquirienteCopropiedad.Curp.Value = "BADD110313HCMLNS07";
      adquirienteCopropiedad.Porcentaje.Value = 10;

      adquirienteCopropiedad = data.Adquiriente.AdquirientesCopropiedades.Add();
      adquirienteCopropiedad.Nombre.Value = "POI";
      adquirienteCopropiedad.ApellidoPaterno.Value = "ÑLK";
      adquirienteCopropiedad.ApellidoMaterno.Value = "MNB";
      adquirienteCopropiedad.Rfc.Value = "AAA010101AA2";
      adquirienteCopropiedad.Curp.Value = "BADD110313HCMLNS06";
      adquirienteCopropiedad.Porcentaje.Value = 85;

      adquirienteCopropiedad = data.Adquiriente.AdquirientesCopropiedades.Add();
      adquirienteCopropiedad.Nombre.Value = "ASD";
      adquirienteCopropiedad.ApellidoPaterno.Value = "ZXC";
      adquirienteCopropiedad.ApellidoMaterno.Value = "QWE";
      adquirienteCopropiedad.Rfc.Value = "AAA010101AA3";
      adquirienteCopropiedad.Curp.Value = "BADD110313HCMLNS05";
      adquirienteCopropiedad.Porcentaje.Value = 5;

      #endregion

      return Base.Save(electronicDocument, "NotariosPublicos.xml", out fileName);
    }
  }
}