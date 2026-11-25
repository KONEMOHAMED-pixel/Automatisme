Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles l2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub r1_Click(sender As Object, e As EventArgs) Handles r1.Click
        'calcul du perimetre
        'l2.Text = 2 * Val(t1.Text) * 3.14
    End Sub

    Private Sub r2_Click(sender As Object, e As EventArgs) Handles r2.Click
        'calcul de l'aire

        l2.Text = t1.Text * t1.Text * 3.14
    End Sub

    Private Sub r3_Click(sender As Object, e As EventArgs) Handles r3.Click
        'calcul de la somme

        Dim i As Integer, n As Integer, som As Integer
        n = t1.Text

        som = 0
        For i = 1 To 10
            som = som + n - i
        Next

        l2.Text = som

    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        'recommencer le processus
        t1.Text = "" : l2.Text = ""
        r1.Checked = False
        r2.Checked = False
        r3.Checked = False
    End Sub
End Class
