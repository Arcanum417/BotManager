﻿Namespace Manager
    Public Class BotFactory
        Public Shared Function GetBot(ByRef botProperties As Properties.BotInformation) As Manager.Generic
            Select Case botProperties.BotClass
                Case "BotManager.Manager.Haxton"
                    Return New Haxton(botProperties)
                Case "BotManager.Manager.Spegeli"
                    Return New Spegeli(botProperties)
            End Select

            Throw New Exception("Uknown Bot Class!")
        End Function
    End Class
End NameSpace