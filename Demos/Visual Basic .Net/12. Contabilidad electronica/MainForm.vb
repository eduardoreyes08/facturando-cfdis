Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.CatalogoCuentas
Imports System.IO
Imports System.Media
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarCuentas
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.Balanza
Imports HyperSoft.Shared
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.Poliza
Imports Ionic.Zip

Public Class MainForm

#Region "Constants"
  Private Const DataDirectory As String = "..\..\..\.."
#End Region

#Region "Vars"

  Private _pages As TabPage()

  Private _generationDirectory As String
  Private _manage As ElectronicManage

#End Region

#Region "Methods"

  ''' <summary>
  ''' Método que permite generar el archivo del catálogo de cuentas de la contabilidad electrónica
  ''' para su versión 1.3 publicada por el SAT en el mes de junio de 2017
  ''' </summary>
  Private Function CreateCatalogo(ByRef fileName As String) As Boolean
    ' Se crea una instancia de un objeto de CatalogoCuentas
    Dim catalogoCuentas As CatalogoCuentas = New CatalogoCuentas().Initialization()
    catalogoCuentas.AssignManage(Me._manage)

    ' Datos del encabezado del catálogo de cuentas **********************************************
    catalogoCuentas.Data.Version.Value = "1.3"
    catalogoCuentas.Data.Rfc.Value = "EKU9003173C9"
    catalogoCuentas.Data.Mes.Value = "01"
    catalogoCuentas.Data.Anio.Value = 2015
    ' Detalle de cada cuenta que integran al catálogo de cuentas 
    ' Se crea una instancia de un objeto de cuenta

    Dim cuenta As ElectronicDocumentLibrary.Contabilidad.CatalogoCuentas.Cuenta = catalogoCuentas.Data.Cuentas.Add()
    ' Cuenta No 1 *******************************************************************************
    cuenta.CodigoAgrupador.Value = "102"
    cuenta.Numero.Value = "001"
    cuenta.Descripcion.Value = "BANCOS"
    cuenta.SubCuenta.Value = "001"
    cuenta.Nivel.Value = 1
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 2 *******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "102.01"
    cuenta.Numero.Value = "001002"
    cuenta.Descripcion.Value = "BANCOS"
    cuenta.SubCuenta.Value = "001002"
    cuenta.Nivel.Value = 2
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 3 *******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "102.01"
    cuenta.Numero.Value = "001002001"
    cuenta.Descripcion.Value = "CUENTA DE CHEQUES"
    cuenta.SubCuenta.Value = "001002001"
    cuenta.Nivel.Value = 3
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 4 *******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "102.01"
    cuenta.Numero.Value = "001002001000002"
    cuenta.Descripcion.Value = "CUENTA DE CHEQUES"
    cuenta.SubCuenta.Value = "001002001000002"
    cuenta.Nivel.Value = 4
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 5 *******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "105"
    cuenta.Numero.Value = "001"
    cuenta.Descripcion.Value = "CLIENTES"
    cuenta.SubCuenta.Value = "001"
    cuenta.Nivel.Value = 1
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 6 *******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "105.01"
    cuenta.Numero.Value = "001001"
    cuenta.Descripcion.Value = "CLIENTES"
    cuenta.SubCuenta.Value = "001001"
    cuenta.Nivel.Value = 2
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 7 *******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "105.01"
    cuenta.Numero.Value = "001001001"
    cuenta.Descripcion.Value = "CLIENTES"
    cuenta.SubCuenta.Value = "001001001"
    cuenta.Nivel.Value = 3
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 8 *******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "105.01"
    cuenta.Numero.Value = "001001001001"
    cuenta.Descripcion.Value = "CLIENTES"
    cuenta.SubCuenta.Value = "001001001"
    cuenta.Nivel.Value = 3
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 9 *******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "105.01"
    cuenta.Numero.Value = "001001001000001"
    cuenta.Descripcion.Value = "CLIENTE 1"
    cuenta.SubCuenta.Value = "001001001000001"
    cuenta.Nivel.Value = 4
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 10 ******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "105.01"
    cuenta.Numero.Value = "001001001000002"
    cuenta.Descripcion.Value = "CLIENTE 2"
    cuenta.SubCuenta.Value = "001001001000002"
    cuenta.Nivel.Value = 4
    cuenta.Naturaleza.Value = "D"

    ' Cuenta No 11 ******************************************************************************
    cuenta = catalogoCuentas.Data.Cuentas.Add()
    cuenta.CodigoAgrupador.Value = "105.01"
    cuenta.Numero.Value = "001001001000003"
    cuenta.Descripcion.Value = "CLIENTE 3"
    cuenta.SubCuenta.Value = "001001001000003"
    cuenta.Nivel.Value = 4
    cuenta.Naturaleza.Value = "D"
    Try
      ' Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
      Dim fileNameZip As String = Path.Combine(Me._generationDirectory, catalogoCuentas.FileName)
      fileName = Path.ChangeExtension(fileNameZip, ".xml")

      If catalogoCuentas.SaveToFile(fileName) Then
        ' Se crea una instancia de un objeto de zip, para llevar a cabo la generación
        ' del archivo compactado que contendrá el XML del catálogo de cuentas
        If Me.chkGenerarZip.Checked Then
          Using zip As New ZipFile()
            zip.AddFile(fileName, String.Empty)
            zip.Save(fileNameZip)
          End Using
        End If
        Return True
      End If
      Gui.ShowError(catalogoCuentas.ErrorText)
      Return False
    Finally
      Chronometer.Instance.[Stop]()
    End Try
  End Function

  ''' <summary>
  ''' Método que permite generar el archivo de la balanza de comprobación de la contabilidad electrónica
  ''' para su versión 1.3 publicada por el SAT en el mes de junio de 2017
  ''' </summary>
  Private Function CreateBalanza(ByRef fileName As String) As Boolean
    ' Se crea una instancia de un objeto de balanza
    Dim balanza As Balanza = New Balanza().Initialization()
    balanza.AssignManage(Me._manage)

    ' Datos del encabezado de la balanza de comprobación ****************************************
    balanza.Data.Version.Value = "1.3"
    balanza.Data.Rfc.Value = "EKU9003173C9"
    balanza.Data.Mes.Value = "01"
    balanza.Data.Anio.Value = 2015
    balanza.Data.TipoEnvio.Value = "N"
    balanza.Data.FechaModificacion.Value = DateTime.Now
    ' Detalle de cada cuenta que integran al archivo de la balanza de comprobación
    ' Se crea una instancia de un objeto de cuenta
    Dim cuenta As ElectronicDocumentLibrary.Contabilidad.Balanza.Cuenta = balanza.Data.Cuentas.Add()

    ' Cuenta No 1 *******************************************************************************
    cuenta.Numero.Value = "001"
    cuenta.SaldoInicial.Value = 1428.47
    cuenta.Debe.Value = 267326.62
    cuenta.Haber.Value = 270787.55
    cuenta.SaldoFinal.Value = -2032.46

    ' Cuenta No 2 *******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001002"
    cuenta.SaldoInicial.Value = 1428.47
    cuenta.Debe.Value = 267326.62
    cuenta.Haber.Value = 270787.55
    cuenta.SaldoFinal.Value = -2032.46

    ' Cuenta No 3 *******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001002001"
    cuenta.SaldoInicial.Value = 1428.47
    cuenta.Debe.Value = 267326.62
    cuenta.Haber.Value = 270787.55
    cuenta.SaldoFinal.Value = -2032.46

    ' Cuenta No 4 *******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001002001000002"
    cuenta.SaldoInicial.Value = 1428.47
    cuenta.Debe.Value = 267326.62
    cuenta.Haber.Value = 270787.55
    cuenta.SaldoFinal.Value = -2032.46

    ' Cuenta No 5 *******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001"
    cuenta.SaldoInicial.Value = 232096.28
    cuenta.Debe.Value = 145121.8
    cuenta.Haber.Value = 224326.6
    cuenta.SaldoFinal.Value = 152891.48

    ' Cuenta No 6 *******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001001"
    cuenta.SaldoInicial.Value = 232096.28
    cuenta.Debe.Value = 145121.8
    cuenta.Haber.Value = 224326.6
    cuenta.SaldoFinal.Value = 152891.48

    ' Cuenta No 7 *******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001001001"
    cuenta.SaldoInicial.Value = 232096.28
    cuenta.Debe.Value = 145121.8
    cuenta.Haber.Value = 224326.6
    cuenta.SaldoFinal.Value = 152891.48

    ' Cuenta No 8 *******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001001001000001"
    cuenta.SaldoInicial.Value = 0.0
    cuenta.Debe.Value = 27865.52
    cuenta.Haber.Value = 27865.52
    cuenta.SaldoFinal.Value = 0.0

    ' Cuenta No 9 *******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001001001000002"
    cuenta.SaldoInicial.Value = 23232.48
    cuenta.Debe.Value = 23232.48
    cuenta.Haber.Value = 25320.48
    cuenta.SaldoFinal.Value = 21144.48

    ' Cuenta No 10 ******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001001001000003"
    cuenta.SaldoInicial.Value = 88803.8
    cuenta.Debe.Value = 88803.8
    cuenta.Haber.Value = 161280.6
    cuenta.SaldoFinal.Value = 16327.0

    ' Cuenta No 11 ******************************************************************************
    cuenta = balanza.Data.Cuentas.Add()
    cuenta.Numero.Value = "001001001000004"
    cuenta.SaldoInicial.Value = 4640.0
    cuenta.Debe.Value = 3480.0
    cuenta.Haber.Value = 8120.0
    cuenta.SaldoFinal.Value = 0.0
    Try
      ' Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
      Dim fileNameZip As String = Path.Combine(Me._generationDirectory, balanza.FileName)
      fileName = Path.ChangeExtension(fileNameZip, ".xml")

      If balanza.SaveToFile(fileName) Then
        ' Se crea una instancia de un objeto de zip, para llevar a cabo la generación
        ' del archivo compactado que contendrá el XML de la balanza de comprobación
        If Me.chkGenerarZip.Checked Then
          Using zip As New ZipFile()
            zip.AddFile(fileName, String.Empty)
            zip.Save(fileNameZip)
          End Using
        End If
        Return True
      End If

      Gui.ShowError(balanza.ErrorText)
      Return False
    Finally
      Chronometer.Instance.[Stop]()
    End Try
  End Function

  ''' <summary>
  ''' Método que permite generar el archivo de pólizas contables de la contabilidad electrónica
  ''' para su versión 1.3 publicada por el SAT en el mes de junio de 2017
  ''' </summary>
  Private Function CreatePoliza(ByRef fileName As String) As Boolean
    ' Se crea una instancia de un objeto de polizaContable
    Dim polizaContable As PolizaContable = New PolizaContable().Initialization()
    polizaContable.AssignManage(Me._manage)

    ' Datos generales del archivo de las pólizas contables **************************************
    polizaContable.Data.Version.Value = "1.3"
    polizaContable.Data.Rfc.Value = "EKU9003173C9"
    polizaContable.Data.Mes.Value = "01"
    polizaContable.Data.Anio.Value = 2015
    polizaContable.Data.TipoSolicitud.Value = "DE"
    polizaContable.Data.NumeroOrden.Value = "ABC4567890/23"
    polizaContable.Data.NumeroTramite.Value = "AB123456789012"
    ' Encabezado de la póliza que integra el archivo de pólizas contables
    ' Se crea una instancia de un objeto poliza
    Dim poliza As Poliza = polizaContable.Data.Polizas.Add()

    ' Póliza No 1 *******************************************************************************
    poliza.Numero.Value = "1"
    poliza.Fecha.Value = DateTime.Now
    poliza.Concepto.Value = "Póliza de ingresos"
    ' Detalle de cada transacción dentro de la póliza No 1
    ' Se crea una instancia de un objeto transacción
    Dim transaccion As Transaccion = poliza.Transacciones.Add()

    ' Transacción No 1 **************************************************************************
    transaccion.NumeroCuenta.Value = "00030001"
    transaccion.NombreCuenta.Value = "Ventas"
    transaccion.Concepto.Value = "Venta de mercancía"
    transaccion.Debe.Value = 1000.0
    transaccion.Haber.Value = 0.0
    ' Detalle de cada comprobante nacional relacionado con la transacción
    ' Se crea una instancia de un objeto nacional
    Dim nacional As ElectronicDocumentLibrary.Contabilidad.Poliza.ComprobanteNacional = transaccion.ComprobantesNacional.Add()

    ' Comprobante nacional No 1 *****************************************************************
    nacional.Uuid.Value = "711D0509-8F74-41F2-A0F9-C03884832897"
    nacional.Rfc.Value = "AAA010101AAA"
    nacional.MontoTotal.Value = 200.0
    nacional.Moneda.Value = "MXN"
    nacional.TipoCambio.Value = 1.0

    ' Comprobante nacional No 2 *****************************************************************
    nacional = transaccion.ComprobantesNacional.Add()
    nacional.Uuid.Value = "711D0509-8F74-41F2-A0F9-C03884832890"
    nacional.Rfc.Value = "AAA010101AAA"
    nacional.MontoTotal.Value = 200.0
    nacional.Moneda.Value = "MXN"
    nacional.TipoCambio.Value = 1.0

    ' Detalle de cada comprobante nacional relacionado con la transacción
    ' Se crea una instancia de un objeto nacionalOtro
    Dim nacionalOtro As ElectronicDocumentLibrary.Contabilidad.Poliza.ComprobanteNacionalOtro = transaccion.ComprobantesNacionalOtro.Add()

    ' Comprobante nacional otro No 1 ************************************************************
    nacionalOtro.Serie.Value = "F"
    nacionalOtro.Folio.Value = "1"
    nacionalOtro.Rfc.Value = "AAA010101AAA"
    nacionalOtro.MontoTotal.Value = 200.0
    nacionalOtro.Moneda.Value = "MXN"
    nacionalOtro.TipoCambio.Value = 1.0

    ' Comprobante nacional otro No 2 ************************************************************
    nacionalOtro = transaccion.ComprobantesNacionalOtro.Add()
    nacionalOtro.Serie.Value = "F"
    nacionalOtro.Folio.Value = "2"
    nacionalOtro.Rfc.Value = "AAA010101AAA"
    nacionalOtro.MontoTotal.Value = 200.0
    nacionalOtro.Moneda.Value = "MXN"
    nacionalOtro.TipoCambio.Value = 1.0

    ' Detalle de cada comprobante extranjero relacionado con la transacción
    ' Se crea una instancia de un objeto extranjero
    Dim extranjero As ElectronicDocumentLibrary.Contabilidad.Poliza.ComprobanteExtranjero = transaccion.ComprobantesExtranjero.Add()

    ' Comprobante extranjero No 1 ************************************************************
    extranjero.NumeroFactura.Value = "1"
    extranjero.TaxId.Value = "1"
    extranjero.MontoTotal.Value = 100.0
    extranjero.Moneda.Value = "USD"
    extranjero.TipoCambio.Value = 1.0

    ' Comprobante extranjero No 2 ************************************************************
    extranjero = transaccion.ComprobantesExtranjero.Add()
    extranjero.NumeroFactura.Value = "2"
    extranjero.TaxId.Value = "2"
    extranjero.MontoTotal.Value = 100.0
    extranjero.Moneda.Value = "USD"
    extranjero.TipoCambio.Value = 1.0
    ' Detalle de cada cheque soporte del pago dentro de la póliza No 1
    ' Se crea una instancia de un objeto cheque

    Dim cheque As Cheque = transaccion.Cheques.Add()

    ' Cheque No 1 *******************************************************************************
    cheque.Numero.Value = "1"
    cheque.BancoEmisorNacional.Value = "021"
    cheque.CuentaOrigen.Value = "1234567890"
    cheque.Fecha.Value = DateTime.Now
    cheque.Monto.Value = 200.0
    cheque.Beneficiario.Value = "Empresa de prueba"
    cheque.Rfc.Value = "AAA010101AAA"

    ' Cheque No 2 *******************************************************************************
    cheque = transaccion.Cheques.Add()
    cheque.Numero.Value = "2"
    cheque.BancoEmisorNacional.Value = "021"
    cheque.CuentaOrigen.Value = "1234567890"
    cheque.Fecha.Value = DateTime.Now
    cheque.Monto.Value = 200.0
    cheque.Beneficiario.Value = "Empresa de prueba"
    cheque.Rfc.Value = "AAA010101AAA"
    ' Detalle de cada transferencia soporte del pago dentro de la póliza No 1
    ' Se crea una instancia de un objeto transferencia

    Dim transferencia As Transferencia = transaccion.Transferencias.Add()

    ' Transferencia No 1 ************************************************************************
    transferencia.CuentaOrigen.Value = "1234567890"
    transferencia.BancoOrigenNacional.Value = "021"
    transferencia.BancoDestinoNacional.Value = "106"
    transferencia.Monto.Value = 200.0
    transferencia.CuentaDestino.Value = "0987654321"
    transferencia.Fecha.Value = DateTime.Now
    transferencia.Beneficiario.Value = "Empresa de prueba"
    transferencia.Rfc.Value = "AAA010101AAA"

    ' Transferencia No 2 ************************************************************************
    transferencia = transaccion.Transferencias.Add()
    transferencia.CuentaOrigen.Value = "1234567890"
    transferencia.BancoOrigenNacional.Value = "021"
    transferencia.BancoDestinoNacional.Value = "106"
    transferencia.Monto.Value = 200.0
    transferencia.CuentaDestino.Value = "0987654321"
    transferencia.Fecha.Value = DateTime.Now
    transferencia.Beneficiario.Value = "Empresa de prueba"
    transferencia.Rfc.Value = "AAA010101AAA"
    ' Detalle de cada pago distinto de cheque y transferencia soporte del pago dentro de la póliza No 1
    ' Se crea una instancia de un objeto otroMetodoPago

    Dim otroMetodoPago As OtroMetodoPago = transaccion.OtrosMetodosPago.Add()

    ' Método de pago No 1 ***********************************************************************
    otroMetodoPago.MetodoPago.Value = "01"
    otroMetodoPago.Fecha.Value = DateTime.Now
    otroMetodoPago.Beneficiario.Value = "Empresa de prueba"
    otroMetodoPago.Rfc.Value = "AAA010101AAA"
    otroMetodoPago.Monto.Value = 100.0

    ' Método de pago No 2 ***********************************************************************
    otroMetodoPago = transaccion.OtrosMetodosPago.Add()
    otroMetodoPago.MetodoPago.Value = "01"
    otroMetodoPago.Fecha.Value = DateTime.Now
    otroMetodoPago.Beneficiario.Value = "Empresa de prueba"
    otroMetodoPago.Rfc.Value = "AAA010101AAA"
    otroMetodoPago.Monto.Value = 100.0

    ' Encabezado de la póliza que integra el archivo de pólizas contables
    ' Se crea una instancia de un objeto poliza
    ' Póliza No 2 *******************************************************************************
    poliza = polizaContable.Data.Polizas.Add()
    poliza.Numero.Value = "2"
    poliza.Fecha.Value = DateTime.Now
    poliza.Concepto.Value = "Póliza de ingresos"
    ' Detalle de cada transacción dentro de la póliza No 2
    ' Se crea una instancia de un objeto transacción
    transaccion = poliza.Transacciones.Add()
    ' Transacción No 1 **************************************************************************
    transaccion.NumeroCuenta.Value = "00030001"
    transaccion.NombreCuenta.Value = "Ventas"
    transaccion.Concepto.Value = "Venta de mercancía"
    transaccion.Debe.Value = 1000.0
    transaccion.Haber.Value = 0.0
    ' Detalle de cada comprobante nacional relacionado con la transacción
    ' Se crea una instancia de un objeto nacional
    nacional = transaccion.ComprobantesNacional.Add()
    ' Comprobante nacional No 1 *****************************************************************
    nacional.Uuid.Value = "711D0509-8F74-41F2-A0F9-C03884832897"
    nacional.Rfc.Value = "AAA010101AAA"
    nacional.MontoTotal.Value = 200.0
    nacional.Moneda.Value = "MXN"
    nacional.TipoCambio.Value = 1.0
    ' Comprobante nacional No 2 *****************************************************************
    nacional = transaccion.ComprobantesNacional.Add()
    nacional.Uuid.Value = "711D0509-8F74-41F2-A0F9-C03884832890"
    nacional.Rfc.Value = "AAA010101AAA"
    nacional.MontoTotal.Value = 200.0
    nacional.Moneda.Value = "MXN"
    nacional.TipoCambio.Value = 1.0
    ' Detalle de cada comprobante nacional relacionado con la transacción
    ' Se crea una instancia de un objeto nacionalOtro
    nacionalOtro = transaccion.ComprobantesNacionalOtro.Add()
    ' Comprobante nacional otro No 1 ************************************************************
    nacionalOtro.Serie.Value = "F"
    nacionalOtro.Folio.Value = "1"
    nacionalOtro.Rfc.Value = "AAA010101AAA"
    nacionalOtro.MontoTotal.Value = 200.0
    nacionalOtro.Moneda.Value = "MXN"
    nacionalOtro.TipoCambio.Value = 1.0
    ' Comprobante nacional otro No 2 ************************************************************
    nacionalOtro = transaccion.ComprobantesNacionalOtro.Add()
    nacionalOtro.Serie.Value = "F"
    nacionalOtro.Folio.Value = "2"
    nacionalOtro.Rfc.Value = "AAA010101AAA"
    nacionalOtro.MontoTotal.Value = 200.0
    nacionalOtro.Moneda.Value = "MXN"
    nacionalOtro.TipoCambio.Value = 1.0
    ' Detalle de cada comprobante extranjero relacionado con la transacción
    ' Se crea una instancia de un objeto extranjero
    extranjero = transaccion.ComprobantesExtranjero.Add()
    ' Comprobante extranjero No 1 ************************************************************
    extranjero.NumeroFactura.Value = "1"
    extranjero.TaxId.Value = "1"
    extranjero.MontoTotal.Value = 100.0
    extranjero.Moneda.Value = "USD"
    extranjero.TipoCambio.Value = 1.0
    ' Comprobante extranjero No 2 ************************************************************
    extranjero = transaccion.ComprobantesExtranjero.Add()
    extranjero.NumeroFactura.Value = "2"
    extranjero.TaxId.Value = "2"
    extranjero.MontoTotal.Value = 100.0
    extranjero.Moneda.Value = "USD"
    extranjero.TipoCambio.Value = 1.0

    ' Detalle de cada cheque soporte del pago dentro de la póliza No 2
    ' Se crea una instancia de un objeto cheque
    cheque = transaccion.Cheques.Add()
    ' Cheque No 1 *******************************************************************************
    cheque.Numero.Value = "1"
    cheque.BancoEmisorNacional.Value = "021"
    cheque.CuentaOrigen.Value = "1234567890"
    cheque.Fecha.Value = DateTime.Now
    cheque.Monto.Value = 200.0
    cheque.Beneficiario.Value = "Empresa de prueba"
    cheque.Rfc.Value = "AAA010101AAA"
    ' Cheque No 2 *******************************************************************************
    cheque = transaccion.Cheques.Add()
    cheque.Numero.Value = "2"
    cheque.BancoEmisorNacional.Value = "021"
    cheque.CuentaOrigen.Value = "1234567890"
    cheque.Fecha.Value = DateTime.Now
    cheque.Monto.Value = 200.0
    cheque.Beneficiario.Value = "Empresa de prueba"
    cheque.Rfc.Value = "AAA010101AAA"
    ' Detalle de cada transferencia soporte del pago dentro de la póliza No 2
    ' Se crea una instancia de un objeto transferencia
    transferencia = transaccion.Transferencias.Add()
    ' Transferencia No 1 ************************************************************************
    transferencia.CuentaOrigen.Value = "1234567890"
    transferencia.BancoOrigenNacional.Value = "021"
    transferencia.BancoDestinoNacional.Value = "106"
    transferencia.Monto.Value = 200.0
    transferencia.CuentaDestino.Value = "0987654321"
    transferencia.Fecha.Value = DateTime.Now
    transferencia.Beneficiario.Value = "Empresa de prueba"
    transferencia.Rfc.Value = "AAA010101AAA"
    ' Transferencia No 2 ************************************************************************
    transferencia = transaccion.Transferencias.Add()
    transferencia.CuentaOrigen.Value = "1234567890"
    transferencia.BancoOrigenNacional.Value = "021"
    transferencia.BancoDestinoNacional.Value = "106"
    transferencia.Monto.Value = 200.0
    transferencia.CuentaDestino.Value = "0987654321"
    transferencia.Fecha.Value = DateTime.Now
    transferencia.Beneficiario.Value = "Empresa de prueba"
    transferencia.Rfc.Value = "AAA010101AAA"
    ' Detalle de cada pago distinto de cheque y transferencia soporte del pago dentro de la póliza No 2
    ' Se crea una instancia de un objeto otroMetodoPago
    otroMetodoPago = transaccion.OtrosMetodosPago.Add()
    ' Método de pago No 1 ***********************************************************************
    otroMetodoPago.MetodoPago.Value = "01"
    otroMetodoPago.Fecha.Value = DateTime.Now
    otroMetodoPago.Beneficiario.Value = "Empresa de prueba"
    otroMetodoPago.Rfc.Value = "AAA010101AAA"
    otroMetodoPago.Monto.Value = 100.0
    ' Método de pago No 2 ***********************************************************************
    otroMetodoPago = transaccion.OtrosMetodosPago.Add()
    otroMetodoPago.MetodoPago.Value = "01"
    otroMetodoPago.Fecha.Value = DateTime.Now
    otroMetodoPago.Beneficiario.Value = "Empresa de prueba"
    otroMetodoPago.Rfc.Value = "AAA010101AAA"
    otroMetodoPago.Monto.Value = 100.0
    Try
      ' Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
      Dim fileNameZip As String = Path.Combine(Me._generationDirectory, polizaContable.FileName)
      fileName = Path.ChangeExtension(fileNameZip, ".xml")
      If polizaContable.SaveToFile(fileName) Then
        ' Se crea una instancia de un objeto de zip, para llevar a cabo la generación
        ' del archivo compactado que contendrá el XML de las pólizas contables
        If Me.chkGenerarZip.Checked Then
          Using zip As New ZipFile()
            zip.AddFile(fileName, String.Empty)
            zip.Save(fileNameZip)
          End Using
        End If
        Return True
      End If
      Gui.ShowError(polizaContable.ErrorText)
      Return False
    Finally
      Chronometer.Instance.[Stop]()
    End Try
  End Function

  ''' <summary>
  ''' Método que permite generar el archivo auxiliar de folios de la contabilidad electrónica
  ''' para su versión 1.3 publicada por el SAT en el mes de junio de 2017
  ''' </summary>
  Private Function CreateAuxiliarFolios(ByRef fileName As String) As Boolean
    ' Se crea una instancia de un objeto de auxiliarFolios
    Dim auxiliarFolios As AuxiliarFolios = New AuxiliarFolios().Initialization()
    auxiliarFolios.AssignManage(Me._manage)
    ' Datos del encabezado del auxiliar de folios
    auxiliarFolios.Data.Version.Value = "1.3"
    auxiliarFolios.Data.Rfc.Value = "EKU9003173C9"
    auxiliarFolios.Data.Mes.Value = "01"
    auxiliarFolios.Data.Anio.Value = 2015
    auxiliarFolios.Data.TipoSolicitud.Value = "AF"
    auxiliarFolios.Data.NumeroOrden.Value = "AAA0000000/00"
    auxiliarFolios.Data.NumeroTramite.Value = "AB123456789012"
    ' Detalle de folios del auxiliar de folios
    ' Se crea una instancia de un objeto detalle
    Dim detalle As Detalle = auxiliarFolios.Data.Detalles.Add()
    detalle.Numero.Value = "001"
    detalle.Fecha.Value = DateTime.Now
    ' Detalle de cada comprobante nacional
    ' Se crea una instancia de un objeto comprobanteNacional
    Dim comprobantesNacional As ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios.ComprobanteNacional = detalle.ComprobantesNacional.Add()
    ' Comprobante nacional No. 1 ****************************************************************
    comprobantesNacional.Uuid.Value = "5A76AF2C-F415-43D7-945A-13C6AEF6A072"
    comprobantesNacional.MontoTotal.Value = 1000
    comprobantesNacional.Rfc.Value = "AAA010101AAA"
    comprobantesNacional.MetodoPago.Value = "01"
    comprobantesNacional.Moneda.Value = "MXN"
    comprobantesNacional.TipoCambio.Value = 1
    ' Detalle de cada comprobante nacional otro distinto de CFDI
    ' Se crea una instancia de un objeto comprobanteNacionalOtro
    Dim comprobantesNacionalOtro As ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios.ComprobanteNacionalOtro = detalle.ComprobantesNacionalOtro.Add()
    ' Comprobante nacional otro No. 1 ***********************************************************
    comprobantesNacionalOtro.Serie.Value = "A"
    comprobantesNacionalOtro.Folio.Value = "123456"
    comprobantesNacionalOtro.MontoTotal.Value = 1001
    comprobantesNacionalOtro.Rfc.Value = "AAA010101AA1"
    comprobantesNacionalOtro.MetodoPago.Value = "02"
    comprobantesNacionalOtro.Moneda.Value = "MXN"
    comprobantesNacionalOtro.TipoCambio.Value = 1
    ' Detalle de cada comprobante extranjero
    ' Se crea una instancia de un objeto comprobanteExtranjero
    Dim comprobanteExtranjero As ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios.ComprobanteExtranjero = detalle.ComprobantesExtranjero.Add()
    ' Comprobante extranjero No. 1 **************************************************************
    comprobanteExtranjero.NumeroFactura.Value = "123456"
    comprobanteExtranjero.TaxId.Value = "123"
    comprobanteExtranjero.MontoTotal.Value = 1002
    comprobanteExtranjero.MetodoPago.Value = "03"
    comprobanteExtranjero.Moneda.Value = "MXN"
    comprobanteExtranjero.TipoCambio.Value = 1
    ' Detalle de folios del auxiliar de folios
    ' Se crea una instancia de un objeto detalle
    detalle = auxiliarFolios.Data.Detalles.Add()
    detalle.Numero.Value = "002"
    detalle.Fecha.Value = DateTime.Now
    ' Detalle de cada comprobante nacional
    ' Se crea una instancia de un objeto comprobanteNacional
    comprobantesNacional = detalle.ComprobantesNacional.Add()
    ' Comprobante nacional No. 1 ****************************************************************
    comprobantesNacional.Uuid.Value = "5A76AF2C-F415-43D7-945A-13C6AEF6A072"
    comprobantesNacional.MontoTotal.Value = 1000
    comprobantesNacional.Rfc.Value = "AAA010101AAA"
    comprobantesNacional.MetodoPago.Value = "01"
    comprobantesNacional.Moneda.Value = "MXN"
    comprobantesNacional.TipoCambio.Value = 1
    ' Detalle de cada comprobante nacional otro distinto de CFDI
    ' Se crea una instancia de un objeto comprobanteNacionalOtro
    comprobantesNacionalOtro = detalle.ComprobantesNacionalOtro.Add()
    ' Comprobante nacional otro No. 1 ***********************************************************
    comprobantesNacionalOtro.Serie.Value = "A"
    comprobantesNacionalOtro.Folio.Value = "123456"
    comprobantesNacionalOtro.MontoTotal.Value = 1001
    comprobantesNacionalOtro.Rfc.Value = "AAA010101AA1"
    comprobantesNacionalOtro.MetodoPago.Value = "02"
    comprobantesNacionalOtro.Moneda.Value = "MXN"
    comprobantesNacionalOtro.TipoCambio.Value = 1
    ' Detalle de cada comprobante extranjero
    ' Se crea una instancia de un objeto comprobanteExtranjero
    comprobanteExtranjero = detalle.ComprobantesExtranjero.Add()
    ' Comprobante extranjero No. 1 **************************************************************
    comprobanteExtranjero.NumeroFactura.Value = "123456"
    comprobanteExtranjero.TaxId.Value = "123"
    comprobanteExtranjero.MontoTotal.Value = 1002
    comprobanteExtranjero.MetodoPago.Value = "03"
    comprobanteExtranjero.Moneda.Value = "MXN"
    comprobanteExtranjero.TipoCambio.Value = 1
    Try
      ' Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
      Dim fileNameZip As String = Path.Combine(Me._generationDirectory, auxiliarFolios.FileName)
      fileName = Path.ChangeExtension(fileNameZip, ".xml")
      If auxiliarFolios.SaveToFile(fileName) Then
        ' Se crea una instancia de un objeto de zip, para llevar a cabo la generación
        ' del archivo compactado que contendrá el XML del auxiliar de folios
        If Me.chkGenerarZip.Checked Then
          Using zip As New ZipFile()
            zip.AddFile(fileName, String.Empty)
            zip.Save(fileNameZip)
          End Using
        End If
        Return True
      End If
      Gui.ShowError(auxiliarFolios.ErrorText)
      Return False
    Finally
      Chronometer.Instance.[Stop]()
    End Try
  End Function

  ''' <summary>
  ''' Método que permite generar el archivo auxiliar de cuentas de la contabilidad electrónica
  ''' para su versión 1.3 publicada por el SAT en el mes de junio de 2017
  ''' </summary>
  Private Function CreateAuxiliarCuentas(ByRef fileName As String) As Boolean
    ' Se crea una instancia de un objeto de auxiliarCuenta
    Dim auxiliarCuenta As AuxiliarCuentas = New AuxiliarCuentas().Initialization()
    auxiliarCuenta.AssignManage(Me._manage)
    ' Datos del encabezado del auxiliar de cuentas
    auxiliarCuenta.Data.Version.Value = "1.3"
    auxiliarCuenta.Data.Rfc.Value = "EKU9003173C9"
    auxiliarCuenta.Data.Mes.Value = "01"
    auxiliarCuenta.Data.Anio.Value = 2015
    auxiliarCuenta.Data.TipoSolicitud.Value = "AF"
    auxiliarCuenta.Data.NumeroOrden.Value = "AAA0000000/00"
    auxiliarCuenta.Data.NumeroTramite.Value = "AB123456789012"
    ' Movimientos del periodo del auxiliar de cuentas
    ' Se crea una instancia de un objeto cuenta
    Dim cuenta As ElectronicDocumentLibrary.Contabilidad.AuxiliarCuentas.Cuenta = auxiliarCuenta.Data.Cuentas.Add()
    cuenta.Numero.Value = "001"
    cuenta.Descripcion.Value = "Cuenta de compras"
    cuenta.SaldoInicial.Value = 700.0
    cuenta.SaldoFinal.Value = 500.0
    ' Detalle de cada cuenta
    ' Se crea una instancia de un objeto detalle
    Dim detalle As DetalleAuxiliar = cuenta.Detalles.Add()
    ' Detalle de cuenta No. 1 *******************************************************************
    detalle.Fecha.Value = DateTime.Now
    detalle.Numero.Value = "001001"
    detalle.Concepto.Value = "Compras"
    detalle.Debe.Value = 700.0
    detalle.Haber.Value = 200.0
    ' Detalle de cuenta No. 2 *******************************************************************
    detalle = cuenta.Detalles.Add()
    detalle.Fecha.Value = DateTime.Now
    detalle.Numero.Value = "001001"
    detalle.Concepto.Value = "Compras"
    detalle.Debe.Value = 700.0
    detalle.Haber.Value = 200.0
    ' Movimientos del periodo del auxiliar de cuentas
    ' Se crea una instancia de un objeto cuenta
    cuenta = auxiliarCuenta.Data.Cuentas.Add()
    cuenta.Numero.Value = "002"
    cuenta.Descripcion.Value = "Cuenta de compras"
    cuenta.SaldoInicial.Value = 700.0
    cuenta.SaldoFinal.Value = 500.0
    ' Detalle de cada cuenta
    ' Se crea una instancia de un objeto detalle
    detalle = cuenta.Detalles.Add()
    ' Detalle de cuenta No. 1 *******************************************************************
    detalle.Fecha.Value = DateTime.Now
    detalle.Numero.Value = "002001"
    detalle.Concepto.Value = "Compras"
    detalle.Debe.Value = 700.0
    detalle.Haber.Value = 200.0
    ' Detalle de cuenta No. 2 *******************************************************************
    detalle = cuenta.Detalles.Add()
    detalle.Fecha.Value = DateTime.Now
    detalle.Numero.Value = "002001"
    detalle.Concepto.Value = "Compras"
    detalle.Debe.Value = 700.0
    detalle.Haber.Value = 200.0
    Try
      ' Se asigna el nombre que llevará el archivo XML y la ubicación donde será generado
      Dim fileNameZip As String = Path.Combine(Me._generationDirectory, auxiliarCuenta.FileName)
      fileName = Path.ChangeExtension(fileNameZip, ".xml")
      If auxiliarCuenta.SaveToFile(fileName) Then
        ' Se crea una instancia de un objeto de zip, para llevar a cabo la generación
        ' del archivo compactado que contendrá el XML del auxiliar de cuentas
        If Me.chkGenerarZip.Checked Then
          Using zip As New ZipFile()
            zip.AddFile(fileName, String.Empty)
            zip.Save(fileNameZip)
          End Using
        End If
        Return True
      End If
      Gui.ShowError(auxiliarCuenta.ErrorText)
      Return False
    Finally
      Chronometer.Instance.[Stop]()
    End Try
  End Function


  ''' <summary>
  ''' Método que muestra como crear los objetos a usar en este ejemplos
  ''' </summary>
  Private Sub CreateObjects()
    ' Se configuran algunas opciones de la librería
    Configuration.Library()

    Me._manage = New ElectronicManage().Initialization()

    ' *** ELIMINAR ESTA LÍNEA EN EL AMBIENTE DE PRODUCCION *** 
    Me._manage.CertificateAuthorityList.UseForTest()

    Dim cerFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.cer")
    Dim keyFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.key")
    Dim password As String = "12345678a"
    Dim certificate as ElectronicCertificate = New ElectronicCertificate().Load(cerFile, keyFile, password)

    ' Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
    ' y administrar TODOS los recursos que serán usados en el proceso
    Me._manage.Save.AssignCertificate(certificate)

    ' Directorio donde van a ser almacenado los XML generados
    Me._generationDirectory = Utils.CreateDirectory()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "Contabilidad electrónica"

    ReDim _pages(6)
    _pages(0) = tshCatalogo
    _pages(1) = tshBalanza
    _pages(2) = tshPoliza
    _pages(3) = tshAuxiliarFolios
    _pages(4) = tshAuxiliarCuentas
    _pages(5) = tshSelloDigital

    ' -- Código para uso interno de este ejemplo
    Me.pgcInformacion.SuspendLayout()
    While Me.pgcInformacion.TabPages.Count > 0
      Me.pgcInformacion.TabPages.RemoveAt(0)
    End While
    Me.pgcInformacion.ResumeLayout()

    Me.cmbOperacion.SelectedIndex = 0

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.Initialization(Me.lblLicencia, Me.lblVersion, Me.lblTime)
    Utilerias.Gui.Shared.Buttons(Me.btnTimbrado, Me.btnHelp, Me.btnAbout, Me.btnClose)
  End Sub

#End Region

#Region "Events"

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

    Chronometer.Instance.StartWithCursor()

    Dim generatedfile As Boolean = False
    Dim fileName As String = String.Empty

    Try
      Select Case cmbOperacion.SelectedIndex
        ' Catálogo
        Case 0
          generatedfile = Me.CreateCatalogo(fileName)
          Exit Select

          ' Balanza
        Case 1
          generatedfile = Me.CreateBalanza(fileName)
          Exit Select

          ' Póliza
        Case 2
          generatedfile = Me.CreatePoliza(fileName)
          Exit Select

          ' Auxiliar de folios
        Case 3
          generatedfile = Me.CreateAuxiliarFolios(fileName)
          Exit Select

          ' Auxiliar de cuentas
        Case 4
          generatedfile = Me.CreateAuxiliarCuentas(fileName)
          Exit Select

        Case Else
          Throw New ArgumentOutOfRangeException()
      End Select
    Finally
      lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      SystemSounds.Asterisk.Play()

      If generatedfile AndAlso Gui.ShowQuestion(String.Format("El documento fue generado con éxito.{0}{0}¿Desea visualizarlo ?", Environment.NewLine)) Then
        Process.Start(Path.GetFullPath(fileName))
      End If
    End Try
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub cmbOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperacion.SelectedIndexChanged

    pgcInformacion.SuspendLayout()
    Try
      If pgcInformacion.TabPages.Count > 0 Then
        pgcInformacion.TabPages.RemoveAt(0)
      End If

      pgcInformacion.TabPages.Add(_pages(cmbOperacion.SelectedIndex))
    Finally
      pgcInformacion.ResumeLayout()
    End Try
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    IntegrationForm.ShowForm()

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.TimerLicenciaEnabled()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    ' -- Código para uso interno de este ejemplo
    License.CargarLicencia()

    ' -- Código para uso interno de este ejemplo
    Me.ConfigurateControls()

    ' -- Muestra como crear los objetos requeridos para este ejemplos
    Me.CreateObjects()
  End Sub

#End Region

End Class