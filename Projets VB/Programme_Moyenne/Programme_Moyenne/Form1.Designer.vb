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
        nudNote1 = New NumericUpDown()
        nudNote2 = New NumericUpDown()
        nudNote3 = New NumericUpDown()
        btnCalculer = New Button()
        lblMoyenne = New Label()
        CType(nudNote1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudNote2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudNote3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' nudNote1
        ' 
        nudNote1.Location = New Point(97, 133)
        nudNote1.Name = "nudNote1"
        nudNote1.Size = New Size(150, 27)
        nudNote1.TabIndex = 0
        ' 
        ' nudNote2
        ' 
        nudNote2.Location = New Point(97, 236)
        nudNote2.Name = "nudNote2"
        nudNote2.Size = New Size(150, 27)
        nudNote2.TabIndex = 1
        ' 
        ' nudNote3
        ' 
        nudNote3.Location = New Point(97, 338)
        nudNote3.Name = "nudNote3"
        nudNote3.Size = New Size(150, 27)
        nudNote3.TabIndex = 2
        ' 
        ' btnCalculer
        ' 
        btnCalculer.Location = New Point(406, 340)
        btnCalculer.Name = "btnCalculer"
        btnCalculer.Size = New Size(94, 29)
        btnCalculer.TabIndex = 3
        btnCalculer.Text = "Calculer"
        btnCalculer.UseVisualStyleBackColor = True
        ' 
        ' lblMoyenne
        ' 
        lblMoyenne.AutoSize = True
        lblMoyenne.Location = New Point(321, 78)
        lblMoyenne.Name = "lblMoyenne"
        lblMoyenne.Size = New Size(96, 20)
        lblMoyenne.TabIndex = 4
        lblMoyenne.Text = "Moyenne : —"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblMoyenne)
        Controls.Add(btnCalculer)
        Controls.Add(nudNote3)
        Controls.Add(nudNote2)
        Controls.Add(nudNote1)
        Name = "Form1"
        Text = "Form1"
        CType(nudNote1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudNote2, ComponentModel.ISupportInitialize).EndInit()
        CType(nudNote3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nudNote1 As NumericUpDown
    Friend WithEvents nudNote2 As NumericUpDown
    Friend WithEvents nudNote3 As NumericUpDown
    Friend WithEvents btnCalculer As Button
    Friend WithEvents lblMoyenne As Label

End Class
