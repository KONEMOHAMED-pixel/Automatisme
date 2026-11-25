<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        t1 = New TextBox()
        t2 = New TextBox()
        t3 = New TextBox()
        l1 = New Label()
        l2 = New Label()
        Label9 = New Label()
        b1 = New Button()
        b2 = New Button()
        b3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.HighlightText
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(315, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 25)
        Label1.TabIndex = 0
        Label1.Text = "PARTIEL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 1
        Label2.Text = "Note 1 : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 2
        Label3.Text = "Note 2 : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(80, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 3
        Label4.Text = "Note 4 : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(80, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 4
        Label5.Text = "Moyenne : "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(80, 334)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 20)
        Label6.TabIndex = 5
        Label6.Text = "Appreciation : "
        ' 
        ' t1
        ' 
        t1.Location = New Point(151, 91)
        t1.Name = "t1"
        t1.Size = New Size(125, 27)
        t1.TabIndex = 6
        ' 
        ' t2
        ' 
        t2.Location = New Point(151, 146)
        t2.Name = "t2"
        t2.Size = New Size(125, 27)
        t2.TabIndex = 7
        ' 
        ' t3
        ' 
        t3.Location = New Point(151, 209)
        t3.Name = "t3"
        t3.Size = New Size(125, 27)
        t3.TabIndex = 8
        ' 
        ' l1
        ' 
        l1.AutoSize = True
        l1.Location = New Point(192, 282)
        l1.Name = "l1"
        l1.Size = New Size(0, 20)
        l1.TabIndex = 9
        ' 
        ' l2
        ' 
        l2.AutoSize = True
        l2.Location = New Point(197, 333)
        l2.Name = "l2"
        l2.Size = New Size(53, 20)
        l2.TabIndex = 10
        l2.Text = "Label8"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(251, 282)
        Label9.Name = "Label9"
        Label9.Size = New Size(31, 20)
        Label9.TabIndex = 11
        Label9.Text = "/20"
        ' 
        ' b1
        ' 
        b1.Location = New Point(212, 392)
        b1.Name = "b1"
        b1.Size = New Size(144, 46)
        b1.TabIndex = 12
        b1.Text = "VALIDER"
        b1.UseVisualStyleBackColor = True
        ' 
        ' b2
        ' 
        b2.Location = New Point(388, 392)
        b2.Name = "b2"
        b2.Size = New Size(132, 46)
        b2.TabIndex = 13
        b2.Text = "FIN"
        b2.UseVisualStyleBackColor = True
        ' 
        ' b3
        ' 
        b3.Location = New Point(44, 392)
        b3.Name = "b3"
        b3.Size = New Size(133, 46)
        b3.TabIndex = 14
        b3.Text = "VIDER"
        b3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(b3)
        Controls.Add(b2)
        Controls.Add(b1)
        Controls.Add(Label9)
        Controls.Add(l2)
        Controls.Add(l1)
        Controls.Add(t3)
        Controls.Add(t2)
        Controls.Add(t1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents t1 As TextBox
    Friend WithEvents t2 As TextBox
    Friend WithEvents t3 As TextBox
    Friend WithEvents l1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button

End Class
