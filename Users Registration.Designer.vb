<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users_Registration
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cbuid = New System.Windows.Forms.ComboBox
        Me.txtuid = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbutype = New System.Windows.Forms.ComboBox
        Me.txtrpass = New System.Windows.Forms.TextBox
        Me.txtupass = New System.Windows.Forms.TextBox
        Me.txtuname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtfemale = New System.Windows.Forms.RadioButton
        Me.rbtmale = New System.Windows.Forms.RadioButton
        Me.cbemail = New System.Windows.Forms.ComboBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtmob = New System.Windows.Forms.TextBox
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.txtpadd = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnreg = New System.Windows.Forms.Button
        Me.btncancle = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnremove = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USERS REGISTRATION"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cbuid)
        Me.GroupBox1.Controls.Add(Me.txtuid)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbutype)
        Me.GroupBox1.Controls.Add(Me.txtrpass)
        Me.GroupBox1.Controls.Add(Me.txtupass)
        Me.GroupBox1.Controls.Add(Me.txtuname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 173)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USER INFORMATION"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(472, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 28)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2021, 6, 21, 0, 0, 0, 0)
        '
        'cbuid
        '
        Me.cbuid.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbuid.FormattingEnabled = True
        Me.cbuid.Location = New System.Drawing.Point(144, 48)
        Me.cbuid.Name = "cbuid"
        Me.cbuid.Size = New System.Drawing.Size(119, 28)
        Me.cbuid.TabIndex = 0
        '
        'txtuid
        '
        Me.txtuid.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuid.Location = New System.Drawing.Point(144, 48)
        Me.txtuid.Name = "txtuid"
        Me.txtuid.Size = New System.Drawing.Size(120, 28)
        Me.txtuid.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 21)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "USER ID"
        '
        'cbutype
        '
        Me.cbutype.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbutype.FormattingEnabled = True
        Me.cbutype.Items.AddRange(New Object() {"Admin", "User"})
        Me.cbutype.Location = New System.Drawing.Point(503, 63)
        Me.cbutype.Name = "cbutype"
        Me.cbutype.Size = New System.Drawing.Size(119, 28)
        Me.cbutype.TabIndex = 4
        '
        'txtrpass
        '
        Me.txtrpass.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrpass.Location = New System.Drawing.Point(502, 122)
        Me.txtrpass.Name = "txtrpass"
        Me.txtrpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrpass.Size = New System.Drawing.Size(120, 28)
        Me.txtrpass.TabIndex = 3
        '
        'txtupass
        '
        Me.txtupass.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupass.Location = New System.Drawing.Point(144, 126)
        Me.txtupass.Name = "txtupass"
        Me.txtupass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtupass.Size = New System.Drawing.Size(120, 28)
        Me.txtupass.TabIndex = 3
        '
        'txtuname
        '
        Me.txtuname.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.Location = New System.Drawing.Point(144, 85)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(120, 28)
        Me.txtuname.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "USER TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(355, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "REG.DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(307, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "RETYPE PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USER NAME"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.rbtfemale)
        Me.GroupBox2.Controls.Add(Me.rbtmale)
        Me.GroupBox2.Controls.Add(Me.cbemail)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.txtmob)
        Me.GroupBox2.Controls.Add(Me.txtpname)
        Me.GroupBox2.Controls.Add(Me.txtpadd)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(645, 145)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PERSONAL INFORMATION"
        '
        'rbtfemale
        '
        Me.rbtfemale.AutoSize = True
        Me.rbtfemale.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtfemale.Location = New System.Drawing.Point(230, 107)
        Me.rbtfemale.Name = "rbtfemale"
        Me.rbtfemale.Size = New System.Drawing.Size(84, 25)
        Me.rbtfemale.TabIndex = 9
        Me.rbtfemale.TabStop = True
        Me.rbtfemale.Text = "Female"
        Me.rbtfemale.UseVisualStyleBackColor = True
        '
        'rbtmale
        '
        Me.rbtmale.AutoSize = True
        Me.rbtmale.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtmale.Location = New System.Drawing.Point(144, 105)
        Me.rbtmale.Name = "rbtmale"
        Me.rbtmale.Size = New System.Drawing.Size(67, 25)
        Me.rbtmale.TabIndex = 9
        Me.rbtmale.TabStop = True
        Me.rbtmale.Text = "Male"
        Me.rbtmale.UseVisualStyleBackColor = True
        '
        'cbemail
        '
        Me.cbemail.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbemail.FormattingEnabled = True
        Me.cbemail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbemail.Items.AddRange(New Object() {"@email.com", "@gmail.com", "@yahoo.com"})
        Me.cbemail.Location = New System.Drawing.Point(502, 98)
        Me.cbemail.Name = "cbemail"
        Me.cbemail.Size = New System.Drawing.Size(119, 28)
        Me.cbemail.TabIndex = 8
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(394, 98)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(102, 28)
        Me.txtemail.TabIndex = 8
        '
        'txtmob
        '
        Me.txtmob.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmob.Location = New System.Drawing.Point(144, 68)
        Me.txtmob.MaxLength = 10
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(142, 28)
        Me.txtmob.TabIndex = 6
        '
        'txtpname
        '
        Me.txtpname.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpname.Location = New System.Drawing.Point(144, 27)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(171, 28)
        Me.txtpname.TabIndex = 5
        '
        'txtpadd
        '
        Me.txtpadd.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpadd.Location = New System.Drawing.Point(423, 27)
        Me.txtpadd.Multiline = True
        Me.txtpadd.Name = "txtpadd"
        Me.txtpadd.Size = New System.Drawing.Size(198, 57)
        Me.txtpadd.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(321, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 21)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "EMAIL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(322, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 21)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "ADDRESS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "GENDER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "MOBILE NO."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "FULL NAME"
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(156, 387)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(119, 30)
        Me.btnnew.TabIndex = 9
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnreg
        '
        Me.btnreg.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg.Location = New System.Drawing.Point(281, 387)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(119, 30)
        Me.btnreg.TabIndex = 4
        Me.btnreg.Text = "REGISTER"
        Me.btnreg.UseVisualStyleBackColor = True
        '
        'btncancle
        '
        Me.btncancle.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancle.Location = New System.Drawing.Point(406, 387)
        Me.btncancle.Name = "btncancle"
        Me.btncancle.Size = New System.Drawing.Size(115, 30)
        Me.btncancle.TabIndex = 5
        Me.btncancle.Text = "CANCLE"
        Me.btncancle.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Auto_Mgmt.My.Resources.Resources.backimg
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(893, 502)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(282, 387)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(119, 30)
        Me.btnsearch.TabIndex = 6
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(157, 387)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(119, 30)
        Me.btnedit.TabIndex = 7
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(156, 387)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(119, 30)
        Me.btnremove.TabIndex = 8
        Me.btnremove.Text = "DELETE"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'Users_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 455)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btncancle)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnreg)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Users_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users_Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrpass As System.Windows.Forms.TextBox
    Friend WithEvents txtupass As System.Windows.Forms.TextBox
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents txtpadd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbutype As System.Windows.Forms.ComboBox
    Friend WithEvents cbemail As System.Windows.Forms.ComboBox
    Friend WithEvents btnreg As System.Windows.Forms.Button
    Friend WithEvents btncancle As System.Windows.Forms.Button
    Friend WithEvents txtuid As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents cbuid As System.Windows.Forms.ComboBox
    Friend WithEvents rbtfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtmale As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnnew As System.Windows.Forms.Button
End Class
