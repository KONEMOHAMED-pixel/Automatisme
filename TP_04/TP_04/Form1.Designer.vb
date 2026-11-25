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
        l1 = New Label()
        b1 = New Button()
        t1 = New TextBox()
        l2 = New Label()
        b2 = New Button()
        b3 = New Button()
        SuspendLayout()
        ' 
        ' l1
        ' 
        l1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        l1.Font = New Font("Segoe UI", 36F, FontStyle.Bold)
        l1.Location = New Point(12, 118)
        l1.Name = "l1"
        l1.Size = New Size(911, 152)
        l1.TabIndex = 0
        l1.Text = "WELCOME"
        l1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' b1
        ' 
        b1.Location = New Point(372, 509)
        b1.Name = "b1"
        b1.Size = New Size(218, 61)
        b1.TabIndex = 1
        b1.Text = "&Click"
        b1.UseVisualStyleBackColor = True
        ' 
        ' t1
        ' 
        t1.Location = New Point(236, 427)
        t1.Name = "t1"
        t1.Size = New Size(464, 27)
        t1.TabIndex = 4
        ' 
        ' l2
        ' 
        l2.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        l2.Location = New Point(32, 415)
        l2.Name = "l2"
        l2.Size = New Size(198, 51)
        l2.TabIndex = 5
        l2.Text = "Votre nom:"
        l2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' b2
        ' 
        b2.Location = New Point(690, 509)
        b2.Name = "b2"
        b2.Size = New Size(218, 61)
        b2.TabIndex = 6
        b2.Text = "&FERMER"
        b2.UseVisualStyleBackColor = True
        ' 
        ' b3
        ' 
        b3.Location = New Point(45, 509)
        b3.Name = "b3"
        b3.Size = New Size(218, 61)
        b3.TabIndex = 7
        b3.Text = "&RECOMMENCER"
        b3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(935, 669)
        Controls.Add(b3)
        Controls.Add(b2)
        Controls.Add(l2)
        Controls.Add(t1)
        Controls.Add(b1)
        Controls.Add(l1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents l1 As Label
    Friend WithEvents b1 As Button
    Friend WithEvents t1 As TextBox
    Friend WithEvents l2 As Label
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button

End Class
