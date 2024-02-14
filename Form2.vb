Public Class objectdemoForm
    Private Sub FontRadioButtons_CheckedChanged(sender As Object, e As EventArgs) _
        Handles garamondButton.CheckedChanged, magnetoButton.CheckedChanged, tahomaButton.CheckedChanged

        If garamondButton.Checked Then
            sampletestBox.Font = New Font("Garamond", sampletestBox.Font.Size)
        ElseIf magnetoButton.Checked Then
            sampletestBox.Font = New Font("Magneto", sampletestBox.Font.Size)
        ElseIf tahomaButton.Checked Then
            sampletestBox.Font = New Font("Tahoma", sampletestBox.Font.Size)
        End If
    End Sub

    Private Sub FontStyleCheckBoxes_CheckedChanged(sender As Object, e As EventArgs) _
    Handles italicBox.CheckedChanged, boldBox.CheckedChanged, bolditalicBox.CheckedChanged

        Dim style As FontStyle = FontStyle.Regular
        If italicBox.Checked Then style = style Or FontStyle.Italic
        If boldBox.Checked Then style = style Or FontStyle.Bold
        If bolditalicBox.Checked Then style = style Or FontStyle.Bold Or FontStyle.Italic
        sampletestBox.Font = New Font(sampletestBox.Font, style)
    End Sub

    Private Sub FontColorRadioButtons_CheckedChanged(sender As Object, e As EventArgs) _
    Handles greenButton.CheckedChanged, blueButton.CheckedChanged, redButton.CheckedChanged

        If greenButton.Checked Then
            sampletestBox.ForeColor = Color.Green
        ElseIf blueButton.Checked Then
            sampletestBox.ForeColor = Color.Blue
        ElseIf redButton.Checked Then
            sampletestBox.ForeColor = Color.Red
        End If
    End Sub
    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles pictureButton.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                PictureBox.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles exitButton2.Click
        Me.Close() ' Closes the current form
    End Sub
End Class