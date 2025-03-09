Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading

Public Class NFCReader
    <DllImport("winscard.dll")>
    Private Shared Function SCardEstablishContext(dwScope As UInteger, pvReserved1 As IntPtr, pvReserved2 As IntPtr, ByRef phContext As IntPtr) As Integer
    End Function

    <DllImport("winscard.dll")>
    Private Shared Function SCardGetStatusChange(hContext As IntPtr, dwTimeout As Integer, ByRef rgReaderStates As SCARD_READERSTATE, cReaders As Integer) As Integer
    End Function

    <DllImport("winscard.dll")>
    Private Shared Function SCardConnect(hContext As IntPtr, szReader As String, dwShareMode As UInteger, dwPreferredProtocols As UInteger, ByRef phCard As IntPtr, ByRef pdwActiveProtocol As UInteger) As Integer
    End Function

    <DllImport("winscard.dll")>
    Private Shared Function SCardTransmit(hCard As IntPtr, pioSendPci As IntPtr, pbSendBuffer As Byte(), cbSendLength As Integer, pioRecvPci As IntPtr, pbRecvBuffer As Byte(), ByRef pcbRecvLength As Integer) As Integer
    End Function

    <DllImport("winscard.dll")>
    Private Shared Function SCardDisconnect(hCard As IntPtr, dwDisposition As UInteger) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure SCARD_READERSTATE
        <MarshalAs(UnmanagedType.LPStr)>
        Public szReader As String
        Public pvUserData As IntPtr
        Public dwCurrentState As UInteger
        Public dwEventState As UInteger
        Public cbAtr As UInteger
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)>
        Public rgbAtr As Byte()
    End Structure

    Public Event CardDetected(uid As String)

    Private ReadOnly _readerThread As Thread
    Private _stopThread As Boolean = False

    Public Sub New()
        _readerThread = New Thread(AddressOf ListenForCard)
        _readerThread.IsBackground = True
        _readerThread.Start()
    End Sub

    Private Sub ListenForCard()
        Dim hContext As IntPtr
        Dim result As Integer = SCardEstablishContext(2, IntPtr.Zero, IntPtr.Zero, hContext)

        If result <> 0 Then
            Debug.WriteLine("Error: SCardEstablishContext failed. Code: " & result)
            Exit Sub
        Else
            Debug.WriteLine("SCardEstablishContext: Success")
        End If

        Dim readerState As New SCARD_READERSTATE() With {.szReader = "ACS ACR122"}

        While Not _stopThread
            readerState.dwCurrentState = readerState.dwEventState
            result = SCardGetStatusChange(hContext, 500, readerState, 1)

            If result <> 0 Then
                Debug.WriteLine("Error: SCardGetStatusChange failed. Code: " & result)
            End If

            If (readerState.dwEventState And &H20) <> 0 Then ' SCARD_STATE_PRESENT (card detected)
                Dim uid As String = ReadNFCUID()
                Debug.WriteLine($"Card Detected, UID: {uid}")
                RaiseEvent CardDetected(uid)
            End If
        End While
    End Sub



    ''' <summary>
    ''' Reads the UID from an NFC card.
    ''' </summary>
    ''' <returns>The card's UID as a hex string.</returns>
    Public Function ReadNFCUID() As String
        Dim hContext As IntPtr
        Dim hCard As IntPtr
        Dim protocol As UInteger

        ' Establish connection
        Dim result As Integer = SCardEstablishContext(2, IntPtr.Zero, IntPtr.Zero, hContext)
        If result <> 0 Then
            Debug.WriteLine("Error: Cannot establish context. Code: " & result)
            Return "Error: Cannot establish context."
        End If
        Debug.WriteLine("SCardEstablishContext successful.")

        result = SCardConnect(hContext, "ACS ACR122U PICC Interface 0", 1, 3, hCard, protocol)
        If result <> 0 Then
            Debug.WriteLine("Error: Cannot connect to reader. Code: " & result)
            Return "Error: Cannot connect to reader."
        End If
        Debug.WriteLine("SCardConnect successful.")

        ' APDU command to get UID
        Dim apdu As Byte() = {&HFF, &HCA, &H0, &H0, &H0}
        Dim recvBuffer As Byte() = New Byte(9) {}
        Dim recvLength As Integer = recvBuffer.Length

        result = SCardTransmit(hCard, IntPtr.Zero, apdu, apdu.Length, IntPtr.Zero, recvBuffer, recvLength)
        If result <> 0 Then
            SCardDisconnect(hCard, 2)
            Debug.WriteLine("Error: Cannot read UID. Code: " & result)
            Return "Error: Cannot read UID."
        End If

        ' Convert response to hex UID
        Dim uid As String = BitConverter.ToString(recvBuffer, 0, recvLength).Replace("-", "")
        SCardDisconnect(hCard, 2)

        Debug.WriteLine($"UID Read Successfully: {uid}")
        Return uid
    End Function



    Public Sub StopListening()
        _stopThread = True
    End Sub
End Class
