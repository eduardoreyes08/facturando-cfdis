using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarCuentas;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.CatalogoCuentas;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.Poliza;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;
using Ionic.Zip;
using Cuenta = HyperSoft.ElectronicDocumentLibrary.Contabilidad.CatalogoCuentas.Cuenta;
// ReSharper disable LocalizableElement

namespace HyperSoft.Ejemplo.ContabilidadElectronica
{
  public partial class MainForm : Form
  {
    #region Business

    #region Constants

    private const string DataDirectory = "..\\..\\..\\..";

    #endregion

    #region Vars

    private TabPage[] pages;
    private string generationDirectory;
    private ElectronicManage manage;

    #endregion

    #region Methods

    /// <summary>
    /// Método que permite generar el archivo del catálogo de cuentas de la contabilidad electrónica
    /// para su versión 1.3 publicada por el SAT en el mes de junio de 2017
    /// </summary>
    private bool CreateCatalogo(out string fileName)
    {
      // Se crea una instancia de un objeto de CatalogoCuentas
      CatalogoCuentas catalogoCuentas = new CatalogoCuentas().Initialization();
      catalogoCuentas.AssignManage(this.manage);

      // Datos del encabezado del catálogo de cuentas **********************************************
      catalogoCuentas.Data.Version.Value = "1.3";
      catalogoCuentas.Data.Rfc.Value = "EKU9003173C9";
      catalogoCuentas.Data.Mes.Value = "01";
      catalogoCuentas.Data.Anio.Value = 2015;
      // Detalle de cada cuenta que integran al catálogo de cuentas 
      // Se crea una instancia de un objeto de cuenta

      Cuenta cuenta = catalogoCuentas.Data.Cuentas.Add();
      // Cuenta No 1 *******************************************************************************
      cuenta.CodigoAgrupador.Value = "102";
      cuenta.Numero.Value = "001";
      cuenta.Descripcion.Value = "BANCOS";
      cuenta.SubCuenta.Value = "001";
      cuenta.Nivel.Value = 1;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 2 *******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "102.01";
      cuenta.Numero.Value = "001002";
      cuenta.Descripcion.Value = "BANCOS";
      cuenta.SubCuenta.Value = "001002";
      cuenta.Nivel.Value = 2;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 3 *******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "102.01";
      cuenta.Numero.Value = "001002001";
      cuenta.Descripcion.Value = "CUENTA DE CHEQUES";
      cuenta.SubCuenta.Value = "001002001";
      cuenta.Nivel.Value = 3;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 4 *******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "102.01";
      cuenta.Numero.Value = "001002001000002";
      cuenta.Descripcion.Value = "CUENTA DE CHEQUES";
      cuenta.SubCuenta.Value = "001002001000002";
      cuenta.Nivel.Value = 4;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 5 *******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "105";
      cuenta.Numero.Value = "001";
      cuenta.Descripcion.Value = "CLIENTES";
      cuenta.SubCuenta.Value = "001";
      cuenta.Nivel.Value = 1;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 6 *******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "105.01";
      cuenta.Numero.Value = "001001";
      cuenta.Descripcion.Value = "CLIENTES";
      cuenta.SubCuenta.Value = "001001";
      cuenta.Nivel.Value = 2;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 7 *******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "105.01";
      cuenta.Numero.Value = "001001001";
      cuenta.Descripcion.Value = "CLIENTES";
      cuenta.SubCuenta.Value = "001001001";
      cuenta.Nivel.Value = 3;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 8 *******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "105.01";
      cuenta.Numero.Value = "001001001001";
      cuenta.Descripcion.Value = "CLIENTES";
      cuenta.SubCuenta.Value = "001001001";
      cuenta.Nivel.Value = 3;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 9 *******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "105.01";
      cuenta.Numero.Value = "001001001000001";
      cuenta.Descripcion.Value = "CLIENTE 1";
      cuenta.SubCuenta.Value = "001001001000001";
      cuenta.Nivel.Value = 4;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 10 ******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "105.01";
      cuenta.Numero.Value = "001001001000002";
      cuenta.Descripcion.Value = "CLIENTE 2";
      cuenta.SubCuenta.Value = "001001001000002";
      cuenta.Nivel.Value = 4;
      cuenta.Naturaleza.Value = "D";

      // Cuenta No 11 ******************************************************************************
      cuenta = catalogoCuentas.Data.Cuentas.Add();
      cuenta.CodigoAgrupador.Value = "105.01";
      cuenta.Numero.Value = "001001001000003";
      cuenta.Descripcion.Value = "CLIENTE 3";
      cuenta.SubCuenta.Value = "001001001000003";
      cuenta.Nivel.Value = 4;
      cuenta.Naturaleza.Value = "D";
      try
      {
        // Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
        string fileNameZip = Path.Combine(this.generationDirectory, catalogoCuentas.FileName);
        fileName = Path.ChangeExtension(fileNameZip, ".xml");

        if (catalogoCuentas.SaveToFile(fileName))
        {
          // Se crea una instancia de un objeto de zip, para llevar a cabo la generación
          // del archivo compactado que contendrá el XML del catálogo de cuentas
          if (this.chkGenerarZip.Checked)
            using (ZipFile zip = new ZipFile())
            {
              zip.AddFile(fileName, string.Empty);
              zip.Save(fileNameZip);
            }
          return true;
        }
        Gui.ShowError(catalogoCuentas.ErrorText);
        return false;
      }
      finally
      {
        Chronometer.Instance.Stop();
      }
    }

