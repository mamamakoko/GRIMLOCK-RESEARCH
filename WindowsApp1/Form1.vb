Imports PCSC
Imports PCSC.Monitoring
Imports PCSC.Exceptions

Public Class Form1
    Private contextFactory As New ContextFactory()
    Private monitor As ISCardMonitor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim readerName As String = GetReaderName()
        If readerName IsNot Nothing Then
            monitor = New SCardMonitor(New ContextFactory(), SCardScope.System)
            AddHandler monitor.CardInserted, AddressOf CardInserted
            monitor.Start(readerName)
        Else
            LabelUID.Text = "No NFC Reader Found"
        End If
    End Sub

    Private Function GetReaderName() As String
        Using context = contextFactory.Establish(SCardScope.System)
            Dim readerNames = context.GetReaders()
            If readerNames.Length > 0 Then Return readerNames(0)
        End Using
        Return Nothing
    End Function

    Private Sub CardInserted(sender As Object, e As CardStatusEventArgs)
        Dim uid As String = GetCardUID(e.ReaderName)

        If uid = "6300" Then
            Me.Invoke(Sub() LabelUID.Text = "Sorry, please try again.")
        ElseIf uid IsNot Nothing AndAlso uid <> "6300" Then
            Me.Invoke(Sub() LabelUID.Text = "UID: " & uid)
        End If
    End Sub


    Private Function GetCardUID(readerName As String) As String
        Try
            Using context = contextFactory.Establish(SCardScope.System)
                Using reader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any)
                    ' APDU command to get UID: FF CA 00 00 00
                    Dim apdu As Byte() = {&HFF, &HCA, &H0, &H0, &H0}
                    Dim receiveBuffer As Byte() = New Byte(255) {}
                    Dim command = reader.Transmit(apdu, receiveBuffer)

                    ' Extract UID from response
                    Dim uidLength As Integer = command
                    If uidLength > 0 Then
                        Return BitConverter.ToString(receiveBuffer, 0, uidLength).Replace("-", "")
                    End If
                End Using
            End Using
        Catch ex As PCSC.Exceptions.ReaderUnavailableException
            Me.Invoke(Sub() LabelUID.Text = "NFC Reader Not Available")
        Catch ex As Exception
            Me.Invoke(Sub() LabelUID.Text = "Error: " & ex.Message)
        End Try
        Return Nothing
    End Function

End Class
