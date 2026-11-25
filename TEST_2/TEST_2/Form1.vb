Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Close()
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        'Nettoyer les controles
        t1.Text = "" : t2.Text = "" : t3.Text = ""
        l1.Text = "" : l2.Text = ""
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        'Calcul moyenne
        'methode 1 : les propriétés des controles
        l1.Text = (Val(t1.Text) + Val(t2.Text) + Val(t3.Text) * 2) / 4

        If Val(l1.Text) < 10 Then
            ap = "ECHEC"
        Else
            ap =
        End If

    End Sub
End Class