    /// <summary>
    /// Método que permite generar el archivo de la balanza de comprobación de la contabilidad electrónica
    /// para su versión 1.3 publicada por el SAT en el mes de junio de 2017
    /// </summary>
    private bool CreateBalanza(out string fileName)
    {
      // Se crea una instancia de un objeto de balanza
      ElectronicDocumentLibrary.Contabilidad.Balanza.Balanza balanza = new ElectronicDocumentLibrary.Contabilidad.Balanza.Balanza().Initialization();
      balanza.AssignManage(this.manage);
      
      // Datos del encabezado de la balanza de comprobación ****************************************
      balanza.Data.Version.Value = "1.3";
      balanza.Data.Rfc.Value = "EKU9003173C9";
      balanza.Data.Mes.Value = "01";
      balanza.Data.Anio.Value = 2015;
      balanza.Data.TipoEnvio.Value = "N";
      balanza.Data.FechaModificacion.Value = DateTime.Now;
      // Detalle de cada cuenta que integran al archivo de la balanza de comprobación
      // Se crea una instancia de un objeto de cuenta
      ElectronicDocumentLibrary.Contabilidad.Balanza.Cuenta cuenta = balanza.Data.Cuentas.Add();
      
      // Cuenta No 1 *******************************************************************************
      cuenta.Numero.Value = "001";
      cuenta.SaldoInicial.Value = 1428.47;
      cuenta.Debe.Value = 267326.62;
      cuenta.Haber.Value = 270787.55;
      cuenta.SaldoFinal.Value = -2032.46;
      
      // Cuenta No 2 *******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001002";
      cuenta.SaldoInicial.Value = 1428.47;
      cuenta.Debe.Value = 267326.62;
      cuenta.Haber.Value = 270787.55;
      cuenta.SaldoFinal.Value = -2032.46;
      
      // Cuenta No 3 *******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001002001";
      cuenta.SaldoInicial.Value = 1428.47;
      cuenta.Debe.Value = 267326.62;
      cuenta.Haber.Value = 270787.55;
      cuenta.SaldoFinal.Value = -2032.46;
      
      // Cuenta No 4 *******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001002001000002";
      cuenta.SaldoInicial.Value = 1428.47;
      cuenta.Debe.Value = 267326.62;
      cuenta.Haber.Value = 270787.55;
      cuenta.SaldoFinal.Value = -2032.46;
      
      // Cuenta No 5 *******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001";
      cuenta.SaldoInicial.Value = 232096.28;
      cuenta.Debe.Value = 145121.80;
      cuenta.Haber.Value = 224326.60;
      cuenta.SaldoFinal.Value = 152891.48;
      
      // Cuenta No 6 *******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001001";
      cuenta.SaldoInicial.Value = 232096.28;
      cuenta.Debe.Value = 145121.80;
      cuenta.Haber.Value = 224326.60;
      cuenta.SaldoFinal.Value = 152891.48;
      
      // Cuenta No 7 *******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001001001";
      cuenta.SaldoInicial.Value = 232096.28;
      cuenta.Debe.Value = 145121.80;
      cuenta.Haber.Value = 224326.60;
      cuenta.SaldoFinal.Value = 152891.48;
      
      // Cuenta No 8 *******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001001001000001";
      cuenta.SaldoInicial.Value = 0.00;
      cuenta.Debe.Value = 27865.52;
      cuenta.Haber.Value = 27865.52;
      cuenta.SaldoFinal.Value = 0.00;
      
      // Cuenta No 9 *******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001001001000002";
      cuenta.SaldoInicial.Value = 23232.48;
      cuenta.Debe.Value = 23232.48;
      cuenta.Haber.Value = 25320.48;
      cuenta.SaldoFinal.Value = 21144.48;
      
      // Cuenta No 10 ******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001001001000003";
      cuenta.SaldoInicial.Value = 88803.80;
      cuenta.Debe.Value = 88803.80;
      cuenta.Haber.Value = 161280.60;
      cuenta.SaldoFinal.Value = 16327.00;
      
      // Cuenta No 11 ******************************************************************************
      cuenta = balanza.Data.Cuentas.Add();
      cuenta.Numero.Value = "001001001000004";
      cuenta.SaldoInicial.Value = 4640.00;
      cuenta.Debe.Value = 3480.00;
      cuenta.Haber.Value = 8120.00;
      cuenta.SaldoFinal.Value = 0.00;
      try
      {
        // Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
        string fileNameZip = Path.Combine(this.generationDirectory, balanza.FileName);
        fileName = Path.ChangeExtension(fileNameZip, ".xml");

        if (balanza.SaveToFile(fileName))
        {
          // Se crea una instancia de un objeto de zip, para llevar a cabo la generación
          // del archivo compactado que contendrá el XML de la balanza de comprobación
          if (this.chkGenerarZip.Checked)
            using (ZipFile zip = new ZipFile())
            {
              zip.AddFile(fileName, string.Empty);
              zip.Save(fileNameZip);
            }
          return true;
        }

        Gui.ShowError(balanza.ErrorText);
        return false;
      }
      finally
      {
        Chronometer.Instance.Stop();
      }
    }

