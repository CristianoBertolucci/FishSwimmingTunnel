Imports System
Imports System.Threading
Imports System.IO

'test interface for zebrafish pump controller
'starting: September 2019

Public Class Form1

    '---------------------------------------------------
    'constant
    '---------------------------------------------------
    Public Const START = 1
    Public Const STOPP = 2
    Public Const VEL = 3
    '---------------------------------------------------
    'string
    '---------------------------------------------------
    Public profili(30), campi(5) As String
    Public stringa_da_inviare As String
    Public ora, minuti, secondi As String
    '---------------------------------------------------
    'boolean
    '---------------------------------------------------
    Public riuscita_apertura_seriale, refresh_dati, send_seriale As Boolean
    Public PM As Boolean
    Public tempo_ass As Boolean
    Public puoi_iniziare_profilo As Boolean
    Public prima_volta As Boolean
    Public running_profile As Boolean
    '---------------------------------------------------
    'integer
    '---------------------------------------------------
    Public start_orario_tot(31), stop_orario_tot(31) As Integer
    Public attuale_orario_tot, tempo_start_fase, tempo_tot_da_inizio As Integer
    Public tempo_attesa As Integer
    Dim tempo_seriale_errore As Integer
    '---------------------------------------------------
    'date
    '---------------------------------------------------
    Public currentTime As Date
    '---------------------------------------------------
    'byte
    '---------------------------------------------------
    Public start_ora(31), start_minuti(31), stop_ora(31), stop_minuti(31), speed_fase(31) As Byte
    Public ciccio As Byte
    Public fase_profilo As Byte
    Public n_fasi As Byte
    Public prec_value As Byte
    Public i As Byte
    '---------------------------------------------------
    'double
    '---------------------------------------------------
    Public temp(10) As Double
    Public ph(10) As Double
    Public media_temp, media_ph As Double

    '----------------------------------------------------------------------------------------
    'button to exit the program
    '----------------------------------------------------------------------------------------
    Private Sub but_chiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_chiudi.Click
        Dim puoi_uscire As Boolean

        'before closing, if communication is ON then send a 0 to the pump
        If riuscita_apertura_seriale Then
            stringa_da_inviare = "dut0" & vbCr
            Serial_485.Write(stringa_da_inviare)
        End If

        Me.Focus()
        Try
            puoi_uscire = Application.AllowQuit()
        Catch ex As Exception

        End Try
        Me.Focus()
        If puoi_uscire Then

            Application.Exit()
        End If
    End Sub
    
    '-------------------------------------------------
    'thread to close serial port
    '-------------------------------------------------
    Private Sub mio_thread_chiudi_seriale()
        Try
            Serial_485.Close() 'close the serial port
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'catch any serial port closing error messages
        End Try
    End Sub

    '----------------------------------------------------------------------------------------
    ' form load event
    '----------------------------------------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ritorno_msg, ritorno_msg1 As MsgBoxResult
        Dim caption = "Serial Port"
        Dim porta_COM As String

        refresh_dati = True
        send_seriale = True
        prec_value = 0 'previous pump value
        '-----------------------------------------------------
        'trying to open serial port
        '------------------------------------------------------
        Serial_485.PortName = "COM1"
        Serial_485.BaudRate = 115200
        riuscita_apertura_seriale = True

        ritorno_msg = MsgBox("Open serial port?", 4, caption)

        If (ritorno_msg = MsgBoxResult.Yes) Then

            Dim MyReader2 As Microsoft.VisualBasic.FileIO.TextFieldParser
            Try
                MyReader2 = My.Computer.FileSystem.OpenTextFieldParser("serial_port.txt")
                porta_COM = MyReader2.ReadLine
                Serial_485.PortName = porta_COM
                MyReader2.Close() ' Close the TextFieldParser

            Catch ex As Exception
                MsgBox("Error in opening serial_port.txt. File corrupted or absent")
                riuscita_apertura_seriale = False
            End Try

            If (riuscita_apertura_seriale) Then
                Try
                    Serial_485.Open()
                    riuscita_apertura_seriale = True
                Catch ex As Exception
                    riuscita_apertura_seriale = False
                    MsgBox("Error in opening serial port COM", , caption)
                    ritorno_msg1 = MsgBox("Do you want to change serial port?", 4, caption)

                    If (ritorno_msg1 = MsgBoxResult.Yes) Then
                        Dim form_serial As New form_serial
                        form_serial.ShowDialog()
                    End If
                End Try
            End If
        Else
            riuscita_apertura_seriale = False
        End If


        lbox_dc_circ.SelectedIndex = 0
        If riuscita_apertura_seriale Then
            'PWM circulator set to 0
            stringa_da_inviare = "cir0" & vbCr
            Serial_485.Write(stringa_da_inviare)
            lab_serial_status.Text = "Open"
            lbox_trackbar.Text = 0
        End If
        rbut_0_24.Checked = True 'hour in format 0 to 23
        Timer1.Start()
    End Sub

    '---------------------------------------------------------------------------------------
    '-----------------------         TIMER for profile control          --------------------
    '---------------------------------------------------------------------------------------
    Private Sub Timer_tx_comandi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_profilo.Tick

        If running_profile Then

            lab_profile_phase.Text = fase_profilo

            currentTime = TimeOfDay
            ora = currentTime.Hour.ToString
            If (ora.Length = 1) Then
                ora = "0" & ora
            End If
            minuti = currentTime.Minute.ToString
            If (minuti.Length = 1) Then
                minuti = "0" & minuti
            End If
            secondi = currentTime.Second.ToString
            If (secondi.Length = 1) Then
                secondi = "0" & secondi
            End If
            lab_ora.Text = ora & ":" & minuti & ":" & secondi
            If (currentTime.ToString.IndexOf("PM")) Then
                PM = True
                attuale_orario_tot = 720 + currentTime.Hour * 60 + currentTime.Minute
            Else
                PM = False
                attuale_orario_tot = currentTime.Hour * 60 + currentTime.Minute
            End If
            attuale_orario_tot = currentTime.Hour * 60 + currentTime.Minute

            'check if time is relative or absolute
            If (tempo_ass) Then
                'absolute time
                If (attuale_orario_tot >= start_orario_tot(fase_profilo)) And (attuale_orario_tot < stop_orario_tot(fase_profilo)) Then

                    If prima_volta Then
                        prima_volta = False
                        stringa_da_inviare = "dut" & speed_fase(fase_profilo) * 10 & vbCr
                        If riuscita_apertura_seriale Then
                            Serial_485.Write(stringa_da_inviare)
                        End If
                    End If

                Else
                    If (attuale_orario_tot >= stop_orario_tot(fase_profilo)) Then
                        If (fase_profilo < n_fasi) Then
                            'passing to next step
                            prima_volta = True
                            fase_profilo = fase_profilo + 1
                            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                            stringa_da_inviare = "dut" & speed_fase(fase_profilo) * 10 & vbCr
                            If riuscita_apertura_seriale Then
                                Serial_485.Write(stringa_da_inviare)
                            End If

                        Else
                            'finished
                            stringa_da_inviare = "dut0" & vbCr 'stop the pump
                            If riuscita_apertura_seriale Then
                                Serial_485.Write(stringa_da_inviare)
                            End If
                            lab_fine_profilo.Visible = True
                            but_stop_profile.Visible = False
                            but_del_profile.Visible = True
                            lab_running_profile.Visible = False
                            lab_ora.Visible = False
                            lab_time.Visible = False
                            Timer_profilo.Stop()
                        End If
                    End If
                End If

            Else
                'relative time
                If (attuale_orario_tot - tempo_start_fase >= start_orario_tot(fase_profilo)) Then
                   
                    If (fase_profilo < n_fasi) Then
                        'passing to next step
                        fase_profilo = fase_profilo + 1
                        ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                        tempo_start_fase = attuale_orario_tot
                        stringa_da_inviare = "dut" & speed_fase(fase_profilo) * 10 & vbCr
                        If riuscita_apertura_seriale Then
                            Serial_485.Write(stringa_da_inviare)
                        End If
                    Else
                        'finished
                        stringa_da_inviare = "dut0" & vbCr 'stop the pump
                        If riuscita_apertura_seriale Then
                            Serial_485.Write(stringa_da_inviare)
                        End If
                        lab_fine_profilo.Visible = True
                        but_stop_profile.Visible = False
                        but_del_profile.Visible = True
                        lab_running_profile.Visible = False
                        lab_ora.Visible = False
                        lab_time.Visible = False
                        Timer_profilo.Stop()
                    End If
                End If
            End If
        End If
    End Sub


    '----------------------------------   ***************************----------------------------------------
    '-------------------------------         READING FROM SERIAL PORT   -------------------------------------
    '--------------------------------     ***************************----------------------------------------
    '--------------------------------     ***************************----------------------------------------

    'delegate 
    Public Delegate Sub myDelegate()
    'event: something arrived from serial port

    Private Sub seriale_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Serial_485.DataReceived
        Try
            txbox_51.Invoke(New myDelegate(AddressOf leggi_da_seriale), New Object() {})

        Catch ex As Exception

            'Finally

        End Try
    End Sub

    Private Sub leggi_da_seriale()

        Dim s As String
        Dim a As Byte
        Dim j As Byte

        tempo_seriale_errore = 0 'set serial time to 0
        'if I don't receive something from serial port for a certain amount of time --> error
        s = Serial_485.ReadLine
        a = s.IndexOf("*")
        If (a > 0) Then
            ph(i) = CDbl(s.Substring(a + 1)) / 100
            temp(i) = CDbl(s.Remove(a)) / 100
            If (i < 10) Then
                i = i + 1
            Else
                i = 0
                media_temp = 0
                media_ph = 0
                For j = 0 To 9
                    media_temp = media_temp + temp(j)
                    media_ph = media_ph + ph(j)
                Next
                media_temp = media_temp / 10
                media_ph = media_ph / 10
                'an average value every 10 samples
                txbox_temp.Text = media_temp
                txbox_ph.Text = media_ph
            End If

        End If
    End Sub
    '-------------------------------------------------
    'button for data refresh
    '-------------------------------------------------
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If refresh_dati Then
            refresh_dati = False
        Else
            refresh_dati = True
        End If
    End Sub
    '-------------------------------------------------
    'button for profile opening
    '-------------------------------------------------
    Private Sub but_open_prifilo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_open_profilo.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Dim i, parziale As Byte

        ListBox1.Items.Clear()
        For i = 0 To 30
            speed_fase(i) = 0
            start_ora(i) = 0
            start_minuti(i) = 0
            stop_ora(i) = 0
            stop_minuti(i) = 0
            start_orario_tot(i) = 0
            stop_orario_tot(i) = 0
        Next

        'opening  a file explorer
        If result = Windows.Forms.DialogResult.OK Then

            Dim path As String = OpenFileDialog1.FileName
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(path)
            Dim stringReader As String

            puoi_iniziare_profilo = True

            lab_profilo.Visible = True
            lab_start.Visible = True
            lab_speed.Visible = True
            lab_absrel_time_profile.Visible = True
            For i = 0 To 31
                stringReader = fileReader.ReadLine()
                If (stringReader <> Nothing) Then
                    profili(i) = stringReader
                    If (i = 0) Then

                        If (profili(0) = "ass") Then
                            tempo_ass = True
                            lab_absrel_time_profile.Text = "Absolute time profile"
                        Else
                            If (profili(0) = "rel") Then
                                tempo_ass = False
                                lab_absrel_time_profile.Text = "Relative time profile"
                            Else
                                MessageBox.Show("Attenzione: file profilo corrotto")
                                puoi_iniziare_profilo = False
                                Exit Sub
                            End If
                        End If
                    Else

                        campi = profili(i).Split(",")
                        parziale = campi(0).IndexOf(".")
                        start_ora(i) = CByte(campi(0).Remove(parziale, campi(0).Length - parziale))
                        start_minuti(i) = CByte(campi(0).Substring(parziale + 1))

                        If (tempo_ass) Then
                            parziale = campi(1).IndexOf(".")
                            stop_ora(i) = CByte(campi(1).Remove(parziale, campi(1).Length - parziale))
                            stop_minuti(i) = CByte(campi(1).Substring(parziale + 1))
                            speed_fase(i) = CByte(campi(2))
                        Else
                            'tempo relativo
                            speed_fase(i) = CByte(campi(1))
                        End If

                        'security checks
                        If (rbut_ampm.Checked And ((start_ora(i) > 12) Or (stop_ora(i) > 12))) Then
                            MessageBox.Show("Attenzione: incongruenza AM/PM con orari profilo")
                            puoi_iniziare_profilo = False
                        End If

                        If (start_minuti(i) > 59) Or (stop_minuti(i) > 59) Then
                            MessageBox.Show("Attenzione: i minuti devono essere compresi nel range 0 - 59. Carica un profilo valido")
                            puoi_iniziare_profilo = False
                        End If

                        If (start_ora(i) > 23) Or (stop_ora(i) > 23) Or (start_ora(i) < 0) Or (stop_ora(i) < 0) Then
                            MessageBox.Show("Attenzione: le ore devono essere comprese nel range 0 - 23. Carica un profino valido")
                            puoi_iniziare_profilo = False
                        End If

                        start_orario_tot(i) = start_ora(i) * 60 + start_minuti(i)
                        stop_orario_tot(i) = stop_ora(i) * 60 + stop_minuti(i)


                        If (tempo_ass) Then
                            If (i < 10) Then
                                ListBox1.Items.Add("0" + i.ToString + "          " + campi(0) + "          " + campi(1) + "          " + campi(2))

                            Else
                                ListBox1.Items.Add(i.ToString + "          " + campi(0) + "          " + campi(1) + "          " + campi(2))
                            End If

                        Else
                            If (i < 10) Then
                                ListBox1.Items.Add("0" + i.ToString + "          " + campi(0) + "          " + campi(1))
                            Else
                                ListBox1.Items.Add(i.ToString + "          " + campi(0) + "          " + campi(1))
                            End If
                        End If
                        ListBox1.SelectedIndex = 0
                    End If

                Else

                    but_del_profile.Visible = True
                    but_start_profile.Visible = True
                    n_fasi = i - 1
                    Exit For
                End If
            Next

            'if profile steps have not incremental values, there is an error
            For i = 1 To n_fasi - 1
                If (stop_orario_tot(i) > start_orario_tot(i + 1)) Then
                    MessageBox.Show("Attenzione: una fascia oraria finisce dopo l'inizio della successiva. Caricare un profilo valido")
                    puoi_iniziare_profilo = False
                    Exit For
                End If
            Next
            If (tempo_ass) Then
                lab_stop.Visible = True
                lab_start.Location = New Point(360, 289)
                lab_start.Text = "start"
                lab_stop.Location = New Point(420, 289)
                lab_speed.Location = New Point(460, 289)
            Else
                'relative time
                lab_stop.Visible = False
                lab_start.Location = New Point(360, 289)
                lab_start.Text = "lenght"
                lab_speed.Location = New Point(420, 289)
            End If
        End If
    End Sub
    '-------------------------------------------------
    'listbox to select pump speed
    '-------------------------------------------------
    Private Sub lbox_dc_circ_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbox_dc_circ.SelectedIndexChanged
        If riuscita_apertura_seriale Then
            stringa_da_inviare = "dut" & lbox_dc_circ.SelectedItem * 10 & vbCr
            Serial_485.Write(stringa_da_inviare)
        End If
    End Sub
    '-------------------------------------------------
    'button to erase a profile
    '-------------------------------------------------
    Private Sub but_del_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_del_profile.Click

        ListBox1.Items.Clear()
        rbut_0_24.Enabled = True
        rbut_ampm.Enabled = True

        but_start_profile.Visible = False
        but_stop_profile.Visible = False
        but_del_profile.Visible = False

        lab_profilo.Visible = False
        lab_start.Visible = False
        lab_stop.Visible = False
        lab_speed.Visible = False
        lab_absrel_time_profile.Visible = False
        lab_running_profile.Visible = False
        lab_fine_profilo.Visible = False

    End Sub
    '-------------------------------------------------
    'button to run a profile
    '-------------------------------------------------
    Private Sub but_start_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_start_profile.Click

        'show current time
        currentTime = TimeOfDay
        lab_ora.Text = currentTime.Hour & ":" & currentTime.Minute

        If (puoi_iniziare_profilo) Then

            lab_running_profile.Text = "Running Profile"
            'absolute time
            attuale_orario_tot = currentTime.Hour * 60 + currentTime.Minute
            'check if start time is before actual time
            If (tempo_ass) Then

                If (attuale_orario_tot > start_orario_tot(1)) Then
                    MessageBox.Show("Errore: ora iniziale precedente all'ora attuale. Carica un profilo valido")
                    puoi_iniziare_profilo = False
                    Exit Sub
                End If
            Else

                lab_start_time.Visible = True
                lab_num_start_time.Visible = True
                lab_num_start_time.Text = lab_ora.Text
                tempo_start_fase = attuale_orario_tot
                'set the pump to 0
                If riuscita_apertura_seriale Then
                    stringa_da_inviare = "cir0" & vbCr
                    Serial_485.Write(stringa_da_inviare)
                End If
            End If


            but_stop_profile.Visible = True
            but_start_profile.Visible = False
            but_del_profile.Visible = False
            fase_profilo = 0
            running_profile = True
            rbut_ampm.Enabled = False
            rbut_0_24.Enabled = False
            lab_ora.Visible = True
            lab_time.Visible = True
            lab_running_profile.Visible = True

            fase_profilo = 1
            prima_volta = True
            Timer_profilo.Start()
            ciccio = 0
        End If
    End Sub


    Private Sub rbut_ampm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbut_ampm.CheckedChanged
        ciccio = 0
    End Sub

    Private Sub rbut_0_24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbut_0_24.CheckedChanged
        ciccio = 0
    End Sub
    '-------------------------------------------------
    'button to stop a profile
    '-------------------------------------------------
    Private Sub but_stop_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_stop_profile.Click
        'stop the pump
        If riuscita_apertura_seriale Then
            stringa_da_inviare = "dut0" & vbCr
            Serial_485.Write(stringa_da_inviare)
        End If
        but_del_profile.Visible = True
        but_stop_profile.Visible = False
        lab_running_profile.Text = "Profile stopped"
        running_profile = False
        fase_profilo = 0
        lab_profile_phase.Text = fase_profilo
        Timer_profilo.Stop()
    End Sub
    '-------------------------------------------------
    'update pump's value trackbar 
    '-------------------------------------------------
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        lbox_trackbar.Text = TrackBar1.Value
    End Sub
    '-------------------------------------------------
    'button to send a command to the pump
    '-------------------------------------------------
    Private Sub but_change_speed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_change_speed.Click

        lab_val_prec.Text = "Prec: " & prec_value.ToString
        prec_value = TrackBar1.Value
        If riuscita_apertura_seriale Then
            stringa_da_inviare = "dut" & TrackBar1.Value * 10 & vbCr
            Serial_485.Write(stringa_da_inviare)
        End If
    End Sub

    Private Sub but_00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_00.Click
        lab_val_prec.Text = "Prec: " & prec_value.ToString
        prec_value = 0
        TrackBar1.Value = 0
        lbox_trackbar.Text = 0
        If riuscita_apertura_seriale Then
            stringa_da_inviare = "dut0" & vbCr
            Serial_485.Write(stringa_da_inviare)
        End If
    End Sub

    Private Sub but25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but25.Click
        lab_val_prec.Text = "Prec: " & prec_value.ToString
        prec_value = 25
        TrackBar1.Value = 25
        lbox_trackbar.Text = 25
        If riuscita_apertura_seriale Then
            stringa_da_inviare = "dut250" & vbCr
            Serial_485.Write(stringa_da_inviare)
        End If
    End Sub

    Private Sub but50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but50.Click
        lab_val_prec.Text = "Prec: " & prec_value.ToString
        prec_value = 50
        TrackBar1.Value = 50
        lbox_trackbar.Text = 50
        If riuscita_apertura_seriale Then
            stringa_da_inviare = "dut500" & vbCr
            Serial_485.Write(stringa_da_inviare)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'every second checks stream coming from the video program
        Dim filestream As FileStream = New FileStream("pipe", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim filereader As StreamReader = New StreamReader(filestream)
        Dim line As String

        While (Not filereader.EndOfStream)
            line = filereader.ReadLine()
            If line = "1" Then
                'the other program set the condition "tired fish" --> stop the profile and the pump
                If riuscita_apertura_seriale Then
                    stringa_da_inviare = "dut0" & vbCr
                    Serial_485.Write(stringa_da_inviare)
                End If
                but_00.PerformClick() 'the same as clicking on the button to set pump to 0
                but_emergenza.Visible = True
                running_profile = False
                fase_profilo = 0
                lab_profile_phase.Text = fase_profilo
                lab_running_profile.Visible = True
                lab_running_profile.Text = "Profile stopped by camera alarm"
                Timer_profilo.Stop()

            ElseIf line = "0" Then
                but_emergenza.Visible = False
            End If
        End While

        filestream.Close()
        filereader.Close()
    End Sub
End Class


