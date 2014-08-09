Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CreateBackup As System.Windows.Forms.CheckBox
    Friend WithEvents incdec As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents linestart As System.Windows.Forms.NumericUpDown
    Friend WithEvents lineend As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DisplayResults As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CreateBackup = New System.Windows.Forms.CheckBox
        Me.incdec = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DisplayResults = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lineend = New System.Windows.Forms.NumericUpDown
        Me.linestart = New System.Windows.Forms.NumericUpDown
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.lineend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linestart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "ssa"
        Me.OpenFileDialog1.Filter = "Sub Station Alpha|*.ssa"
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.Title = "Select a Sub Station Alpha Script File"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.DefaultExt = "txt"
        Me.OpenFileDialog2.Filter = "JACOsub|*.js|All files (*.*)|*.*"
        Me.OpenFileDialog2.RestoreDirectory = True
        Me.OpenFileDialog2.Title = "Select a JACOsub Script File"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(384, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Proceed"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Adjusted Times:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 32)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        Me.TextBox1.WordWrap = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"Split Seconds", "Seconds", "Minutes", "Hours"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'CreateBackup
        '
        Me.CreateBackup.Checked = True
        Me.CreateBackup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CreateBackup.Location = New System.Drawing.Point(584, 72)
        Me.CreateBackup.Name = "CreateBackup"
        Me.CreateBackup.Size = New System.Drawing.Size(128, 24)
        Me.CreateBackup.TabIndex = 5
        Me.CreateBackup.Text = "Create Backup File"
        '
        'incdec
        '
        Me.incdec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.incdec.Items.AddRange(New Object() {"Decrement", "Increment"})
        Me.incdec.Location = New System.Drawing.Point(32, 32)
        Me.incdec.Name = "incdec"
        Me.incdec.Size = New System.Drawing.Size(80, 21)
        Me.incdec.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DisplayResults)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lineend)
        Me.GroupBox1.Controls.Add(Me.linestart)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CreateBackup)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.incdec)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 352)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adjust SSA Script Time"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 104)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(712, 240)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(392, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 128)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label5.Location = New System.Drawing.Point(632, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "About  |"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(680, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Exit  |"
        '
        'DisplayResults
        '
        Me.DisplayResults.Location = New System.Drawing.Point(472, 72)
        Me.DisplayResults.Name = "DisplayResults"
        Me.DisplayResults.TabIndex = 6
        Me.DisplayResults.Text = "Display Results"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(336, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "End"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(280, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start"
        '
        'lineend
        '
        Me.lineend.Location = New System.Drawing.Point(328, 32)
        Me.lineend.Name = "lineend"
        Me.lineend.Size = New System.Drawing.Size(48, 20)
        Me.lineend.TabIndex = 1
        '
        'linestart
        '
        Me.linestart.Location = New System.Drawing.Point(272, 32)
        Me.linestart.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.linestart.Name = "linestart"
        Me.linestart.Size = New System.Drawing.Size(48, 20)
        Me.linestart.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(544, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Convert JACOsub to SSA"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(24, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "View File Contents"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(384, 368)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 24)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Convert SRT to SSA"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.DefaultExt = "txt"
        Me.OpenFileDialog3.Filter = "SRT Subtitles|*.srt|All files (*.*)|*.*"
        Me.OpenFileDialog3.RestoreDirectory = True
        Me.OpenFileDialog3.Title = "Select a SRT Subtitle Script File"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label6.Location = New System.Drawing.Point(56, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sub Station Alpha Script Adjuster"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label7.Location = New System.Drawing.Point(40, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Version:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label8.Location = New System.Drawing.Point(40, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Build:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label9.Location = New System.Drawing.Point(40, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Release:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(40, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Developer:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label11.Location = New System.Drawing.Point(112, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "1.0"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label12.Location = New System.Drawing.Point(112, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "1.0.5"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label13.Location = New System.Drawing.Point(112, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "20/01/2005"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label14.Location = New System.Drawing.Point(112, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Craig Lotter"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(760, 406)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(768, 440)
        Me.MinimumSize = New System.Drawing.Size(768, 440)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub Station Alpha Script Adjuster"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.lineend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linestart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.CheckFileExists = True
        Dim SelectedFile As String
        SelectedFile = OpenFileDialog1.FileName
        If Not SelectedFile = "" Then
            Dim sr = New System.IO.StreamReader(SelectedFile)
            ' Open the file to read.
            Dim filemanipulator = New System.IO.FileInfo(SelectedFile)
            If CreateBackup.Checked = True Then
                filemanipulator.CopyTo(filemanipulator.DirectoryName & "\Backup_" & filemanipulator.Name, True)
            End If
            Dim stg As String = filemanipulator.DirectoryName & "\Temp_" & filemanipulator.Name

            Dim filemanipulator2 = New System.IO.FileInfo(stg)
            If filemanipulator2.Exists = True Then
                filemanipulator2.Delete()
            End If
            'Pass the file path and the file name to the StreamWriter constructor.
            Dim objStreamWriter = New System.IO.StreamWriter(stg)








            ' Read each line in the file.
            ' When the end of the file is reached, return the value "-1".
            Dim x As String
            Dim decrementby As Integer
            decrementby = Val(TextBox1.Text)
            If ComboBox1.SelectedIndex = 1 Then
                decrementby = decrementby * 60
            End If
            If ComboBox1.SelectedIndex = 2 Then
                decrementby = decrementby * 60 * 60
            End If
            If ComboBox1.SelectedIndex = 3 Then
                decrementby = decrementby * 60 * 60 * 60
            End If
            RichTextBox1.Clear()
            x = sr.ReadLine
            Dim time1 As String
            Dim thour As String
            Dim tminute As String
            Dim tsecond As String
            Dim tsplitsecond As String
            Dim itime1 As Integer
            Dim ihour As Integer
            Dim iminute As Integer
            Dim isecond As Integer
            Dim isplitsecond As Integer
            Dim temp As Integer
            Dim time2 As String
            Dim thour2 As String
            Dim tminute2 As String
            Dim tsecond2 As String
            Dim tsplitsecond2 As String
            Dim itime2 As Integer
            Dim ihour2 As Integer
            Dim iminute2 As Integer
            Dim isecond2 As Integer
            Dim isplitsecond2 As Integer
            Dim temp2 As Integer
            Dim indexofchar As Integer
            Dim linecounter As Integer = 1
            Dim lineflag As Boolean = True
            Dim linestartflag As Boolean = False
            If lineend.Value = 0 Or linestart.Value = 0 Then
                lineflag = False
                linestartflag = True
            End If

            Do While Not x Is Nothing
                If lineflag = True Then
                    If linecounter = linestart.Value Then
                        linestartflag = True
                    End If
                    If linecounter = lineend.Value + 1 Then
                        linestartflag = False
                    End If
                End If
                If linestartflag = True Then
                    If x.StartsWith("Dialogue:") Or x.StartsWith("Comment:") Then
                        indexofchar = x.IndexOf(":", 9)
                        time1 = x.Substring(indexofchar - 1, 10)
                        thour = time1.Substring(0, 1)
                        tminute = time1.Substring(2, 2)
                        tsecond = time1.Substring(5, 2)
                        tsplitsecond = time1.Substring(8, 2)
                        If tminute.StartsWith("0") Then
                            tminute = tminute.Substring(1, 1)
                        End If
                        If tsecond.StartsWith("0") Then
                            tsecond = tsecond.Substring(1, 1)
                        End If
                        If tsplitsecond.StartsWith("0") Then
                            tsplitsecond = tsplitsecond.Substring(1, 1)
                        End If
                        ihour = Val(thour)
                        iminute = Val(tminute)
                        isecond = Val(tsecond)
                        isplitsecond = Val(tsplitsecond)
                        ihour = ihour * 60 * 60 * 60
                        iminute = iminute * 60 * 60
                        isecond = isecond * 60
                        itime1 = ihour + iminute + isecond + isplitsecond
                        If incdec.SelectedIndex = 0 Then
                            itime1 = itime1 - decrementby
                        End If
                        If incdec.SelectedIndex = 1 Then
                            itime1 = itime1 + decrementby
                        End If

                        If itime1 < 0 Then
                            itime1 = 0
                        End If
                        temp = (itime1 \ 60 \ 60 \ 60)
                        If temp > 0 Then
                            itime1 = itime1 - (temp * 60 * 60 * 60)
                        End If
                        ihour = temp
                        temp = (itime1 \ 60 \ 60)
                        If temp > 0 Then
                            itime1 = itime1 - (temp * 60 * 60)
                        End If
                        iminute = temp
                        temp = (itime1 \ 60)
                        If temp > 0 Then
                            itime1 = itime1 - (temp * 60)
                        End If
                        isecond = temp
                        isplitsecond = itime1

                        thour = Str(ihour)
                        thour = Trim(thour)
                        tminute = Str(iminute)
                        tminute = Trim(tminute)
                        If tminute.Length = 1 Then
                            tminute = "0" & tminute
                        End If
                        tsecond = Str(isecond)
                        tsecond = Trim(tsecond)
                        If tsecond.Length = 1 Then
                            tsecond = "0" & tsecond
                        End If
                        tsplitsecond = Str(isplitsecond)
                        tsplitsecond = Trim(tsplitsecond)
                        If tsplitsecond.Length = 1 Then
                            tsplitsecond = "0" & tsplitsecond
                        End If

                        time1 = thour & ":" & tminute & ":" & tsecond & "." & tsplitsecond


                        time2 = x.Substring(indexofchar + 10, 10)

                        thour2 = time2.Substring(0, 1)
                        tminute2 = time2.Substring(2, 2)
                        tsecond2 = time2.Substring(5, 2)
                        tsplitsecond2 = time2.Substring(8, 2)
                        If tminute2.StartsWith("0") Then
                            tminute2 = tminute2.Substring(1, 1)
                        End If
                        If tsecond2.StartsWith("0") Then
                            tsecond2 = tsecond2.Substring(1, 1)
                        End If
                        If tsplitsecond2.StartsWith("0") Then
                            tsplitsecond2 = tsplitsecond2.Substring(1, 1)
                        End If
                        ihour2 = Val(thour2)
                        iminute2 = Val(tminute2)
                        isecond2 = Val(tsecond2)
                        isplitsecond2 = Val(tsplitsecond2)
                        ihour2 = ihour2 * 60 * 60 * 60
                        iminute2 = iminute2 * 60 * 60
                        isecond2 = isecond2 * 60
                        itime2 = ihour2 + iminute2 + isecond2 + isplitsecond2
                        If incdec.SelectedIndex = 0 Then
                            itime2 = itime2 - decrementby
                        End If
                        If incdec.SelectedIndex = 1 Then
                            itime2 = itime2 + decrementby
                        End If
                        If itime2 < 0 Then
                            itime2 = 0
                        End If

                        temp2 = (itime2 \ 60 \ 60 \ 60)
                        If temp2 > 0 Then
                            itime2 = itime2 - (temp2 * 60 * 60 * 60)
                        End If
                        ihour2 = temp2
                        temp2 = (itime2 \ 60 \ 60)
                        If temp2 > 0 Then
                            itime2 = itime2 - (temp2 * 60 * 60)
                        End If
                        iminute2 = temp2
                        temp2 = (itime2 \ 60)
                        If temp2 > 0 Then
                            itime2 = itime2 - (temp2 * 60)
                        End If
                        isecond2 = temp2
                        isplitsecond2 = itime2

                        thour2 = Str(ihour2)
                        thour2 = Trim(thour2)
                        tminute2 = Str(iminute2)
                        tminute2 = Trim(tminute2)
                        If tminute2.Length = 1 Then
                            tminute2 = "0" & tminute2
                        End If
                        tsecond2 = Str(isecond2)
                        tsecond2 = Trim(tsecond2)
                        If tsecond2.Length = 1 Then
                            tsecond2 = "0" & tsecond2
                        End If
                        tsplitsecond2 = Str(isplitsecond2)
                        tsplitsecond2 = Trim(tsplitsecond2)
                        If tsplitsecond2.Length = 1 Then
                            tsplitsecond2 = "0" & tsplitsecond2
                        End If

                        time2 = thour2 & ":" & tminute2 & ":" & tsecond2 & "." & tsplitsecond2
                        If DisplayResults.Checked = True Then
                            RichTextBox1.Text = RichTextBox1.Text & "Line: " & linecounter & "  " & x & "  (" & time1 & " - " & time2 & ")" & vbCrLf
                        End If
                        Mid(x, indexofchar, 10) = time1
                        Mid(x, indexofchar + 11, 10) = time2
                    End If
                End If
                
                objStreamWriter.WriteLine(x)

                x = sr.ReadLine
                linecounter = linecounter + 1
            Loop

            'Close the file.
            objStreamWriter.Close()

            ' Tell user the operation is over and close the file.
            MsgBox("The File has been processed.")
            Button1.Enabled = False
            OpenFileDialog1.FileName = ""
            sr.Close()
            filemanipulator2.CopyTo(SelectedFile, True)
            filemanipulator2.Delete()
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 1
        incdec.SelectedIndex = 0
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog2.ShowDialog()
        OpenFileDialog2.CheckFileExists = True
        Dim SelectedFile As String
        SelectedFile = OpenFileDialog2.FileName
        If Not SelectedFile = "" Then
            Dim sr = New System.IO.StreamReader(SelectedFile)
            ' Open the file to read.
            Dim filemanipulator = New System.IO.FileInfo(SelectedFile)
            'If CreateBackup.Checked = True Then
            'filemanipulator.CopyTo(filemanipulator.DirectoryName & "\Backup_" & filemanipulator.Name, True)
            'End If
            Dim stg As String = filemanipulator.DirectoryName & "\" & filemanipulator.Name & ".ssa"

            Dim filemanipulator2 = New System.IO.FileInfo(stg)
            If filemanipulator2.Exists = True Then
                filemanipulator2.Delete()
            End If
            'Pass the file path and the file name to the StreamWriter constructor.
            Dim objStreamWriter = New System.IO.StreamWriter(stg)



            ' Read each line in the file.
            ' When the end of the file is reached, return the value "-1".
            Dim x As String
            Dim tempwrite As String
            tempwrite = ""
            'RichTextBox1.Clear()
            x = sr.ReadLine
            Dim writeflag As Boolean
            Dim writestylesflag As Boolean
            writestylesflag = False
            Do While Not x Is Nothing
                writeflag = False

                x = x.Replace("`", "'")
                If x.Length > 20 Then
                    If System.Char.IsNumber(x.Chars(0)) = True And x.Chars(1) = ":" Then
                        If writestylesflag = False Then
                            objStreamWriter.WriteLine("")
                            objStreamWriter.WriteLine("[V4 Styles]")
                            objStreamWriter.WriteLine("Format: Name(, Fontname, Fontsize, PrimaryColour, SecondaryColour, TertiaryColour, BackColour, Bold, Italic, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, AlphaLevel, Encoding)")
                            objStreamWriter.WriteLine("Style: Default,Tahoma,16,253436,253436,253436,0,-1,0,1,2,2,2,15,15,15,0,0")
                            objStreamWriter.WriteLine("Style: Colours,Tahoma,16,&HA9E1DE,&HA9E1DE,&HA9E1DE,0,-1,0,1,2,2,2,15,15,15,0,0")
                            objStreamWriter.WriteLine("")
                            objStreamWriter.WriteLine("[Events]")
                            objStreamWriter.WriteLine("Format: Marked, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text")
                            objStreamWriter.WriteLine("")
                            writestylesflag = True
                        End If

                        If x.LastIndexOf("{~}") >= 0 Then
                            tempwrite = "Dialogue: Marked=0," & x.Substring(0, 10) & "," & x.Substring(11, 10) & ","
                            x = x.Remove(0, 22)
                            If x.StartsWith("{~} ") Then
                                tempwrite = tempwrite & "Default,NTP,0000,0000,0000,!Effect,"
                                x = x.Remove(0, 4)
                                tempwrite = tempwrite & x
                            Else
                                tempwrite = tempwrite & "Colours,NTP,0000,0000,0000,!Effect,"

                                x = x.Remove(0, x.LastIndexOf("}") + 2)
                                tempwrite = tempwrite & x
                            End If

                            Dim slashsearch As Integer
                            Dim myArray() As String = Split(tempwrite, "\")
                            Dim slashcounter As Integer
                            For slashcounter = 1 To myArray.Length() - 1

                                If myArray(slashcounter).StartsWith("n") Or myArray(slashcounter).StartsWith("N") Then
                                    myArray(slashcounter) = "\" & myArray(slashcounter)
                                Else
                                    myArray(slashcounter) = myArray(slashcounter).Remove(0, 2)
                                End If
                            Next
                            tempwrite = Join(myArray)
                            objStreamWriter.WriteLine(tempwrite)
                            writeflag = True
                        End If
                        If writeflag = False Then
                            objStreamWriter.WriteLine(";" & x)
                            writeflag = True
                        End If

                    End If

                End If
                If x.StartsWith("#") Then
                    x = x.Remove(0, 1)
                    objStreamWriter.WriteLine(";" & x)
                    writeflag = True
                End If
                If x = "" Then
                    objStreamWriter.WriteLine("")
                    writeflag = True
                Else
                    If writeflag = False Then
                        objStreamWriter.WriteLine(x)
                    End If
                End If
                x = sr.ReadLine
            Loop

            'Close the file.
            objStreamWriter.Close()

            ' Tell user the operation is over and close the file.
            MsgBox("The File has been converted.")
            Button1.Enabled = False
            OpenFileDialog2.FileName = ""
            sr.Close()
            'filemanipulator2.CopyTo(SelectedFile, True)
            'filemanipulator2.Delete()
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.CheckFileExists = True
        Dim SelectedFile As String
        SelectedFile = OpenFileDialog1.FileName
        If Not SelectedFile = "" Then
            Dim sr = New System.IO.StreamReader(SelectedFile)
            ' Open the file to read.



            ' Read each line in the file.
            ' When the end of the file is reached, return the value "-1".
            Dim x As String
            RichTextBox1.Clear()
            x = sr.ReadLine
            Dim linecounter As Integer = 1

            Do While Not x Is Nothing
                RichTextBox1.Text = RichTextBox1.Text & "Line: " & linecounter & "  " & x & vbCrLf
                x = sr.ReadLine
                linecounter = linecounter + 1
            Loop

            ' Tell user the operation is over and close the file.
            MsgBox("The File has been loaded.")
            OpenFileDialog1.FileName = ""
            sr.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog3.ShowDialog()
        OpenFileDialog3.CheckFileExists = True
        Dim SelectedFile As String
        SelectedFile = OpenFileDialog3.FileName
        If Not SelectedFile = "" Then
            Dim sr = New System.IO.StreamReader(SelectedFile)
            ' Open the file to read.
            Dim filemanipulator = New System.IO.FileInfo(SelectedFile)
            'If CreateBackup.Checked = True Then
            'filemanipulator.CopyTo(filemanipulator.DirectoryName & "\Backup_" & filemanipulator.Name, True)
            'End If
            Dim stg As String = filemanipulator.DirectoryName & "\" & filemanipulator.Name & ".ssa"

            Dim filemanipulator2 = New System.IO.FileInfo(stg)
            If filemanipulator2.Exists = True Then
                filemanipulator2.Delete()
            End If
            'Pass the file path and the file name to the StreamWriter constructor.
            Dim objStreamWriter = New System.IO.StreamWriter(stg)



            ' Read each line in the file.
            ' When the end of the file is reached, return the value "-1".
            Dim x As String
            Dim tempwrite As String
            tempwrite = ""
            'RichTextBox1.Clear()
            x = sr.ReadLine
            Dim writeflag As Boolean
            Dim writestylesflag As Boolean

            writestylesflag = False
            Dim counter As Integer = 0
            Do While Not x Is Nothing
                If writestylesflag = False Then
                    objStreamWriter.WriteLine("[Script Info]")
                    objStreamWriter.WriteLine("Title: ")
                    objStreamWriter.WriteLine("ScriptType: v4(0.0)")
                    objStreamWriter.WriteLine("Collisions: Normal()")
                    objStreamWriter.WriteLine("Timer: 100.0000")
                    objStreamWriter.WriteLine("")
                    objStreamWriter.WriteLine("[V4 Styles]")
                    objStreamWriter.WriteLine("Format: Name(, Fontname, Fontsize, PrimaryColour, SecondaryColour, TertiaryColour, BackColour, Bold, Italic, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, AlphaLevel, Encoding)")
                    objStreamWriter.WriteLine("Style: Default,Tahoma,16,253436,253436,253436,0,-1,0,1,2,2,2,15,15,15,0,0")
                    objStreamWriter.WriteLine("Style: Colours,Tahoma,16,&HA9E1DE,&HA9E1DE,&HA9E1DE,0,-1,0,1,2,2,2,15,15,15,0,0")
                    objStreamWriter.WriteLine("")
                    objStreamWriter.WriteLine("[Events]")
                    objStreamWriter.WriteLine("Format: Marked, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text")
                    objStreamWriter.WriteLine("")
                    writestylesflag = True
                End If
                tempwrite = x
                If IsNumeric(tempwrite) = True Then
                    tempwrite = "Dialogue: Marked=0,"
                    x = sr.readLine()
                    Dim strarray() As String = Split(x, " --> ", -1, CompareMethod.Text)
                    For counter = 0 To UBound(strarray)
                        strarray(counter) = strarray(counter).Replace(",", ".")
                        strarray(counter) = strarray(counter).Remove(0, 1)
                        strarray(counter) = strarray(counter).Remove(strarray(counter).Length - 1, 1)
                    Next counter
                    tempwrite = tempwrite & strarray(0) & "," & strarray(1) & ",Default,NTP,0000,0000,0000,!Effect,"
                    x = sr.readline()
                    While Not x.Equals("")
                        tempwrite = tempwrite & x & " "
                        x = sr.readline()
                    End While
                End If
                writeflag = False


                If writeflag = False Then
                    objStreamWriter.WriteLine(tempwrite)
                    writeflag = True
                End If


                x = sr.ReadLine
                'counter = counter + 1
            Loop
        'MsgBox(counter)
        'Close the file.
        objStreamWriter.Close()

        ' Tell user the operation is over and close the file.
        MsgBox("The File has been converted.")
        Button1.Enabled = False
            OpenFileDialog3.FileName = ""
            sr.Close()
            'filemanipulator2.CopyTo(SelectedFile, True)
            'filemanipulator2.Delete()
        End If
    End Sub

    
  

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
End Class