    /// <summary>
    /// Método que permite generar el archivo de pólizas contables de la contabilidad electrónica
    /// para su versión 1.3 publicada por el SAT en el mes de junio de 2017
    /// </summary>
    private bool CreatePoliza(out string fileName)
    {
      // Se crea una instancia de un objeto de polizaContable
      PolizaContable polizaContable = new PolizaContable().Initialization();
      polizaContable.AssignManage(this.manage);
      
      // Datos generales del archivo de las pólizas contables **************************************
      polizaContable.Data.Version.Value = "1.3";
      polizaContable.Data.Rfc.Value = "EKU9003173C9";
      polizaContable.Data.Mes.Value = "01";
      polizaContable.Data.Anio.Value = 2015;
      polizaContable.Data.TipoSolicitud.Value = "DE";
      polizaContable.Data.NumeroOrden.Value = "ABC4567890/23";
      polizaContable.Data.NumeroTramite.Value = "AB123456789012";
      // Encabezado de la póliza que integra el archivo de pólizas contables
      // Se crea una instancia de un objeto poliza
      Poliza poliza = polizaContable.Data.Polizas.Add();
      
      // Póliza No 1 *******************************************************************************
      poliza.Numero.Value = "1";
      poliza.Fecha.Value = DateTime.Now;
      poliza.Concepto.Value = "Póliza de ingresos";
      // Detalle de cada transacción dentro de la póliza No 1
      // Se crea una instancia de un objeto transacción
      Transaccion transaccion = poliza.Transacciones.Add();
      
      // Transacción No 1 **************************************************************************
      transaccion.NumeroCuenta.Value = "00030001";
      transaccion.NombreCuenta.Value = "Ventas";
      transaccion.Concepto.Value = "Venta de mercancía";
      transaccion.Debe.Value = 1000.00;
      transaccion.Haber.Value = 0.00;
      // Detalle de cada comprobante nacional relacionado con la transacción
      // Se crea una instancia de un objeto nacional
      ElectronicDocumentLibrary.Contabilidad.Poliza.ComprobanteNacional nacional = transaccion.ComprobantesNacional.Add();
      
      // Comprobante nacional No 1 *****************************************************************
      nacional.Uuid.Value = "711D0509-8F74-41F2-A0F9-C03884832897";
      nacional.Rfc.Value = "AAA010101AAA";
      nacional.MontoTotal.Value = 200.00;
      nacional.Moneda.Value = "MXN";
      nacional.TipoCambio.Value = 1.00;
      
      // Comprobante nacional No 2 *****************************************************************
      nacional = transaccion.ComprobantesNacional.Add();
      nacional.Uuid.Value = "711D0509-8F74-41F2-A0F9-C03884832890";
      nacional.Rfc.Value = "AAA010101AAA";
      nacional.MontoTotal.Value = 200.00;
      nacional.Moneda.Value = "MXN";
      nacional.TipoCambio.Value = 1.00;
      
      // Detalle de cada comprobante nacional relacionado con la transacción
      // Se crea una instancia de un objeto nacionalOtro
      ElectronicDocumentLibrary.Contabilidad.Poliza.ComprobanteNacionalOtro nacionalOtro = transaccion.ComprobantesNacionalOtro.Add();
      
      // Comprobante nacional otro No 1 ************************************************************
      nacionalOtro.Serie.Value = "F";
      nacionalOtro.Folio.Value = "1";
      nacionalOtro.Rfc.Value = "AAA010101AAA";
      nacionalOtro.MontoTotal.Value = 200.00;
      nacionalOtro.Moneda.Value = "MXN";
      nacionalOtro.TipoCambio.Value = 1.00;
      
      // Comprobante nacional otro No 2 ************************************************************
      nacionalOtro = transaccion.ComprobantesNacionalOtro.Add();
      nacionalOtro.Serie.Value = "F";
      nacionalOtro.Folio.Value = "2";
      nacionalOtro.Rfc.Value = "AAA010101AAA";
      nacionalOtro.MontoTotal.Value = 200.00;
      nacionalOtro.Moneda.Value = "MXN";
      nacionalOtro.TipoCambio.Value = 1.00;
      
      // Detalle de cada comprobante extranjero relacionado con la transacción
      // Se crea una instancia de un objeto extranjero
      ElectronicDocumentLibrary.Contabilidad.Poliza.ComprobanteExtranjero extranjero = transaccion.ComprobantesExtranjero.Add();
      
      // Comprobante extranjero No 1 ************************************************************
      extranjero.NumeroFactura.Value = "1";
      extranjero.TaxId.Value = "1";
      extranjero.MontoTotal.Value = 100.00;
      extranjero.Moneda.Value = "USD";
      extranjero.TipoCambio.Value = 1.00;
      
      // Comprobante extranjero No 2 ************************************************************
      extranjero = transaccion.ComprobantesExtranjero.Add();
      extranjero.NumeroFactura.Value = "2";
      extranjero.TaxId.Value = "2";
      extranjero.MontoTotal.Value = 100.00;
      extranjero.Moneda.Value = "USD";
      extranjero.TipoCambio.Value = 1.00;
      // Detalle de cada cheque soporte del pago dentro de la póliza No 1
      // Se crea una instancia de un objeto cheque

      Cheque cheque = transaccion.Cheques.Add();
      
      // Cheque No 1 *******************************************************************************
      cheque.Numero.Value = "1";
      cheque.BancoEmisorNacional.Value = "021";
      cheque.CuentaOrigen.Value = "1234567890";
      cheque.Fecha.Value = DateTime.Now;
      cheque.Monto.Value = 200.00;
      cheque.Beneficiario.Value = "Empresa de prueba";
      cheque.Rfc.Value = "AAA010101AAA";
      
      // Cheque No 2 *******************************************************************************
      cheque = transaccion.Cheques.Add();
      cheque.Numero.Value = "2";
      cheque.BancoEmisorNacional.Value = "021";
      cheque.CuentaOrigen.Value = "1234567890";
      cheque.Fecha.Value = DateTime.Now;
      cheque.Monto.Value = 200.00;
      cheque.Beneficiario.Value = "Empresa de prueba";
      cheque.Rfc.Value = "AAA010101AAA";
      // Detalle de cada transferencia soporte del pago dentro de la póliza No 1
      // Se crea una instancia de un objeto transferencia

      Transferencia transferencia = transaccion.Transferencias.Add();
      
      // Transferencia No 1 ************************************************************************
      transferencia.CuentaOrigen.Value = "1234567890";
      transferencia.BancoOrigenNacional.Value = "021";
      transferencia.BancoDestinoNacional.Value = "106";
      transferencia.Monto.Value = 200.00;
      transferencia.CuentaDestino.Value = "0987654321";
      transferencia.Fecha.Value = DateTime.Now;
      transferencia.Beneficiario.Value = "Empresa de prueba";
      transferencia.Rfc.Value = "AAA010101AAA";
      
      // Transferencia No 2 ************************************************************************
      transferencia = transaccion.Transferencias.Add();
      transferencia.CuentaOrigen.Value = "1234567890";
      transferencia.BancoOrigenNacional.Value = "021";
      transferencia.BancoDestinoNacional.Value = "106";
      transferencia.Monto.Value = 200.00;
      transferencia.CuentaDestino.Value = "0987654321";
      transferencia.Fecha.Value = DateTime.Now;
      transferencia.Beneficiario.Value = "Empresa de prueba";
      transferencia.Rfc.Value = "AAA010101AAA";
      // Detalle de cada pago distinto de cheque y transferencia soporte del pago dentro de la póliza No 1
      // Se crea una instancia de un objeto otroMetodoPago

      OtroMetodoPago otroMetodoPago = transaccion.OtrosMetodosPago.Add();
      
      // Método de pago No 1 ***********************************************************************
      otroMetodoPago.MetodoPago.Value = "01";
      otroMetodoPago.Fecha.Value = DateTime.Now;
      otroMetodoPago.Beneficiario.Value = "Empresa de prueba";
      otroMetodoPago.Rfc.Value = "AAA010101AAA";
      otroMetodoPago.Monto.Value = 100.00;
      
      // Método de pago No 2 ***********************************************************************
      otroMetodoPago = transaccion.OtrosMetodosPago.Add();
      otroMetodoPago.MetodoPago.Value = "01";
      otroMetodoPago.Fecha.Value = DateTime.Now;
      otroMetodoPago.Beneficiario.Value = "Empresa de prueba";
      otroMetodoPago.Rfc.Value = "AAA010101AAA";
      otroMetodoPago.Monto.Value = 100.00;
      
      // Encabezado de la póliza que integra el archivo de pólizas contables
      // Se crea una instancia de un objeto poliza
      // Póliza No 2 *******************************************************************************
      poliza = polizaContable.Data.Polizas.Add();
      poliza.Numero.Value = "2";
      poliza.Fecha.Value = DateTime.Now;
      poliza.Concepto.Value = "Póliza de ingresos";
      // Detalle de cada transacción dentro de la póliza No 2
      // Se crea una instancia de un objeto transacción
      transaccion = poliza.Transacciones.Add();
      // Transacción No 1 **************************************************************************
      transaccion.NumeroCuenta.Value = "00030001";
      transaccion.NombreCuenta.Value = "Ventas";
      transaccion.Concepto.Value = "Venta de mercancía";
      transaccion.Debe.Value = 1000.00;
      transaccion.Haber.Value = 0.00;
      // Detalle de cada comprobante nacional relacionado con la transacción
      // Se crea una instancia de un objeto nacional
      nacional = transaccion.ComprobantesNacional.Add();
      // Comprobante nacional No 1 *****************************************************************
      nacional.Uuid.Value = "711D0509-8F74-41F2-A0F9-C03884832897";
      nacional.Rfc.Value = "AAA010101AAA";
      nacional.MontoTotal.Value = 200.00;
      nacional.Moneda.Value = "MXN";
      nacional.TipoCambio.Value = 1.00;
      // Comprobante nacional No 2 *****************************************************************
      nacional = transaccion.ComprobantesNacional.Add();
      nacional.Uuid.Value = "711D0509-8F74-41F2-A0F9-C03884832890";
      nacional.Rfc.Value = "AAA010101AAA";
      nacional.MontoTotal.Value = 200.00;
      nacional.Moneda.Value = "MXN";
      nacional.TipoCambio.Value = 1.00;
      // Detalle de cada comprobante nacional relacionado con la transacción
      // Se crea una instancia de un objeto nacionalOtro
      nacionalOtro = transaccion.ComprobantesNacionalOtro.Add();
      // Comprobante nacional otro No 1 ************************************************************
      nacionalOtro.Serie.Value = "F";
      nacionalOtro.Folio.Value = "1";
      nacionalOtro.Rfc.Value = "AAA010101AAA";
      nacionalOtro.MontoTotal.Value = 200.00;
      nacionalOtro.Moneda.Value = "MXN";
      nacionalOtro.TipoCambio.Value = 1.00;
      // Comprobante nacional otro No 2 ************************************************************
      nacionalOtro = transaccion.ComprobantesNacionalOtro.Add();
      nacionalOtro.Serie.Value = "F";
      nacionalOtro.Folio.Value = "2";
      nacionalOtro.Rfc.Value = "AAA010101AAA";
      nacionalOtro.MontoTotal.Value = 200.00;
      nacionalOtro.Moneda.Value = "MXN";
      nacionalOtro.TipoCambio.Value = 1.00;
      // Detalle de cada comprobante extranjero relacionado con la transacción
      // Se crea una instancia de un objeto extranjero
      extranjero = transaccion.ComprobantesExtranjero.Add();
      // Comprobante extranjero No 1 ************************************************************
      extranjero.NumeroFactura.Value = "1";
      extranjero.TaxId.Value = "1";
      extranjero.MontoTotal.Value = 100.00;
      extranjero.Moneda.Value = "USD";
      extranjero.TipoCambio.Value = 1.00;
      // Comprobante extranjero No 2 ************************************************************
      extranjero = transaccion.ComprobantesExtranjero.Add();
      extranjero.NumeroFactura.Value = "2";
      extranjero.TaxId.Value = "2";
      extranjero.MontoTotal.Value = 100.00;
      extranjero.Moneda.Value = "USD";
      extranjero.TipoCambio.Value = 1.00;

      // Detalle de cada cheque soporte del pago dentro de la póliza No 2
      // Se crea una instancia de un objeto cheque
      cheque = transaccion.Cheques.Add();
      // Cheque No 1 *******************************************************************************
      cheque.Numero.Value = "1";
      cheque.BancoEmisorNacional.Value = "021";
      cheque.CuentaOrigen.Value = "1234567890";
      cheque.Fecha.Value = DateTime.Now;
      cheque.Monto.Value = 200.00;
      cheque.Beneficiario.Value = "Empresa de prueba";
      cheque.Rfc.Value = "AAA010101AAA";
      // Cheque No 2 *******************************************************************************
      cheque = transaccion.Cheques.Add();
      cheque.Numero.Value = "2";
      cheque.BancoEmisorNacional.Value = "021";
      cheque.CuentaOrigen.Value = "1234567890";
      cheque.Fecha.Value = DateTime.Now;
      cheque.Monto.Value = 200.00;
      cheque.Beneficiario.Value = "Empresa de prueba";
      cheque.Rfc.Value = "AAA010101AAA";
      // Detalle de cada transferencia soporte del pago dentro de la póliza No 2
      // Se crea una instancia de un objeto transferencia
      transferencia = transaccion.Transferencias.Add();
      // Transferencia No 1 ************************************************************************
      transferencia.CuentaOrigen.Value = "1234567890";
      transferencia.BancoOrigenNacional.Value = "021";
      transferencia.BancoDestinoNacional.Value = "106";
      transferencia.Monto.Value = 200.00;
      transferencia.CuentaDestino.Value = "0987654321";
      transferencia.Fecha.Value = DateTime.Now;
      transferencia.Beneficiario.Value = "Empresa de prueba";
      transferencia.Rfc.Value = "AAA010101AAA";
      // Transferencia No 2 ************************************************************************
      transferencia = transaccion.Transferencias.Add();
      transferencia.CuentaOrigen.Value = "1234567890";
      transferencia.BancoOrigenNacional.Value = "021";
      transferencia.BancoDestinoNacional.Value = "106";
      transferencia.Monto.Value = 200.00;
      transferencia.CuentaDestino.Value = "0987654321";
      transferencia.Fecha.Value = DateTime.Now;
      transferencia.Beneficiario.Value = "Empresa de prueba";
      transferencia.Rfc.Value = "AAA010101AAA";
      // Detalle de cada pago distinto de cheque y transferencia soporte del pago dentro de la póliza No 2
      // Se crea una instancia de un objeto otroMetodoPago
      otroMetodoPago = transaccion.OtrosMetodosPago.Add();
      // Método de pago No 1 ***********************************************************************
      otroMetodoPago.MetodoPago.Value = "01";
      otroMetodoPago.Fecha.Value = DateTime.Now;
      otroMetodoPago.Beneficiario.Value = "Empresa de prueba";
      otroMetodoPago.Rfc.Value = "AAA010101AAA";
      otroMetodoPago.Monto.Value = 100.00;
      // Método de pago No 2 ***********************************************************************
      otroMetodoPago = transaccion.OtrosMetodosPago.Add();
      otroMetodoPago.MetodoPago.Value = "01";
      otroMetodoPago.Fecha.Value = DateTime.Now;
      otroMetodoPago.Beneficiario.Value = "Empresa de prueba";
      otroMetodoPago.Rfc.Value = "AAA010101AAA";
      otroMetodoPago.Monto.Value = 100.00;
      try
      {
        // Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
        string fileNameZip = Path.Combine(this.generationDirectory, polizaContable.FileName);
        fileName = Path.ChangeExtension(fileNameZip, ".xml");
        if (polizaContable.SaveToFile(fileName))
        {
          // Se crea una instancia de un objeto de zip, para llevar a cabo la generación
          // del archivo compactado que contendrá el XML de las pólizas contables
          if (this.chkGenerarZip.Checked)
            using (ZipFile zip = new ZipFile())
            {
              zip.AddFile(fileName, string.Empty);
              zip.Save(fileNameZip);
            }
          return true;
        }
        Gui.ShowError(polizaContable.ErrorText);
        return false;
      }
      finally
      {
        Chronometer.Instance.Stop();
      }
    }

