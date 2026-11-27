Imports System

' Régulation tout ou rien avec hystérésis.
' Cette fonction ne dépend pas de Windows Forms et ne commande aucun matériel.
Public Module Regulation
    Public Function CommanderPompe(niveau As Integer,
                                   seuilBas As Integer,
                                   seuilHaut As Integer,
                                   automatique As Boolean,
                                   pompePrecedente As Boolean) As Boolean
        ' L'arrêt de la régulation coupe toujours la commande.
        If Not automatique Then Return False

        If niveau < 0 OrElse niveau > 100 Then
            Throw New ArgumentOutOfRangeException(NameOf(niveau))
        End If

        If seuilBas < 0 OrElse seuilHaut > 100 OrElse seuilBas >= seuilHaut Then
            Throw New ArgumentException("Les seuils doivent respecter 0 ≤ bas < haut ≤ 100.")
        End If

        If niveau >= seuilHaut Then Return False
        If niveau <= seuilBas Then Return True

        ' Entre les deux seuils, on mémorise l'état précédent.
        Return pompePrecedente
    End Function
End Module
