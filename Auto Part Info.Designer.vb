<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auto_Part_Info
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.txtpid = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbptype = New System.Windows.Forms.ComboBox
        Me.txtcompany = New System.Windows.Forms.TextBox
        Me.txtadesc = New System.Windows.Forms.TextBox
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btncancle = New System.Windows.Forms.Button
        Me.btnreg = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(148, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "AUTO PART INFORMATION"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtrate)
        Me.GroupBox1.Controls.Add(Me.txtpid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbptype)
        Me.GroupBox1.Controls.Add(Me.txtcompany)
        Me.GroupBox1.Controls.Add(Me.txtadesc)
        Me.GroupBox1.Controls.Add(Me.txtpname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 301)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "DESCRIPTION"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(182, 192)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(171, 28)
        Me.txtrate.TabIndex = 12
        '
        'txtpid
        '
        Me.txtpid.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpid.Location = New System.Drawing.Point(182, 17)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(120, 28)
        Me.txtpid.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "AUTO PART ID"
        '
        'cbptype
        '
        Me.cbptype.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbptype.FormattingEnabled = True
        Me.cbptype.Items.AddRange(New Object() {"Two Wheeler", "Four Wheeler"})
        Me.cbptype.Location = New System.Drawing.Point(183, 103)
        Me.cbptype.Name = "cbptype"
        Me.cbptype.Size = New System.Drawing.Size(170, 28)
        Me.cbptype.TabIndex = 8
        '
        'txtcompany
        '
        Me.txtcompany.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompany.Location = New System.Drawing.Point(183, 147)
        Me.txtcompany.MaxLength = 10
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.Size = New System.Drawing.Size(170, 28)
        Me.txtcompany.TabIndex = 7
        '
        'txtadesc
        '
        Me.txtadesc.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadesc.Location = New System.Drawing.Point(183, 235)
        Me.txtadesc.Multiline = True
        Me.txtadesc.Name = "txtadesc"
        Me.txtadesc.Size = New System.Drawing.Size(170, 53)
        Me.txtadesc.TabIndex = 6
        '
        'txtpname
        '
        Me.txtpname.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpname.Location = New System.Drawing.Point(183, 64)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(170, 28)
        Me.txtpname.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "RATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "COMPANY NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PART TYPE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PART NAME"
        '
        'btncancle
        '
        Me.btncancle.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancle.Location = New System.Drawing.Point(325, 378)
        Me.btncancle.Name = "btncancle"
        Me.btncancle.Size = New System.Drawing.Size(115, 30)
        Me.btncancle.TabIndex = 8
        Me.btncancle.Text = "CANCLE"
        Me.btncancle.UseVisualStyleBackColor = True
        '
        'btnreg
        '
        Me.btnreg.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg.Location = New System.Drawing.Point(195, 378)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(124, 30)
        Me.btnreg.TabIndex = 7
        Me.btnreg.Text = "REGISTER"
        Me.btnreg.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Auto_Mgmt.My.Resources.Resources.backimg3
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(670, 455)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Auto_Part_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 455)
        Me.Controls.Add(Me.btncancle)
        Me.Controls.Add(Me.btnreg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Auto_Part_Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto_Part_Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents txtpid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbptype As System.Windows.Forms.ComboBox
    Friend WithEvents txtcompany As System.Windows.Forms.TextBox
    Friend WithEvents txtadesc As System.Windows.Forms.TextBox
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncancle As System.Windows.Forms.Button
    Friend WithEvents btnreg As System.Windows.Forms.Button
End Class
