<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim CornerRadius1 As RFID_Arduino_User_Data_Interface.CornerRadius = New RFID_Arduino_User_Data_Interface.CornerRadius()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.timeEvent = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TimeListView2 = New RFID_Arduino_User_Data_Interface.CustomMaterialListView()
        Me.timeOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.StudentPanel = New System.Windows.Forms.Panel()
        Me.BtnSettings = New RFID_Arduino_User_Data_Interface.CustomButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.PictureBoxStudent = New System.Windows.Forms.PictureBox()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TimeListView2)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Location = New System.Drawing.Point(435, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 700)
        Me.Panel1.TabIndex = 1
        '
        'TimeListView2
        '
        Me.TimeListView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeListView2.AutoArrange = False
        Me.TimeListView2.AutoSizeTable = False
        Me.TimeListView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TimeListView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TimeListView2.ColumnBackColor = System.Drawing.Color.LightSkyBlue
        Me.TimeListView2.ColumnForeColor = System.Drawing.Color.Black
        Me.TimeListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.timeIn, Me.timeOut})
        Me.TimeListView2.Depth = 0
        Me.TimeListView2.EvenRowColor = System.Drawing.Color.White
        Me.TimeListView2.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeListView2.ForeColor = System.Drawing.Color.Black
        Me.TimeListView2.FullRowSelect = True
        Me.TimeListView2.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TimeListView2.HeaderForeColor = System.Drawing.Color.Black
        Me.TimeListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.TimeListView2.HideSelection = False
        Me.TimeListView2.Location = New System.Drawing.Point(0, 5)
        Me.TimeListView2.Margin = New System.Windows.Forms.Padding(0)
        Me.TimeListView2.MinimumSize = New System.Drawing.Size(200, 100)
        Me.TimeListView2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.TimeListView2.MouseState = MaterialSkin.MouseState.OUT
        Me.TimeListView2.MultiSelect = False
        Me.TimeListView2.Name = "TimeListView2"
        Me.TimeListView2.OddRowColor = System.Drawing.Color.LightGray
        Me.TimeListView2.OwnerDraw = True
        Me.TimeListView2.Size = New System.Drawing.Size(934, 463)
        Me.TimeListView2.TabIndex = 2
        Me.TimeListView2.UseCompatibleStateImageBehavior = False
        Me.TimeListView2.View = System.Windows.Forms.View.Details
        '
        'timeOut
        '
        Me.timeOut.Text = "Time Out"
        Me.timeOut.Width = 469
        '
        'timeIn
        '
        Me.timeIn.Text = "Time In"
        Me.timeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.timeIn.Width = 465
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ListView1.BackgroundImage = Global.RFID_Arduino_User_Data_Interface.My.Resources.Resources.Background
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 468)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(937, 232)
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
        Me.StudentPanel.Controls.Add(Me.BtnSettings)
        Me.StudentPanel.Controls.Add(Me.Label4)
        Me.StudentPanel.Controls.Add(Me.Label3)
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
        'BtnSettings
        '
        Me.BtnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSettings.BackColor = System.Drawing.Color.White
        Me.BtnSettings.ButtonIcon = Global.RFID_Arduino_User_Data_Interface.My.Resources.Resources.caret_arrow_up
        CornerRadius1.BottomLeft = 0
        CornerRadius1.BottomRight = 0
        Me.BtnSettings.CornerRadii = CornerRadius1
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.Location = New System.Drawing.Point(75, 721)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(280, 29)
        Me.BtnSettings.TabIndex = 17
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSettings As CustomButton
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents TimeListView2 As CustomMaterialListView
    Friend WithEvents timeOut As ColumnHeader
    Friend WithEvents timeIn As ColumnHeader
    Friend WithEvents Label3 As Label
End Class
