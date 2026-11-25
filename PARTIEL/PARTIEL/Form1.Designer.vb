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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        l1 = New TextBox()
        l2 = New TextBox()
        l3 = New TextBox()
        Labeln1 = New Label()
        Labeln3 = New Label()
        Labeln2 = New Label()
        l4 = New Label()
        Labelmoy = New Label()
        l5 = New Label()
        LabelA = New Label()
        vider = New Button()
        BP_START = New Button()
        fermer = New Button()
        Label7 = New Label()
        lblBanniere = New Label()
        PictureBox1 = New PictureBox()
        pnlBanniere = New Panel()
        TimerBanniere = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlBanniere.SuspendLayout()
        SuspendLayout()
        ' 
        ' l1
        ' 
        l1.Font = New Font("Forte", 16.2F)
        l1.Location = New Point(199, 207)
        l1.Margin = New Padding(6, 4, 6, 4)
        l1.Name = "l1"
        l1.Size = New Size(240, 44)
        l1.TabIndex = 0
        ' 
        ' l2
        ' 
        l2.Location = New Point(199, 284)
        l2.Name = "l2"
        l2.Size = New Size(240, 44)
        l2.TabIndex = 1
        ' 
        ' l3
        ' 
        l3.Location = New Point(199, 364)
        l3.Name = "l3"
        l3.Size = New Size(240, 44)
        l3.TabIndex = 2
        ' 
        ' Labeln1
        ' 
        Labeln1.AutoSize = True
        Labeln1.BackColor = Color.Orange
        Labeln1.Font = New Font("Gloucester MT Extra Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labeln1.Location = New Point(33, 207)
        Labeln1.Name = "Labeln1"
        Labeln1.Size = New Size(143, 51)
        Labeln1.TabIndex = 3
        Labeln1.Text = "NOTE 1 :"
        ' 
        ' Labeln3
        ' 
        Labeln3.AutoSize = True
        Labeln3.BackColor = Color.Lime
        Labeln3.Font = New Font("Gloucester MT Extra Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labeln3.Location = New Point(33, 357)
        Labeln3.Name = "Labeln3"
        Labeln3.Size = New Size(152, 51)
        Labeln3.TabIndex = 4
        Labeln3.Text = "NOTE 3 : "
        ' 
        ' Labeln2
        ' 
        Labeln2.AutoSize = True
        Labeln2.BackColor = Color.Turquoise
        Labeln2.Font = New Font("Gloucester MT Extra Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labeln2.Location = New Point(33, 277)
        Labeln2.Name = "Labeln2"
        Labeln2.Size = New Size(143, 51)
        Labeln2.TabIndex = 5
        Labeln2.Text = "NOTE 2 :"
        ' 
        ' l4
        ' 
        l4.AutoSize = True
        l4.BackColor = Color.Yellow
        l4.Font = New Font("Gloucester MT Extra Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        l4.Location = New Point(33, 430)
        l4.Name = "l4"
        l4.Size = New Size(104, 51)
        l4.TabIndex = 6
        l4.Text = "MOY :"
        ' 
        ' Labelmoy
        ' 
        Labelmoy.AutoSize = True
        Labelmoy.BackColor = Color.LimeGreen
        Labelmoy.Font = New Font("Gloucester MT Extra Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelmoy.ForeColor = Color.OrangeRed
        Labelmoy.Location = New Point(199, 430)
        Labelmoy.Name = "Labelmoy"
        Labelmoy.Size = New Size(111, 51)
        Labelmoy.TabIndex = 7
        Labelmoy.Text = "Label1"
        ' 
        ' l5
        ' 
        l5.AutoSize = True
        l5.BackColor = Color.Olive
        l5.Font = New Font("Gloucester MT Extra Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        l5.Location = New Point(33, 503)
        l5.Name = "l5"
        l5.Size = New Size(98, 51)
        l5.TabIndex = 8
        l5.Text = "APP :"
        ' 
        ' LabelA
        ' 
        LabelA.AutoSize = True
        LabelA.BackColor = Color.Turquoise
        LabelA.Font = New Font("Gloucester MT Extra Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelA.ForeColor = Color.DarkGoldenrod
        LabelA.Location = New Point(199, 503)
        LabelA.Name = "LabelA"
        LabelA.Size = New Size(111, 51)
        LabelA.TabIndex = 9
        LabelA.Text = "Label1"
        ' 
        ' vider
        ' 
        vider.BackColor = Color.DarkCyan
        vider.FlatStyle = FlatStyle.Popup
        vider.Font = New Font("Informal Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        vider.Location = New Point(12, 604)
        vider.Name = "vider"
        vider.Size = New Size(267, 93)
        vider.TabIndex = 10
        vider.Text = "VIDER"
        vider.UseVisualStyleBackColor = False
        ' 
        ' BP_START
        ' 
        BP_START.BackColor = Color.Green
        BP_START.FlatStyle = FlatStyle.Popup
        BP_START.Font = New Font("Informal Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BP_START.ForeColor = Color.White
        BP_START.Location = New Point(285, 604)
        BP_START.Name = "BP_START"
        BP_START.Size = New Size(249, 93)
        BP_START.TabIndex = 11
        BP_START.Text = "VALIDER"
        BP_START.UseVisualStyleBackColor = False
        ' 
        ' fermer
        ' 
        fermer.BackColor = Color.Red
        fermer.FlatStyle = FlatStyle.Popup
        fermer.Font = New Font("Informal Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fermer.Location = New Point(540, 604)
        fermer.Name = "fermer"
        fermer.Size = New Size(249, 93)
        fermer.TabIndex = 12
        fermer.Text = "FERMER"
        fermer.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Gold
        Label7.Font = New Font("Old English Text MT", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Indigo
        Label7.Location = New Point(79, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(804, 71)
        Label7.TabIndex = 13
        Label7.Text = "RESULTATS PARTIEL"
        ' 
        ' lblBanniere
        ' 
        lblBanniere.AutoSize = True
        lblBanniere.Font = New Font("Old English Text MT", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBanniere.Location = New Point(12, 13)
        lblBanniere.Name = "lblBanniere"
        lblBanniere.Size = New Size(804, 71)
        lblBanniere.TabIndex = 14
        lblBanniere.Text = "RESULTATS PARTIEL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(482, 225)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(401, 313)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' pnlBanniere
        ' 
        pnlBanniere.Controls.Add(lblBanniere)
        pnlBanniere.Location = New Point(0, 97)
        pnlBanniere.Name = "pnlBanniere"
        pnlBanniere.Size = New Size(947, 103)
        pnlBanniere.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(15F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(949, 709)
        Controls.Add(pnlBanniere)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(fermer)
        Controls.Add(BP_START)
        Controls.Add(vider)
        Controls.Add(LabelA)
        Controls.Add(l5)
        Controls.Add(Labelmoy)
        Controls.Add(l4)
        Controls.Add(Labeln2)
        Controls.Add(Labeln3)
        Controls.Add(Labeln1)
        Controls.Add(l3)
        Controls.Add(l2)
        Controls.Add(l1)
        Font = New Font("Forte", 16.2F)
        Margin = New Padding(6, 4, 6, 4)
        Name = "Form1"
        Text = "PARTIEL"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlBanniere.ResumeLayout(False)
        pnlBanniere.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents l1 As TextBox
    Friend WithEvents l2 As TextBox
    Friend WithEvents l3 As TextBox
    Friend WithEvents Labeln1 As Label
    Friend WithEvents Labeln3 As Label
    Friend WithEvents Labeln2 As Label
    Friend WithEvents l4 As Label
    Friend WithEvents Labelmoy As Label
    Friend WithEvents l5 As Label
    Friend WithEvents LabelA As Label
    Friend WithEvents vider As Button
    Friend WithEvents BP_START As Button
    Friend WithEvents fermer As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblBanniere As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlBanniere As Panel
    Friend WithEvents TimerBanniere As Timer

End Class
