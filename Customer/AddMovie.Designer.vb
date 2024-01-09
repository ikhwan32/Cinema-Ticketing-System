<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMovie))
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnMovieShowing = New System.Windows.Forms.Button()
        Me.btnAddMovie = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.grpNewMovie = New System.Windows.Forms.GroupBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtMovie = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.pcbMovie = New System.Windows.Forms.PictureBox()
        Me.grpNewMovie.SuspendLayout()
        CType(Me.pcbMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.Black
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransaction.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Location = New System.Drawing.Point(109, 175)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(135, 47)
        Me.btnTransaction.TabIndex = 23
        Me.btnTransaction.Text = "TRANSACTION HISTORY"
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnMovieShowing
        '
        Me.btnMovieShowing.BackColor = System.Drawing.Color.Black
        Me.btnMovieShowing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMovieShowing.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovieShowing.ForeColor = System.Drawing.Color.White
        Me.btnMovieShowing.Location = New System.Drawing.Point(109, 122)
        Me.btnMovieShowing.Name = "btnMovieShowing"
        Me.btnMovieShowing.Size = New System.Drawing.Size(135, 32)
        Me.btnMovieShowing.TabIndex = 22
        Me.btnMovieShowing.Text = "MOVIE SHOWING"
        Me.btnMovieShowing.UseVisualStyleBackColor = False
        '
        'btnAddMovie
        '
        Me.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddMovie.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMovie.Location = New System.Drawing.Point(109, 69)
        Me.btnAddMovie.Name = "btnAddMovie"
        Me.btnAddMovie.Size = New System.Drawing.Size(135, 32)
        Me.btnAddMovie.TabIndex = 21
        Me.btnAddMovie.Text = "ADD MOVIE"
        Me.btnAddMovie.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(616, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(317, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(518, 393)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.LawnGreen
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInsert.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(417, 393)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 17
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'grpNewMovie
        '
        Me.grpNewMovie.Controls.Add(Me.txtDuration)
        Me.grpNewMovie.Controls.Add(Me.txtGenre)
        Me.grpNewMovie.Controls.Add(Me.txtMovie)
        Me.grpNewMovie.Controls.Add(Me.lblGenre)
        Me.grpNewMovie.Controls.Add(Me.lblDuration)
        Me.grpNewMovie.Controls.Add(Me.lblMovie)
        Me.grpNewMovie.Location = New System.Drawing.Point(317, 234)
        Me.grpNewMovie.Name = "grpNewMovie"
        Me.grpNewMovie.Size = New System.Drawing.Size(359, 140)
        Me.grpNewMovie.TabIndex = 16
        Me.grpNewMovie.TabStop = False
        '
        'txtDuration
        '
        Me.txtDuration.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuration.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(94, 87)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(254, 22)
        Me.txtDuration.TabIndex = 6
        '
        'txtGenre
        '
        Me.txtGenre.BackColor = System.Drawing.SystemColors.Menu
        Me.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenre.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre.Location = New System.Drawing.Point(94, 55)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(254, 22)
        Me.txtGenre.TabIndex = 5
        '
        'txtMovie
        '
        Me.txtMovie.BackColor = System.Drawing.SystemColors.Menu
        Me.txtMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMovie.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovie.Location = New System.Drawing.Point(94, 23)
        Me.txtMovie.Name = "txtMovie"
        Me.txtMovie.Size = New System.Drawing.Size(254, 22)
        Me.txtMovie.TabIndex = 4
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblGenre.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(39, 59)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(53, 15)
        Me.lblGenre.TabIndex = 3
        Me.lblGenre.Text = "Genre :"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDuration.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(23, 90)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(69, 15)
        Me.lblDuration.TabIndex = 2
        Me.lblDuration.Text = "Duration :"
        '
        'lblMovie
        '
        Me.lblMovie.AutoSize = True
        Me.lblMovie.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMovie.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovie.Location = New System.Drawing.Point(10, 26)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(82, 15)
        Me.lblMovie.TabIndex = 1
        Me.lblMovie.Text = "Movie Title :"
        '
        'pcbMovie
        '
        Me.pcbMovie.Location = New System.Drawing.Point(420, 34)
        Me.pcbMovie.Name = "pcbMovie"
        Me.pcbMovie.Size = New System.Drawing.Size(154, 188)
        Me.pcbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMovie.TabIndex = 15
        Me.pcbMovie.TabStop = False
        '
        'AddMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.btnMovieShowing)
        Me.Controls.Add(Me.btnAddMovie)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.grpNewMovie)
        Me.Controls.Add(Me.pcbMovie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddMovie"
        Me.Text = "AddMovie"
        Me.grpNewMovie.ResumeLayout(False)
        Me.grpNewMovie.PerformLayout()
        CType(Me.pcbMovie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnMovieShowing As Button
    Friend WithEvents btnAddMovie As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents grpNewMovie As GroupBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtMovie As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblMovie As Label
    Friend WithEvents pcbMovie As PictureBox
End Class
