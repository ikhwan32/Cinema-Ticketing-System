<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction))
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnMovieShowing = New System.Windows.Forms.Button()
        Me.btnAddMovie = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.Black
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTransaction.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Location = New System.Drawing.Point(109, 175)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(135, 47)
        Me.btnTransaction.TabIndex = 20
        Me.btnTransaction.Text = "TRANSACTION HISTORY"
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnMovieShowing
        '
        Me.btnMovieShowing.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMovieShowing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMovieShowing.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovieShowing.ForeColor = System.Drawing.Color.White
        Me.btnMovieShowing.Location = New System.Drawing.Point(109, 122)
        Me.btnMovieShowing.Name = "btnMovieShowing"
        Me.btnMovieShowing.Size = New System.Drawing.Size(135, 32)
        Me.btnMovieShowing.TabIndex = 19
        Me.btnMovieShowing.Text = "MOVIE SHOWING"
        Me.btnMovieShowing.UseVisualStyleBackColor = False
        '
        'btnAddMovie
        '
        Me.btnAddMovie.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddMovie.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMovie.ForeColor = System.Drawing.Color.White
        Me.btnAddMovie.Location = New System.Drawing.Point(109, 69)
        Me.btnAddMovie.Name = "btnAddMovie"
        Me.btnAddMovie.Size = New System.Drawing.Size(135, 32)
        Me.btnAddMovie.TabIndex = 18
        Me.btnAddMovie.Text = "ADD MOVIE"
        Me.btnAddMovie.UseVisualStyleBackColor = False
        '
        'Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.btnMovieShowing)
        Me.Controls.Add(Me.btnAddMovie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaction"
        Me.Text = "Transaction"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnMovieShowing As Button
    Friend WithEvents btnAddMovie As Button
End Class
