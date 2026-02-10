using HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class ComercioExterior11
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO COMERCIO EXTERIOR");
      Utils.ShowField("Versión                  ", data.Version);
      Utils.ShowField("MotivoTraslado           ", data.MotivoTraslado);
      Utils.ShowField("TipoOperacion            ", data.TipoOperacion);
      Utils.ShowField("ClavePedimento           ", data.ClavePedimento);
      Utils.ShowField("CertificadoOrigen        ", data.CertificadoOrigen);
      Utils.ShowField("NumeroCertificadoOrigen  ", data.NumeroCertificadoOrigen);
      Utils.ShowField("NumeroExportadorConfiable", data.NumeroExportadorConfiable);
      Utils.ShowField("Incoterm                 ", data.Incoterm);
      Utils.ShowField("SubDivision              ", data.SubDivision);
      Utils.ShowField("Observaciones            ", data.Observaciones);
      Utils.ShowField("TipoCambioUsd            ", data.TipoCambioUsd);
      Utils.ShowField("TotalUsd                 ", data.TotalUsd);

      ShowEmisor(data.Emisor);
      ShowPropietarios(data.Propietarios);
      ShowReceptor(data.Receptor);
      ShowDestinatarios(data.Destinatarios);
      ShowMercancias(data.Mercancias);
    }

    private static void ShowEmisor(Emisor data)
    {
      if (data.IsAssigned)
        return;

      const string Title = "COMERCIO EXTERIOR / EMISOR";
      Utils.ShowTitle(Title);
      Utils.ShowField("Curp", data.Curp);

      ShowDomicilio(Title, data.Domicilio);
    }

    private static void ShowDomicilio(string title, Domicilio data)
    {
      if (data.IsAssigned)
        return;

      Utils.ShowTitle($"{title} / DOMICILIO");
      Utils.ShowField("Calle         ", data.Calle);
      Utils.ShowField("NumeroExterior", data.NumeroExterior);
      Utils.ShowField("NumeroInterior", data.NumeroInterior);
      Utils.ShowField("Colonia       ", data.Colonia);
      Utils.ShowField("Localidad     ", data.Localidad);
      Utils.ShowField("Referencia    ", data.Referencia);
      Utils.ShowField("Municipio     ", data.Municipio);
      Utils.ShowField("Estado        ", data.Estado);
      Utils.ShowField("Pais          ", data.Pais);
      Utils.ShowField("CodigoPostal  ", data.CodigoPostal);      
    }

    private static void ShowPropietarios(PropietarioList data)
    {
      for (int i = 0; i < data.Count; i++)
      {
        Utils.ShowTitle($"COMERCIO EXTERIOR / PROPIETARIO - {i + 1}");
        Utils.ShowField("NumeroRegistroTributario", data[i].NumeroRegistroTributario);
        Utils.ShowField("ResidenciaFiscal        ", data[i].ResidenciaFiscal);
      }
    }

    private static void ShowReceptor(Receptor data)
    {
      if (data.IsAssigned)
        return;

      const string Title = "COMERCIO EXTERIOR / RECEPTOR";
      Utils.ShowTitle(Title);
      Utils.ShowField("NumeroRegistroTributario", data.NumeroRegistroTributario);

      ShowDomicilio(Title, data.Domicilio);
    }

    private static void ShowDestinatarios(DestinatarioList data)
    {
      for (int i = 0; i < data.Count; i++)
      {
        string title = $"COMERCIO EXTERIOR / DESTINATARIO - {i + 1}";
        Utils.ShowTitle(title);
        Utils.ShowField("NumeroRegistroTributario", data[i].NumeroRegistroTributario);
        Utils.ShowField("Nombre                  ", data[i].Nombre);

        ShowDomicilio(title, data[i].Domicilio);
      }
    }

    private static void ShowMercancias(MercanciaList data)
    {
      for (int i = 0; i < data.Count; i++)
      {
        string title = $"COMERCIO EXTERIOR / MERCANCIA - {i + 1}";
        Utils.ShowTitle(title);

        Mercancia mercancia = data[i];
        Utils.ShowField("NumeroIdentificacion", mercancia.NumeroIdentificacion);
        Utils.ShowField("FraccionArancelaria ", mercancia.FraccionArancelaria);
        Utils.ShowField("CantidadAduana      ", mercancia.CantidadAduana);
        Utils.ShowField("UnidadAduana        ", mercancia.UnidadAduana);
        Utils.ShowField("ValorUnitarioAduana ", mercancia.ValorUnitarioAduana);
        Utils.ShowField("ValorDolares        ", mercancia.ValorDolares);

        ShowDescripcionesEspecificas(title, mercancia.DescripcionesEspecificas);
      }
    }

    private static void ShowDescripcionesEspecificas(string title, DescripcionEspecificaList data)
    {
      for (int i = 0; i < data.Count; i++)
      {
        Utils.ShowTitle($"{title} / DESCRIPCIONES ESPECIFICAS - {i + 1}");
        Utils.ShowField("Marca      ", data[i].Marca);
        Utils.ShowField("Modelo     ", data[i].Modelo);
        Utils.ShowField("SubModelo  ", data[i].SubModelo);
        Utils.ShowField("NumeroSerie", data[i].NumeroSerie);
      }
    }
  }
}