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
        Me.timeListView = New System.Windows.Forms.ListView()
        Me.timeIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.StudentPanel = New System.Windows.Forms.Panel()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.PictureBoxStudent = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StudentPanel.SuspendLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel3.Controls.Add(Me.timeEvent)
        Me.Panel3.Location = New System.Drawing.Point(435, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(935, 55)
        Me.Panel3.TabIndex = 2
        '
        'timeEvent
        '
        Me.timeEvent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.timeEvent.AutoSize = True
        Me.timeEvent.BackColor = System.Drawing.Color.Transparent
        Me.timeEvent.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeEvent.ForeColor = System.Drawing.Color.White
        Me.timeEvent.Location = New System.Drawing.Point(11, 18)
        Me.timeEvent.Name = "timeEvent"
        Me.timeEvent.Size = New System.Drawing.Size(298, 34)
        Me.timeEvent.TabIndex = 0
        Me.timeEvent.Text = "September 30, 2024  00:00:00"
        Me.timeEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
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
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.timeListView)
        Me.Panel1.Location = New System.Drawing.Point(435, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 700)
        Me.Panel1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ListView1.BackgroundImage = Global.RFID_Arduino_User_Data_Interface.My.Resources.Resources.Background
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 468)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(935, 232)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'StudentPanel
        '
        Me.StudentPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StudentPanel.BackColor = System.Drawing.Color.White
        Me.StudentPanel.BackgroundImage = Global.RFID_Arduino_User_Data_Interface.My.Resources.Resources.Background
        Me.StudentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StudentPanel.Controls.Add(Me.Label4)
        Me.StudentPanel.Controls.Add(Me.Label3)
        Me.StudentPanel.Controls.Add(Me.btnSettings)
        Me.StudentPanel.Controls.Add(Me.lblSection)
        Me.StudentPanel.Controls.Add(Me.lblName)
        Me.StudentPanel.Controls.Add(Me.Panel2)
        Me.StudentPanel.Controls.Add(Me.lblStudentNumber)
        Me.StudentPanel.Controls.Add(Me.PictureBoxStudent)
        Me.StudentPanel.Location = New System.Drawing.Point(0, 0)
        Me.StudentPanel.Name = "StudentPanel"
        Me.StudentPanel.Size = New System.Drawing.Size(436, 750)
        Me.StudentPanel.TabIndex = 0
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSettings.Image = Global.RFID_Arduino_User_Data_Interface.My.Resources.Resources.setting_24px_
        Me.btnSettings.Location = New System.Drawing.Point(0, 0)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(38, 38)
        Me.btnSettings.TabIndex = 14
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.Transparent
        Me.lblSection.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.White
        Me.lblSection.Location = New System.Drawing.Point(57, 552)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(109, 34)
        Me.lblSection.TabIndex = 11
        Me.lblSection.Text = "Waiting..."
        Me.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(56, 518)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(109, 34)
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
        Me.lblStudentNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentNumber.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNumber.ForeColor = System.Drawing.Color.White
        Me.lblStudentNumber.Location = New System.Drawing.Point(57, 484)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(109, 34)
        Me.lblStudentNumber.TabIndex = 4
        Me.lblStudentNumber.Text = "Waiting..."
        Me.lblStudentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStudentNumber.UseMnemonic = False
        '
        'PictureBoxStudent
        '
        Me.PictureBoxStudent.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxStudent.Image = Global.RFID_Arduino_User_Data_Interface.My.Resources.Resources.student2
        Me.PictureBoxStudent.Location = New System.Drawing.Point(92, 113)
        Me.PictureBoxStudent.Name = "PictureBoxStudent"
        Me.PictureBoxStudent.Size = New System.Drawing.Size(250, 250)
        Me.PictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStudent.TabIndex = 0
        Me.PictureBoxStudent.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(55, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 37)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Welcome to NAS Laboratory!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(123, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 48)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "TAP YOUR ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel1.ResumeLayout(False)
        Me.StudentPanel.ResumeLayout(False)
        Me.StudentPanel.PerformLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentPanel As Panel
    Friend WithEvents PictureBoxStudent As PictureBox
    Friend WithEvents lblStudentNumber As Label
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
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
