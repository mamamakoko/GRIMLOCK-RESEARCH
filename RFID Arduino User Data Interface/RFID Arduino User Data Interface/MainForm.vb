Imports System.Net
Imports Newtonsoft.Json.Linq
Imports PCSC
Imports PCSC.Monitoring
Imports System.Drawing.Drawing2D

Imports MaterialSkin
Imports MaterialSkin.Controls


Public Class MainForm
    Inherits MaterialSkin.Controls.MaterialForm

    Private contextFactory As New ContextFactory()
    Private monitor As ISCardMonitor

    Private ipAddress As String = ""  ' Default IP address or URL source

    ' Function to fetch and display the latest user data and attendance records
    Private Async Sub GetLatestUserID()
        Dim url As String = $"http://{ipAddress}/controller/getLatestUser.php"  ' Use the current IP address or URL

        Using client As New WebClient()
            Try
                ' Perform the web request asynchronously
                Dim jsonResponse As String = Await client.DownloadStringTaskAsync(url)

                ' Parse the JSON response
                Dim json As JObject = JObject.Parse(jsonResponse)

                ' Check if we have data and display it
                If json IsNot Nothing AndAlso json.Count > 0 Then
                    ' Update user information labels
                    lblStudentNumber.Text = If(json("user_id") IsNot Nothing, json("user_id").ToString(), "N/A")
                    lblName.Text = If(json("name") IsNot Nothing, json("name").ToString(), "N/A")
                    lblSection.Text = If(json("section") IsNot Nothing, json("section").ToString(), "N/A")

                    ' Clear the ListView before adding new data
                    TimeListView2.Items.Clear()

                    ' Check if 'attendance' key exists and parse it safely
                    If json("attendance") IsNot Nothing Then
                        Dim timeArray As JArray = JArray.Parse(json("attendance").ToString())

                        ' Loop through each attendance record and add to the ListView
                        For Each attendance In timeArray
                            Dim listItem As New ListViewItem(If(attendance("time_in_date") IsNot Nothing, attendance("time_in_date").ToString(), "N/A")) ' time_in
                            listItem.SubItems.Add(If(attendance("time_out_date") IsNot Nothing, attendance("time_out_date").ToString(), "N/A"))          ' time_out
                            TimeListView2.Items.Add(listItem)
                        Next
                    End If
                End If

            Catch ex As WebException
                ' Log the error silently without showing a message box
                Debug.WriteLine("Connection failed: " & ex.Message)
            Catch ex As Exception
                ' Handle other errors silently as well
                Debug.WriteLine("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load event for the form, sets up timers and fetches initial data
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None ' Remove window border
        ' Me.WindowState = FormWindowState.Maximized ' Optional: Make fullscreen

        TimeListView2.OwnerDraw = True ' Enable custom drawing

        Timer1.Interval = 2000  ' Set for fetching user data every 2 seconds
        Timer1.Enabled = True    ' Start the data fetching timer

        Timer2.Interval = 1000   ' Set for updating time display every 1 second
        Timer2.Enabled = True    ' Start the time updating timer

        GetLatestUserID()  ' Call the function initially when the form loads

        'Dim readerName As String = GetReaderName()
        'If readerName IsNot Nothing Then
        'monitor = New SCardMonitor(New ContextFactory(), SCardScope.System)
        'AddHandler monitor.CardInserted, AddressOf CardInserted
        'monitor.Start(readerName)
        'Else
        'LabelUID.Text = "No NFC Reader Found"
        'End If
    End Sub

    ' Timer event to repeatedly fetch the latest user data
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetLatestUserID()  ' Call to get the latest user ID and attendance
    End Sub

    ' Timer event to update the clock display
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        timeEvent.Text = Date.Now.ToString("MMMM dd, yyyy  HH:mm:ss")  ' Update the time display every second
    End Sub

    ' Button to allow user to change IP address or source URL
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Dim newIP As String = InputBox("Enter the new IP address or URL:", "Change IP Address", ipAddress)

        ' Validate the new IP address or URL (basic validation)
        'If IsValidIPAddress(newIP) Then
        'ipAddress = newIP
        'MessageBox.Show("IP address updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        'MessageBox.Show("Invalid IP address or URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        ' Validate the new IP address or URL (basic validation)
        If IsValidIPAddress(newIP) Then
            ipAddress = newIP
            MessageBox.Show("IP address updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf newIP = "" Then
            MessageBox.Show("Invalid IP address or URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Function to validate IP address format, domain names, or localhost
    Private Function IsValidIPAddress(ip As String) As Boolean
        ' Allow localhost or 127.0.0.1 in addition to valid IP address patterns
        If ip.Equals("localhost", StringComparison.OrdinalIgnoreCase) OrElse ip.Equals("127.0.0.1") Then
            Return True
        End If

        ' Regex for validating an IP address with optional port
        Dim ipRegex As New System.Text.RegularExpressions.Regex(
            "^((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])\.){3}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])(:[0-9]{1,5})?$"
        )

        ' Regex for validating domain names
        Dim domainRegex As New System.Text.RegularExpressions.Regex(
            "^(?!-)[A-Za-z0-9-]{1,63}(?<!-)(\.[A-Za-z]{2,})+$"
        )

        ' Validate IP address or domain name
        Return ipRegex.IsMatch(ip) OrElse domainRegex.IsMatch(ip)
    End Function

    '' Adjust the column widths when the form is resized
    'Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    AdjustListViewColumns()
    'End Sub

    'Private Sub AdjustListViewColumns()
    '    ' Make both columns equal width when the form is resized
    '    Dim totalWidth As Integer = TimeListView.ClientSize.Width
    '    Dim columnWidth As Integer = totalWidth \ TimeListView.Columns.Count ' Divide by the number of columns

    '    For Each col As ColumnHeader In TimeListView.Columns
    '        col.Width = columnWidth
    '    Next
    'End Sub

    '' Draw event to center text
    'Private Sub timeListView_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles TimeListView.DrawSubItem
    '    Dim format As New StringFormat()
    '    format.Alignment = StringAlignment.Center
    '    format.LineAlignment = StringAlignment.Center

    '    ' Draw background
    '    e.DrawBackground()

    '    ' Draw centered text
    '    e.Graphics.DrawString(e.SubItem.Text, TimeListView.Font, Brushes.Black, e.Bounds, format)
    'End Sub

    '' Draw event to center column headers
    'Private Sub timeListView_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles TimeListView.DrawColumnHeader
    '    Dim format As New StringFormat()
    '    format.Alignment = StringAlignment.Center
    '    format.LineAlignment = StringAlignment.Center

    '    ' Draw header text
    '    e.DrawBackground()
    '    e.Graphics.DrawString(e.Header.Text, TimeListView.Font, Brushes.Black, e.Bounds, format)
    'End Sub

    ' Adjust the column widths when the form is resized
    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AdjustListViewColumns()
    End Sub

    Private Sub AdjustListViewColumns()
        ' Make both columns equal width when the form is resized
        Dim totalWidth As Integer = TimeListView2.ClientSize.Width
        Dim columnWidth As Integer = totalWidth \ TimeListView2.Columns.Count ' Divide by the number of columns

        For Each col As ColumnHeader In TimeListView2.Columns
            col.Width = columnWidth
        Next
    End Sub

    ' Draw event to center text
    Private Sub TimeListView2_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles TimeListView2.DrawSubItem
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center

        ' Draw background
        e.DrawBackground()

        ' Draw centered text
        e.Graphics.DrawString(e.SubItem.Text, TimeListView2.Font, Brushes.Black, e.Bounds, format)
    End Sub

    ' Draw event to center column headers
    Private Sub TimeListView2_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles TimeListView2.DrawColumnHeader
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center

        ' Draw header text
        e.DrawBackground()
        e.Graphics.DrawString(e.Header.Text, TimeListView2.Font, Brushes.Black, e.Bounds, format)
    End Sub

    Private Function GetReaderName() As String
        Using context = contextFactory.Establish(SCardScope.System)
            Dim readerNames = context.GetReaders()
            If readerNames.Length > 0 Then Return readerNames(0)
        End Using
        Return Nothing
    End Function

    'Private Sub CardInserted(sender As Object, e As CardStatusEventArgs)
    'Dim uid As String = GetCardUID(e.ReaderName)

    'If uid = "6300" Then
    'Me.Invoke(Sub() LabelUID.Text = "Sorry, please try again.")
    'ElseIf uid IsNot Nothing AndAlso uid <> "6300" Then
    'Me.Invoke(Sub() LabelUID.Text = "UID: " & uid)
    'End If
    'End Sub


    'Private Function GetCardUID(readerName As String) As String
    'Try
    'Using context = contextFactory.Establish(SCardScope.System)
    'Using reader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any)
    '' APDU command to get UID: FF CA 00 00 00
    'Dim apdu As Byte() = {&HFF, &HCA, &H0, &H0, &H0}
    'Dim receiveBuffer As Byte() = New Byte(255) {}
    'Dim command = reader.Transmit(apdu, receiveBuffer)

    ' Extract UID from response
    'Dim uidLength As Integer = command
    'If uidLength > 0 Then
    'Return BitConverter.ToString(receiveBuffer, 0, uidLength).Replace("-", "")
    'End If
    'End Using
    'End Using
    'Catch ex As PCSC.Exceptions.ReaderUnavailableException
    'Me.Invoke(Sub() LabelUID.Text = "NFC Reader Not Available")
    'Catch ex As Exception
    'Me.Invoke(Sub() LabelUID.Text = "Error: " & ex.Message)
    'End Try
    'Return Nothing
    'End Function
End Class
