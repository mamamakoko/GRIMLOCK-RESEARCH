<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.timeEvent = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StudentPanel = New System.Windows.Forms.Panel()
        Me.LabelUID = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxStudent = New System.Windows.Forms.PictureBox()
        Me.RoundedPanel1 = New RFID_Arduino_User_Data_Interface.RoundedPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.timeListView = New System.Windows.Forms.ListView()
        Me.timeIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.StudentPanel.SuspendLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel3.Controls.Add(Me.timeEvent)
        Me.Panel3.Location = New System.Drawing.Point(435, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(935, 55)
        Me.Panel3.TabIndex = 2
        '
        'timeEvent
        '
        Me.timeEvent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.timeEvent.AutoSize = True
        Me.timeEvent.BackColor = System.Drawing.Color.Transparent
        Me.timeEvent.Font = New System.Drawing.Font("Montserrat", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeEvent.ForeColor = System.Drawing.Color.White
        Me.timeEvent.Location = New System.Drawing.Point(619, 14)
        Me.timeEvent.Name = "timeEvent"
        Me.timeEvent.Size = New System.Drawing.Size(307, 26)
        Me.timeEvent.TabIndex = 0
        Me.timeEvent.Text = "September 30, 2024  00:00:00"
        Me.timeEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        '
        'StudentPanel
        '
        Me.StudentPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StudentPanel.BackColor = System.Drawing.Color.White
        Me.StudentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StudentPanel.Controls.Add(Me.Label11)
        Me.StudentPanel.Controls.Add(Me.LabelUID)
        Me.StudentPanel.Controls.Add(Me.btnSettings)
        Me.StudentPanel.Controls.Add(Me.lblSection)
        Me.StudentPanel.Controls.Add(Me.lblName)
        Me.StudentPanel.Controls.Add(Me.Panel2)
        Me.StudentPanel.Controls.Add(Me.lblStudentNumber)
        Me.StudentPanel.Controls.Add(Me.Label2)
        Me.StudentPanel.Controls.Add(Me.Label1)
        Me.StudentPanel.Controls.Add(Me.PictureBoxStudent)
        Me.StudentPanel.Controls.Add(Me.RoundedPanel1)
        Me.StudentPanel.Location = New System.Drawing.Point(0, 0)
        Me.StudentPanel.Name = "StudentPanel"
        Me.StudentPanel.Size = New System.Drawing.Size(436, 750)
        Me.StudentPanel.TabIndex = 0
        '
        'LabelUID
        '
        Me.LabelUID.AutoSize = True
        Me.LabelUID.Font = New System.Drawing.Font("Lato Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUID.Location = New System.Drawing.Point(167, 661)
        Me.LabelUID.Name = "LabelUID"
        Me.LabelUID.Size = New System.Drawing.Size(78, 19)
        Me.LabelUID.TabIndex = 15
        Me.LabelUID.Text = "UIDLabel"
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSettings.Image = Global.RFID_Arduino_User_Data_Interface.My.Resources.Resources.setting_24px_
        Me.btnSettings.Location = New System.Drawing.Point(0, 712)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(38, 38)
        Me.btnSettings.TabIndex = 14
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lblSection.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.White
        Me.lblSection.Location = New System.Drawing.Point(153, 503)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(92, 24)
        Me.lblSection.TabIndex = 11
        Me.lblSection.Text = "Waiting..."
        Me.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(153, 454)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 24)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Waiting..."
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Location = New System.Drawing.Point(443, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 44)
        Me.Panel2.TabIndex = 9
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lblStudentNumber.Font = New System.Drawing.Font("Montserrat", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNumber.ForeColor = System.Drawing.Color.White
        Me.lblStudentNumber.Location = New System.Drawing.Point(131, 368)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(168, 27)
        Me.lblStudentNumber.TabIndex = 4
        Me.lblStudentNumber.Text = "SCAN YOUR ID"
        Me.lblStudentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStudentNumber.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 503)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Section  :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBoxStudent
        '
        Me.PictureBoxStudent.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxStudent.Image = Global.RFID_Arduino_User_Data_Interface.My.Resources.Resources.student
        Me.PictureBoxStudent.Location = New System.Drawing.Point(92, 85)
        Me.PictureBoxStudent.Name = "PictureBoxStudent"
        Me.PictureBoxStudent.Size = New System.Drawing.Size(250, 250)
        Me.PictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStudent.TabIndex = 0
        Me.PictureBoxStudent.TabStop = False
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.RoundedPanel1.Controls.Add(Me.Label4)
        Me.RoundedPanel1.Controls.Add(Me.Label3)
        Me.RoundedPanel1.CornerRadius = 30
        Me.RoundedPanel1.Location = New System.Drawing.Point(23, 0)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(388, 635)
        Me.RoundedPanel1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(130, 545)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Student"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 545)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Role :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'timeListView
        '
        Me.timeListView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.timeListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeListView.BackColor = System.Drawing.Color.White
        Me.timeListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.timeListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.timeIn, Me.timeOut})
        Me.timeListView.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.timeListView.HideSelection = False
        Me.timeListView.LabelWrap = False
        Me.timeListView.Location = New System.Drawing.Point(0, 5)
        Me.timeListView.Margin = New System.Windows.Forms.Padding(0)
        Me.timeListView.MultiSelect = False
        Me.timeListView.Name = "timeListView"
        Me.timeListView.OwnerDraw = True
        Me.timeListView.Scrollable = False
        Me.timeListView.ShowGroups = False
        Me.timeListView.Size = New System.Drawing.Size(935, 321)
        Me.timeListView.TabIndex = 0
        Me.timeListView.TileSize = New System.Drawing.Size(348, 48)
        Me.timeListView.UseCompatibleStateImageBehavior = False
        Me.timeListView.View = System.Windows.Forms.View.Details
        '
        'timeIn
        '
        Me.timeIn.Text = "Time in"
        Me.timeIn.Width = 240
        '
        'timeOut
        '
        Me.timeOut.Text = "Time Out"
        Me.timeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.timeOut.Width = 240
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.timeListView)
        Me.Panel1.Location = New System.Drawing.Point(435, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 700)
        Me.Panel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(351, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 26)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "September 30, 2024  00:00:00"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(7, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 26)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "John Francis Lomeda"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(351, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(307, 26)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "September 30, 2024  00:00:00"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(298, 26)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Edlyn Joan Marie Examinada"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(351, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(307, 26)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "September 30, 2024  00:00:00"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Lea Jean Cavite"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 353)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(935, 232)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(296, 674)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Label11"
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StudentPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StudentPanel.ResumeLayout(False)
        Me.StudentPanel.PerformLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.RoundedPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentPanel As Panel
    Friend WithEvents PictureBoxStudent As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents timeEvent As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnSettings As Button
    Friend WithEvents timeListView As ListView
    Friend WithEvents timeIn As ColumnHeader
    Friend WithEvents timeOut As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelUID As Label
    Friend WithEvents Label11 As Label
End Class
