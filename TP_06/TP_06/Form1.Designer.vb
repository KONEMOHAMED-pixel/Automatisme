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
        t3 = New TextBox()
        b3 = New Button()
        t1 = New TextBox()
        t2 = New TextBox()
        b2 = New Button()
        b1 = New Button()
        l1 = New Label()
        l2 = New Label()
        l3 = New Label()
        l5 = New Label()
        l4 = New Label()
        l6 = New Label()
        l7 = New Label()
        l8 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' t3
        ' 
        t3.Font = New Font("Segoe UI", 14F)
        t3.Location = New Point(332, 367)
        t3.Name = "t3"
        t3.Size = New Size(125, 39)
        t3.TabIndex = 1
        t3.TextAlign = HorizontalAlignment.Center
        ' 
        ' b3
        ' 
        b3.Location = New Point(85, 589)
        b3.Name = "b3"
        b3.Size = New Size(192, 69)
        b3.TabIndex = 2
        b3.Text = "RECOMMENCER"
        b3.UseVisualStyleBackColor = True
        ' 
        ' t1
        ' 
        t1.Font = New Font("Segoe UI", 14F)
        t1.Location = New Point(332, 235)
        t1.Name = "t1"
        t1.Size = New Size(125, 39)
        t1.TabIndex = 3
        t1.TextAlign = HorizontalAlignment.Center
        ' 
        ' t2
        ' 
        t2.Font = New Font("Segoe UI", 14F)
        t2.Location = New Point(332, 302)
        t2.Name = "t2"
        t2.Size = New Size(125, 39)
        t2.TabIndex = 4
        t2.TextAlign = HorizontalAlignment.Center
        ' 
        ' b2
        ' 
        b2.Location = New Point(528, 589)
        b2.Name = "b2"
        b2.Size = New Size(185, 69)
        b2.TabIndex = 5
        b2.Text = "FERMER"
        b2.UseVisualStyleBackColor = True
        ' 
        ' b1
        ' 
        b1.Location = New Point(312, 589)
        b1.Name = "b1"
        b1.Size = New Size(180, 69)
        b1.TabIndex = 6
        b1.Text = "OK"
        b1.UseVisualStyleBackColor = True
        ' 
        ' l1
        ' 
        l1.Font = New Font("Segoe UI", 14F)
        l1.Location = New Point(165, 235)
        l1.Name = "l1"
        l1.Size = New Size(98, 27)
        l1.TabIndex = 9
        l1.Text = "NOT1:"
        l1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l2
        ' 
        l2.Font = New Font("Segoe UI", 14F)
        l2.Location = New Point(165, 314)
        l2.Name = "l2"
        l2.Size = New Size(98, 27)
        l2.TabIndex = 10
        l2.Text = "NOT2:"
        l2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l3
        ' 
        l3.Font = New Font("Segoe UI", 14F)
        l3.Location = New Point(165, 379)
        l3.Name = "l3"
        l3.Size = New Size(98, 27)
        l3.TabIndex = 11
        l3.Text = "NOTE3:"
        l3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l5
        ' 
        l5.Font = New Font("Segoe UI", 14F)
        l5.Location = New Point(165, 498)
        l5.Name = "l5"
        l5.Size = New Size(98, 27)
        l5.TabIndex = 12
        l5.Text = "DECISION"
        l5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l4
        ' 
        l4.Font = New Font("Segoe UI", 14F)
        l4.Location = New Point(165, 456)
        l4.Name = "l4"
        l4.Size = New Size(128, 27)
        l4.TabIndex = 13
        l4.Text = "MOYENNE:"
        l4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l6
        ' 
        l6.Font = New Font("Segoe UI", 14F)
        l6.Location = New Point(287, 456)
        l6.Name = "l6"
        l6.Size = New Size(98, 27)
        l6.TabIndex = 14
        l6.Text = "Label6"
        l6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l7
        ' 
        l7.Font = New Font("Segoe UI", 14F)
        l7.Location = New Point(287, 498)
        l7.Name = "l7"
        l7.Size = New Size(98, 27)
        l7.TabIndex = 15
        l7.Text = "Label7"
        l7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l8
        ' 
        l8.Font = New Font("Segoe UI", 14F)
        l8.Location = New Point(380, 456)
        l8.Name = "l8"
        l8.Size = New Size(98, 27)
        l8.TabIndex = 16
        l8.Text = "/20"
        l8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 36F, FontStyle.Bold)
        Label9.Location = New Point(56, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(833, 139)
        Label9.TabIndex = 17
        Label9.Text = "RELEVES PARTIEL 2025"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(973, 693)
        Controls.Add(Label9)
        Controls.Add(l8)
        Controls.Add(l7)
        Controls.Add(l6)
        Controls.Add(l4)
        Controls.Add(l5)
        Controls.Add(l3)
        Controls.Add(l2)
        Controls.Add(l1)
        Controls.Add(b1)
        Controls.Add(b2)
        Controls.Add(t2)
        Controls.Add(t1)
        Controls.Add(b3)
        Controls.Add(t3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents l1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents l3 As Label
    Friend WithEvents l5 As Label
    Friend WithEvents l4 As Label
    Friend WithEvents l6 As Label
    Friend WithEvents l7 As Label
    Friend WithEvents l8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents t3 As TextBox
    Friend WithEvents b3 As Button
    Friend WithEvents t1 As TextBox
    Friend WithEvents t2 As TextBox
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents l2 As Label
    Friend WithEvents l1 As Label

End Class
