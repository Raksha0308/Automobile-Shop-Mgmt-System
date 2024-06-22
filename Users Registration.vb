Imports System.Data
Imports System.Data.SqlClient
Public Class Users_Registration
    Dim email1 As String
    Dim gender As String

    'Clear Code
    Public Sub Clear()
        cbuid.Text = ""
        txtuid.Text = ""
        txtuname.Text = ""
        txtupass.Text = ""
        txtrpass.Text = ""
        txtmob.Text = ""
        txtpname.Text = ""
        txtemail.Text = ""
        cbutype.Text = ""
        cbemail.Text = ""
        txtpadd.Text = ""
        rbtmale.Checked = False
        rbtfemale.Checked = False
    End Sub

    Private Sub Users_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Register Close Form
        If mid = 0 Then
            btnreg.Visible = True
            btncancle.Visible = True
            txtuid.Visible = True
            btnedit.Visible = False
            btnremove.Visible = False
            btnsearch.Visible = False
            cbuid.Visible = False
            txtuid.Enabled = False
            btnreg.Enabled = False

        End If
        'edit Form
        If mid = 1 Then
            btnreg.Visible = False
            txtuid.Visible = False
            btncancle.Visible = True
            btnedit.Visible = True
            btnremove.Visible = False
            btnsearch.Visible = True
            cbuid.Visible = True
            btnnew.Visible = False
        End If
        'Delete Form
        If mid = 2 Then
            btnreg.Visible = False
            txtuid.Visible = False
            btncancle.Visible = True
            btnedit.Visible = False
            btnremove.Visible = True
            btnsearch.Visible = True
            cbuid.Visible = True
            btnnew.Visible = False
        End If
        'SEARCH BY ID
        Connection()
        strsql = "select uid from UserReg"
        cmd = New SqlCommand(strsql, con)
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            While (dr.Read)
                cbuid.Items.Add(dr(0).ToString())
            End While
        End If
        Conclose()
        

    End Sub

    'Register Code
    Private Sub btnreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreg.Click
        If txtuid.Text = "" Then
            MsgBox("User ID Not Generated")
            txtuid.Focus()
            'btnreg.BackColor = Color.Red
            Exit Sub
        End If
        If txtuname.Text = "" Then
            MsgBox("User Name")
            txtuname.Focus()
            Exit Sub
        End If
        If txtupass.Text <> txtrpass.Text Then
            MsgBox("Retype Password is not Match")
            txtrpass.Clear()
            txtrpass.Focus()
            Exit Sub
        End If

        If rbtmale.Checked = True Then
            gender = "Male"
        End If
        If rbtfemale.Checked = True Then
            gender = "Female"
        End If

        email1 = txtemail.Text & cbemail.Text
        strsql = "Insert into UserReg(uid,regdate,uname,upass,utype,pname,pmob,padd,pemail,pgender) values(" & txtuid.Text & ",'" & DateTimePicker1.Value & "','" & txtuname.Text & " ','" & txtupass.Text & " ','" & cbutype.Text & "','" & txtpname.Text & "','" & txtmob.Text & "','" & txtpadd.Text & "','" & email1 & "', '" & gender & "' )"
        Connection()
        cmd = New SqlCommand(strsql, con)
        cmd.ExecuteNonQuery()
        Conclose()
        MsgBox("Record Added Successfully")
        Clear()
        ' btnreg.Enabled = False


    End Sub

    'Close Code
    Private Sub btncancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancle.Click
        Me.Close()
    End Sub

    'Code For Delete
    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If cbuid.Text <> "" And IsNumeric(cbuid.Text) Then
            Connection()
            strsql = "Delete from UserReg Where uid=" & cbuid.Text
            cmd = New SqlCommand(strsql, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Information Removed")
            Conclose()
            Clear()
        End If

    End Sub

    'Edit Code
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If cbuid.Text <> "" And IsNumeric(cbuid.Text) Then
            Connection()
            strsql = "update UserReg set regdate= '" & DateTimePicker1.Value & "',uname= '" & txtuname.Text & "',upass='" & txtupass.Text & " ' ,utype='" & cbutype.Text & "' ,pname= '" & txtpname.Text & "',pmob='" & txtmob.Text & "',padd= '" & txtpadd.Text & "',pemail= '" & txtemail.Text & cbemail.Text & "',pgender= '" & gender & "' where uid=" & cbuid.Text
            cmd = New SqlCommand(strsql, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Information Updated")
        Else
            MsgBox("Select User ID")

            Conclose()
        End If
        Clear()
    End Sub

    'New Button
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        strsql = "select MAX(uid) From UserReg"
        Connection()
        cmd = New SqlCommand(strsql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                txtuid.Text = CInt(dr(0).ToString) + 1
                btnreg.Enabled = True
                'btnreg.BackColor = Color.GreenYellow
            End While
        End If
        Conclose()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
       
        Dim strArr() As String
        'search code
        If cbuid.Text <> "" And IsNumeric(cbuid.Text) Then
            Connection()
            strsql = "select * from UserReg where uid=" & cbuid.Text
            cmd = New SqlCommand(strsql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    DateTimePicker1.Value = dr(1).ToString
                    txtuname.Text = dr(2).ToString
                    txtupass.Text = dr(3).ToString
                    txtrpass.Text = dr(3).ToString
                    cbutype.Text = dr(4).ToString
                    txtpname.Text = dr(5).ToString
                    txtmob.Text = dr(6).ToString
                    txtpadd.Text = dr(7).ToString
                    strArr = (dr(8).ToString()).Split("@")
                    txtemail.Text = strArr(0)
                    cbemail.Text = "@" & strArr(1)
                    strArr = (dr(8).ToString()).Split("@")
                    If dr(9).ToString = "Male" Then
                        rbtmale.Checked = True
                    Else
                        rbtfemale.Checked = True
                    End If

                End While

            Else
                MsgBox("user id information is not available")
            End If
            Conclose()
        Else
            MsgBox("Select User Id")
            Exit Sub
        End If
    End Sub

End Class