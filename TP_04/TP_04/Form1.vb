Public Class Form1

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        'affichage du message

        If t1.Text <> "" Then
            l1.Text = t1.Text + ",BIENVENU(E) au CME"
        End If

    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        'recommencer le processus
        t1.Text = ""
        l1.Text = ""
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        'fermeture de l'application
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
