<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        loadBtn = New Button()
        exitBtn = New Button()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' loadBtn
        ' 
        loadBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loadBtn.Location = New Point(43, 179)
        loadBtn.Name = "loadBtn"
        loadBtn.Size = New Size(198, 57)
        loadBtn.TabIndex = 0
        loadBtn.Text = "&Load Object Demo"
        loadBtn.TextAlign = ContentAlignment.TopLeft
        loadBtn.UseVisualStyleBackColor = True
        ' 
        ' exitBtn
        ' 
        exitBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exitBtn.Location = New Point(407, 185)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(190, 51)
        exitBtn.TabIndex = 1
        exitBtn.Text = "E&XIT"
        exitBtn.TextAlign = ContentAlignment.TopLeft
        exitBtn.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ' 
        ' welcomeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(exitBtn)
        Controls.Add(loadBtn)
        Name = "welcomeForm"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents loadBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
