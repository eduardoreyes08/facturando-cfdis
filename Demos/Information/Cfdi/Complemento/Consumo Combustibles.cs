namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class ConsumoCombustibles
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.ConsumoCombustibles.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO CONSUMO COMBUSTIBLES");
      Utils.ShowField("Versión          ", data.Version);
      Utils.ShowField("Tipo de operación", data.TipoOperacion);
      Utils.ShowField("Número de cuenta ", data.NumeroCuenta);
      Utils.ShowField("SubTotal         ", data.SubTotal);
      Utils.ShowField("Total            ", data.Total);

      for (int i = 0; i < data.Conceptos.Count; i++)
      {
        HyperSoft.ElectronicDocumentLibrary.Complemento.ConsumoCombustibles.Concepto concepto = data.Conceptos[i];

        Utils.ShowTitle("CONSUMO COMBUSTIBLES / CONCEPTO - " + (i + 1));
        Utils.ShowField("Identificador         ", concepto.Identificador);
        Utils.ShowField("Fecha                 ", concepto.Fecha);
        Utils.ShowField("RFC                   ", concepto.Rfc);
        Utils.ShowField("Clave de estación     ", concepto.ClaveEstacion);
        Utils.ShowField("Cantidad              ", concepto.Cantidad);
        Utils.ShowField("Nombre del combustible", concepto.NombreCombustible);
        Utils.ShowField("Folio de operación    ", concepto.FolioOperacion);
        Utils.ShowField("Valor unitario        ", concepto.ValorUnitario);
        Utils.ShowField("Importe               ", concepto.Importe);

        for (int j = 0; j < concepto.Determinados.Count; j++)
        {
          Utils.ShowTitle("DETERMINADOS - " + (i + 1) + " - " + (j + 1));
          Utils.ShowField("Importe ", concepto.Determinados[0].Importe);
          Utils.ShowField("Impuesto", concepto.Determinados[0].Impuesto);
          Utils.ShowField("Tasa    ", concepto.Determinados[0].Tasa);
        }
      }
    }
  }
}