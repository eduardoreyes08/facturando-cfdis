namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class NotariosPublicos
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.NotariosPublicos.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO NOTARIOS PUBLICO");
      Utils.ShowField("Versión          ", data.Version);

      for (int i = 0; i < data.Inmuebles.Count; i++)
      {
        Utils.ShowTitle("NOTARIOS PUBLICO / INMUEBLE - " + (i + 1));
        Utils.ShowField("Tipo           ", data.Inmuebles[i].Tipo);
        Utils.ShowField("Calle          ", data.Inmuebles[i].Calle);
        Utils.ShowField("Número exterior", data.Inmuebles[i].NumeroExterior);
        Utils.ShowField("Número interior", data.Inmuebles[i].NumeroInterior);
        Utils.ShowField("Colonia        ", data.Inmuebles[i].Colonia);
        Utils.ShowField("Localidad      ", data.Inmuebles[i].Localidad);
        Utils.ShowField("Referencia     ", data.Inmuebles[i].Referencia);
        Utils.ShowField("Municipio      ", data.Inmuebles[i].Municipio);
        Utils.ShowField("Estado         ", data.Inmuebles[i].Estado);
        Utils.ShowField("País           ", data.Inmuebles[i].Pais);
        Utils.ShowField("Código postal  ", data.Inmuebles[i].CodigoPostal);
      }

      if (data.Operacion.IsAssigned)
      {
        Utils.ShowTitle("NOTARIOS PUBLICO / OPERACION");
        Utils.ShowField("Número instrumento notarial", data.Operacion.NumeroInstrumentoNotarial);
        Utils.ShowField("Fecha instrumento notarial ", data.Operacion.FechaInstrumentoNotarial);
        Utils.ShowField("MontoOperacion             ", data.Operacion.MontoOperacion);
        Utils.ShowField("SubTotal                   ", data.Operacion.SubTotal);
        Utils.ShowField("IVA                        ", data.Operacion.Iva);
      }

      if (data.Notario.IsAssigned)
      {
        Utils.ShowTitle("NOTARIOS PUBLICO / NOTARIO");
        Utils.ShowField("CURP              ", data.Notario.Curp);
        Utils.ShowField("Número notaria    ", data.Notario.NumeroNotaria);
        Utils.ShowField("Entidad federativa", data.Notario.EntidadFederativa);
        Utils.ShowField("Adscripcion       ", data.Notario.Adscripcion);
      }

      if (data.Enajenante.IsAssigned)
      {
        Utils.ShowTitle("NOTARIOS PUBLICO / ENAJENANTE");
        Utils.ShowField("CopropiedadSociedadConyugal", data.Enajenante.CopropiedadSociedadConyugal);

        if (data.Enajenante.UnEnajenante.IsAssigned)
        {
          Utils.ShowTitle("NOTARIOS PUBLICO / ENAJENANTE / UN ENAJENANTE");
          Utils.ShowField("Nombre          ", data.Enajenante.UnEnajenante.Nombre);
          Utils.ShowField("Apellido paterno", data.Enajenante.UnEnajenante.ApellidoPaterno);
          Utils.ShowField("Apellido materno", data.Enajenante.UnEnajenante.ApellidoMaterno);
          Utils.ShowField("RFC             ", data.Enajenante.UnEnajenante.Rfc);
          Utils.ShowField("CURP            ", data.Enajenante.UnEnajenante.Curp);
        }

        for (int i = 0; i < data.Enajenante.EnajenantesCopropiedades.Count; i++)
        {
          Utils.ShowTitle("NOTARIOS PUBLICO / ENAJENANTE / COPROPIEDAD - " + (i + 1));
          Utils.ShowField("Nombre          ", data.Enajenante.EnajenantesCopropiedades[i].Nombre);
          Utils.ShowField("Apellido paterno", data.Enajenante.EnajenantesCopropiedades[i].ApellidoPaterno);
          Utils.ShowField("Apellido materno", data.Enajenante.EnajenantesCopropiedades[i].ApellidoMaterno);
          Utils.ShowField("RFC             ", data.Enajenante.EnajenantesCopropiedades[i].Rfc);
          Utils.ShowField("CURP            ", data.Enajenante.EnajenantesCopropiedades[i].Curp);
          Utils.ShowField("Porcentaje      ", data.Enajenante.EnajenantesCopropiedades[i].Porcentaje);
        }
      }

      if (data.Adquiriente.IsAssigned)
      {
        Utils.ShowTitle("NOTARIOS PUBLICO / ADQUIRIENTE");
        Utils.ShowField("CopropiedadSociedadConyugal", data.Adquiriente.CopropiedadSociedadConyugal);

        if (data.Adquiriente.UnAdquiriente.IsAssigned)
        {
          Utils.ShowTitle("NOTARIOS PUBLICO / ADQUIRIENTE / UN ADQUIRIENTE");
          Utils.ShowField("Nombre          ", data.Adquiriente.UnAdquiriente.Nombre);
          Utils.ShowField("Apellido paterno", data.Adquiriente.UnAdquiriente.ApellidoPaterno);
          Utils.ShowField("Apellido materno", data.Adquiriente.UnAdquiriente.ApellidoMaterno);
          Utils.ShowField("RFC             ", data.Adquiriente.UnAdquiriente.Rfc);
          Utils.ShowField("CURP            ", data.Adquiriente.UnAdquiriente.Curp);
        }

        for (int i = 0; i < data.Adquiriente.AdquirientesCopropiedades.Count; i++)
        {
          Utils.ShowTitle("NOTARIOS PUBLICO / ADQUIRIENTE / COPROPIEDAD - " + (i + 1));
          Utils.ShowField("Nombre          ", data.Adquiriente.AdquirientesCopropiedades[i].Nombre);
          Utils.ShowField("Apellido paterno", data.Adquiriente.AdquirientesCopropiedades[i].ApellidoPaterno);
          Utils.ShowField("Apellido materno", data.Adquiriente.AdquirientesCopropiedades[i].ApellidoMaterno);
          Utils.ShowField("RFC             ", data.Adquiriente.AdquirientesCopropiedades[i].Rfc);
          Utils.ShowField("CURP            ", data.Adquiriente.AdquirientesCopropiedades[i].Curp);
          Utils.ShowField("Porcentaje      ", data.Adquiriente.AdquirientesCopropiedades[i].Porcentaje);
        }
      }
    }
  }
}