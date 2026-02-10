using HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarCuentas;

namespace HyperSoft.Ejemplo.Information
{
  public static class Auxiliar
  {
    public static string Show(AuxiliarCuentas auxiliarCuentas)
    {
      Utils.ShowTitle("AUXILIAR DE CUENTAS");
      Utils.ShowField("Versión          ", auxiliarCuentas.Data.Version);
      Utils.ShowField("RFC              ", auxiliarCuentas.Data.Rfc);
      Utils.ShowField("Mes              ", auxiliarCuentas.Data.Mes);
      Utils.ShowField("Año              ", auxiliarCuentas.Data.Anio);
      Utils.ShowField("Tipo de solicitud", auxiliarCuentas.Data.TipoSolicitud);
      Utils.ShowField("Número de orden  ", auxiliarCuentas.Data.NumeroOrden);
      Utils.ShowField("Número de tramite", auxiliarCuentas.Data.NumeroTramite);
      Utils.ShowField("Sello            ", auxiliarCuentas.Data.Sello);
      Utils.ShowField("No de certificado", auxiliarCuentas.Data.NumeroCertificado);
      //ShowField("Certificado      ", auxiliarCuentas.Data.Certificado);

      for (int i = 0; i < auxiliarCuentas.Data.Cuentas.Count; i++)
      {
        Cuenta cuenta = auxiliarCuentas.Data.Cuentas[i];

        Utils.ShowTitle("CUENTA - " + (i + 1));
        Utils.ShowField("Número       ", cuenta.Numero);
        Utils.ShowField("Descripción  ", cuenta.Descripcion);
        Utils.ShowField("Saldo inicial", cuenta.SaldoInicial);
        Utils.ShowField("Saldo final  ", cuenta.SaldoFinal);

        for (int j = 0; j < cuenta.Detalles.Count; j++)
        {
          DetalleAuxiliar detalle = cuenta.Detalles[j];

          Utils.ShowTitle("DETALLE - " + (j + 1));
          Utils.ShowField("Fecha   ", detalle.Fecha);
          Utils.ShowField("Número  ", detalle.Numero);
          Utils.ShowField("Concepto", detalle.Concepto);
          Utils.ShowField("Debe    ", detalle.Debe);
          Utils.ShowField("Haber   ", detalle.Haber);
        }
      }

      Utils.ShowTitle("CADENA ORIGINAL");
      Utils.ShowValue(auxiliarCuentas.FingerPrint);

      return Utils.Finalization();
    }
  }
}