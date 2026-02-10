using HyperSoft.ElectronicDocumentLibrary.Contabilidad.CatalogoCuentas;

namespace HyperSoft.Ejemplo.Information
{
  public static class Catalogo
  {
    public static string Show(CatalogoCuentas catalogoCuentas)
    {
      Utils.ShowTitle("CATALOGO");
      Utils.ShowField("Versión          ", catalogoCuentas.Data.Version);
      Utils.ShowField("RFC              ", catalogoCuentas.Data.Rfc);
      Utils.ShowField("Mes              ", catalogoCuentas.Data.Mes);
      Utils.ShowField("Año              ", catalogoCuentas.Data.Anio);
      Utils.ShowField("Sello            ", catalogoCuentas.Data.Sello);
      Utils.ShowField("No de certificado", catalogoCuentas.Data.NumeroCertificado);
      //ShowField("Certificado                ", catalogoCuentas.Data.Certificado);

      for (int i = 0; i < catalogoCuentas.Data.Cuentas.Count; i++)
      {
        Cuenta cuenta = catalogoCuentas.Data.Cuentas[i];

        Utils.ShowTitle("CUENTA - " + (i + 1));
        Utils.ShowField("Código agrupador", cuenta.CodigoAgrupador);
        Utils.ShowField("Número          ", cuenta.Numero);
        Utils.ShowField("Descripción     ", cuenta.Descripcion);
        Utils.ShowField("SubCuenta       ", cuenta.SubCuenta);
        Utils.ShowField("Nivel           ", cuenta.Nivel);
        Utils.ShowField("Naturaleza      ", cuenta.Naturaleza);
      }

      Utils.ShowTitle("CADENA ORIGINAL");
      Utils.ShowValue(catalogoCuentas.FingerPrint);

      return Utils.Finalization();
    }
  }
}