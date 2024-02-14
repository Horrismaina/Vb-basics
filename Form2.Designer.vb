<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class objectdemoForm
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
        displayBox = New GroupBox()
        sampletestBox = New TextBox()
        fontBox = New GroupBox()
        tahomaButton = New RadioButton()
        magnetoButton = New RadioButton()
        garamondButton = New RadioButton()
        PictureBox = New PictureBox()
        fontstyleBox = New GroupBox()
        bolditalicBox = New CheckBox()
        boldBox = New CheckBox()
        italicBox = New CheckBox()
        colorBox = New GroupBox()
        redButton = New RadioButton()
        blueButton = New RadioButton()
        greenButton = New RadioButton()
        pictureButton = New Button()
        exitButton2 = New Button()
        displayBox.SuspendLayout()
        fontBox.SuspendLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        fontstyleBox.SuspendLayout()
        colorBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' displayBox
        ' 
        displayBox.Controls.Add(sampletestBox)
        displayBox.Location = New Point(12, 37)
        displayBox.Name = "displayBox"
        displayBox.Size = New Size(238, 88)
        displayBox.TabIndex = 0
        displayBox.TabStop = False
        displayBox.Text = "Display Test"
        ' 
        ' sampletestBox
        ' 
        sampletestBox.Location = New Point(22, 35)
        sampletestBox.Name = "sampletestBox"
        sampletestBox.Size = New Size(141, 27)
        sampletestBox.TabIndex = 0
        sampletestBox.Text = "Sample Test"
        ' 
        ' fontBox
        ' 
        fontBox.Controls.Add(tahomaButton)
        fontBox.Controls.Add(magnetoButton)
        fontBox.Controls.Add(garamondButton)
        fontBox.Location = New Point(301, 48)
        fontBox.Name = "fontBox"
        fontBox.Size = New Size(487, 97)
        fontBox.TabIndex = 1
        fontBox.TabStop = False
        fontBox.Text = "Font"
        ' 
        ' tahomaButton
        ' 
        tahomaButton.AutoSize = True
        tahomaButton.Location = New Point(348, 36)
        tahomaButton.Name = "tahomaButton"
        tahomaButton.Size = New Size(82, 24)
        tahomaButton.TabIndex = 2
        tahomaButton.TabStop = True
        tahomaButton.Text = "Tahoma"
        tahomaButton.UseVisualStyleBackColor = True
        ' 
        ' magnetoButton
        ' 
        magnetoButton.AutoSize = True
        magnetoButton.Location = New Point(176, 36)
        magnetoButton.Name = "magnetoButton"
        magnetoButton.Size = New Size(90, 24)
        magnetoButton.TabIndex = 1
        magnetoButton.TabStop = True
        magnetoButton.Text = "Magneto"
        magnetoButton.UseVisualStyleBackColor = True
        ' 
        ' garamondButton
        ' 
        garamondButton.AutoSize = True
        garamondButton.Location = New Point(21, 36)
        garamondButton.Name = "garamondButton"
        garamondButton.Size = New Size(100, 24)
        garamondButton.TabIndex = 0
        garamondButton.TabStop = True
        garamondButton.Text = "Garamond"
        garamondButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox
        ' 
        PictureBox.Location = New Point(34, 183)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(248, 230)
        PictureBox.TabIndex = 3
        PictureBox.TabStop = False
        ' 
        ' fontstyleBox
        ' 
        fontstyleBox.Controls.Add(bolditalicBox)
        fontstyleBox.Controls.Add(boldBox)
        fontstyleBox.Controls.Add(italicBox)
        fontstyleBox.Location = New Point(338, 206)
        fontstyleBox.Name = "fontstyleBox"
        fontstyleBox.Size = New Size(184, 207)
        fontstyleBox.TabIndex = 4
        fontstyleBox.TabStop = False
        fontstyleBox.Text = "Font Style"
        ' 
        ' bolditalicBox
        ' 
        bolditalicBox.AutoSize = True
        bolditalicBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        bolditalicBox.Location = New Point(34, 155)
        bolditalicBox.Name = "bolditalicBox"
        bolditalicBox.Size = New Size(112, 27)
        bolditalicBox.TabIndex = 2
        bolditalicBox.Text = "Bold Italic"
        bolditalicBox.UseVisualStyleBackColor = True
        ' 
        ' boldBox
        ' 
        boldBox.AutoSize = True
        boldBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        boldBox.Location = New Point(34, 91)
        boldBox.Name = "boldBox"
        boldBox.Size = New Size(69, 27)
        boldBox.TabIndex = 1
        boldBox.Text = "Bold"
        boldBox.UseVisualStyleBackColor = True
        ' 
        ' italicBox
        ' 
        italicBox.AutoSize = True
        italicBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        italicBox.Location = New Point(34, 36)
        italicBox.Name = "italicBox"
        italicBox.Size = New Size(67, 27)
        italicBox.TabIndex = 0
        italicBox.Text = "Italic"
        italicBox.UseVisualStyleBackColor = True
        ' 
        ' colorBox
        ' 
        colorBox.Controls.Add(redButton)
        colorBox.Controls.Add(blueButton)
        colorBox.Controls.Add(greenButton)
        colorBox.Location = New Point(594, 217)
        colorBox.Name = "colorBox"
        colorBox.Size = New Size(194, 196)
        colorBox.TabIndex = 5
        colorBox.TabStop = False
        colorBox.Text = "Font Color"
        ' 
        ' redButton
        ' 
        redButton.AutoSize = True
        redButton.Location = New Point(58, 144)
        redButton.Name = "redButton"
        redButton.Size = New Size(56, 24)
        redButton.TabIndex = 2
        redButton.TabStop = True
        redButton.Text = "&Red"
        redButton.UseVisualStyleBackColor = True
        ' 
        ' blueButton
        ' 
        blueButton.AutoSize = True
        blueButton.Location = New Point(55, 92)
        blueButton.Name = "blueButton"
        blueButton.Size = New Size(59, 24)
        blueButton.TabIndex = 1
        blueButton.TabStop = True
        blueButton.Text = "&Blue"
        blueButton.UseVisualStyleBackColor = True
        ' 
        ' greenButton
        ' 
        greenButton.AutoSize = True
        greenButton.Location = New Point(55, 40)
        greenButton.Name = "greenButton"
        greenButton.Size = New Size(69, 24)
        greenButton.TabIndex = 0
        greenButton.TabStop = True
        greenButton.Text = "&Green"
        greenButton.UseVisualStyleBackColor = True
        ' 
        ' pictureButton
        ' 
        pictureButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pictureButton.Location = New Point(68, 440)
        pictureButton.Name = "pictureButton"
        pictureButton.Size = New Size(156, 47)
        pictureButton.TabIndex = 6
        pictureButton.Text = "&Load Picture"
        pictureButton.UseVisualStyleBackColor = True
        ' 
        ' exitButton2
        ' 
        exitButton2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exitButton2.Location = New Point(694, 440)
        exitButton2.Name = "exitButton2"
        exitButton2.Size = New Size(117, 47)
        exitButton2.TabIndex = 7
        exitButton2.Text = "E&xit"
        exitButton2.UseVisualStyleBackColor = True
        ' 
        ' objectdemoForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(925, 514)
        Controls.Add(exitButton2)
        Controls.Add(pictureButton)
        Controls.Add(colorBox)
        Controls.Add(fontstyleBox)
        Controls.Add(PictureBox)
        Controls.Add(fontBox)
        Controls.Add(displayBox)
        Name = "objectdemoForm"
        Text = "Object Demonstration"
        displayBox.ResumeLayout(False)
        displayBox.PerformLayout()
        fontBox.ResumeLayout(False)
        fontBox.PerformLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).EndInit()
        fontstyleBox.ResumeLayout(False)
        fontstyleBox.PerformLayout()
        colorBox.ResumeLayout(False)
        colorBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents displayBox As GroupBox
    Friend WithEvents sampletestBox As TextBox
    Friend WithEvents fontBox As GroupBox
    Friend WithEvents tahomaButton As RadioButton
    Friend WithEvents magnetoButton As RadioButton
    Friend WithEvents garamondButton As RadioButton
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents fontstyleBox As GroupBox
    Friend WithEvents bolditalicBox As CheckBox
    Friend WithEvents boldBox As CheckBox
    Friend WithEvents italicBox As CheckBox
    Friend WithEvents colorBox As GroupBox
    Friend WithEvents redButton As RadioButton
    Friend WithEvents blueButton As RadioButton
    Friend WithEvents greenButton As RadioButton
    Friend WithEvents pictureButton As Button
    Friend WithEvents exitButton2 As Button
End Class
