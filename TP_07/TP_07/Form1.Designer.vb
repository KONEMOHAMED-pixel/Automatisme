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
        t1 = New TextBox()
        t2 = New TextBox()
        l1 = New Label()
        l2 = New Label()
        b3 = New Button()
        b2 = New Button()
        b1 = New Button()
        l9 = New Label()
        l7 = New Label()
        l8 = New Label()
        l4 = New Label()
        l3 = New Label()
        l5 = New Label()
        l6 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' t1
        ' 
        t1.Font = New Font("Segoe UI", 14F)
        t1.Location = New Point(358, 199)
        t1.Name = "t1"
        t1.Size = New Size(138, 39)
        t1.TabIndex = 0
        ' 
        ' t2
        ' 
        t2.Font = New Font("Segoe UI", 14F)
        t2.Location = New Point(358, 258)
        t2.Name = "t2"
        t2.Size = New Size(138, 39)
        t2.TabIndex = 1
        ' 
        ' l1
        ' 
        l1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        l1.Font = New Font("Segoe UI", 14F)
        l1.Location = New Point(149, 198)
        l1.Name = "l1"
        l1.Size = New Size(124, 39)
        l1.TabIndex = 2
        l1.Text = "Quantité:"
        l1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l2
        ' 
        l2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        l2.Font = New Font("Segoe UI", 14F)
        l2.Location = New Point(175, 260)
        l2.Name = "l2"
        l2.Size = New Size(98, 33)
        l2.TabIndex = 3
        l2.Text = "Prix Unitaire:"
        l2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' b3
        ' 
        b3.Font = New Font("Segoe UI", 14F)
        b3.Location = New Point(103, 481)
        b3.Name = "b3"
        b3.Size = New Size(211, 59)
        b3.TabIndex = 4
        b3.Text = "&RECOMMENCER"
        b3.UseVisualStyleBackColor = True
        ' 
        ' b2
        ' 
        b2.Font = New Font("Segoe UI", 14F)
        b2.Location = New Point(625, 481)
        b2.Name = "b2"
        b2.Size = New Size(165, 59)
        b2.TabIndex = 5
        b2.Text = "&FERMER"
        b2.UseVisualStyleBackColor = True
        ' 
        ' b1
        ' 
        b1.Font = New Font("Segoe UI", 14F)
        b1.Location = New Point(373, 481)
        b1.Name = "b1"
        b1.Size = New Size(163, 59)
        b1.TabIndex = 6
        b1.Text = "&OK"
        b1.UseVisualStyleBackColor = True
        ' 
        ' l9
        ' 
        l9.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        l9.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Underline)
        l9.Location = New Point(273, 50)
        l9.Name = "l9"
        l9.Size = New Size(659, 39)
        l9.TabIndex = 7
        l9.Text = "VALEUR D'UN ARTICLE"
        l9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l7
        ' 
        l7.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        l7.Font = New Font("Segoe UI", 14F)
        l7.Location = New Point(513, 349)
        l7.Name = "l7"
        l7.Size = New Size(124, 39)
        l7.TabIndex = 8
        l7.Text = "F.cfa"
        l7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l8
        ' 
        l8.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        l8.Font = New Font("Segoe UI", 14F)
        l8.Location = New Point(513, 414)
        l8.Name = "l8"
        l8.Size = New Size(124, 39)
        l8.TabIndex = 9
        l8.Text = "F.cfa"
        l8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l4
        ' 
        l4.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        l4.Font = New Font("Segoe UI", 14F)
        l4.Location = New Point(131, 414)
        l4.Name = "l4"
        l4.Size = New Size(171, 39)
        l4.TabIndex = 10
        l4.Text = "Montant TTC:"
        l4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l3
        ' 
        l3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        l3.Font = New Font("Segoe UI", 14F)
        l3.Location = New Point(131, 349)
        l3.Name = "l3"
        l3.Size = New Size(171, 39)
        l3.TabIndex = 11
        l3.Text = "Montant HT:"
        l3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l5
        ' 
        l5.BackColor = Color.White
        l5.Font = New Font("Segoe UI", 14F)
        l5.Location = New Point(341, 349)
        l5.Name = "l5"
        l5.Size = New Size(124, 39)
        l5.TabIndex = 12
        l5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l6
        ' 
        l6.BackColor = Color.White
        l6.Font = New Font("Segoe UI", 14F)
        l6.Location = New Point(341, 414)
        l6.Name = "l6"
        l6.Size = New Size(124, 39)
        l6.TabIndex = 13
        l6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14F)
        Button1.Location = New Point(851, 198)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 59)
        Button1.TabIndex = 14
        Button1.Text = "&OK2"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1075, 647)
        Controls.Add(Button1)
        Controls.Add(l6)
        Controls.Add(l5)
        Controls.Add(l3)
        Controls.Add(l4)
        Controls.Add(l8)
        Controls.Add(l7)
        Controls.Add(l9)
        Controls.Add(b1)
        Controls.Add(b2)
        Controls.Add(b3)
        Controls.Add(l2)
        Controls.Add(l1)
        Controls.Add(t2)
        Controls.Add(t1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents t1 As TextBox
    Friend WithEvents t2 As TextBox
    Friend WithEvents l1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents b3 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents l9 As Label
    Friend WithEvents l7 As Label
    Friend WithEvents l8 As Label
    Friend WithEvents l4 As Label
    Friend WithEvents l3 As Label
    Friend WithEvents l5 As Label
    Friend WithEvents l6 As Label
    Friend WithEvents Button1 As Button

End Class