    /// <summary>
    /// Método que permite generar el archivo auxiliar de folios de la contabilidad electrónica
    /// para su versión 1.3 publicada por el SAT en el mes de junio de 2017
    /// </summary>
    private bool CreateAuxiliarFolios(out string fileName)
    {
      // Se crea una instancia de un objeto de auxiliarFolios
      AuxiliarFolios auxiliarFolios = new AuxiliarFolios().Initialization();
      auxiliarFolios.AssignManage(this.manage);
      // Datos del encabezado del auxiliar de folios
      auxiliarFolios.Data.Version.Value = "1.3";
      auxiliarFolios.Data.Rfc.Value = "EKU9003173C9";
      auxiliarFolios.Data.Mes.Value = "01";
      auxiliarFolios.Data.Anio.Value = 2015;
      auxiliarFolios.Data.TipoSolicitud.Value = "AF";
      auxiliarFolios.Data.NumeroOrden.Value = "AAA0000000/00";
      auxiliarFolios.Data.NumeroTramite.Value = "AB123456789012";
      // Detalle de folios del auxiliar de folios
      // Se crea una instancia de un objeto detalle
      Detalle detalle = auxiliarFolios.Data.Detalles.Add();
      detalle.Numero.Value = "001";
      detalle.Fecha.Value = DateTime.Now;
      // Detalle de cada comprobante nacional
      // Se crea una instancia de un objeto comprobanteNacional
      ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios.ComprobanteNacional comprobantesNacional = detalle.ComprobantesNacional.Add();
      // Comprobante nacional No. 1 ****************************************************************
      comprobantesNacional.Uuid.Value = "5A76AF2C-F415-43D7-945A-13C6AEF6A072";
      comprobantesNacional.MontoTotal.Value = 1000;
      comprobantesNacional.Rfc.Value = "AAA010101AAA";
      comprobantesNacional.MetodoPago.Value = "01";
      comprobantesNacional.Moneda.Value = "MXN";
      comprobantesNacional.TipoCambio.Value = 1;
      // Detalle de cada comprobante nacional otro distinto de CFDI
      // Se crea una instancia de un objeto comprobanteNacionalOtro
      ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios.ComprobanteNacionalOtro comprobantesNacionalOtro = detalle.ComprobantesNacionalOtro.Add();
      // Comprobante nacional otro No. 1 ***********************************************************
      comprobantesNacionalOtro.Serie.Value = "A";
      comprobantesNacionalOtro.Folio.Value = "123456";
      comprobantesNacionalOtro.MontoTotal.Value = 1001;
      comprobantesNacionalOtro.Rfc.Value = "AAA010101AA1";
      comprobantesNacionalOtro.MetodoPago.Value = "02";
      comprobantesNacionalOtro.Moneda.Value = "MXN";
      comprobantesNacionalOtro.TipoCambio.Value = 1;
      // Detalle de cada comprobante extranjero
      // Se crea una instancia de un objeto comprobanteExtranjero
      ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios.ComprobanteExtranjero comprobanteExtranjero = detalle.ComprobantesExtranjero.Add();
      // Comprobante extranjero No. 1 **************************************************************
      comprobanteExtranjero.NumeroFactura.Value = "123456";
      comprobanteExtranjero.TaxId.Value = "123";
      comprobanteExtranjero.MontoTotal.Value = 1002;
      comprobanteExtranjero.MetodoPago.Value = "03";
      comprobanteExtranjero.Moneda.Value = "MXN";
      comprobanteExtranjero.TipoCambio.Value = 1;
      // Detalle de folios del auxiliar de folios
      // Se crea una instancia de un objeto detalle
      detalle = auxiliarFolios.Data.Detalles.Add();
      detalle.Numero.Value = "002";
      detalle.Fecha.Value = DateTime.Now;
      // Detalle de cada comprobante nacional
      // Se crea una instancia de un objeto comprobanteNacional
      comprobantesNacional = detalle.ComprobantesNacional.Add();
      // Comprobante nacional No. 1 ****************************************************************
      comprobantesNacional.Uuid.Value = "5A76AF2C-F415-43D7-945A-13C6AEF6A072";
      comprobantesNacional.MontoTotal.Value = 1000;
      comprobantesNacional.Rfc.Value = "AAA010101AAA";
      comprobantesNacional.MetodoPago.Value = "01";
      comprobantesNacional.Moneda.Value = "MXN";
      comprobantesNacional.TipoCambio.Value = 1;
      // Detalle de cada comprobante nacional otro distinto de CFDI
      // Se crea una instancia de un objeto comprobanteNacionalOtro
      comprobantesNacionalOtro = detalle.ComprobantesNacionalOtro.Add();
      // Comprobante nacional otro No. 1 ***********************************************************
      comprobantesNacionalOtro.Serie.Value = "A";
      comprobantesNacionalOtro.Folio.Value = "123456";
      comprobantesNacionalOtro.MontoTotal.Value = 1001;
      comprobantesNacionalOtro.Rfc.Value = "AAA010101AA1";
      comprobantesNacionalOtro.MetodoPago.Value = "02";
      comprobantesNacionalOtro.Moneda.Value = "MXN";
      comprobantesNacionalOtro.TipoCambio.Value = 1;
      // Detalle de cada comprobante extranjero
      // Se crea una instancia de un objeto comprobanteExtranjero
      comprobanteExtranjero = detalle.ComprobantesExtranjero.Add();
      // Comprobante extranjero No. 1 **************************************************************
      comprobanteExtranjero.NumeroFactura.Value = "123456";
      comprobanteExtranjero.TaxId.Value = "123";
      comprobanteExtranjero.MontoTotal.Value = 1002;
      comprobanteExtranjero.MetodoPago.Value = "03";
      comprobanteExtranjero.Moneda.Value = "MXN";
      comprobanteExtranjero.TipoCambio.Value = 1;
      try
      {
        // Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
        string fileNameZip = Path.Combine(this.generationDirectory, auxiliarFolios.FileName);
        fileName = Path.ChangeExtension(fileNameZip, ".xml");
        if (auxiliarFolios.SaveToFile(fileName))
        {
          // Se crea una instancia de un objeto de zip, para llevar a cabo la generación
          // del archivo compactado que contendrá el XML del auxiliar de folios
          if (this.chkGenerarZip.Checked)
            using (ZipFile zip = new ZipFile())
            {
              zip.AddFile(fileName, string.Empty);
              zip.Save(fileNameZip);
            }
          return true;
        }
        Gui.ShowError(auxiliarFolios.ErrorText);
        return false;
      }
      finally
      {
        Chronometer.Instance.Stop();
      }
    }

