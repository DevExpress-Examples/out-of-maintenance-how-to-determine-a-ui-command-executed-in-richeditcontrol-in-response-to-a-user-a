Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraRichEdit
Imports DevExpress.Services.Implementation
Imports DevExpress.Services

Namespace DXApplication9
    Public Class CustomCommandExecutionListenerService
        Inherits CommandExecutionListenerService

        Public Property RichEditControl() As RichEditControl
        Public Delegate Sub CommandExecutedEventHandler(ByVal sender As Object, ByVal e As CommandEventArgs)
        Public Event CommandExecutedEvent As CommandExecutedEventHandler

        Protected Overridable Sub RaiseCommandExecutedEvent(ByVal e As CommandEventArgs)
            RaiseEvent CommandExecutedEvent(Me, e)
        End Sub

        Public Overrides Sub EndCommandExecution(ByVal command As DevExpress.Utils.Commands.Command, ByVal state As DevExpress.Utils.Commands.ICommandUIState)
            MyBase.EndCommandExecution(command, state)
            If Not RichEditControl.IsUpdateLocked Then
                RaiseCommandExecutedEvent(New CommandEventArgs(command.ToString(), command.Description))
            End If
        End Sub
    End Class
    Public Class CommandEventArgs
        Public Sub New(ByVal name As String, ByVal description As String)
            CommandName = name
            CommandDescription = description
        End Sub
        Private privateCommandName As String
        Public Property CommandName() As String
            Get
                Return privateCommandName
            End Get
            Private Set(ByVal value As String)
                privateCommandName = value
            End Set
        End Property
        Private privateCommandDescription As String
        Public Property CommandDescription() As String
            Get
                Return privateCommandDescription
            End Get
            Private Set(ByVal value As String)
                privateCommandDescription = value
            End Set
        End Property
    End Class
End Namespace
