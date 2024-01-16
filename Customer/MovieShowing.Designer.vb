<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovieShowing
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovieShowing))
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnMovieShowing = New System.Windows.Forms.Button()
        Me.btnAddMovie = New System.Windows.Forms.Button()
        Me.pcbMovie1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MovieIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunningTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieCoverDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDataset = New Customer.MainDataset()
        Me.MovieTableAdapter = New Customer.MainDatasetTableAdapters.movieTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.pcbMovie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.Black
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransaction.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Location = New System.Drawing.Point(12, 111)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(135, 47)
        Me.btnTransaction.TabIndex = 17
        Me.btnTransaction.Text = "TRANSACTION HISTORY"
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnMovieShowing
        '
        Me.btnMovieShowing.BackColor = System.Drawing.SystemColors.Control
        Me.btnMovieShowing.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnMovieShowing.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovieShowing.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMovieShowing.Location = New System.Drawing.Point(12, 73)
        Me.btnMovieShowing.Name = "btnMovieShowing"
        Me.btnMovieShowing.Size = New System.Drawing.Size(135, 32)
        Me.btnMovieShowing.TabIndex = 16
        Me.btnMovieShowing.Text = "MOVIE SHOWING"
        Me.btnMovieShowing.UseVisualStyleBackColor = False
        '
        'btnAddMovie
        '
        Me.btnAddMovie.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddMovie.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMovie.ForeColor = System.Drawing.Color.White
        Me.btnAddMovie.Location = New System.Drawing.Point(12, 35)
        Me.btnAddMovie.Name = "btnAddMovie"
        Me.btnAddMovie.Size = New System.Drawing.Size(135, 32)
        Me.btnAddMovie.TabIndex = 15
        Me.btnAddMovie.Text = "ADD MOVIE"
        Me.btnAddMovie.UseVisualStyleBackColor = False
        '
        'pcbMovie1
        '
        Me.pcbMovie1.Location = New System.Drawing.Point(428, 35)
        Me.pcbMovie1.Name = "pcbMovie1"
        Me.pcbMovie1.Size = New System.Drawing.Size(100, 132)
        Me.pcbMovie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMovie1.TabIndex = 18
        Me.pcbMovie1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OliveDrab
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "SHOWING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(442, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "UPCOMING"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(562, 98)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 48
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(562, 68)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(562, 38)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(440, 173)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 45
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(250, 111)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 43
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(250, 80)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(169, 20)
        Me.txtDesc.TabIndex = 42
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(250, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 20)
        Me.txtName.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(173, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Desc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Playing Time"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(562, 127)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 48
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovieIDDataGridViewTextBoxColumn, Me.MovieNameDataGridViewTextBoxColumn, Me.MovieDescDataGridViewTextBoxColumn, Me.RunningTimeDataGridViewTextBoxColumn, Me.MovieCoverDataGridViewTextBoxColumn, Me.MovieStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovieBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(83, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(646, 150)
        Me.DataGridView1.TabIndex = 52
        '
        'MovieIDDataGridViewTextBoxColumn
        '
        Me.MovieIDDataGridViewTextBoxColumn.DataPropertyName = "movieID"
        Me.MovieIDDataGridViewTextBoxColumn.HeaderText = "movieID"
        Me.MovieIDDataGridViewTextBoxColumn.Name = "MovieIDDataGridViewTextBoxColumn"
        Me.MovieIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovieNameDataGridViewTextBoxColumn
        '
        Me.MovieNameDataGridViewTextBoxColumn.DataPropertyName = "movieName"
        Me.MovieNameDataGridViewTextBoxColumn.HeaderText = "movieName"
        Me.MovieNameDataGridViewTextBoxColumn.Name = "MovieNameDataGridViewTextBoxColumn"
        Me.MovieNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovieDescDataGridViewTextBoxColumn
        '
        Me.MovieDescDataGridViewTextBoxColumn.DataPropertyName = "movieDesc"
        Me.MovieDescDataGridViewTextBoxColumn.HeaderText = "movieDesc"
        Me.MovieDescDataGridViewTextBoxColumn.Name = "MovieDescDataGridViewTextBoxColumn"
        Me.MovieDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RunningTimeDataGridViewTextBoxColumn
        '
        Me.RunningTimeDataGridViewTextBoxColumn.DataPropertyName = "runningTime"
        Me.RunningTimeDataGridViewTextBoxColumn.HeaderText = "runningTime"
        Me.RunningTimeDataGridViewTextBoxColumn.Name = "RunningTimeDataGridViewTextBoxColumn"
        Me.RunningTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovieCoverDataGridViewTextBoxColumn
        '
        Me.MovieCoverDataGridViewTextBoxColumn.DataPropertyName = "movieCover"
        Me.MovieCoverDataGridViewTextBoxColumn.HeaderText = "movieCover"
        Me.MovieCoverDataGridViewTextBoxColumn.Name = "MovieCoverDataGridViewTextBoxColumn"
        Me.MovieCoverDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovieStatusDataGridViewTextBoxColumn
        '
        Me.MovieStatusDataGridViewTextBoxColumn.DataPropertyName = "movieStatus"
        Me.MovieStatusDataGridViewTextBoxColumn.HeaderText = "movieStatus"
        Me.MovieStatusDataGridViewTextBoxColumn.Name = "MovieStatusDataGridViewTextBoxColumn"
        Me.MovieStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovieBindingSource
        '
        Me.MovieBindingSource.DataMember = "movie"
        Me.MovieBindingSource.DataSource = Me.MainDataset
        '
        'MainDataset
        '
        Me.MainDataset.DataSetName = "MainDataset"
        Me.MainDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovieTableAdapter
        '
        Me.MovieTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Label5"
        '
        'comboBoxStatus
        '
        Me.comboBoxStatus.FormattingEnabled = True
        Me.comboBoxStatus.Items.AddRange(New Object() {"Showing", "Upcoming"})
        Me.comboBoxStatus.Location = New System.Drawing.Point(250, 145)
        Me.comboBoxStatus.Name = "comboBoxStatus"
        Me.comboBoxStatus.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxStatus.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(177, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Status"
        '
        'MovieShowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.comboBoxStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcbMovie1)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.btnMovieShowing)
        Me.Controls.Add(Me.btnAddMovie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MovieShowing"
        Me.Text = "MovieShowing"
        CType(Me.pcbMovie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnMovieShowing As Button
    Friend WithEvents btnAddMovie As Button
    Friend WithEvents pcbMovie1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MainDataset As MainDataset
    Friend WithEvents MovieBindingSource As BindingSource
    Friend WithEvents MovieTableAdapter As MainDatasetTableAdapters.movieTableAdapter
    Friend WithEvents MovieIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RunningTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieCoverDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents comboBoxStatus As ComboBox
    Friend WithEvents Label6 As Label
End Class
