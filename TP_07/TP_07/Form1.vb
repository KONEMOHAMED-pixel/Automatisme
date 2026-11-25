Public Class Form1

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        'nettoyer les contenus
        t1.Text = "" : t2.Text = ""
        l5.Text = "" : l6.Text = ""
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        'calcul 
        l5.Text = Val(t1.Text) * Val(t2.Text)
        l6.Text = Val(l5.Text) + Val(l5.Text) * 0.18

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        ' fermerture
        Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'operation2
        Dim qt As Integer, px As Integer
        Dim mht As Integer, mttc As Double

        px = t2.Text  'Affectation des valeurs 
        qt = t1.Text

        mht = qt * px   'operation de calculs
        mttc = mht * 1.18

        l5.Text = mht     ' renvoi de la valeur
        l6.Text = mttc
    End Sub
End Class
