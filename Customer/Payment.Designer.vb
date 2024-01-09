<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpOnline = New System.Windows.Forms.GroupBox()
        Me.radOnline = New System.Windows.Forms.RadioButton()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.grpCard = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtExpired = New System.Windows.Forms.TextBox()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblExpired = New System.Windows.Forms.Label()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.radCard = New System.Windows.Forms.RadioButton()
        Me.grpOnline.SuspendLayout()
        Me.grpCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(264, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(222, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PAYMENT METHOD"
        '
        'grpOnline
        '
        Me.grpOnline.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grpOnline.Controls.Add(Me.radOnline)
        Me.grpOnline.Controls.Add(Me.txtPassword)
        Me.grpOnline.Controls.Add(Me.txtUsername)
        Me.grpOnline.Controls.Add(Me.ComboBox1)
        Me.grpOnline.Controls.Add(Me.lblUsername)
        Me.grpOnline.Controls.Add(Me.lblPassword)
        Me.grpOnline.Controls.Add(Me.lblBank)
        Me.grpOnline.Location = New System.Drawing.Point(42, 73)
        Me.grpOnline.Name = "grpOnline"
        Me.grpOnline.Size = New System.Drawing.Size(320, 280)
        Me.grpOnline.TabIndex = 1
        Me.grpOnline.TabStop = False
        '
        'radOnline
        '
        Me.radOnline.AutoSize = True
        Me.radOnline.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOnline.Location = New System.Drawing.Point(86, 33)
        Me.radOnline.Name = "radOnline"
        Me.radOnline.Size = New System.Drawing.Size(111, 19)
        Me.radOnline.TabIndex = 6
        Me.radOnline.TabStop = True
        Me.radOnline.Text = "Online Banking"
        Me.radOnline.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(107, 159)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(203, 22)
        Me.txtPassword.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Menu
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(107, 115)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(203, 22)
        Me.txtUsername.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bank Islam", "Bank Simpanan Nasional", "RHB Bank", "Maybank2u", "CIMB Bank", "Bank Kerjasama Rakyat", "Ambank", "Agrobank ", "HSBC Online", "Public Bank", "Hong Leong Connect", "Affin Bank", "Bank Muamalat", "OSBC Online"})
        Me.ComboBox1.Location = New System.Drawing.Point(107, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(32, 118)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 15)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(34, 162)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(71, 15)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password :"
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.BackColor = System.Drawing.Color.Transparent
        Me.lblBank.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(13, 75)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(92, 15)
        Me.lblBank.TabIndex = 1
        Me.lblBank.Text = "Choose Bank :"
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPay.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(698, 378)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(76, 33)
        Me.btnPay.TabIndex = 4
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'grpCard
        '
        Me.grpCard.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grpCard.Controls.Add(Me.txtPhone)
        Me.grpCard.Controls.Add(Me.txtExpired)
        Me.grpCard.Controls.Add(Me.txtCard)
        Me.grpCard.Controls.Add(Me.txtCVV)
        Me.grpCard.Controls.Add(Me.txtName)
        Me.grpCard.Controls.Add(Me.lblPhone)
        Me.grpCard.Controls.Add(Me.lblExpired)
        Me.grpCard.Controls.Add(Me.lblCVV)
        Me.grpCard.Controls.Add(Me.lblCard)
        Me.grpCard.Controls.Add(Me.lblName)
        Me.grpCard.Controls.Add(Me.radCard)
        Me.grpCard.Location = New System.Drawing.Point(434, 73)
        Me.grpCard.Name = "grpCard"
        Me.grpCard.Size = New System.Drawing.Size(320, 280)
        Me.grpCard.TabIndex = 5
        Me.grpCard.TabStop = False
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(124, 223)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(181, 22)
        Me.txtPhone.TabIndex = 13
        '
        'txtExpired
        '
        Me.txtExpired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpired.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpired.Location = New System.Drawing.Point(124, 185)
        Me.txtExpired.Name = "txtExpired"
        Me.txtExpired.Size = New System.Drawing.Size(181, 22)
        Me.txtExpired.TabIndex = 12
        '
        'txtCard
        '
        Me.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCard.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCard.Location = New System.Drawing.Point(124, 111)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(181, 22)
        Me.txtCard.TabIndex = 11
        '
        'txtCVV
        '
        Me.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCVV.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVV.Location = New System.Drawing.Point(124, 147)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(181, 22)
        Me.txtCVV.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(124, 75)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(181, 22)
        Me.txtName.TabIndex = 9
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(22, 226)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(99, 15)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone Number :"
        '
        'lblExpired
        '
        Me.lblExpired.AutoSize = True
        Me.lblExpired.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpired.Location = New System.Drawing.Point(30, 188)
        Me.lblExpired.Name = "lblExpired"
        Me.lblExpired.Size = New System.Drawing.Size(91, 15)
        Me.lblExpired.TabIndex = 4
        Me.lblExpired.Text = "Expired Date :"
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVV.Location = New System.Drawing.Point(82, 150)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(39, 15)
        Me.lblCVV.TabIndex = 3
        Me.lblCVV.Text = "CVV :"
        '
        'lblCard
        '
        Me.lblCard.AutoSize = True
        Me.lblCard.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCard.Location = New System.Drawing.Point(28, 114)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(93, 15)
        Me.lblCard.TabIndex = 2
        Me.lblCard.Text = "Card Number :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(74, 78)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name :"
        '
        'radCard
        '
        Me.radCard.AutoSize = True
        Me.radCard.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCard.Location = New System.Drawing.Point(85, 31)
        Me.radCard.Name = "radCard"
        Me.radCard.Size = New System.Drawing.Size(133, 19)
        Me.radCard.TabIndex = 0
        Me.radCard.TabStop = True
        Me.radCard.Text = "Debit/Credit Card"
        Me.radCard.UseVisualStyleBackColor = True
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 430)
        Me.Controls.Add(Me.grpCard)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.grpOnline)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.grpOnline.ResumeLayout(False)
        Me.grpOnline.PerformLayout()
        Me.grpCard.ResumeLayout(False)
        Me.grpCard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpOnline As GroupBox
    Friend WithEvents lblBank As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents radOnline As RadioButton
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents grpCard As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtExpired As TextBox
    Friend WithEvents txtCard As TextBox
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblExpired As Label
    Friend WithEvents lblCVV As Label
    Friend WithEvents lblCard As Label
    Friend WithEvents lblName As Label
    Friend WithEvents radCard As RadioButton
End Class
