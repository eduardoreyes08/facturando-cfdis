using System;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarCuentas;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.Balanza;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.CatalogoCuentas;
using HyperSoft.ElectronicDocumentLibrary.Contabilidad.Poliza;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Validacion
{
  public partial class MainForm : Form
  {
    #region Bussines

    #region Constants

    private const string DataDirectory = "..\\..\\..\\..";
    
    #endregion

    #region Vars

    private ElectronicManage manage;
    private ElectronicDocument electronicDocument;

    #endregion

    #region Methods

    private void ValidarComprobante(string fileName)
    {
      if (this.electronicDocument.LoadFromFile(fileName) == false)
      {
        Gui.ShowError(this.electronicDocument.ErrorText);
        return;
      }

      this.mmoInformation.Text = Information.Cfdi.Show(this.electronicDocument);
    }

    private void ValidarCatalogoCuentas(string fileName)
    {
      CatalogoCuentas catalogoCuentas = new CatalogoCuentas().Initialization();
      catalogoCuentas.AssignManage(this.manage);
      
      try
      {
        if (catalogoCuentas.LoadFromFile(fileName) == false)
        {
          Gui.ShowError(catalogoCuentas.ErrorText);
          return;
        }

        this.mmoInformation.Text = Information.Catalogo.Show(catalogoCuentas);
      }
      finally
      {
        catalogoCuentas.UnAssignManage();
      }
    }

    private void ValidarBalanza(string fileName)
    {
      Balanza balanza = new Balanza().Initialization();
      balanza.AssignManage(this.manage);

      try
      {
        if (balanza.LoadFromFile(fileName) == false)
        {
          Gui.ShowError(balanza.ErrorText);
          return;
        }

        this.mmoInformation.Text = Information.BalanzaComprobacion.Show(balanza);
      }
      finally
      {
        balanza.UnAssignManage();
      }
    }

    private void ValidarPoliza(string fileName)
    {
      PolizaContable polizaContable = new PolizaContable().Initialization();
      polizaContable.AssignManage(this.manage);

      try
      {
        if (polizaContable.LoadFromFile(fileName) == false)
        {
          Gui.ShowError(polizaContable.ErrorText);
          return;
        }

        this.mmoInformation.Text = Information.PolizaContabilidad.Show(polizaContable);
      }
      finally
      {
        polizaContable.UnAssignManage();
      }
    }

    private void ValidarAuxiliarCuentas(string fileName)
    {
      AuxiliarCuentas auxiliarCuentas = new AuxiliarCuentas().Initialization();
      auxiliarCuentas.AssignManage(this.manage);

      try
      {
        if (auxiliarCuentas.LoadFromFile(fileName) == false)
        {
          Gui.ShowError(auxiliarCuentas.ErrorText);
          return;
        }

        this.mmoInformation.Text = Information.Auxiliar.Show(auxiliarCuentas);
      }
      finally
      {
        auxiliarCuentas.UnAssignManage();
      }
    }

    private void ValidarAuxiliarFolios(string fileName)
    {
      AuxiliarFolios auxiliarFolios = new AuxiliarFolios().Initialization();
      auxiliarFolios.AssignManage(this.manage);

      try
      {
        if (auxiliarFolios.LoadFromFile(fileName) == false)
        {
          Gui.ShowError(auxiliarFolios.ErrorText);
          return;
        }

        this.mmoInformation.Text = Information.Folios.Show(auxiliarFolios);
      }
      finally
      {
        auxiliarFolios.UnAssignManage();
      }
    }

    private void ValidarConstanciaRetenciones(string fileName)
    {
      ConstanciaRetenciones retenciones = new ConstanciaRetenciones().Initialization();
      retenciones.AssignManage(this.manage);

      try
      {
        if (retenciones.LoadFromFile(fileName) == false)
        {
          Gui.ShowError(retenciones.ErrorText);
          return;
        }

        this.mmoInformation.Text = Information.Constancia.Show(retenciones);
      }
      finally
      {
        retenciones.UnAssignManage();
      }
    }

    /// <summary>
    /// Método que muestra como crear los objetos a usar en este ejemplos
    /// </summary>
    private void CreateObjects()
    {
      // Se configuran algunas opciones de la librería
      Configuration.Library();

      // Instanciamos la clase TManageElectronicDocument, si quieren saber para qué sirve
      // pueden leer el documento que se encuentra en la carpeta Documentación.
      this.manage = new ElectronicManage().Initialization();

      // Debido a que se validar CFDI de pruebas se elimina la validación contra del timbre.
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      this.manage.Load.Options -= LoadOptions.ValidateStamp;

      // Se cargan a memoria el archivo de autoridades certificadoras de prueba
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      this.manage.CertificateAuthorityList.UseForTest();

      // Se instancia la clase que es la encarga de llevar a cabo el proceso de validación y se le pasa
      // el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
      this.electronicDocument = new ElectronicDocument().Initialization();
      this.electronicDocument.AssignManage(this.manage);
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      Gui.MessageBoxCaption = "Validación";

      // -- Código para uso interno de este ejemplo
      this.tbcOpciones.SelectedIndex = 0;

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(null, this.btnHelp, this.btnAbout, this.btnClose);

      // -- Código para uso interno de este ejemplo
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\1.0\\ejemplo1.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\2.2\\ejemplo1.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\3.2\\CFDI1.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\3.3\\CFDI33.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\4.0\\CFDI40.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Nomina\\ReciboNomina12.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Recibo de pago\\ReciboPago10.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Recibo de pago\\ReciboPago20.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Complementos\\ImpuestosLocales10.xml")));
      this.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Addenda\\Addenda_Ado.xml")));
      this.cbbCfdi.SelectedIndex = 4;

      // -- Código para uso interno de este ejemplo
      this.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Contabilidad electrónica\\catalogo.xml")));
      this.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Contabilidad electrónica\\balanza.xml")));
      this.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Contabilidad electrónica\\poliza.xml")));
      this.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Contabilidad electrónica\\Auxiliar_Cuentas.xml")));
      this.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Contabilidad electrónica\\Auxiliar_Folios.xml")));      
      this.cbbContabilidad.SelectedIndex = 0;
      this.cbbContabilidadTipo.SelectedIndex = 0;
      
      // -- Código para uso interno de este ejemplo
      this.cbbConstanciaRetenciones.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Constancia de retenciones\\Constancia_Retenciones_20.xml")));
      this.cbbConstanciaRetenciones.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\Constancia de retenciones\\Constancia_Retenciones_Plataformas_Tecnologicas.xml")));
      this.cbbConstanciaRetenciones.SelectedIndex = 0;
    }
    #endregion

    #region Events

    private void btnValidar_Click(object sender, EventArgs e)
    {
      // = Configuramos la interfaz del ejemplo ===========================
      this.lblTime.Text = string.Empty;
      Application.DoEvents();
      Chronometer.Instance.StartWithCursor();
      //===================================================================

      this.mmoInformation.Text = "";

      try
      {
        // Por default se hacen todas las validaciones, si quisiera quitar alguna,
        // por ejemplo que no se valide que el folio haya sido autoridado por el SAT,
        // se puede hacer esto:
        // manage.Save.Options -= SaveOptions.ValidateWithFoliosAutorizados; 
        // A continuacion se muestran todas las opciones
        //     ValidateWithSchema,
        //     ValidateInformation,
        //     ValidateWithFoliosAutorizados,
        //     ValidateSignature,
        //     ValidateCertificateWithCa,
        //     ValidateCertificateWithCrl,
        //     AddCertificateToCel

        // Se ejecuta el proceso de validación        
        switch (this.tbcOpciones.SelectedIndex)
        {
          case 0:
            // CFD: Validar un comprobante de la versión 1.0
            this.ValidarComprobante(this.cbbCfdi.Text.Trim());
            break;

          case 1:
            switch (this.cbbContabilidadTipo.SelectedIndex)
            {
              // CONTABILIDAD ELECTRÓNICA : Validar el catálogo de cuentas contables
              case 0:
                this.ValidarCatalogoCuentas(this.cbbContabilidad.Text.Trim());
                break;

              // CONTABILIDAD ELECTRÓNICA : Validar la balanza de comprobación
              case 1:
                this.ValidarBalanza(this.cbbContabilidad.Text.Trim());
                break;

              // CONTABILIDAD ELECTRÓNICA : Validar las pólizas
              case 2:
                this.ValidarPoliza(this.cbbContabilidad.Text.Trim());
                break;

              // CONTABILIDAD ELECTRÓNICA : Validar el auxiliar de cuentas
              case 3:
                this.ValidarAuxiliarCuentas(this.cbbContabilidad.Text.Trim());
                break;

              // CONTABILIDAD ELECTRÓNICA : Validar el auxiliar de folios
              case 4:
                this.ValidarAuxiliarFolios(this.cbbContabilidad.Text.Trim());
                break;
            }
            break;

          case 2:
            // CFD: Validar un comprobante de la versión 1.0
            this.ValidarConstanciaRetenciones(this.cbbConstanciaRetenciones.Text.Trim());
            break;
        }
      }
      finally
      {
        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";
        System.Media.SystemSounds.Asterisk.Play();
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

      // -- Código para uso interno de este ejemplo
      this.btnValidar.Focus();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
      ComboBox control;
      if (this.tbcOpciones.SelectedIndex == 0)
        control = this.cbbCfdi;
      else if (this.tbcOpciones.SelectedIndex == 1)
        control = this.cbbContabilidad;
      else if (this.tbcOpciones.SelectedIndex == 2)
        control = this.cbbConstanciaRetenciones;
      else throw new ArgumentException();

      string fileName = control.Text;

      if (Utils.SelectFile(ref fileName) == false)
        return;

      control.Text = fileName;      
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void cbbContabilidadTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.cbbContabilidad.Text = this.cbbContabilidad.Items[this.cbbContabilidadTipo.SelectedIndex].ToString();
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