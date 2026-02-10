using HyperSoft.Base;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class EmisionPorCuentaDeTerceros
  {
    internal static void Show(int concepto, ObjectBase value)
    {
      HyperSoft.ElectronicDocumentLibrary.Complemento.EmisionPorCuentaDeTerceros.Data data =
        (HyperSoft.ElectronicDocumentLibrary.Complemento.EmisionPorCuentaDeTerceros.Data) value;

      Utils.ShowTitle($"CONCEPTO {concepto} / COMPLEMENTO EMISION POR CUENTA DE TERCEROS");
      Utils.ShowField("Versión", data.Version);
      Utils.ShowField("RFC    ", data.Rfc);
      Utils.ShowField("Nombre ", data.Nombre);

      #region INFORMACION FISCAL TERCERO

      if (data.InformacionFiscalTercero.IsAssigned)
      {
        Utils.ShowTitle($"CONCEPTO {concepto} / EMISION POR CUENTA DE TERCEROS / INFORMACION FISCAL TERCERO");
        Utils.ShowField("Calle          ", data.InformacionFiscalTercero.Calle);
        Utils.ShowField("Número exterior", data.InformacionFiscalTercero.NumeroExterior);
        Utils.ShowField("Número interior", data.InformacionFiscalTercero.NumeroInterior);
        Utils.ShowField("Colonia        ", data.InformacionFiscalTercero.Colonia);
        Utils.ShowField("Localidad      ", data.InformacionFiscalTercero.Localidad);
        Utils.ShowField("Referencia     ", data.InformacionFiscalTercero.Referencia);
        Utils.ShowField("Municipio      ", data.InformacionFiscalTercero.Municipio);
        Utils.ShowField("Estado         ", data.InformacionFiscalTercero.Estado);
        Utils.ShowField("País           ", data.InformacionFiscalTercero.Pais);
        Utils.ShowField("Código postal  ", data.InformacionFiscalTercero.CodigoPostal);

        if (data.InformacionFiscalTercero.InformacionAduanera.IsAssigned)
        {
          Utils.ShowTitle($"CONCEPTO {concepto} / EMISION POR CUENTA DE TERCEROS / INFORMACION FISCAL / INFORMACION ADUANERA");
          Utils.ShowField("Número", data.InformacionFiscalTercero.InformacionAduanera.Numero);
          Utils.ShowField("Fecha ", data.InformacionFiscalTercero.InformacionAduanera.Fecha);
          Utils.ShowField("Aduana", data.InformacionFiscalTercero.InformacionAduanera.Aduana);
        }

        for (int i = 0; i < data.InformacionFiscalTercero.Partes.Count; i++)
        {
          string title = $"CONCEPTO {concepto} / EMISION POR CUENTA DE TERCEROS / INFORMACION FISCAL / PARTE {i + 1}";
          Utils.ShowTitle(title);

          HyperSoft.ElectronicDocumentLibrary.Complemento.EmisionPorCuentaDeTerceros.Partida partida = data.InformacionFiscalTercero.Partes[i];

          Utils.ShowField("Cantidad                ", partida.Cantidad);
          Utils.ShowField("Unidad                  ", partida.Unidad);
          Utils.ShowField("Descripción             ", partida.Descripcion);
          Utils.ShowField("Número de identificación", partida.NumeroIdentificacion);
          Utils.ShowField("Valor unitario          ", partida.ValorUnitario);
          Utils.ShowField("Importe                 ", partida.Importe);

          for (int j = 0; j < partida.InformacionAduanera.Count; j++)
          {
            Utils.ShowTitle($"{title} / INFORMACION ADUANERA {j + 1}");
            Utils.ShowField("Número", partida.InformacionAduanera[i].Numero);
            Utils.ShowField("Fecha ", partida.InformacionAduanera[i].Fecha);
            Utils.ShowField("Aduana", partida.InformacionAduanera[i].Aduana);
          }

          if (data.InformacionFiscalTercero.CuentaPredial.IsAssigned)
          {
            Utils.ShowTitle($"{title} / CUENTA PREDIAL");
            Utils.ShowField("Número", data.InformacionFiscalTercero.CuentaPredial.Numero);
          }
        }
      }

      #endregion

      #region INFORMACION ADUANERA

      if (data.InformacionAduanera.IsAssigned)
      {
        Utils.ShowTitle($"CONCEPTO {concepto} / EMISION POR CUENTA DE TERCEROS / INFORMACION FISCAL / INFORMACION ADUANERA");
        Utils.ShowField("Número", data.InformacionAduanera.Numero);
        Utils.ShowField("Fecha ", data.InformacionAduanera.Fecha);
        Utils.ShowField("Aduana", data.InformacionAduanera.Aduana);
      }

      #endregion

      #region PARTES

      for (int i = 0; i < data.Partes.Count; i++)
      {
        string title = $"CONCEPTO {concepto} / EMISION POR CUENTA DE TERCEROS / PARTE {i + 1}";
        Utils.ShowTitle(title);

        HyperSoft.ElectronicDocumentLibrary.Complemento.EmisionPorCuentaDeTerceros.Partida partida = data.Partes[i];

        Utils.ShowField("Cantidad                ", partida.Cantidad);
        Utils.ShowField("Unidad                  ", partida.Unidad);
        Utils.ShowField("Descripción             ", partida.Descripcion);
        Utils.ShowField("Número de identificación", partida.NumeroIdentificacion);
        Utils.ShowField("Valor unitario          ", partida.ValorUnitario);
        Utils.ShowField("Importe                 ", partida.Importe);

        for (int j = 0; j < partida.InformacionAduanera.Count; j++)
        {
          Utils.ShowTitle($"{title} / INFORMACION ADUANERA {j + 1}");
          Utils.ShowField("Número", partida.InformacionAduanera[j].Numero);
          Utils.ShowField("Fecha ", partida.InformacionAduanera[j].Fecha);
          Utils.ShowField("Aduana", partida.InformacionAduanera[j].Aduana);
        }
      }

      #endregion

      #region CUENTA PREDIAL

      if (data.CuentaPredial.IsAssigned)
      {
        Utils.ShowTitle($"CONCEPTO {concepto} / EMISION POR CUENTA DE TERCEROS / CUENTA PREDIAL");
        Utils.ShowField("Número", data.CuentaPredial.Numero);
      }

      #endregion

      #region IMPUESTOS

      for (int i = 0; i < data.Impuestos.Retenciones.Count; i++)
      {
        Utils.ShowTitle($"CONCEPTO {concepto} / EMISION POR CUENTA DE TERCEROS / IMPUESTOS / RETENCIONES {i + 1}");
        Utils.ShowField("Impuesto", data.Impuestos.Retenciones[i].Tipo);
        Utils.ShowField("Importe ", data.Impuestos.Retenciones[i].Importe);
      }

      for (int i = 0; i < data.Impuestos.Traslados.Count; i++)
      {
        Utils.ShowTitle($"CONCEPTO {concepto} / EMISION POR CUENTA DE TERCEROS / IMPUESTOS / TRASLADOS {i + 1}");
        Utils.ShowField("Impuesto", data.Impuestos.Traslados[i].Tipo);
        Utils.ShowField("Tasa    ", data.Impuestos.Traslados[i].Tasa);
        Utils.ShowField("Importe ", data.Impuestos.Traslados[i].Importe);
      }

      #endregion
    }
  }
}
