<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DateTicket))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpDateTicket = New System.Windows.Forms.GroupBox()
        Me.cmbTicket = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblMovie2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpDateTicket.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(225, 62)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(396, 22)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SELECT DATE AND NUMBER OF TICKETS"
        '
        'grpDateTicket
        '
        Me.grpDateTicket.Controls.Add(Me.cmbTicket)
        Me.grpDateTicket.Controls.Add(Me.dtpDate)
        Me.grpDateTicket.Controls.Add(Me.lblMovie2)
        Me.grpDateTicket.Controls.Add(Me.lblDate)
        Me.grpDateTicket.Controls.Add(Me.lblTicket)
        Me.grpDateTicket.Controls.Add(Me.lblMovie)
        Me.grpDateTicket.Location = New System.Drawing.Point(229, 127)
        Me.grpDateTicket.Name = "grpDateTicket"
        Me.grpDateTicket.Size = New System.Drawing.Size(393, 151)
        Me.grpDateTicket.TabIndex = 1
        Me.grpDateTicket.TabStop = False
        '
        'cmbTicket
        '
        Me.cmbTicket.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbTicket.FormattingEnabled = True
        Me.cmbTicket.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbTicket.Location = New System.Drawing.Point(150, 101)
        Me.cmbTicket.Name = "cmbTicket"
        Me.cmbTicket.Size = New System.Drawing.Size(121, 21)
        Me.cmbTicket.TabIndex = 5
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight
        Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight
        Me.dtpDate.Location = New System.Drawing.Point(150, 64)
        Me.dtpDate.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(214, 20)
        Me.dtpDate.TabIndex = 4
        '
        'lblMovie2
        '
        Me.lblMovie2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMovie2.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovie2.Location = New System.Drawing.Point(151, 32)
        Me.lblMovie2.Name = "lblMovie2"
        Me.lblMovie2.Size = New System.Drawing.Size(213, 15)
        Me.lblMovie2.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(105, 66)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 15)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date :"
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.BackColor = System.Drawing.Color.Transparent
        Me.lblTicket.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.Location = New System.Drawing.Point(25, 103)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(125, 15)
        Me.lblTicket.TabIndex = 1
        Me.lblTicket.Text = "Number of Tickets :"
        '
        'lblMovie
        '
        Me.lblMovie.AutoSize = True
        Me.lblMovie.BackColor = System.Drawing.Color.Transparent
        Me.lblMovie.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovie.Location = New System.Drawing.Point(101, 32)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(49, 15)
        Me.lblMovie.TabIndex = 0
        Me.lblMovie.Text = "Movie :"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightGray
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(333, 314)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 32)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightGray
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(475, 314)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 32)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'DateTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 421)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpDateTicket)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DateTicket"
        Me.Text = "DateTicket"
        Me.grpDateTicket.ResumeLayout(False)
        Me.grpDateTicket.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpDateTicket As GroupBox
    Friend WithEvents lblMovie2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTicket As Label
    Friend WithEvents lblMovie As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbTicket As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