    /// <summary>
    /// Método que permite generar el archivo auxiliar de cuentas de la contabilidad electrónica
    /// para su versión 1.3 publicada por el SAT en el mes de junio de 2017
    /// </summary>
    private bool CreateAuxiliarCuentas(out string fileName)
    {
      // Se crea una instancia de un objeto de auxiliarCuenta
      AuxiliarCuentas auxiliarCuenta = new AuxiliarCuentas().Initialization();
      auxiliarCuenta.AssignManage(this.manage);
      // Datos del encabezado del auxiliar de cuentas
      auxiliarCuenta.Data.Version.Value = "1.3";
      auxiliarCuenta.Data.Rfc.Value = "EKU9003173C9";
      auxiliarCuenta.Data.Mes.Value = "01";
      auxiliarCuenta.Data.Anio.Value = 2015;
      auxiliarCuenta.Data.TipoSolicitud.Value = "AF";
      auxiliarCuenta.Data.NumeroOrden.Value = "AAA0000000/00";
      auxiliarCuenta.Data.NumeroTramite.Value = "AB123456789012";
      // Movimientos del periodo del auxiliar de cuentas
      // Se crea una instancia de un objeto cuenta
      ElectronicDocumentLibrary.Contabilidad.AuxiliarCuentas.Cuenta cuenta = auxiliarCuenta.Data.Cuentas.Add();
      cuenta.Numero.Value = "001";
      cuenta.Descripcion.Value = "Cuenta de compras";
      cuenta.SaldoInicial.Value = 700.00;
      cuenta.SaldoFinal.Value = 500.00;
      // Detalle de cada cuenta
      // Se crea una instancia de un objeto detalle
      DetalleAuxiliar detalle = cuenta.Detalles.Add();
      // Detalle de cuenta No. 1 *******************************************************************
      detalle.Fecha.Value = DateTime.Now;
      detalle.Numero.Value = "001001";
      detalle.Concepto.Value = "Compras";
      detalle.Debe.Value = 700.00;
      detalle.Haber.Value = 200.00;
      // Detalle de cuenta No. 2 *******************************************************************
      detalle = cuenta.Detalles.Add();
      detalle.Fecha.Value = DateTime.Now;
      detalle.Numero.Value = "001001";
      detalle.Concepto.Value = "Compras";
      detalle.Debe.Value = 700.00;
      detalle.Haber.Value = 200.00;
      // Movimientos del periodo del auxiliar de cuentas
      // Se crea una instancia de un objeto cuenta
      cuenta = auxiliarCuenta.Data.Cuentas.Add();
      cuenta.Numero.Value = "002";
      cuenta.Descripcion.Value = "Cuenta de compras";
      cuenta.SaldoInicial.Value = 700.00;
      cuenta.SaldoFinal.Value = 500.00;
      // Detalle de cada cuenta
      // Se crea una instancia de un objeto detalle
      detalle = cuenta.Detalles.Add();
      // Detalle de cuenta No. 1 *******************************************************************
      detalle.Fecha.Value = DateTime.Now;
      detalle.Numero.Value = "002001";
      detalle.Concepto.Value = "Compras";
      detalle.Debe.Value = 700.00;
      detalle.Haber.Value = 200.00;
      // Detalle de cuenta No. 2 *******************************************************************
      detalle = cuenta.Detalles.Add();
      detalle.Fecha.Value = DateTime.Now;
      detalle.Numero.Value = "002001";
      detalle.Concepto.Value = "Compras";
      detalle.Debe.Value = 700.00;
      detalle.Haber.Value = 200.00;
      try
      {
        // Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
        string fileNameZip = Path.Combine(this.generationDirectory, auxiliarCuenta.FileName);
        fileName = Path.ChangeExtension(fileNameZip, ".xml");
        if (auxiliarCuenta.SaveToFile(fileName))
        {
          // Se crea una instancia de un objeto de zip, para llevar a cabo la generación
          // del archivo compactado que contendrá el XML del auxiliar de cuentas
          if (this.chkGenerarZip.Checked)
            using (ZipFile zip = new ZipFile())
            {
              zip.AddFile(fileName, string.Empty);
              zip.Save(fileNameZip);
            }
          return true;
        }
        Gui.ShowError(auxiliarCuenta.ErrorText);
        return false;
      }
      finally
      {
        Chronometer.Instance.Stop();
      }
    }

