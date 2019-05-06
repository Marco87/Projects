<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarkSeat
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarkSeat))
        Me.lblSeatNo = New System.Windows.Forms.Label()
        Me.rbAvailable = New System.Windows.Forms.RadioButton()
        Me.rbOccupied = New System.Windows.Forms.RadioButton()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'lblSeatNo
        '
        Me.lblSeatNo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblSeatNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatNo.ForeColor = System.Drawing.Color.White
        Me.lblSeatNo.Location = New System.Drawing.Point(12, 21)
        Me.lblSeatNo.Name = "lblSeatNo"
        Me.lblSeatNo.Size = New System.Drawing.Size(155, 85)
        Me.lblSeatNo.TabIndex = 0
        Me.lblSeatNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbAvailable
        '
        Me.rbAvailable.AutoSize = True
        Me.rbAvailable.Location = New System.Drawing.Point(12, 119)
        Me.rbAvailable.Name = "rbAvailable"
        Me.rbAvailable.Size = New System.Drawing.Size(68, 17)
        Me.rbAvailable.TabIndex = 1
        Me.rbAvailable.TabStop = True
        Me.rbAvailable.Text = "Available"
        Me.rbAvailable.UseVisualStyleBackColor = True
        '
        'rbOccupied
        '
        Me.rbOccupied.AutoSize = True
        Me.rbOccupied.Location = New System.Drawing.Point(104, 119)
        Me.rbOccupied.Name = "rbOccupied"
        Me.rbOccupied.Size = New System.Drawing.Size(71, 17)
        Me.rbOccupied.TabIndex = 2
        Me.rbOccupied.TabStop = True
        Me.rbOccupied.Text = "Occupied"
        Me.rbOccupied.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(12, 152)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(78, 40)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "   Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seat #"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(96, 152)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(78, 40)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "    Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "chair-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "chair_occupied.png")
        '
        'frmMarkSeat
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 204)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.rbOccupied)
        Me.Controls.Add(Me.rbAvailable)
        Me.Controls.Add(Me.lblSeatNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMarkSeat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeatNo As System.Windows.Forms.Label
    Friend WithEvents rbAvailable As System.Windows.Forms.RadioButton
    Friend WithEvents rbOccupied As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
