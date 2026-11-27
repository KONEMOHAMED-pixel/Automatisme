Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Private niveau As Integer = 10
    Private pompeEnMarche As Boolean = False
    Private regulationActive As Boolean = False

    Public Sub New()
        InitializeComponent()
        ActualiserAffichage()
    End Sub

    Private Sub btnDemarrer_Click(sender As Object, e As EventArgs) Handles btnDemarrer.Click
        If nudSeuilBas.Value >= nudSeuilHaut.Value Then
            MessageBox.Show("Le seuil bas doit être inférieur au seuil haut.",
                            "Vérifier les seuils", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        regulationActive = True
        AppliquerRegulation()
        Timer1.Start()
        ActualiserAffichage()
    End Sub

    Private Sub btnArreter_Click(sender As Object, e As EventArgs) Handles btnArreter.Click
        ArreterRegulation()
    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click
        ArreterRegulation()
        niveau = 10
        ActualiserAffichage()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Un pas de simulation : +5 points si la pompe tourne,
        ' puis -1 point si la consommation d'eau est activée.
        ' Ce modèle pédagogique ne représente pas un débit réel.
        If Not regulationActive Then Return

        If pompeEnMarche Then niveau += 5
        If chkConsommation.Checked Then niveau -= 1

        ' Le niveau simulé reste compris entre 0 et 100 %.
        niveau = Math.Max(0, Math.Min(100, niveau))

        AppliquerRegulation()
        ActualiserAffichage()
    End Sub

    Private Sub AppliquerRegulation()
        pompeEnMarche = CommanderPompe(niveau,
                                      CInt(nudSeuilBas.Value),
                                      CInt(nudSeuilHaut.Value),
                                      regulationActive,
                                      pompeEnMarche)
    End Sub

    Private Sub ArreterRegulation()
        Timer1.Stop()
        regulationActive = False
        pompeEnMarche = False
        ActualiserAffichage()
    End Sub

    Private Sub ActualiserAffichage()
        barNiveau.Value = niveau
        lblNiveau.Text = "Niveau : " & niveau.ToString() & " %"

        If pompeEnMarche Then
            lblPompe.Text = "Pompe : MARCHE"
            lblPompe.ForeColor = Color.DarkGreen
        Else
            lblPompe.Text = "Pompe : ARRÊT"
            lblPompe.ForeColor = Color.Firebrick
        End If

        If Not regulationActive Then
            lblEtat.Text = "Régulation arrêtée — simulation en pause."
        ElseIf pompeEnMarche Then
            lblEtat.Text = "Remplissage jusqu'au seuil haut."
        Else
            lblEtat.Text = "Attente : redémarrage au seuil bas."
        End If

        btnDemarrer.Enabled = Not regulationActive
        btnArreter.Enabled = regulationActive
        nudSeuilBas.Enabled = Not regulationActive
        nudSeuilHaut.Enabled = Not regulationActive
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        regulationActive = False
        pompeEnMarche = False
    End Sub
End Class
