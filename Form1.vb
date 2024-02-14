Public Class welcomeForm
    Private Sub WelcomingForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub loadBtn_Click(sender As Object, e As EventArgs) Handles loadBtn.Click
        Dim objDemoForm As New objectdemoForm() ' Assuming the form's name is ObjectDemoForm
        objDemoForm.Show()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Application.Exit()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
        ToolTip1.SetToolTip(loadBtn, "Click to load and display the object demonstration form.")
        ToolTip1.SetToolTip(exitBtn, "Click to exit the application.")
    End Sub
End Class