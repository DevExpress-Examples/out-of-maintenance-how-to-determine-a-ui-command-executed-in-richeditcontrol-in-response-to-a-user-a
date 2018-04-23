Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Services

Namespace DXApplication9
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
           InitializeComponent()
           Dim service As New CustomCommandExecutionListenerService()
           service.RichEditControl = richEditControl
           AddHandler service.CommandExecutedEvent, AddressOf service_CommandExecutedEvent
           richEditControl.RemoveService(GetType(ICommandExecutionListenerService))
           richEditControl.AddService(GetType(ICommandExecutionListenerService), service)
        End Sub

        Private Sub service_CommandExecutedEvent(ByVal sender As Object, ByVal e As CommandEventArgs)
            Dim text As String = String.Format("{0} Description: {1}{2}", e.CommandName, e.CommandDescription, Environment.NewLine)
            memoEdit1.Text += text
        End Sub


    End Class
End Namespace




