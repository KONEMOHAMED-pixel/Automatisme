Option Strict On
Option Explicit On

Imports System.Globalization

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) _
        Handles btnCalculer.Click

        ' Les trois notes ont le même coefficient.
        Dim note1 As Decimal = nudNote1.Value
        Dim note2 As Decimal = nudNote2.Value
        Dim note3 As Decimal = nudNote3.Value

        ' L'appréciation porte sur la moyenne arrondie à deux décimales.
        Dim moyenne As Decimal = Math.Round((note1 + note2 + note3) / 3D,
                                           2, MidpointRounding.AwayFromZero)
        Dim appreciation As String

        If moyenne >= 16D Then
            appreciation = "Très bien"
        ElseIf moyenne >= 14D Then
            appreciation = "Bien"
        ElseIf moyenne >= 12D Then
            appreciation = "Assez bien"
        ElseIf moyenne >= 10D Then
            appreciation = "Passable"
        ElseIf moyenne >= 8D Then
            appreciation = "Insuffisant"
        Else
            appreciation = "Très insuffisant"
        End If

        lblMoyenne.Text = "Moyenne : " &
            moyenne.ToString("F2", CultureInfo.GetCultureInfo("fr-FR")) & " / 20"
        lblAppreciation.Text = "Appréciation : " & appreciation
    End Sub

    Private Sub Notes_ValueChanged(sender As Object, e As EventArgs) _
        Handles nudNote1.ValueChanged, nudNote2.ValueChanged, nudNote3.ValueChanged

        ' Effacer le résultat précédent lorsqu'une note change.
        lblMoyenne.Text = "Moyenne : —"
        lblAppreciation.Text = "Appréciation : —"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
