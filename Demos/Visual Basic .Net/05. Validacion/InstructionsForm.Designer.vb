<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructionsForm
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructionsForm))
    Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
    Me.SuspendLayout()
    '
    'richTextBox1
    '
    Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
    Me.richTextBox1.Name = "richTextBox1"
    Me.richTextBox1.Size = New System.Drawing.Size(462, 287)
    Me.richTextBox1.TabIndex = 1
    Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
    '
    'InstructionsForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(462, 287)
    Me.Controls.Add(Me.richTextBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "InstructionsForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Ayuda..."
    Me.ResumeLayout(False)

  End Sub
  Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
End Class
