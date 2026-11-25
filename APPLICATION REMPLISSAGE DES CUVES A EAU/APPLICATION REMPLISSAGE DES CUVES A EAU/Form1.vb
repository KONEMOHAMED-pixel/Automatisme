Public Class Form1
    Dim Kp As Double = 2
    Dim Ki As Double = 0.1
    Dim Kd As Double = 0.05

    Dim erreur As Double
    Dim sommeErreur As Double = 0
    Dim erreurPrecedente As Double = 0

    Dim sortie As Double = 0 ' ouverture vanne %

    Dim consigne As Double = 70
    Dim niveau As Double = 0


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Calcul de l'erreur
        erreur = consigne - niveau

        ' Calcul PID
        sommeErreur += erreur
        Dim derivee As Double = erreur - erreurPrecedente

        sortie = Kp * erreur + Ki * sommeErreur + Kd * derivee

        ' Limitation de l'ouverture de la vanne
        If sortie > 100 Then sortie = 100
        If sortie < 0 Then sortie = 0

        ' Simulation du remplissage
        niveau += sortie * 0.01

        ' Arrêt automatique si la consigne est atteinte
        If niveau >= consigne Then
            niveau = consigne
            sortie = 0
            Timer1.Stop()

            BP_START.Enabled = True
            BP_STOP.Enabled = False
        End If

        erreurPrecedente = erreur

        AfficherInformations()


    End Sub



    Private Sub BP_START_Click(sender As Object, e As EventArgs) Handles BP_START.Click
        If Not Double.TryParse(TextBoxConsigne.Text, consigne) Then
            MessageBox.Show("Veuillez entrer une consigne correcte.", "Erreur")
            Exit Sub
        End If

        If consigne < 20 Or consigne > 90 Then
            MessageBox.Show("La consigne doit être comprise entre 20% et 90%.", "Erreur")
            Exit Sub
        End If



        Timer1.Start()

        BP_START.Enabled = False
        BP_STOP.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Timer1.Stop()
        TextBoxConsigne.Text = consigne.ToString()
        BP_STOP.Enabled = False

        AfficherInformations()
    End Sub

    Private Sub BP_STOP_Click(sender As Object, e As EventArgs) Handles BP_STOP.Click
        Timer1.Stop()

        BP_START.Enabled = True
        BP_STOP.Enabled = False
    End Sub

    Private Sub AfficherInformations()
        LabelConsigne.Text = "Consigne : " & consigne.ToString("0.00") & " %"
        LabelNiveau.Text = niveau.ToString("0.00") & " %"
        LabelErreur.Text = erreur.ToString("0.00")
        LabelVanne.Text = sortie.ToString("0.00") & " %"
    End Sub

    Private Sub BP_RESTART_Click(sender As Object, e As EventArgs) Handles BP_RESTART.Click
        Timer1.Enabled = False

        niveau = 0
        erreur = 0
        sommeErreur = 0
        erreurPrecedente = 0
        sortie = 0

        BP_START.Enabled = True
        BP_STOP.Enabled = False

        AfficherInformations()
    End Sub
End Class
