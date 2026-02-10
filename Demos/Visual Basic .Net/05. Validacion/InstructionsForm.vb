Public Class InstructionsForm

  Public Shared Sub ShowForm()
    Using instructionsform As New InstructionsForm()
      instructionsform.ShowDialog()
    End Using
  End Sub

End Class