<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblSousTitre = New System.Windows.Forms.Label()
        Me.lblNiveau = New System.Windows.Forms.Label()
        Me.barNiveau = New System.Windows.Forms.ProgressBar()
        Me.lblPompe = New System.Windows.Forms.Label()
        Me.lblEtat = New System.Windows.Forms.Label()
        Me.lblSeuilBas = New System.Windows.Forms.Label()
        Me.lblSeuilHaut = New System.Windows.Forms.Label()
        Me.nudSeuilBas = New System.Windows.Forms.NumericUpDown()
        Me.nudSeuilHaut = New System.Windows.Forms.NumericUpDown()
        Me.lblRegle = New System.Windows.Forms.Label()
        Me.chkConsommation = New System.Windows.Forms.CheckBox()
        Me.btnDemarrer = New System.Windows.Forms.Button()
        Me.btnArreter = New System.Windows.Forms.Button()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.lblAide = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.nudSeuilBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeuilHaut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' Titre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitre.Location = New System.Drawing.Point(24, 20)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Text = "Remplissage automatique d'une cuve"
        Me.lblSousTitre.AutoSize = True
        Me.lblSousTitre.ForeColor = System.Drawing.Color.DimGray
        Me.lblSousTitre.Location = New System.Drawing.Point(26, 61)
        Me.lblSousTitre.Name = "lblSousTitre"
        Me.lblSousTitre.Text = "SIMULATION  •  Régulation tout ou rien avec hystérésis"
        '
        ' Niveau et pompe
        '
        Me.lblNiveau.AutoSize = True
        Me.lblNiveau.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblNiveau.Location = New System.Drawing.Point(24, 103)
        Me.lblNiveau.Name = "lblNiveau"
        Me.lblNiveau.Text = "Niveau : 10 %"
        Me.barNiveau.Location = New System.Drawing.Point(28, 146)
        Me.barNiveau.Maximum = 100
        Me.barNiveau.Minimum = 0
        Me.barNiveau.Name = "barNiveau"
        Me.barNiveau.Size = New System.Drawing.Size(584, 32)
        Me.barNiveau.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barNiveau.Value = 10
        Me.lblPompe.AutoSize = True
        Me.lblPompe.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPompe.Location = New System.Drawing.Point(24, 194)
        Me.lblPompe.Name = "lblPompe"
        Me.lblPompe.Text = "Pompe : ARRÊT"
        Me.lblEtat.AutoSize = True
        Me.lblEtat.Location = New System.Drawing.Point(26, 227)
        Me.lblEtat.Name = "lblEtat"
        Me.lblEtat.Text = "Régulation arrêtée — simulation en pause."
        '
        ' Réglage des seuils
        '
        Me.lblSeuilBas.AutoSize = True
        Me.lblSeuilBas.Location = New System.Drawing.Point(26, 278)
        Me.lblSeuilBas.Name = "lblSeuilBas"
        Me.lblSeuilBas.Text = "Seuil bas (%)"
        Me.nudSeuilBas.Location = New System.Drawing.Point(132, 273)
        Me.nudSeuilBas.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudSeuilBas.Name = "nudSeuilBas"
        Me.nudSeuilBas.Size = New System.Drawing.Size(74, 25)
        Me.nudSeuilBas.TabIndex = 0
        Me.nudSeuilBas.Value = New Decimal(New Integer() {20, 0, 0, 0})
        Me.lblSeuilHaut.AutoSize = True
        Me.lblSeuilHaut.Location = New System.Drawing.Point(294, 278)
        Me.lblSeuilHaut.Name = "lblSeuilHaut"
        Me.lblSeuilHaut.Text = "Seuil haut (%)"
        Me.nudSeuilHaut.Location = New System.Drawing.Point(410, 273)
        Me.nudSeuilHaut.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSeuilHaut.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudSeuilHaut.Name = "nudSeuilHaut"
        Me.nudSeuilHaut.Size = New System.Drawing.Size(74, 25)
        Me.nudSeuilHaut.TabIndex = 1
        Me.nudSeuilHaut.Value = New Decimal(New Integer() {90, 0, 0, 0})
        Me.lblRegle.AutoSize = True
        Me.lblRegle.ForeColor = System.Drawing.Color.DimGray
        Me.lblRegle.Location = New System.Drawing.Point(26, 313)
        Me.lblRegle.Name = "lblRegle"
        Me.lblRegle.Text = "Entre les deux seuils, la pompe conserve son état."
        '
        ' Consommation et boutons
        '
        Me.chkConsommation.AutoSize = True
        Me.chkConsommation.Checked = True
        Me.chkConsommation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConsommation.Location = New System.Drawing.Point(28, 353)
        Me.chkConsommation.Name = "chkConsommation"
        Me.chkConsommation.TabIndex = 2
        Me.chkConsommation.Text = "Simuler une consommation d'eau"
        Me.chkConsommation.UseVisualStyleBackColor = True
        Me.btnDemarrer.Location = New System.Drawing.Point(28, 401)
        Me.btnDemarrer.Name = "btnDemarrer"
        Me.btnDemarrer.Size = New System.Drawing.Size(178, 40)
        Me.btnDemarrer.TabIndex = 3
        Me.btnDemarrer.Text = "Démarrer"
        Me.btnDemarrer.UseVisualStyleBackColor = True
        Me.btnArreter.Location = New System.Drawing.Point(230, 401)
        Me.btnArreter.Name = "btnArreter"
        Me.btnArreter.Size = New System.Drawing.Size(178, 40)
        Me.btnArreter.TabIndex = 4
        Me.btnArreter.Text = "Arrêter"
        Me.btnArreter.UseVisualStyleBackColor = True
        Me.btnReinitialiser.Location = New System.Drawing.Point(434, 401)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(178, 40)
        Me.btnReinitialiser.TabIndex = 5
        Me.btnReinitialiser.Text = "Réinitialiser à 10 %"
        Me.btnReinitialiser.UseVisualStyleBackColor = True
        Me.lblAide.AutoSize = True
        Me.lblAide.ForeColor = System.Drawing.Color.DimGray
        Me.lblAide.Location = New System.Drawing.Point(26, 466)
        Me.lblAide.Name = "lblAide"
        Me.lblAide.Text = "Pas : 1 seconde. Pompe : +5 points ; consommation : -1 point."
        '
        ' Timer1 et fenêtre
        '
        Me.Timer1.Interval = 1000
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(640, 510)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {
            Me.lblTitre, Me.lblSousTitre, Me.lblNiveau, Me.barNiveau,
            Me.lblPompe, Me.lblEtat, Me.lblSeuilBas, Me.lblSeuilHaut,
            Me.nudSeuilBas, Me.nudSeuilHaut, Me.lblRegle, Me.chkConsommation,
            Me.btnDemarrer, Me.btnArreter, Me.btnReinitialiser, Me.lblAide})
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Régulation du remplissage d'une cuve d'eau"
        CType(Me.nudSeuilBas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeuilHaut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblSousTitre As System.Windows.Forms.Label
    Friend WithEvents lblNiveau As System.Windows.Forms.Label
    Friend WithEvents barNiveau As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPompe As System.Windows.Forms.Label
    Friend WithEvents lblEtat As System.Windows.Forms.Label
    Friend WithEvents lblSeuilBas As System.Windows.Forms.Label
    Friend WithEvents lblSeuilHaut As System.Windows.Forms.Label
    Friend WithEvents nudSeuilBas As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSeuilHaut As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRegle As System.Windows.Forms.Label
    Friend WithEvents chkConsommation As System.Windows.Forms.CheckBox
    Friend WithEvents btnDemarrer As System.Windows.Forms.Button
    Friend WithEvents btnArreter As System.Windows.Forms.Button
    Friend WithEvents btnReinitialiser As System.Windows.Forms.Button
    Friend WithEvents lblAide As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
