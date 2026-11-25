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
        r1 = New RadioButton()
        b3 = New Button()
        t1 = New TextBox()
        r2 = New RadioButton()
        r3 = New RadioButton()
        b1 = New Button()
        b2 = New Button()
        l1 = New Label()
        l2 = New Label()
        l3 = New Label()
        l4 = New Label()
        SuspendLayout()
        ' 
        ' r1
        ' 
        r1.AutoSize = True
        r1.Font = New Font("Segoe UI", 14F)
        r1.Location = New Point(331, 142)
        r1.Name = "r1"
        r1.Size = New Size(137, 36)
        r1.TabIndex = 0
        r1.TabStop = True
        r1.Text = "Périmètre"
        r1.TextAlign = ContentAlignment.MiddleCenter
        r1.UseVisualStyleBackColor = True
        ' 
        ' b3
        ' 
        b3.Font = New Font("Segoe UI", 14F)
        b3.Location = New Point(84, 426)
        b3.Name = "b3"
        b3.Size = New Size(192, 64)
        b3.TabIndex = 1
        b3.Text = "&RECOMMENCER"
        b3.UseVisualStyleBackColor = True
        ' 
        ' t1
        ' 
        t1.Font = New Font("Segoe UI", 14F)
        t1.Location = New Point(223, 82)
        t1.Name = "t1"
        t1.Size = New Size(331, 39)
        t1.TabIndex = 2
        ' 
        ' r2
        ' 
        r2.AutoSize = True
        r2.Font = New Font("Segoe UI", 14F)
        r2.Location = New Point(331, 203)
        r2.Name = "r2"
        r2.Size = New Size(150, 36)
        r2.TabIndex = 3
        r2.TabStop = True
        r2.Text = "Aire Cercle"
        r2.TextAlign = ContentAlignment.MiddleCenter
        r2.UseVisualStyleBackColor = True
        ' 
        ' r3
        ' 
        r3.AutoSize = True
        r3.Font = New Font("Segoe UI", 14F)
        r3.Location = New Point(331, 274)
        r3.Name = "r3"
        r3.Size = New Size(450, 36)
        r3.TabIndex = 4
        r3.TabStop = True
        r3.Text = "Somme de 10 entiers avant ce nombre"
        r3.UseVisualStyleBackColor = True
        ' 
        ' b1
        ' 
        b1.Font = New Font("Segoe UI", 14F)
        b1.Location = New Point(354, 426)
        b1.Name = "b1"
        b1.Size = New Size(192, 64)
        b1.TabIndex = 5
        b1.Text = "&OK"
        b1.UseVisualStyleBackColor = True
        ' 
        ' b2
        ' 
        b2.Font = New Font("Segoe UI", 14F)
        b2.Location = New Point(624, 426)
        b2.Name = "b2"
        b2.Size = New Size(192, 64)
        b2.TabIndex = 6
        b2.Text = "&FERMER"
        b2.TextAlign = ContentAlignment.BottomLeft
        b2.UseVisualStyleBackColor = True
        ' 
        ' l1
        ' 
        l1.AutoSize = True
        l1.Font = New Font("Segoe UI", 14F)
        l1.Location = New Point(223, 359)
        l1.Name = "l1"
        l1.Size = New Size(120, 32)
        l1.TabIndex = 7
        l1.Text = "RESULTAT:"
        l1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l2
        ' 
        l2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        l2.Font = New Font("Segoe UI", 14F)
        l2.Location = New Point(376, 359)
        l2.Name = "l2"
        l2.Size = New Size(119, 44)
        l2.TabIndex = 8
        ' 
        ' l3
        ' 
        l3.AutoSize = True
        l3.Font = New Font("Segoe UI", 14F)
        l3.Location = New Point(70, 89)
        l3.Name = "l3"
        l3.Size = New Size(87, 32)
        l3.TabIndex = 9
        l3.Text = "Entier :"
        l3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l4
        ' 
        l4.AutoSize = True
        l4.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        l4.Location = New Point(272, 9)
        l4.Name = "l4"
        l4.Size = New Size(162, 37)
        l4.TabIndex = 10
        l4.Text = "EXERCICE 8"
        l4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 531)
        Controls.Add(l4)
        Controls.Add(l3)
        Controls.Add(l2)
        Controls.Add(l1)
        Controls.Add(b2)
        Controls.Add(b1)
        Controls.Add(r3)
        Controls.Add(r2)
        Controls.Add(t1)
        Controls.Add(b3)
        Controls.Add(r1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents r1 As RadioButton
    Friend WithEvents b3 As Button
    Friend WithEvents t1 As TextBox
    Friend WithEvents r2 As RadioButton
    Friend WithEvents r3 As RadioButton
    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents l1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents l3 As Label
    Friend WithEvents l4 As Label

End Class
