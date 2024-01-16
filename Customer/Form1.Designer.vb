<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movieList
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CinemaDataSet = New Customer.CinemaDataSet()
        Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovieTableAdapter = New Customer.CinemaDataSetTableAdapters.movieTableAdapter()
        Me.MovieIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunningTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieCoverDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtMovieName = New System.Windows.Forms.TextBox()
        Me.txtMovieDesc = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.movieCover = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CinemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movieCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovieIDDataGridViewTextBoxColumn, Me.MovieNameDataGridViewTextBoxColumn, Me.MovieDescDataGridViewTextBoxColumn, Me.RunningTimeDataGridViewTextBoxColumn, Me.MovieCoverDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.MovieBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(74, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 128)
        Me.DataGridView1.TabIndex = 0
        '
        'CinemaDataSet
        '
        Me.CinemaDataSet.DataSetName = "CinemaDataSet"
        Me.CinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovieBindingSource
        '
        Me.MovieBindingSource.DataMember = "movie"
        Me.MovieBindingSource.DataSource = Me.CinemaDataSet
        '
        'MovieTableAdapter
        '
        Me.MovieTableAdapter.ClearBeforeFill = True
        '
        'MovieIDDataGridViewTextBoxColumn
        '
        Me.MovieIDDataGridViewTextBoxColumn.DataPropertyName = "movieID"
        Me.MovieIDDataGridViewTextBoxColumn.HeaderText = "movieID"
        Me.MovieIDDataGridViewTextBoxColumn.Name = "MovieIDDataGridViewTextBoxColumn"
        '
        'MovieNameDataGridViewTextBoxColumn
        '
        Me.MovieNameDataGridViewTextBoxColumn.DataPropertyName = "movieName"
        Me.MovieNameDataGridViewTextBoxColumn.HeaderText = "movieName"
        Me.MovieNameDataGridViewTextBoxColumn.Name = "MovieNameDataGridViewTextBoxColumn"
        '
        'MovieDescDataGridViewTextBoxColumn
        '
        Me.MovieDescDataGridViewTextBoxColumn.DataPropertyName = "movieDesc"
        Me.MovieDescDataGridViewTextBoxColumn.HeaderText = "movieDesc"
        Me.MovieDescDataGridViewTextBoxColumn.Name = "MovieDescDataGridViewTextBoxColumn"
        '
        'RunningTimeDataGridViewTextBoxColumn
        '
        Me.RunningTimeDataGridViewTextBoxColumn.DataPropertyName = "runningTime"
        Me.RunningTimeDataGridViewTextBoxColumn.HeaderText = "runningTime"
        Me.RunningTimeDataGridViewTextBoxColumn.Name = "RunningTimeDataGridViewTextBoxColumn"
        '
        'MovieCoverDataGridViewImageColumn
        '
        Me.MovieCoverDataGridViewImageColumn.DataPropertyName = "movieCover"
        Me.MovieCoverDataGridViewImageColumn.HeaderText = "movieCover"
        Me.MovieCoverDataGridViewImageColumn.Name = "MovieCoverDataGridViewImageColumn"
        '
        'txtMovieName
        '
        Me.txtMovieName.Location = New System.Drawing.Point(147, 66)
        Me.txtMovieName.Name = "txtMovieName"
        Me.txtMovieName.Size = New System.Drawing.Size(280, 20)
        Me.txtMovieName.TabIndex = 1
        '
        'txtMovieDesc
        '
        Me.txtMovieDesc.Location = New System.Drawing.Point(147, 106)
        Me.txtMovieDesc.Name = "txtMovieDesc"
        Me.txtMovieDesc.Size = New System.Drawing.Size(280, 20)
        Me.txtMovieDesc.TabIndex = 2
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(147, 148)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(155, 20)
        Me.txtTime.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Movie Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Running Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "minutes"
        '
        'movieCover
        '
        Me.movieCover.Location = New System.Drawing.Point(453, 66)
        Me.movieCover.Name = "movieCover"
        Me.movieCover.Size = New System.Drawing.Size(165, 102)
        Me.movieCover.TabIndex = 6
        Me.movieCover.TabStop = False
        '
        'movieList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.movieCover)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtMovieDesc)
        Me.Controls.Add(Me.txtMovieName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "movieList"
        Me.Text = "Movie List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CinemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movieCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CinemaDataSet As CinemaDataSet
    Friend WithEvents MovieBindingSource As BindingSource
    Friend WithEvents MovieTableAdapter As CinemaDataSetTableAdapters.movieTableAdapter
    Friend WithEvents MovieIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RunningTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieCoverDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents txtMovieName As TextBox
    Friend WithEvents txtMovieDesc As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents movieCover As PictureBox
End Class
