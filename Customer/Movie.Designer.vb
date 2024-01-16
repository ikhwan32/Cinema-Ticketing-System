<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movie))
        Me.pcbMovie1 = New System.Windows.Forms.PictureBox()
        Me.btnBook1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MainDataset = New Customer.MainDataset()
        Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovieTableAdapter = New Customer.MainDatasetTableAdapters.movieTableAdapter()
        Me.lblMovieName = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MovieIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunningTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieCoverDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movieStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pcbMovie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbMovie1
        '
        Me.pcbMovie1.Location = New System.Drawing.Point(492, 27)
        Me.pcbMovie1.Name = "pcbMovie1"
        Me.pcbMovie1.Size = New System.Drawing.Size(219, 296)
        Me.pcbMovie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMovie1.TabIndex = 0
        Me.pcbMovie1.TabStop = False
        '
        'btnBook1
        '
        Me.btnBook1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook1.Location = New System.Drawing.Point(492, 329)
        Me.btnBook1.Name = "btnBook1"
        Me.btnBook1.Size = New System.Drawing.Size(219, 26)
        Me.btnBook1.TabIndex = 1
        Me.btnBook1.Text = "BOOK NOW"
        Me.btnBook1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovieIDDataGridViewTextBoxColumn, Me.MovieNameDataGridViewTextBoxColumn, Me.MovieDescDataGridViewTextBoxColumn, Me.RunningTimeDataGridViewTextBoxColumn, Me.MovieCoverDataGridViewTextBoxColumn, Me.movieStatus})
        Me.DataGridView1.DataSource = Me.MovieBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(153, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(296, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'MainDataset
        '
        Me.MainDataset.DataSetName = "MainDataset"
        Me.MainDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovieBindingSource
        '
        Me.MovieBindingSource.DataMember = "movie"
        Me.MovieBindingSource.DataSource = Me.MainDataset
        '
        'MovieTableAdapter
        '
        Me.MovieTableAdapter.ClearBeforeFill = True
        '
        'lblMovieName
        '
        Me.lblMovieName.BackColor = System.Drawing.Color.Transparent
        Me.lblMovieName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieName.ForeColor = System.Drawing.Color.Transparent
        Me.lblMovieName.Location = New System.Drawing.Point(234, 56)
        Me.lblMovieName.Name = "lblMovieName"
        Me.lblMovieName.Size = New System.Drawing.Size(135, 23)
        Me.lblMovieName.TabIndex = 3
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.Transparent
        Me.lblDesc.Location = New System.Drawing.Point(234, 89)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(256, 49)
        Me.lblDesc.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Transparent
        Me.lblTime.Location = New System.Drawing.Point(234, 157)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(135, 23)
        Me.lblTime.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(149, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(149, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Synopsis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(149, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Playtime"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(375, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "minutes"
        '
        'MovieIDDataGridViewTextBoxColumn
        '
        Me.MovieIDDataGridViewTextBoxColumn.DataPropertyName = "movieID"
        Me.MovieIDDataGridViewTextBoxColumn.HeaderText = "movieID"
        Me.MovieIDDataGridViewTextBoxColumn.Name = "MovieIDDataGridViewTextBoxColumn"
        Me.MovieIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovieIDDataGridViewTextBoxColumn.Visible = False
        '
        'MovieNameDataGridViewTextBoxColumn
        '
        Me.MovieNameDataGridViewTextBoxColumn.DataPropertyName = "movieName"
        Me.MovieNameDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.MovieNameDataGridViewTextBoxColumn.Name = "MovieNameDataGridViewTextBoxColumn"
        Me.MovieNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovieNameDataGridViewTextBoxColumn.Width = 250
        '
        'MovieDescDataGridViewTextBoxColumn
        '
        Me.MovieDescDataGridViewTextBoxColumn.DataPropertyName = "movieDesc"
        Me.MovieDescDataGridViewTextBoxColumn.HeaderText = "movieDesc"
        Me.MovieDescDataGridViewTextBoxColumn.Name = "MovieDescDataGridViewTextBoxColumn"
        Me.MovieDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovieDescDataGridViewTextBoxColumn.Visible = False
        '
        'RunningTimeDataGridViewTextBoxColumn
        '
        Me.RunningTimeDataGridViewTextBoxColumn.DataPropertyName = "runningTime"
        Me.RunningTimeDataGridViewTextBoxColumn.HeaderText = "runningTime"
        Me.RunningTimeDataGridViewTextBoxColumn.Name = "RunningTimeDataGridViewTextBoxColumn"
        Me.RunningTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.RunningTimeDataGridViewTextBoxColumn.Visible = False
        '
        'MovieCoverDataGridViewTextBoxColumn
        '
        Me.MovieCoverDataGridViewTextBoxColumn.DataPropertyName = "movieCover"
        Me.MovieCoverDataGridViewTextBoxColumn.HeaderText = "movieCover"
        Me.MovieCoverDataGridViewTextBoxColumn.Name = "MovieCoverDataGridViewTextBoxColumn"
        Me.MovieCoverDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovieCoverDataGridViewTextBoxColumn.Visible = False
        '
        'movieStatus
        '
        Me.movieStatus.DataPropertyName = "movieStatus"
        Me.movieStatus.HeaderText = "movieStatus"
        Me.movieStatus.Name = "movieStatus"
        Me.movieStatus.ReadOnly = True
        Me.movieStatus.Visible = False
        '
        'Movie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(736, 411)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblMovieName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBook1)
        Me.Controls.Add(Me.pcbMovie1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Movie"
        Me.Text = "Movie"
        CType(Me.pcbMovie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbMovie1 As PictureBox
    Friend WithEvents btnBook1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MainDataset As MainDataset
    Friend WithEvents MovieBindingSource As BindingSource
    Friend WithEvents MovieTableAdapter As MainDatasetTableAdapters.movieTableAdapter
    Friend WithEvents lblMovieName As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MovieIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RunningTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieCoverDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents movieStatus As DataGridViewTextBoxColumn
End Class
