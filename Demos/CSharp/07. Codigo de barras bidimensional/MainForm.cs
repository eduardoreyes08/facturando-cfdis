using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.BarCode;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;

// ReSharper disable LocalizableElement
namespace HyperSoft.Ejemplo.Cbb
{
  public partial class MainForm : Form
  {
    #region Business
    
    #region Vars

    private BarCode barCode;

    private ImageFormat fileFormat;

    #endregion

    #region Methods

    private void SampleCfdi33()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        this.barCode.GenerateCfdi(this.edtRFCEmisor.Text, this.edtRFCReceptor.Text, decimal.Parse(this.edtTotal.Text), this.edtUuid.Text, this.edtSello.Text, stream);
        this.lblImageSize.Text = $"Tamaño: {Shared.File.Instance.FormatByteSize(stream.Length)}";
        this.picBarCode.Image = Image.FromStream(stream); 
      }
    }

    private void SampleConstancia()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        this.barCode.GenerateConstancia(this.edtEmisorConstancia.Text, this.edtReceptorConstancia.Text, decimal.Parse(this.edtTotalConstancia.Text), this.edtUuidConstancia.Text, this.edtSello.Text, stream);
        this.lblImageSize.Text = $"Tamaño: {Shared.File.Instance.FormatByteSize(stream.Length)}";
        this.picBarCode.Image = Image.FromStream(stream); 
      }
    }

    private void SampleCartaPorte()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        this.barCode.GenerateCartaPorte(this.edtUuidCartaPorte.Text, this.dteFechaOrigen.Value, this.dteFechaTimbrado.Value, stream);
        this.lblImageSize.Text = $"Tamaño: {Shared.File.Instance.FormatByteSize(stream.Length)}";
        this.picBarCode.Image = Image.FromStream(stream);
      }
    }

    private string CalculateTextCfdi33()
    {
      return this.barCode.CalculateCfdi(
        this.edtRFCEmisor.Text,
        this.edtRFCReceptor.Text,
        decimal.Parse(this.edtTotal.Text),
        this.edtUuid.Text,
        this.edtSello.Text);
    }
    
    private string CalculateTextConstancia()
    {
      return this.barCode.CalculateConstancia(
        this.edtEmisorConstancia.Text,
        this.edtReceptorConstancia.Text,
        decimal.Parse(this.edtTotalConstancia.Text),
        this.edtUuidConstancia.Text,
        this.edtSelloConstancia.Text);
    }

    private string CalculateTextCartaPorte()
    {
      return this.barCode.CalculateCartaPorte(
        this.edtUuidCartaPorte.Text,
        this.dteFechaOrigen.Value,
        this.dteFechaTimbrado.Value);
    }

    private void SampleCfdi32()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        this.barCode.GenerateCfdi(this.edtRFCEmisor.Text, this.edtRFCReceptor.Text, decimal.Parse(this.edtTotal.Text), this.edtUuid.Text, stream);
        this.lblImageSize.Text = $"Tamaño: {Shared.File.Instance.FormatByteSize(stream.Length)}";
        this.picBarCode.Image = Image.FromStream(stream);
      }
    }

    private void SampleConstancia10()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        this.barCode.GenerateConstancia(this.edtEmisorConstancia.Text, this.edtReceptorConstancia.Text, decimal.Parse(this.edtTotalConstancia.Text), this.edtUuidConstancia.Text, stream);
        this.lblImageSize.Text = $"Tamaño: {Shared.File.Instance.FormatByteSize(stream.Length)}";
        this.picBarCode.Image = Image.FromStream(stream);
      }
    }

    private string CalculateTextConstancia10()
    {
      return BarCode.CalculateTextConstancia(
        this.edtEmisorConstancia.Text,
        this.edtReceptorConstancia.Text,
        decimal.Parse(this.edtTotalConstancia.Text),
        this.edtUuidConstancia.Text);
    }

    private string CalculateTextCfdi32()
    {
      return BarCode.CalculateText(
        this.edtRFCEmisor.Text,
        this.edtRFCReceptor.Text,
        decimal.Parse(this.edtTotal.Text),
        this.edtUuid.Text);
    }

    /// <summary>
    /// Método que muestra como crear los objetos a usar en este ejemplos
    /// </summary>
    private void CreateObjects()
    {
      // Se configuran algunas opciones de la librería
      Configuration.Library();

      this.barCode = new BarCode().Initialization();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      Gui.MessageBoxCaption = "Código de barras bidimensional"; 

      // -- Código para uso interno de este ejemplo
      this.picBarCode.SizeMode = PictureBoxSizeMode.CenterImage;

      // -- Código para uso interno de este ejemplo
      this.cbxFormato.Items.Add(ImageFormat.Bmp.ToString().ToUpper());
      this.cbxFormato.Items.Add(ImageFormat.Jpg.ToString().ToUpper());
      this.cbxFormato.Items.Add(ImageFormat.Png.ToString().ToUpper());
      this.cbxFormato.SelectedIndex = 2;
      this.pgcInformacion.SelectedIndex = 0;
      this.cbxFormato.Text = "4";
      this.btnExecute.Focus();

      // -- Código para uso interno de este ejemplo
      this.fileFormat = (ImageFormat)this.cbxFormato.SelectedIndex;

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


      try
      {
        switch (this.pgcInformacion.SelectedIndex)
        {
          case 0:
            this.SampleCfdi33();
            break;

          case 1:
            this.SampleConstancia();
            break;

          case 2:
            this.SampleCartaPorte();
            break;

          default:
            throw new ArgumentOutOfRangeException();
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
    private void btnConfigurar_Click(object sender, EventArgs e)
    {
      this.fileFormat = (ImageFormat) this.cbxFormato.SelectedIndex;
      BarCode.SetConfiguration(int.Parse(this.edtTamano.Text), this.fileFormat, true);
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnText_Click(object sender, EventArgs e)
    {
      //Calculamos la candena contenida en el código de barras bidimensional
      string data;
      switch (this.pgcInformacion.SelectedIndex)
      {
        case 0:
          data = this.CalculateTextCfdi33();
          break;

        case 1:
          data = this.CalculateTextConstancia();
          break;

        case 2:
          data = this.CalculateTextCartaPorte();
          break;

        default:
          throw new ArgumentOutOfRangeException();
      }

      Gui.ShowMessage(data);
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