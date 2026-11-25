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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        TITRE = New Label()
        LabelNiveau = New Label()
        LabelErreur = New Label()
        LabelVanne = New Label()
        Affich_consigne = New Label()
        Affich_niveau = New Label()
        Affich_erreur = New Label()
        Affich_vanne = New Label()
        BP_START = New Button()
        BP_STOP = New Button()
        BP_RESTART = New Button()
        TextBoxConsigne = New TextBox()
        LabelConsigne = New Label()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 500
        ' 
        ' TITRE
        ' 
        TITRE.AutoSize = True
        TITRE.BackColor = Color.Black
        TITRE.Font = New Font("Malgun Gothic", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TITRE.ForeColor = Color.Red
        TITRE.Location = New Point(62, 9)
        TITRE.Name = "TITRE"
        TITRE.Size = New Size(945, 81)
        TITRE.TabIndex = 0
        TITRE.Text = "REMPLISSAGE DE CUVES A EAU"
        ' 
        ' LabelNiveau
        ' 
        LabelNiveau.AutoSize = True
        LabelNiveau.Font = New Font("Siemens Sans SC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNiveau.Location = New Point(281, 196)
        LabelNiveau.Name = "LabelNiveau"
        LabelNiveau.Size = New Size(100, 36)
        LabelNiveau.TabIndex = 2
        LabelNiveau.Text = "Label2"
        ' 
        ' LabelErreur
        ' 
        LabelErreur.AutoSize = True
        LabelErreur.Font = New Font("Siemens Sans SC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelErreur.Location = New Point(281, 273)
        LabelErreur.Name = "LabelErreur"
        LabelErreur.Size = New Size(100, 36)
        LabelErreur.TabIndex = 3
        LabelErreur.Text = "Label3"
        ' 
        ' LabelVanne
        ' 
        LabelVanne.AutoSize = True
        LabelVanne.Font = New Font("Siemens Sans SC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelVanne.Location = New Point(276, 345)
        LabelVanne.Name = "LabelVanne"
        LabelVanne.Size = New Size(101, 36)
        LabelVanne.TabIndex = 4
        LabelVanne.Text = "Label4"
        ' 
        ' Affich_consigne
        ' 
        Affich_consigne.AutoSize = True
        Affich_consigne.BackColor = Color.DarkOrange
        Affich_consigne.Font = New Font("Siemens Sans", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Affich_consigne.Location = New Point(594, 404)
        Affich_consigne.Name = "Affich_consigne"
        Affich_consigne.Size = New Size(230, 45)
        Affich_consigne.TabIndex = 5
        Affich_consigne.Text = "CONSIGNE : "
        ' 
        ' Affich_niveau
        ' 
        Affich_niveau.AutoSize = True
        Affich_niveau.BackColor = Color.Gold
        Affich_niveau.Font = New Font("Siemens Sans", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Affich_niveau.Location = New Point(79, 187)
        Affich_niveau.Name = "Affich_niveau"
        Affich_niveau.Size = New Size(182, 45)
        Affich_niveau.TabIndex = 6
        Affich_niveau.Text = "NIVEAU : "
        ' 
        ' Affich_erreur
        ' 
        Affich_erreur.AutoSize = True
        Affich_erreur.BackColor = Color.Magenta
        Affich_erreur.Font = New Font("Siemens Sans SC Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Affich_erreur.Location = New Point(106, 273)
        Affich_erreur.Name = "Affich_erreur"
        Affich_erreur.Size = New Size(155, 36)
        Affich_erreur.TabIndex = 7
        Affich_erreur.Text = "ERREUR : "
        ' 
        ' Affich_vanne
        ' 
        Affich_vanne.AutoSize = True
        Affich_vanne.BackColor = Color.Green
        Affich_vanne.Font = New Font("Siemens Sans SC", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Affich_vanne.Location = New Point(121, 345)
        Affich_vanne.Name = "Affich_vanne"
        Affich_vanne.Size = New Size(140, 36)
        Affich_vanne.TabIndex = 8
        Affich_vanne.Text = "VANNE : "
        ' 
        ' BP_START
        ' 
        BP_START.BackColor = Color.LimeGreen
        BP_START.FlatStyle = FlatStyle.Popup
        BP_START.Font = New Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BP_START.Location = New Point(506, 486)
        BP_START.Name = "BP_START"
        BP_START.Size = New Size(162, 61)
        BP_START.TabIndex = 9
        BP_START.Text = "START"
        BP_START.UseVisualStyleBackColor = False
        ' 
        ' BP_STOP
        ' 
        BP_STOP.BackColor = Color.Red
        BP_STOP.FlatStyle = FlatStyle.Popup
        BP_STOP.Font = New Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BP_STOP.Location = New Point(686, 486)
        BP_STOP.Name = "BP_STOP"
        BP_STOP.Size = New Size(157, 61)
        BP_STOP.TabIndex = 10
        BP_STOP.Text = "STOP"
        BP_STOP.UseVisualStyleBackColor = False
        ' 
        ' BP_RESTART
        ' 
        BP_RESTART.BackColor = Color.MidnightBlue
        BP_RESTART.FlatStyle = FlatStyle.Popup
        BP_RESTART.Font = New Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BP_RESTART.ForeColor = Color.Red
        BP_RESTART.Location = New Point(859, 486)
        BP_RESTART.Name = "BP_RESTART"
        BP_RESTART.Size = New Size(162, 61)
        BP_RESTART.TabIndex = 11
        BP_RESTART.Text = "RESTART"
        BP_RESTART.UseVisualStyleBackColor = False
        ' 
        ' TextBoxConsigne
        ' 
        TextBoxConsigne.Font = New Font("Siemens Sans SC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxConsigne.Location = New Point(843, 404)
        TextBoxConsigne.Name = "TextBoxConsigne"
        TextBoxConsigne.Size = New Size(125, 44)
        TextBoxConsigne.TabIndex = 12
        ' 
        ' LabelConsigne
        ' 
        LabelConsigne.AutoSize = True
        LabelConsigne.Font = New Font("Siemens Sans SC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelConsigne.Location = New Point(202, 119)
        LabelConsigne.Name = "LabelConsigne"
        LabelConsigne.Size = New Size(100, 36)
        LabelConsigne.TabIndex = 13
        LabelConsigne.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1076, 583)
        Controls.Add(LabelConsigne)
        Controls.Add(TextBoxConsigne)
        Controls.Add(BP_RESTART)
        Controls.Add(BP_STOP)
        Controls.Add(BP_START)
        Controls.Add(Affich_vanne)
        Controls.Add(Affich_erreur)
        Controls.Add(Affich_niveau)
        Controls.Add(Affich_consigne)
        Controls.Add(LabelVanne)
        Controls.Add(LabelErreur)
        Controls.Add(LabelNiveau)
        Controls.Add(TITRE)
        Name = "Form1"
        Text = "RESTART"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents TITRE As Label
    Friend WithEvents LabelNiveau As Label
    Friend WithEvents LabelErreur As Label
    Friend WithEvents LabelVanne As Label
    Friend WithEvents Affich_consigne As Label
    Friend WithEvents Affich_niveau As Label
    Friend WithEvents Affich_erreur As Label
    Friend WithEvents Affich_vanne As Label
    Friend WithEvents BP_START As Button
    Friend WithEvents BP_STOP As Button
    Friend WithEvents BP_RESTART As Button
    Friend WithEvents TextBoxConsigne As TextBox
    Friend WithEvents LabelConsigne As Label

End Class
