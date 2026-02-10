// ReSharper disable RedundantNameQualifier

namespace HyperSoft.Ejemplo.Utilerias
{
  public static class Configuration
  {
    public static void Library()
    {
      // SECCIÓN DE CONFIGURACIÓN GENERAL DE LA LIBRERÍA
      //   HyperSoft.ElectronicDocumentLibrary.Configuration.Config.Cfdi.FixTipoCambio
      //     - Su valor por defecto es TRUE
      //     - El valor recomendado es FALSE
      //     - En caso de usar FALSE, es necesario modificar el atributo tipo de cambio(TipoCambioMx) de acuerdo con lo requiere el SAT cuando la moneda es MXN
      //       TipoCambioMx.Decimals = 0;
      //       TipoCambioMx.Dot = false;

      HyperSoft.ElectronicDocumentLibrary.Configuration.Config.Cfdi.FixTipoCambio = false;
    }
  }
}
