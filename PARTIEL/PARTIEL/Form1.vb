Public Class Form1


    Private Sub BP_START_Click(sender As Object, e As EventArgs) Handles BP_START.Click
        'Calculer la moyenne
        Const c1 = 1, c2 = 2
        Dim n1, n2, n3, moy As Double
        n1 = Val(l1.Text)
        n2 = Val(l2.Text)
        n3 = Val(l3.Text)
        moy = (n1 * c1 + n2 * c1 + n3 * c2) / 4
        Labelmoy.Text = moy.ToString + "/20"

        'Donner une appréciation en fonction de la moyenne 
        If moy > 0 And moy <= 10 Then
            'Si moy<10 resultats mediocre
            LabelA.Text = "Mediocre"
        ElseIf moy > 10 And moy <= 15 Then
            'Si moy ets entre 10 et 15 resultats moyen
            LabelA.Text = "Moyen, peut faire mieux"
        Else
            'Si moy>15 resultats très bien
            LabelA.Text = "Très bien"
        End If
    End Sub

    Private Sub vider_Click(sender As Object, e As EventArgs) Handles vider.Click
        'Nettoyer les controles
        l1.Text = " " : l2.Text = " " : l3.Text = " " : Labelmoy.Text = " " : LabelA.Text = " "

    End Sub

    Private Sub fermer_Click(sender As Object, e As EventArgs) Handles fermer.Click
        Close() 'Fermer le programme
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBanniere.Text = "   RESULTATS PARTIEL - CALCUL DES MOYENNES   "
        lblBanniere.AutoSize = True

        lblBanniere.Left = pnlBanniere.Width
        lblBanniere.Top = (pnlBanniere.Height - lblBanniere.Height) \ 2

        TimerBanniere.Interval = 30
        TimerBanniere.Start()
    End Sub

    Private Sub TimerBanniere_Tick(sender As Object, e As EventArgs) Handles TimerBanniere.Tick
        lblBanniere.Left -= 3

        If lblBanniere.Right < 0 Then
            lblBanniere.Left = pnlBanniere.Width
        End If
    End Sub


End Class