    /// <summary>
    /// Método que muestra como crear los objetos a usar en este ejemplos
    /// </summary>
    private void CreateObjects()
    {
      // Se configuran algunas opciones de la librería
      Configuration.Library();

      this.manage = new ElectronicManage().Initialization();

      // *** ELIMINAR ESTA LÍNEA EN EL AMBIENTE DE PRODUCCION *** 
      this.manage.CertificateAuthorityList.UseForTest();

      string cerFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.cer");
      string keyFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.key");
      string password = "12345678a";
      ElectronicCertificate certificate = new ElectronicCertificate().Load(cerFile, keyFile, password);

      // Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
      // y administrar TODOS los recursos que serán usados en el proceso
      this.manage.Save.AssignCertificate(certificate);

      // Directorio donde van a ser almacenado los XML generados
      this.generationDirectory = Utils.CreateDirectory();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      Gui.MessageBoxCaption = "Contabilidad electrónica";

      this.pages = new[]{
        this.tshCatalogo, this.tshBalanza, this.tshPoliza, this.tshAuxiliarFolios,
        this.tshAuxiliarCuentas, this.tshSelloDigital };

      // -- Código para uso interno de este ejemplo
      this.pgcInformacion.SuspendLayout();
      while (this.pgcInformacion.TabPages.Count > 0)
      {
        this.pgcInformacion.TabPages.RemoveAt(0);
      }
      this.pgcInformacion.ResumeLayout();

      this.cmbOperacion.SelectedIndex = 0;
      
      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(this.btnTimbrado, this.btnHelp, this.btnAbout, this.btnClose);
      
    }

