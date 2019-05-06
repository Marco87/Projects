<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashBoard))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLoadMovie = New System.Windows.Forms.Button()
        Me.dtpMovieDate = New System.Windows.Forms.DateTimePicker()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnNewMovie = New System.Windows.Forms.Button()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgResult = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picCinema6 = New System.Windows.Forms.PictureBox()
        Me.picCinema5 = New System.Windows.Forms.PictureBox()
        Me.picCinema4 = New System.Windows.Forms.PictureBox()
        Me.picCinema3 = New System.Windows.Forms.PictureBox()
        Me.picCinema2 = New System.Windows.Forms.PictureBox()
        Me.picCinema1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.dtgResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCinema6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCinema5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCinema4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCinema3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCinema2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCinema1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label7)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.btnLoadMovie)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dtpMovieDate)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.btnClose)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.btnSignOut)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.btnUsers)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.btnNewMovie)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(150, 587)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(150, 612)
        Me.ToolStripContainer1.TabIndex = 13
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "DATE"
        '
        'btnLoadMovie
        '
        Me.btnLoadMovie.Location = New System.Drawing.Point(12, 414)
        Me.btnLoadMovie.Name = "btnLoadMovie"
        Me.btnLoadMovie.Size = New System.Drawing.Size(116, 42)
        Me.btnLoadMovie.TabIndex = 31
        Me.btnLoadMovie.Text = "Load Movies"
        Me.btnLoadMovie.UseVisualStyleBackColor = True
        '
        'dtpMovieDate
        '
        Me.dtpMovieDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMovieDate.Location = New System.Drawing.Point(17, 388)
        Me.dtpMovieDate.Name = "dtpMovieDate"
        Me.dtpMovieDate.Size = New System.Drawing.Size(111, 20)
        Me.dtpMovieDate.TabIndex = 30
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(27, 257)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 69)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Exit"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSignOut
        '
        Me.btnSignOut.Image = CType(resources.GetObject("btnSignOut.Image"), System.Drawing.Image)
        Me.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSignOut.Location = New System.Drawing.Point(27, 182)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(84, 69)
        Me.btnSignOut.TabIndex = 28
        Me.btnSignOut.Text = "Log out"
        Me.btnSignOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsers.Location = New System.Drawing.Point(27, 107)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(84, 69)
        Me.btnUsers.TabIndex = 27
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnNewMovie
        '
        Me.btnNewMovie.Image = CType(resources.GetObject("btnNewMovie.Image"), System.Drawing.Image)
        Me.btnNewMovie.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNewMovie.Location = New System.Drawing.Point(27, 32)
        Me.btnNewMovie.Name = "btnNewMovie"
        Me.btnNewMovie.Size = New System.Drawing.Size(84, 69)
        Me.btnNewMovie.TabIndex = 26
        Me.btnNewMovie.Text = "Movies"
        Me.btnNewMovie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewMovie.UseVisualStyleBackColor = True
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label6)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label5)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label4)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label3)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label2)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label1)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.dtgResult)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.picCinema6)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.picCinema5)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.picCinema4)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.picCinema3)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.picCinema2)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.picCinema1)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.PictureBox1)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(641, 587)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(150, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(641, 612)
        Me.ToolStripContainer2.TabIndex = 14
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 42)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Cinema 6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 42)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Cinema 5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 42)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cinema 4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 42)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cinema 3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 42)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cinema 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 42)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cinema 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtgResult
        '
        Me.dtgResult.AllowUserToAddRows = False
        Me.dtgResult.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue
        Me.dtgResult.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dtgResult.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.remarks})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgResult.DefaultCellStyle = DataGridViewCellStyle12
        Me.dtgResult.Location = New System.Drawing.Point(22, 398)
        Me.dtgResult.Name = "dtgResult"
        Me.dtgResult.ReadOnly = True
        Me.dtgResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgResult.Size = New System.Drawing.Size(587, 183)
        Me.dtgResult.TabIndex = 19
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "sched_id"
        Me.Column3.HeaderText = "id"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "time_fr"
        DataGridViewCellStyle10.Format = "t"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column1.HeaderText = "Start Time"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "time_to"
        DataGridViewCellStyle11.Format = "t"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column2.HeaderText = "End Time"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'remarks
        '
        Me.remarks.DataPropertyName = "remarks"
        Me.remarks.HeaderText = "Remarks"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        Me.remarks.Width = 250
        '
        'picCinema6
        '
        Me.picCinema6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCinema6.Location = New System.Drawing.Point(424, 281)
        Me.picCinema6.Name = "picCinema6"
        Me.picCinema6.Size = New System.Drawing.Size(176, 99)
        Me.picCinema6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCinema6.TabIndex = 18
        Me.picCinema6.TabStop = False
        '
        'picCinema5
        '
        Me.picCinema5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCinema5.Location = New System.Drawing.Point(226, 281)
        Me.picCinema5.Name = "picCinema5"
        Me.picCinema5.Size = New System.Drawing.Size(176, 99)
        Me.picCinema5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCinema5.TabIndex = 17
        Me.picCinema5.TabStop = False
        '
        'picCinema4
        '
        Me.picCinema4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCinema4.Location = New System.Drawing.Point(30, 281)
        Me.picCinema4.Name = "picCinema4"
        Me.picCinema4.Size = New System.Drawing.Size(176, 99)
        Me.picCinema4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCinema4.TabIndex = 16
        Me.picCinema4.TabStop = False
        '
        'picCinema3
        '
        Me.picCinema3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCinema3.Location = New System.Drawing.Point(424, 134)
        Me.picCinema3.Name = "picCinema3"
        Me.picCinema3.Size = New System.Drawing.Size(176, 99)
        Me.picCinema3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCinema3.TabIndex = 15
        Me.picCinema3.TabStop = False
        '
        'picCinema2
        '
        Me.picCinema2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCinema2.Location = New System.Drawing.Point(226, 134)
        Me.picCinema2.Name = "picCinema2"
        Me.picCinema2.Size = New System.Drawing.Size(176, 99)
        Me.picCinema2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCinema2.TabIndex = 14
        Me.picCinema2.TabStop = False
        '
        'picCinema1
        '
        Me.picCinema1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCinema1.Location = New System.Drawing.Point(30, 134)
        Me.picCinema1.Name = "picCinema1"
        Me.picCinema1.Size = New System.Drawing.Size(176, 99)
        Me.picCinema1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCinema1.TabIndex = 13
        Me.picCinema1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(641, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'frmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 612)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dash Board"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.dtgResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCinema6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCinema5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCinema4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCinema3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCinema2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCinema1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents btnNewMovie As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgResult As System.Windows.Forms.DataGridView
    Friend WithEvents picCinema6 As System.Windows.Forms.PictureBox
    Friend WithEvents picCinema5 As System.Windows.Forms.PictureBox
    Friend WithEvents picCinema4 As System.Windows.Forms.PictureBox
    Friend WithEvents picCinema3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCinema2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCinema1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnLoadMovie As System.Windows.Forms.Button
    Friend WithEvents dtpMovieDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
