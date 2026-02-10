using HyperSoft.ElectronicDocumentLibrary.Contabilidad.Balanza;

namespace HyperSoft.Ejemplo.Information
{
  public static class BalanzaComprobacion
  {
    public static string Show(Balanza balanza)
    {
      Utils.ShowTitle("BALANZA");
      Utils.ShowField("Versión              ", balanza.Data.Version);
      Utils.ShowField("RFC                  ", balanza.Data.Rfc);
      Utils.ShowField("Mes                  ", balanza.Data.Mes);
      Utils.ShowField("Año                  ", balanza.Data.Anio);
      Utils.ShowField("Tipo de envío        ", balanza.Data.TipoEnvio);
      Utils.ShowField("Fecha de modificación", balanza.Data.FechaModificacion);
      Utils.ShowField("Sello                ", balanza.Data.Sello);
      Utils.ShowField("No de certificado    ", balanza.Data.NumeroCertificado);

      for (int i = 0; i < balanza.Data.Cuentas.Count; i++)
      {
        Cuenta cuenta = balanza.Data.Cuentas[i];

        Utils.ShowTitle("CUENTA - " + (i + 1));
        Utils.ShowField("Número       ", cuenta.Numero);
        Utils.ShowField("Saldo inicial", cuenta.SaldoInicial);
        Utils.ShowField("Debe         ", cuenta.Debe);
        Utils.ShowField("Haber        ", cuenta.Haber);
        Utils.ShowField("Saldo final  ", cuenta.SaldoFinal);
      }

      Utils.ShowTitle("CADENA ORIGINAL");
      Utils.ShowValue(balanza.FingerPrint);

      return Utils.Finalization();
    }
  }
}