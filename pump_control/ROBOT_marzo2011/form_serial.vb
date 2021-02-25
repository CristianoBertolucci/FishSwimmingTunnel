Public Class form_serial

    Private Sub form_serial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n_serial As Byte

        Me.BringToFront()
        ' Show all available COM ports.
        n_serial = 0
        For Each sp As String In My.Computer.Ports.SerialPortNames
            lbox_serial_port.Items.Add(sp)
            n_serial = n_serial + 1
        Next
        If (n_serial > 0) Then
            lbox_serial_port.SelectedIndex = 0
        Else
            MsgBox("Error: no serial port available")
            Me.Close()
        End If
    End Sub

    Private Sub but_try_to_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_try_to_open.Click
        If (lbox_serial_port.SelectedItem <> Nothing) Then
            Form1.Serial_485.PortName = lbox_serial_port.SelectedItem
            'update with the last COM port used
            My.Computer.FileSystem.WriteAllText("porta_seriale.txt", Form1.Serial_485.PortName, False)
            'try to open the selected COM port
            Try
                Form1.Serial_485.Open()
                Form1.riuscita_apertura_seriale = True
                Form1.lab_serial_status.Text = "Open"
                Me.Close()
            Catch ex As Exception
                Form1.riuscita_apertura_seriale = False
                MsgBox("Error in opening serial port")
            End Try
        Else
            MsgBox("Error: select a serial port")
        End If
    End Sub
End Class