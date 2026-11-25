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
        b1 = New Button()
        l1 = New Label()
        SuspendLayout()
        ' 
        ' b1
        ' 
        b1.Font = New Font("Segoe UI", 16F)
        b1.Location = New Point(390, 528)
        b1.Name = "b1"
        b1.Size = New Size(240, 59)
        b1.TabIndex = 0
        b1.Text = "FERMER"
        b1.UseVisualStyleBackColor = True
        ' 
        ' l1
        ' 
        l1.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        l1.Font = New Font("Segoe UI", 36F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        l1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        l1.Location = New Point(43, 143)
        l1.Name = "l1"
        l1.Size = New Size(966, 187)
        l1.TabIndex = 1
        l1.Text = "BIENVENU(E) AU CME"
        l1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1054, 642)
        Controls.Add(l1)
        Controls.Add(b1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents b1 As Button
    Friend WithEvents l1 As Label

End Class
