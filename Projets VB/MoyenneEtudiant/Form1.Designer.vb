<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer

    <Global.System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <Global.System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblConsigne = New System.Windows.Forms.Label()
        Me.lblNote1 = New System.Windows.Forms.Label()
        Me.lblNote2 = New System.Windows.Forms.Label()
        Me.lblNote3 = New System.Windows.Forms.Label()
        Me.nudNote1 = New System.Windows.Forms.NumericUpDown()
        Me.nudNote2 = New System.Windows.Forms.NumericUpDown()
        Me.nudNote3 = New System.Windows.Forms.NumericUpDown()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.lblMoyenne = New System.Windows.Forms.Label()
        Me.lblAppreciation = New System.Windows.Forms.Label()
        CType(Me.nudNote1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNote2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNote3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTitre.Location = New System.Drawing.Point(28, 22)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(349, 41)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Moyenne d'un étudiant"
        '
        'lblConsigne
        '
        Me.lblConsigne.AutoSize = True
        Me.lblConsigne.Location = New System.Drawing.Point(30, 66)
        Me.lblConsigne.Name = "lblConsigne"
        Me.lblConsigne.Size = New System.Drawing.Size(344, 23)
        Me.lblConsigne.TabIndex = 1
        Me.lblConsigne.Text = "Trois notes sur 20, avec le même coefficient."
        '
        'lblNote1
        '
        Me.lblNote1.AutoSize = True
        Me.lblNote1.Location = New System.Drawing.Point(30, 119)
        Me.lblNote1.Name = "lblNote1"
        Me.lblNote1.Size = New System.Drawing.Size(62, 23)
        Me.lblNote1.TabIndex = 2
        Me.lblNote1.Text = "Note &1"
        '
        'lblNote2
        '
        Me.lblNote2.AutoSize = True
        Me.lblNote2.Location = New System.Drawing.Point(30, 166)
        Me.lblNote2.Name = "lblNote2"
        Me.lblNote2.Size = New System.Drawing.Size(62, 23)
        Me.lblNote2.TabIndex = 4
        Me.lblNote2.Text = "Note &2"
        '
        'lblNote3
        '
        Me.lblNote3.AutoSize = True
        Me.lblNote3.Location = New System.Drawing.Point(30, 213)
        Me.lblNote3.Name = "lblNote3"
        Me.lblNote3.Size = New System.Drawing.Size(62, 23)
        Me.lblNote3.TabIndex = 6
        Me.lblNote3.Text = "Note &3"
        '
        'nudNote1
        '
        Me.nudNote1.DecimalPlaces = 2
        Me.nudNote1.Increment = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.nudNote1.Location = New System.Drawing.Point(120, 116)
        Me.nudNote1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudNote1.Name = "nudNote1"
        Me.nudNote1.Size = New System.Drawing.Size(130, 30)
        Me.nudNote1.TabIndex = 3
        Me.nudNote1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudNote2
        '
        Me.nudNote2.DecimalPlaces = 2
        Me.nudNote2.Increment = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.nudNote2.Location = New System.Drawing.Point(120, 163)
        Me.nudNote2.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudNote2.Name = "nudNote2"
        Me.nudNote2.Size = New System.Drawing.Size(130, 30)
        Me.nudNote2.TabIndex = 5
        Me.nudNote2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudNote3
        '
        Me.nudNote3.DecimalPlaces = 2
        Me.nudNote3.Increment = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.nudNote3.Location = New System.Drawing.Point(120, 210)
        Me.nudNote3.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudNote3.Name = "nudNote3"
        Me.nudNote3.Size = New System.Drawing.Size(130, 30)
        Me.nudNote3.TabIndex = 7
        Me.nudNote3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculer
        '
        Me.btnCalculer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCalculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculer.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculer.ForeColor = System.Drawing.Color.White
        Me.btnCalculer.Location = New System.Drawing.Point(293, 155)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(154, 46)
        Me.btnCalculer.TabIndex = 8
        Me.btnCalculer.Text = "&Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = False
        '
        'lblMoyenne
        '
        Me.lblMoyenne.AutoSize = True
        Me.lblMoyenne.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMoyenne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblMoyenne.Location = New System.Drawing.Point(29, 283)
        Me.lblMoyenne.Name = "lblMoyenne"
        Me.lblMoyenne.Size = New System.Drawing.Size(166, 32)
        Me.lblMoyenne.TabIndex = 9
        Me.lblMoyenne.Text = "Moyenne : —"
        '
        'lblAppreciation
        '
        Me.lblAppreciation.AutoSize = True
        Me.lblAppreciation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblAppreciation.Location = New System.Drawing.Point(30, 328)
        Me.lblAppreciation.Name = "lblAppreciation"
        Me.lblAppreciation.Size = New System.Drawing.Size(159, 28)
        Me.lblAppreciation.TabIndex = 10
        Me.lblAppreciation.Text = "Appréciation : —"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(490, 390)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.lblConsigne)
        Me.Controls.Add(Me.lblNote1)
        Me.Controls.Add(Me.nudNote1)
        Me.Controls.Add(Me.lblNote2)
        Me.Controls.Add(Me.nudNote2)
        Me.Controls.Add(Me.lblNote3)
        Me.Controls.Add(Me.nudNote3)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.lblMoyenne)
        Me.Controls.Add(Me.lblAppreciation)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcul de moyenne"
        CType(Me.nudNote1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNote2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNote3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Global.System.Windows.Forms.Label
    Friend WithEvents lblConsigne As Global.System.Windows.Forms.Label
    Friend WithEvents lblNote1 As Global.System.Windows.Forms.Label
    Friend WithEvents lblNote2 As Global.System.Windows.Forms.Label
    Friend WithEvents lblNote3 As Global.System.Windows.Forms.Label
    Friend WithEvents nudNote1 As Global.System.Windows.Forms.NumericUpDown
    Friend WithEvents nudNote2 As Global.System.Windows.Forms.NumericUpDown
    Friend WithEvents nudNote3 As Global.System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCalculer As Global.System.Windows.Forms.Button
    Friend WithEvents lblMoyenne As Global.System.Windows.Forms.Label
    Friend WithEvents lblAppreciation As Global.System.Windows.Forms.Label
End Class
