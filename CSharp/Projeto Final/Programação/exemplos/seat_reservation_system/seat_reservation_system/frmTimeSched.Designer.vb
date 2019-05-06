<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeSched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeSched))
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cboCinema = New System.Windows.Forms.ComboBox()
        Me.dtpSchedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dtpFr1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo3 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr3 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo4 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr4 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo5 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr5 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo6 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr6 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo7 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr7 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo8 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr8 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo9 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr9 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo10 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFr10 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(87, 80)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(335, 20)
        Me.txtRemarks.TabIndex = 24
        '
        'cboCinema
        '
        Me.cboCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCinema.FormattingEnabled = True
        Me.cboCinema.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboCinema.Location = New System.Drawing.Point(87, 53)
        Me.cboCinema.Name = "cboCinema"
        Me.cboCinema.Size = New System.Drawing.Size(56, 21)
        Me.cboCinema.TabIndex = 22
        '
        'dtpSchedDate
        '
        Me.dtpSchedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSchedDate.Location = New System.Drawing.Point(87, 27)
        Me.dtpSchedDate.Name = "dtpSchedDate"
        Me.dtpSchedDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpSchedDate.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Cinema"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Remarks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "From"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "To"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(111, 420)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 34)
        Me.btnNew.TabIndex = 59
        Me.btnNew.Text = "  New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(192, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 34)
        Me.btnSave.TabIndex = 60
        Me.btnSave.Text = "    Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(273, 420)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 61
        Me.btnDelete.Text = "      Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(354, 420)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 62
        Me.btnClose.Text = "     Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtpFr1
        '
        Me.dtpFr1.CustomFormat = " "
        Me.dtpFr1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr1.Location = New System.Drawing.Point(87, 135)
        Me.dtpFr1.Name = "dtpFr1"
        Me.dtpFr1.ShowUpDown = True
        Me.dtpFr1.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr1.TabIndex = 63
        Me.dtpFr1.Tag = "0"
        '
        'dtpTo1
        '
        Me.dtpTo1.CustomFormat = " "
        Me.dtpTo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo1.Location = New System.Drawing.Point(229, 135)
        Me.dtpTo1.Name = "dtpTo1"
        Me.dtpTo1.ShowUpDown = True
        Me.dtpTo1.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo1.TabIndex = 64
        Me.dtpTo1.Tag = "0"
        '
        'dtpTo2
        '
        Me.dtpTo2.CustomFormat = " "
        Me.dtpTo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo2.Location = New System.Drawing.Point(229, 161)
        Me.dtpTo2.Name = "dtpTo2"
        Me.dtpTo2.ShowUpDown = True
        Me.dtpTo2.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo2.TabIndex = 66
        Me.dtpTo2.Tag = "0"
        '
        'dtpFr2
        '
        Me.dtpFr2.CustomFormat = " "
        Me.dtpFr2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr2.Location = New System.Drawing.Point(87, 161)
        Me.dtpFr2.Name = "dtpFr2"
        Me.dtpFr2.ShowUpDown = True
        Me.dtpFr2.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr2.TabIndex = 65
        Me.dtpFr2.Tag = "0"
        '
        'dtpTo3
        '
        Me.dtpTo3.CustomFormat = " "
        Me.dtpTo3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo3.Location = New System.Drawing.Point(229, 187)
        Me.dtpTo3.Name = "dtpTo3"
        Me.dtpTo3.ShowUpDown = True
        Me.dtpTo3.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo3.TabIndex = 68
        Me.dtpTo3.Tag = "0"
        '
        'dtpFr3
        '
        Me.dtpFr3.CustomFormat = " "
        Me.dtpFr3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr3.Location = New System.Drawing.Point(87, 187)
        Me.dtpFr3.Name = "dtpFr3"
        Me.dtpFr3.ShowUpDown = True
        Me.dtpFr3.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr3.TabIndex = 67
        Me.dtpFr3.Tag = "0"
        '
        'dtpTo4
        '
        Me.dtpTo4.CustomFormat = " "
        Me.dtpTo4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo4.Location = New System.Drawing.Point(229, 213)
        Me.dtpTo4.Name = "dtpTo4"
        Me.dtpTo4.ShowUpDown = True
        Me.dtpTo4.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo4.TabIndex = 70
        Me.dtpTo4.Tag = "0"
        '
        'dtpFr4
        '
        Me.dtpFr4.CustomFormat = " "
        Me.dtpFr4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr4.Location = New System.Drawing.Point(87, 213)
        Me.dtpFr4.Name = "dtpFr4"
        Me.dtpFr4.ShowUpDown = True
        Me.dtpFr4.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr4.TabIndex = 69
        Me.dtpFr4.Tag = "0"
        '
        'dtpTo5
        '
        Me.dtpTo5.CustomFormat = " "
        Me.dtpTo5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo5.Location = New System.Drawing.Point(229, 239)
        Me.dtpTo5.Name = "dtpTo5"
        Me.dtpTo5.ShowUpDown = True
        Me.dtpTo5.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo5.TabIndex = 72
        Me.dtpTo5.Tag = "0"
        '
        'dtpFr5
        '
        Me.dtpFr5.CustomFormat = " "
        Me.dtpFr5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr5.Location = New System.Drawing.Point(87, 239)
        Me.dtpFr5.Name = "dtpFr5"
        Me.dtpFr5.ShowUpDown = True
        Me.dtpFr5.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr5.TabIndex = 71
        Me.dtpFr5.Tag = "0"
        '
        'dtpTo6
        '
        Me.dtpTo6.CustomFormat = " "
        Me.dtpTo6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo6.Location = New System.Drawing.Point(229, 265)
        Me.dtpTo6.Name = "dtpTo6"
        Me.dtpTo6.ShowUpDown = True
        Me.dtpTo6.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo6.TabIndex = 74
        Me.dtpTo6.Tag = "0"
        '
        'dtpFr6
        '
        Me.dtpFr6.CustomFormat = " "
        Me.dtpFr6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr6.Location = New System.Drawing.Point(87, 265)
        Me.dtpFr6.Name = "dtpFr6"
        Me.dtpFr6.ShowUpDown = True
        Me.dtpFr6.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr6.TabIndex = 73
        Me.dtpFr6.Tag = "0"
        '
        'dtpTo7
        '
        Me.dtpTo7.CustomFormat = " "
        Me.dtpTo7.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo7.Location = New System.Drawing.Point(229, 291)
        Me.dtpTo7.Name = "dtpTo7"
        Me.dtpTo7.ShowUpDown = True
        Me.dtpTo7.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo7.TabIndex = 76
        Me.dtpTo7.Tag = "0"
        '
        'dtpFr7
        '
        Me.dtpFr7.CustomFormat = " "
        Me.dtpFr7.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr7.Location = New System.Drawing.Point(87, 291)
        Me.dtpFr7.Name = "dtpFr7"
        Me.dtpFr7.ShowUpDown = True
        Me.dtpFr7.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr7.TabIndex = 75
        Me.dtpFr7.Tag = "0"
        '
        'dtpTo8
        '
        Me.dtpTo8.CustomFormat = " "
        Me.dtpTo8.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo8.Location = New System.Drawing.Point(229, 317)
        Me.dtpTo8.Name = "dtpTo8"
        Me.dtpTo8.ShowUpDown = True
        Me.dtpTo8.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo8.TabIndex = 78
        Me.dtpTo8.Tag = "0"
        '
        'dtpFr8
        '
        Me.dtpFr8.CustomFormat = " "
        Me.dtpFr8.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr8.Location = New System.Drawing.Point(87, 317)
        Me.dtpFr8.Name = "dtpFr8"
        Me.dtpFr8.ShowUpDown = True
        Me.dtpFr8.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr8.TabIndex = 77
        Me.dtpFr8.Tag = "0"
        '
        'dtpTo9
        '
        Me.dtpTo9.CustomFormat = " "
        Me.dtpTo9.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo9.Location = New System.Drawing.Point(229, 343)
        Me.dtpTo9.Name = "dtpTo9"
        Me.dtpTo9.ShowUpDown = True
        Me.dtpTo9.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo9.TabIndex = 80
        Me.dtpTo9.Tag = "0"
        '
        'dtpFr9
        '
        Me.dtpFr9.CustomFormat = " "
        Me.dtpFr9.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr9.Location = New System.Drawing.Point(87, 343)
        Me.dtpFr9.Name = "dtpFr9"
        Me.dtpFr9.ShowUpDown = True
        Me.dtpFr9.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr9.TabIndex = 79
        Me.dtpFr9.Tag = "0"
        '
        'dtpTo10
        '
        Me.dtpTo10.CustomFormat = " "
        Me.dtpTo10.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo10.Location = New System.Drawing.Point(229, 369)
        Me.dtpTo10.Name = "dtpTo10"
        Me.dtpTo10.ShowUpDown = True
        Me.dtpTo10.Size = New System.Drawing.Size(112, 20)
        Me.dtpTo10.TabIndex = 82
        Me.dtpTo10.Tag = "0"
        '
        'dtpFr10
        '
        Me.dtpFr10.CustomFormat = " "
        Me.dtpFr10.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFr10.Location = New System.Drawing.Point(87, 369)
        Me.dtpFr10.Name = "dtpFr10"
        Me.dtpFr10.ShowUpDown = True
        Me.dtpFr10.Size = New System.Drawing.Size(112, 20)
        Me.dtpFr10.TabIndex = 81
        Me.dtpFr10.Tag = "0"
        '
        'frmTimeSched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 466)
        Me.Controls.Add(Me.dtpTo10)
        Me.Controls.Add(Me.dtpFr10)
        Me.Controls.Add(Me.dtpTo9)
        Me.Controls.Add(Me.dtpFr9)
        Me.Controls.Add(Me.dtpTo8)
        Me.Controls.Add(Me.dtpFr8)
        Me.Controls.Add(Me.dtpTo7)
        Me.Controls.Add(Me.dtpFr7)
        Me.Controls.Add(Me.dtpTo6)
        Me.Controls.Add(Me.dtpFr6)
        Me.Controls.Add(Me.dtpTo5)
        Me.Controls.Add(Me.dtpFr5)
        Me.Controls.Add(Me.dtpTo4)
        Me.Controls.Add(Me.dtpFr4)
        Me.Controls.Add(Me.dtpTo3)
        Me.Controls.Add(Me.dtpFr3)
        Me.Controls.Add(Me.dtpTo2)
        Me.Controls.Add(Me.dtpFr2)
        Me.Controls.Add(Me.dtpTo1)
        Me.Controls.Add(Me.dtpFr1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cboCinema)
        Me.Controls.Add(Me.dtpSchedDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTimeSched"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movie Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cboCinema As System.Windows.Forms.ComboBox
    Friend WithEvents dtpSchedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtpFr1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo7 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr7 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo8 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr8 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo9 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr9 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo10 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFr10 As System.Windows.Forms.DateTimePicker
End Class
