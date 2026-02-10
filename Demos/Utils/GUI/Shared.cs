using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary;
using HyperSoft.ElectronicDocumentLibrary.Base;

// ReSharper disable UseStringInterpolation

namespace HyperSoft.Ejemplo.Utilerias.Gui
{
  public static class Shared
  {
    #region Vars

    private static ToolStripStatusLabel lblLicencia;
    private static readonly Timer TimerLicencia;
    private static RichTextBox rtbDescription;
    private static string[] descriptions;

    #endregion

    #region Methods
    
    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    /// <param name="licencia"></param>
    /// <param name="version"></param>
    /// <param name="lblTime"></param>    
    public static void Initialization(ToolStripStatusLabel licencia, ToolStripStatusLabel version, ToolStripStatusLabel lblTime)
    {
      if (version != null)
      {
        version.Text = string.Format("E.D.L.: {0}", ElectronicDocumentLibrary.Document.ElectronicDocument.Version());
        version.Click += (o, args) => { Utils.ShowVersion(); };
      }
      
      if (lblTime != null)
        lblTime.Text = string.Empty;
      
      if (licencia == null)
        return;

      lblLicencia = licencia;
      lblLicencia.Visible = false;
      lblLicencia.Click += lblLicencia_Click;
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    /// <param name="timbrado"></param>
    /// <param name="help"></param>
    /// <param name="about"></param>
    /// <param name="close"></param>
    /// <param name="puertos"></param>
    public static void Buttons(Button timbrado, Button help, Button about, Button close, Button puertos = null)
    {
      if (timbrado != null)
        timbrado.Click += btnTimbrado_Click;

      if (help != null)
        help.Click += btnHelp_Click;

      if (about != null)
        about.Click += btnAbout_Click;

      if (puertos != null)
        puertos.Click += btnPuertos_Click;

      close.Click += btnClose_Click;
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static void EnabledControls(bool enabled, IEnumerable<Control> controls)
    {
      foreach (Control control in controls)
        control.Enabled = enabled;
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static void ConfigurateModalForm(Form form)
    {
      form.MaximizeBox = false;
      form.MinimizeBox = false;
      form.ShowIcon = false;
      form.ShowInTaskbar = false;
      form.StartPosition = FormStartPosition.CenterParent;
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static void Description(RichTextBox information, string[] description, ComboBox comboBox)
    {
      rtbDescription = information;
      descriptions = description;

      comboBox.SelectedIndexChanged += (sender, args) => { rtbDescription.Text = descriptions[((ComboBox) sender).SelectedIndex]; };
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static void TimerLicenciaEnabled()
    {
      lblLicencia.Text = Activaction.ActivationStatus.ToString().ToUpperInvariant();
      lblLicencia.Visible = true;
      TimerLicencia.Enabled = true;
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static void SetTagValue(Button[] buttons)
    {
      for (int i = 0; i < buttons.Length; i++)
        buttons[i].Tag = i + 1;
    }

    #endregion

    #region Events

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private static void lblLicencia_Click(object sender, EventArgs e)
    {
      LicenciaForm.ShowData();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private static void btnTimbrado_Click(object sender, EventArgs e)
    {
      Process.Start(IntegrationForm.UrlTimbrado);
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private static void btnHelp_Click(object sender, EventArgs e)
    {
      Application.OpenForms[0].Enabled = false;
      try
      {
        HelpForm.ShowForm();
      }
      finally
      {
        Application.OpenForms[0].Enabled = true;
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private static void btnAbout_Click(object sender, EventArgs e)
    {
      Application.OpenForms[0].Enabled = false;
      try
      {
        AboutForm.ShowForm();
      }
      finally
      {
        Application.OpenForms[0].Enabled = true;
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private static void btnClose_Click(object sender, EventArgs e)
    {
      Application.OpenForms[0].Close();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private static void btnPuertos_Click(object sender, EventArgs e)
    {
      string fileName = Path.GetFullPath("..\\..\\..\\..\\..\\Documentos\\Puertos.pdf");
      Process.Start(fileName);
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private static void timerLicencia_OnTimedEvent(object sender, EventArgs e)
    {
      if (Activaction.ActivationStatus == ActivationStatusType.EvaluationMode)
        return;

      lblLicencia.Text = Activaction.ActivationStatus.ToString().ToUpperInvariant();
      TimerLicencia.Enabled = false;
    }

    #endregion

    #region Factory

    static Shared()
    {
      TimerLicencia = new Timer {Interval = 500};
      TimerLicencia.Tick += timerLicencia_OnTimedEvent;
    }

    #endregion
  }
}