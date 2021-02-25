<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.but_chiudi = New System.Windows.Forms.Button
        Me.Serial_485 = New System.IO.Ports.SerialPort(Me.components)
        Me.txbox_51 = New System.Windows.Forms.TextBox
        Me.but_change_speed = New System.Windows.Forms.Button
        Me.txbox_ph = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txbox_temp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbox_dc_circ = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.but_open_profilo = New System.Windows.Forms.Button
        Me.Timer_profilo = New System.Windows.Forms.Timer(Me.components)
        Me.lab_profilo = New System.Windows.Forms.Label
        Me.lab_start = New System.Windows.Forms.Label
        Me.lab_stop = New System.Windows.Forms.Label
        Me.lab_speed = New System.Windows.Forms.Label
        Me.but_del_profile = New System.Windows.Forms.Button
        Me.but_start_profile = New System.Windows.Forms.Button
        Me.but_stop_profile = New System.Windows.Forms.Button
        Me.rbut_ampm = New System.Windows.Forms.RadioButton
        Me.rbut_0_24 = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lab_absrel_time_profile = New System.Windows.Forms.Label
        Me.lab_fine_profilo = New System.Windows.Forms.Label
        Me.lab_ora = New System.Windows.Forms.Label
        Me.lab_time = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lab_serial_status = New System.Windows.Forms.Label
        Me.lab_running_profile = New System.Windows.Forms.Label
        Me.lab_start_time = New System.Windows.Forms.Label
        Me.lab_num_start_time = New System.Windows.Forms.Label
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.txbox_trackbar = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lab_val_prec = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.but_00 = New System.Windows.Forms.Button
        Me.but25 = New System.Windows.Forms.Button
        Me.but50 = New System.Windows.Forms.Button
        Me.lbox_trackbar = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.but_emergenza = New System.Windows.Forms.Button
        Me.lab_profile_phase = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'but_chiudi
        '
        Me.but_chiudi.BackColor = System.Drawing.Color.Red
        Me.but_chiudi.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_chiudi.FlatAppearance.BorderSize = 3
        Me.but_chiudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_chiudi.Location = New System.Drawing.Point(541, 466)
        Me.but_chiudi.Name = "but_chiudi"
        Me.but_chiudi.Size = New System.Drawing.Size(109, 38)
        Me.but_chiudi.TabIndex = 4
        Me.but_chiudi.Text = "EXIT"
        Me.but_chiudi.UseVisualStyleBackColor = False
        '
        'Serial_485
        '
        Me.Serial_485.BaudRate = 19200
        Me.Serial_485.PortName = "COM6"
        '
        'txbox_51
        '
        Me.txbox_51.Location = New System.Drawing.Point(562, 10)
        Me.txbox_51.Multiline = True
        Me.txbox_51.Name = "txbox_51"
        Me.txbox_51.Size = New System.Drawing.Size(88, 28)
        Me.txbox_51.TabIndex = 5
        Me.txbox_51.Visible = False
        '
        'but_change_speed
        '
        Me.but_change_speed.BackColor = System.Drawing.Color.Cyan
        Me.but_change_speed.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_change_speed.FlatAppearance.BorderSize = 3
        Me.but_change_speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_change_speed.Location = New System.Drawing.Point(35, 358)
        Me.but_change_speed.Name = "but_change_speed"
        Me.but_change_speed.Size = New System.Drawing.Size(211, 37)
        Me.but_change_speed.TabIndex = 10
        Me.but_change_speed.Text = "change pump speed"
        Me.but_change_speed.UseVisualStyleBackColor = False
        '
        'txbox_ph
        '
        Me.txbox_ph.Location = New System.Drawing.Point(134, 40)
        Me.txbox_ph.Name = "txbox_ph"
        Me.txbox_ph.Size = New System.Drawing.Size(105, 20)
        Me.txbox_ph.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "PH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Temperature"
        '
        'txbox_temp
        '
        Me.txbox_temp.Location = New System.Drawing.Point(134, 68)
        Me.txbox_temp.Name = "txbox_temp"
        Me.txbox_temp.Size = New System.Drawing.Size(105, 20)
        Me.txbox_temp.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "%"
        '
        'lbox_dc_circ
        '
        Me.lbox_dc_circ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbox_dc_circ.FormattingEnabled = True
        Me.lbox_dc_circ.ItemHeight = 16
        Me.lbox_dc_circ.Items.AddRange(New Object() {"0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.lbox_dc_circ.Location = New System.Drawing.Point(114, 420)
        Me.lbox_dc_circ.Name = "lbox_dc_circ"
        Me.lbox_dc_circ.Size = New System.Drawing.Size(47, 84)
        Me.lbox_dc_circ.TabIndex = 43
        Me.lbox_dc_circ.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(220, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 26)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Zebrafish Water Control"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(285, 196)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(4, 294)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(139, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Manual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(423, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Profile"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Pump Speed"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'but_open_profilo
        '
        Me.but_open_profilo.BackColor = System.Drawing.Color.Yellow
        Me.but_open_profilo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_open_profilo.FlatAppearance.BorderSize = 3
        Me.but_open_profilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_open_profilo.Location = New System.Drawing.Point(374, 197)
        Me.but_open_profilo.Name = "but_open_profilo"
        Me.but_open_profilo.Size = New System.Drawing.Size(166, 49)
        Me.but_open_profilo.TabIndex = 55
        Me.but_open_profilo.Text = "Open Profile File"
        Me.but_open_profilo.UseVisualStyleBackColor = False
        '
        'Timer_profilo
        '
        Me.Timer_profilo.Interval = 1000
        '
        'lab_profilo
        '
        Me.lab_profilo.AutoSize = True
        Me.lab_profilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_profilo.ForeColor = System.Drawing.Color.White
        Me.lab_profilo.Location = New System.Drawing.Point(298, 289)
        Me.lab_profilo.Name = "lab_profilo"
        Me.lab_profilo.Size = New System.Drawing.Size(47, 17)
        Me.lab_profilo.TabIndex = 66
        Me.lab_profilo.Text = "phase"
        Me.lab_profilo.Visible = False
        '
        'lab_start
        '
        Me.lab_start.AutoSize = True
        Me.lab_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_start.ForeColor = System.Drawing.Color.White
        Me.lab_start.Location = New System.Drawing.Point(370, 289)
        Me.lab_start.Name = "lab_start"
        Me.lab_start.Size = New System.Drawing.Size(36, 17)
        Me.lab_start.TabIndex = 67
        Me.lab_start.Text = "start"
        Me.lab_start.Visible = False
        '
        'lab_stop
        '
        Me.lab_stop.AutoSize = True
        Me.lab_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_stop.ForeColor = System.Drawing.Color.White
        Me.lab_stop.Location = New System.Drawing.Point(422, 289)
        Me.lab_stop.Name = "lab_stop"
        Me.lab_stop.Size = New System.Drawing.Size(35, 17)
        Me.lab_stop.TabIndex = 68
        Me.lab_stop.Text = "stop"
        Me.lab_stop.Visible = False
        '
        'lab_speed
        '
        Me.lab_speed.AutoSize = True
        Me.lab_speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_speed.ForeColor = System.Drawing.Color.White
        Me.lab_speed.Location = New System.Drawing.Point(470, 289)
        Me.lab_speed.Name = "lab_speed"
        Me.lab_speed.Size = New System.Drawing.Size(63, 17)
        Me.lab_speed.TabIndex = 69
        Me.lab_speed.Text = "% speed"
        Me.lab_speed.Visible = False
        '
        'but_del_profile
        '
        Me.but_del_profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.but_del_profile.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_del_profile.FlatAppearance.BorderSize = 3
        Me.but_del_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_del_profile.Location = New System.Drawing.Point(554, 287)
        Me.but_del_profile.Name = "but_del_profile"
        Me.but_del_profile.Size = New System.Drawing.Size(87, 49)
        Me.but_del_profile.TabIndex = 100
        Me.but_del_profile.Text = "Delete profile"
        Me.but_del_profile.UseVisualStyleBackColor = False
        Me.but_del_profile.Visible = False
        '
        'but_start_profile
        '
        Me.but_start_profile.BackColor = System.Drawing.Color.Lime
        Me.but_start_profile.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_start_profile.FlatAppearance.BorderSize = 3
        Me.but_start_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_start_profile.Location = New System.Drawing.Point(554, 341)
        Me.but_start_profile.Name = "but_start_profile"
        Me.but_start_profile.Size = New System.Drawing.Size(87, 49)
        Me.but_start_profile.TabIndex = 101
        Me.but_start_profile.Text = "Start profile"
        Me.but_start_profile.UseVisualStyleBackColor = False
        Me.but_start_profile.Visible = False
        '
        'but_stop_profile
        '
        Me.but_stop_profile.BackColor = System.Drawing.Color.Red
        Me.but_stop_profile.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_stop_profile.FlatAppearance.BorderSize = 3
        Me.but_stop_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_stop_profile.Location = New System.Drawing.Point(554, 395)
        Me.but_stop_profile.Name = "but_stop_profile"
        Me.but_stop_profile.Size = New System.Drawing.Size(87, 49)
        Me.but_stop_profile.TabIndex = 102
        Me.but_stop_profile.Text = "Stop profile"
        Me.but_stop_profile.UseVisualStyleBackColor = False
        Me.but_stop_profile.Visible = False
        '
        'rbut_ampm
        '
        Me.rbut_ampm.AutoSize = True
        Me.rbut_ampm.ForeColor = System.Drawing.Color.White
        Me.rbut_ampm.Location = New System.Drawing.Point(572, 203)
        Me.rbut_ampm.Name = "rbut_ampm"
        Me.rbut_ampm.Size = New System.Drawing.Size(62, 17)
        Me.rbut_ampm.TabIndex = 103
        Me.rbut_ampm.TabStop = True
        Me.rbut_ampm.Text = "AM/PM"
        Me.rbut_ampm.UseVisualStyleBackColor = True
        Me.rbut_ampm.Visible = False
        '
        'rbut_0_24
        '
        Me.rbut_0_24.AutoSize = True
        Me.rbut_0_24.ForeColor = System.Drawing.Color.White
        Me.rbut_0_24.Location = New System.Drawing.Point(571, 226)
        Me.rbut_0_24.Name = "rbut_0_24"
        Me.rbut_0_24.Size = New System.Drawing.Size(46, 17)
        Me.rbut_0_24.TabIndex = 104
        Me.rbut_0_24.TabStop = True
        Me.rbut_0_24.Text = "0-24"
        Me.rbut_0_24.UseVisualStyleBackColor = True
        Me.rbut_0_24.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(254, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 105)
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'lab_absrel_time_profile
        '
        Me.lab_absrel_time_profile.AutoSize = True
        Me.lab_absrel_time_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_absrel_time_profile.ForeColor = System.Drawing.Color.White
        Me.lab_absrel_time_profile.Location = New System.Drawing.Point(377, 247)
        Me.lab_absrel_time_profile.Name = "lab_absrel_time_profile"
        Me.lab_absrel_time_profile.Size = New System.Drawing.Size(216, 17)
        Me.lab_absrel_time_profile.TabIndex = 117
        Me.lab_absrel_time_profile.Text = "Absolute/relative time profile"
        Me.lab_absrel_time_profile.Visible = False
        '
        'lab_fine_profilo
        '
        Me.lab_fine_profilo.AutoSize = True
        Me.lab_fine_profilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_fine_profilo.ForeColor = System.Drawing.Color.Red
        Me.lab_fine_profilo.Location = New System.Drawing.Point(386, 501)
        Me.lab_fine_profilo.Name = "lab_fine_profilo"
        Me.lab_fine_profilo.Size = New System.Drawing.Size(115, 20)
        Me.lab_fine_profilo.TabIndex = 118
        Me.lab_fine_profilo.Text = "Profile ended"
        Me.lab_fine_profilo.Visible = False
        '
        'lab_ora
        '
        Me.lab_ora.AutoSize = True
        Me.lab_ora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_ora.ForeColor = System.Drawing.Color.White
        Me.lab_ora.Location = New System.Drawing.Point(130, 115)
        Me.lab_ora.Name = "lab_ora"
        Me.lab_ora.Size = New System.Drawing.Size(44, 17)
        Me.lab_ora.TabIndex = 119
        Me.lab_ora.Text = "08:30"
        Me.lab_ora.Visible = False
        '
        'lab_time
        '
        Me.lab_time.AutoSize = True
        Me.lab_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_time.ForeColor = System.Drawing.Color.White
        Me.lab_time.Location = New System.Drawing.Point(40, 113)
        Me.lab_time.Name = "lab_time"
        Me.lab_time.Size = New System.Drawing.Size(39, 17)
        Me.lab_time.TabIndex = 120
        Me.lab_time.Text = "Time"
        Me.lab_time.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(40, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Serial"
        '
        'lab_serial_status
        '
        Me.lab_serial_status.AutoSize = True
        Me.lab_serial_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_serial_status.ForeColor = System.Drawing.Color.White
        Me.lab_serial_status.Location = New System.Drawing.Point(129, 93)
        Me.lab_serial_status.Name = "lab_serial_status"
        Me.lab_serial_status.Size = New System.Drawing.Size(51, 17)
        Me.lab_serial_status.TabIndex = 123
        Me.lab_serial_status.Text = "Closed"
        '
        'lab_running_profile
        '
        Me.lab_running_profile.AutoSize = True
        Me.lab_running_profile.BackColor = System.Drawing.Color.Red
        Me.lab_running_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_running_profile.ForeColor = System.Drawing.Color.White
        Me.lab_running_profile.Location = New System.Drawing.Point(307, 272)
        Me.lab_running_profile.Name = "lab_running_profile"
        Me.lab_running_profile.Size = New System.Drawing.Size(120, 17)
        Me.lab_running_profile.TabIndex = 124
        Me.lab_running_profile.Text = "Running Profile"
        Me.lab_running_profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lab_running_profile.Visible = False
        '
        'lab_start_time
        '
        Me.lab_start_time.AutoSize = True
        Me.lab_start_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_start_time.ForeColor = System.Drawing.Color.White
        Me.lab_start_time.Location = New System.Drawing.Point(40, 132)
        Me.lab_start_time.Name = "lab_start_time"
        Me.lab_start_time.Size = New System.Drawing.Size(73, 17)
        Me.lab_start_time.TabIndex = 127
        Me.lab_start_time.Text = "Start Time"
        Me.lab_start_time.Visible = False
        '
        'lab_num_start_time
        '
        Me.lab_num_start_time.AutoSize = True
        Me.lab_num_start_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_num_start_time.ForeColor = System.Drawing.Color.White
        Me.lab_num_start_time.Location = New System.Drawing.Point(130, 134)
        Me.lab_num_start_time.Name = "lab_num_start_time"
        Me.lab_num_start_time.Size = New System.Drawing.Size(44, 17)
        Me.lab_num_start_time.TabIndex = 126
        Me.lab_num_start_time.Text = "08:30"
        Me.lab_num_start_time.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(0, 299)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(279, 45)
        Me.TrackBar1.TabIndex = 128
        '
        'txbox_trackbar
        '
        Me.txbox_trackbar.Location = New System.Drawing.Point(600, 144)
        Me.txbox_trackbar.Name = "txbox_trackbar"
        Me.txbox_trackbar.Size = New System.Drawing.Size(41, 20)
        Me.txbox_trackbar.TabIndex = 129
        Me.txbox_trackbar.Text = "sx"
        Me.txbox_trackbar.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 17)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(251, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 17)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "100"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(133, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 17)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "50"
        '
        'lab_val_prec
        '
        Me.lab_val_prec.AutoSize = True
        Me.lab_val_prec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_val_prec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lab_val_prec.Location = New System.Drawing.Point(194, 227)
        Me.lab_val_prec.Name = "lab_val_prec"
        Me.lab_val_prec.Size = New System.Drawing.Size(45, 15)
        Me.lab_val_prec.TabIndex = 133
        Me.lab_val_prec.Text = "Prec: 0"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(18, 306)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 7)
        Me.PictureBox3.TabIndex = 134
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(38, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 13)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "Note: pump works with at least 15%"
        '
        'but_00
        '
        Me.but_00.BackColor = System.Drawing.Color.Red
        Me.but_00.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_00.FlatAppearance.BorderSize = 3
        Me.but_00.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_00.Location = New System.Drawing.Point(36, 404)
        Me.but_00.Name = "but_00"
        Me.but_00.Size = New System.Drawing.Size(62, 37)
        Me.but_00.TabIndex = 136
        Me.but_00.Text = "0%"
        Me.but_00.UseVisualStyleBackColor = False
        '
        'but25
        '
        Me.but25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.but25.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but25.FlatAppearance.BorderSize = 3
        Me.but25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but25.Location = New System.Drawing.Point(105, 404)
        Me.but25.Name = "but25"
        Me.but25.Size = New System.Drawing.Size(66, 37)
        Me.but25.TabIndex = 137
        Me.but25.Text = "25%"
        Me.but25.UseVisualStyleBackColor = False
        '
        'but50
        '
        Me.but50.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.but50.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but50.FlatAppearance.BorderSize = 3
        Me.but50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but50.Location = New System.Drawing.Point(179, 404)
        Me.but50.Name = "but50"
        Me.but50.Size = New System.Drawing.Size(66, 37)
        Me.but50.TabIndex = 138
        Me.but50.Text = "50%"
        Me.but50.UseVisualStyleBackColor = False
        '
        'lbox_trackbar
        '
        Me.lbox_trackbar.AutoSize = True
        Me.lbox_trackbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbox_trackbar.ForeColor = System.Drawing.Color.White
        Me.lbox_trackbar.Location = New System.Drawing.Point(149, 227)
        Me.lbox_trackbar.Name = "lbox_trackbar"
        Me.lbox_trackbar.Size = New System.Drawing.Size(17, 17)
        Me.lbox_trackbar.TabIndex = 139
        Me.lbox_trackbar.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'but_emergenza
        '
        Me.but_emergenza.BackColor = System.Drawing.Color.Red
        Me.but_emergenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_emergenza.ForeColor = System.Drawing.Color.Yellow
        Me.but_emergenza.Location = New System.Drawing.Point(294, 143)
        Me.but_emergenza.Name = "but_emergenza"
        Me.but_emergenza.Size = New System.Drawing.Size(347, 32)
        Me.but_emergenza.TabIndex = 140
        Me.but_emergenza.Text = "Warning"
        Me.but_emergenza.UseVisualStyleBackColor = False
        Me.but_emergenza.Visible = False
        '
        'lab_profile_phase
        '
        Me.lab_profile_phase.AutoSize = True
        Me.lab_profile_phase.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_profile_phase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lab_profile_phase.Location = New System.Drawing.Point(12, 504)
        Me.lab_profile_phase.Name = "lab_profile_phase"
        Me.lab_profile_phase.Size = New System.Drawing.Size(42, 9)
        Me.lab_profile_phase.TabIndex = 141
        Me.lab_profile_phase.Text = "prof phase:"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(314, 318)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(213, 180)
        Me.ListBox1.TabIndex = 142
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(656, 522)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lab_profile_phase)
        Me.Controls.Add(Me.but_emergenza)
        Me.Controls.Add(Me.lbox_trackbar)
        Me.Controls.Add(Me.but50)
        Me.Controls.Add(Me.but25)
        Me.Controls.Add(Me.but_00)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lab_val_prec)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txbox_trackbar)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.lab_start_time)
        Me.Controls.Add(Me.lab_num_start_time)
        Me.Controls.Add(Me.lab_running_profile)
        Me.Controls.Add(Me.lab_serial_status)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lab_time)
        Me.Controls.Add(Me.lab_ora)
        Me.Controls.Add(Me.lab_fine_profilo)
        Me.Controls.Add(Me.lab_absrel_time_profile)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbut_0_24)
        Me.Controls.Add(Me.rbut_ampm)
        Me.Controls.Add(Me.but_stop_profile)
        Me.Controls.Add(Me.but_start_profile)
        Me.Controls.Add(Me.but_del_profile)
        Me.Controls.Add(Me.lab_speed)
        Me.Controls.Add(Me.lab_stop)
        Me.Controls.Add(Me.lab_start)
        Me.Controls.Add(Me.lab_profilo)
        Me.Controls.Add(Me.but_open_profilo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbox_temp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbox_ph)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbox_dc_circ)
        Me.Controls.Add(Me.but_change_speed)
        Me.Controls.Add(Me.txbox_51)
        Me.Controls.Add(Me.but_chiudi)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zebrafish"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents but_chiudi As System.Windows.Forms.Button
    Friend WithEvents Serial_485 As System.IO.Ports.SerialPort
    Friend WithEvents txbox_51 As System.Windows.Forms.TextBox
    Friend WithEvents but_change_speed As System.Windows.Forms.Button
    Friend WithEvents txbox_ph As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txbox_temp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbox_dc_circ As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents but_open_profilo As System.Windows.Forms.Button
    Friend WithEvents Timer_profilo As System.Windows.Forms.Timer
    Friend WithEvents lab_profilo As System.Windows.Forms.Label
    Friend WithEvents lab_start As System.Windows.Forms.Label
    Friend WithEvents lab_stop As System.Windows.Forms.Label
    Friend WithEvents lab_speed As System.Windows.Forms.Label
    Friend WithEvents but_del_profile As System.Windows.Forms.Button
    Friend WithEvents but_start_profile As System.Windows.Forms.Button
    Friend WithEvents but_stop_profile As System.Windows.Forms.Button
    Friend WithEvents rbut_ampm As System.Windows.Forms.RadioButton
    Friend WithEvents rbut_0_24 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lab_absrel_time_profile As System.Windows.Forms.Label
    Friend WithEvents lab_fine_profilo As System.Windows.Forms.Label
    Friend WithEvents lab_ora As System.Windows.Forms.Label
    Friend WithEvents lab_time As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lab_serial_status As System.Windows.Forms.Label
    Friend WithEvents lab_running_profile As System.Windows.Forms.Label
    Friend WithEvents lab_start_time As System.Windows.Forms.Label
    Friend WithEvents lab_num_start_time As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents txbox_trackbar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lab_val_prec As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents but_00 As System.Windows.Forms.Button
    Friend WithEvents but25 As System.Windows.Forms.Button
    Friend WithEvents but50 As System.Windows.Forms.Button
    Friend WithEvents lbox_trackbar As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents but_emergenza As System.Windows.Forms.Button
    Friend WithEvents lab_profile_phase As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
