<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        txtAdvice1 = New TextBox()
        txtAdvice2 = New TextBox()
        txtAdvice3 = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(131, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 0
        Label1.Text = "Advice 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 1
        Label2.Text = "Advice 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(131, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 2
        Label3.Text = "Advice 3"
        ' 
        ' Button1
        ' 
        Button1.AllowDrop = True
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(235, 343)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 62)
        Button1.TabIndex = 3
        Button1.Tag = "Advice for Young people"
        Button1.Text = "Show message"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SeaShell
        Button2.Location = New Point(501, 351)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 54)
        Button2.TabIndex = 4
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtAdvice1
        ' 
        txtAdvice1.Location = New Point(284, 109)
        txtAdvice1.Name = "txtAdvice1"
        txtAdvice1.Size = New Size(300, 27)
        txtAdvice1.TabIndex = 5
        txtAdvice1.Text = "1) "
        ' 
        ' txtAdvice2
        ' 
        txtAdvice2.Location = New Point(284, 189)
        txtAdvice2.Name = "txtAdvice2"
        txtAdvice2.Size = New Size(300, 27)
        txtAdvice2.TabIndex = 6
        txtAdvice2.Text = "2) "
        ' 
        ' txtAdvice3
        ' 
        txtAdvice3.Location = New Point(284, 262)
        txtAdvice3.Name = "txtAdvice3"
        txtAdvice3.Size = New Size(300, 27)
        txtAdvice3.TabIndex = 7
        txtAdvice3.Text = "3)"
        ' 
        ' Label4
        ' 
        Label4.BackColor = SystemColors.ControlLightLight
        Label4.Location = New Point(307, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 30)
        Label4.TabIndex = 8
        Label4.Text = "Advice for Young People"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(txtAdvice3)
        Controls.Add(txtAdvice2)
        Controls.Add(txtAdvice1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Advice For Young People"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtAdvice1 As TextBox
    Friend WithEvents txtAdvice2 As TextBox
    Friend WithEvents txtAdvice3 As TextBox
    Friend WithEvents Label4 As Label
End Class