    #endregion

    #region Events

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnExecute_Click(object sender, EventArgs e)
    {
      // = Configuramos la interfaz del ejemplo ===========================
      this.lblTime.Text = string.Empty;
      Application.DoEvents();
      Chronometer.Instance.StartWithCursor();
      //===================================================================

      string fileName = string.Empty;
      bool generatedfile = false;

      try
      {
        switch (this.cmbOperacion.SelectedIndex)
        {
          // Catálogo
          case 0:
            generatedfile = this.CreateCatalogo(out fileName);              
            break;

          // Balanza
          case 1:
            generatedfile = this.CreateBalanza(out fileName);
            break;

          // Póliza
          case 2:
            generatedfile = this.CreatePoliza(out fileName);
            break;

          // Auxiliar de folios
          case 3:
            generatedfile = this.CreateAuxiliarFolios(out fileName);
            break;

          // Auxiliar de cuentas
          case 4:
            generatedfile = this.CreateAuxiliarCuentas(out fileName);
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }
      }
      finally
      {
        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";
        System.Media.SystemSounds.Asterisk.Play();

        if (generatedfile && Gui.ShowQuestion(string.Format("El archivo fue generado con éxito.{0}{0}¿Desea visualizarlo ?", Environment.NewLine)))
          Process.Start(Path.GetFullPath(fileName));
      }
    }
    
    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.pgcInformacion.SuspendLayout();
      try
      {
        if (this.pgcInformacion.TabPages.Count > 0)
          this.pgcInformacion.TabPages.RemoveAt(0);

        this.pgcInformacion.TabPages.Add(this.pages[this.cmbOperacion.SelectedIndex]);
      }
      finally
      {
        this.pgcInformacion.ResumeLayout();
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void After_Show(object sender, EventArgs e)
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      IntegrationForm.ShowForm();

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.TimerLicenciaEnabled();
    }

    #endregion

    #endregion

    #region Factory

    public MainForm()
    {
      this.InitializeComponent();

      // -- Código para uso interno de este ejemplo
      License.CargarLicencia();

      // -- Código para uso interno de este ejemplo
      this.ConfigurateControls();

      // -- Muestra como crear los objetos requeridos para este ejemplos
      this.CreateObjects();

      // -- Código para uso interno de este ejemplo
      this.Shown += this.After_Show;
    }

    #endregion
  }
}