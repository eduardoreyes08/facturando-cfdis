namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class ValesDespensa
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.ValesDespensa.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO VALES DE DESPENSA");
      Utils.ShowField("Versión          ", data.Version);
      Utils.ShowField("Tipo operación   ", data.TipoOperacion);
      Utils.ShowField("Registro patronal", data.RegistroPatronal);
      Utils.ShowField("Número de cuenta ", data.NumeroCuenta);
      Utils.ShowField("Total            ", data.Total);

      for (int i = 0; i < data.Conceptos.Count; i++)
      {
        Utils.ShowTitle("VALES DE DESPENSA / CONCEPTO - " + (i + 1));
        Utils.ShowField("Identificador   ", data.Conceptos[i].Identificador);
        Utils.ShowField("Fecha           ", data.Conceptos[i].Fecha);
        Utils.ShowField("RFC             ", data.Conceptos[i].Rfc);
        Utils.ShowField("CURP            ", data.Conceptos[i].Curp);
        Utils.ShowField("Nombre          ", data.Conceptos[i].Nombre);
        Utils.ShowField("Seguridad social", data.Conceptos[i].NumeroSeguridadSocial);
        Utils.ShowField("Importe         ", data.Conceptos[i].Importe);
      }
    }
  }
}