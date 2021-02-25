<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_serial
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
        Me.lbox_serial_port = New System.Windows.Forms.ListBox
        Me.but_try_to_open = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbox_serial_port
        '
        Me.lbox_serial_port.FormattingEnabled = True
        Me.lbox_serial_port.Location = New System.Drawing.Point(60, 64)
        Me.lbox_serial_port.Name = "lbox_serial_port"
        Me.lbox_serial_port.Size = New System.Drawing.Size(88, 95)
        Me.lbox_serial_port.TabIndex = 129
        '
        'but_try_to_open
        '
        Me.but_try_to_open.Location = New System.Drawing.Point(154, 64)
        Me.but_try_to_open.Name = "but_try_to_open"
        Me.but_try_to_open.Size = New System.Drawing.Size(83, 49)
        Me.but_try_to_open.TabIndex = 130
        Me.but_try_to_open.Text = "Try to open"
        Me.but_try_to_open.UseVisualStyleBackColor = True
        '
        'form_serial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.but_try_to_open)
        Me.Controls.Add(Me.lbox_serial_port)
        Me.Name = "form_serial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_serial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbox_serial_port As System.Windows.Forms.ListBox
    Friend WithEvents but_try_to_open As System.Windows.Forms.Button
End Class
