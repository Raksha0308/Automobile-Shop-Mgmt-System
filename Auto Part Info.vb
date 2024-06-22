Imports System.Data
Imports System.Data.SqlClient
Public Class Auto_Part_Info
    'CLEAR TEXTBOX
    Public Sub Clear()
        txtpid.Text = ""
        txtpname.Text = ""
        cbptype.Text = ""
        txtcompany.Text = ""
        txtrate.Text = ""
        txtadesc.Text = ""
    End Sub
    'MAX ID
    Public Sub MaxId()
        Dim pid As Integer
        strsql = "select MAX(pid) From AutopInfo"
        Connection()
        cmd = New SqlCommand(strsql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If dr(0).ToString = "" Then
                    txtpid.Text = "1"
                Else
                    pid = dr(0).ToString
                    txtpid.Text = pid + 1
                End If
                'txtpid.Text = CInt(dr(0).ToString) + 1
                'btnreg.Enabled = True
                'btnreg.BackColor = Color.GreenYellow
            End While
        End If
        Conclose()
    End Sub

    Private Sub Auto_Part_Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaxId()
        txtpid.Enabled = False
    End Sub
    'AUTO INFO REG
    Private Sub btnreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreg.Click
        If txtpid.Text = "" Then
            MsgBox("User ID Not Generated")
            btnreg.Focus()
            btnreg.BackColor = Color.Red
            Exit Sub
        End If
        If txtpname.Text = "" Then
            MsgBox("User Name")
            txtpname.Focus()
            Exit Sub
        End If
        'Insert Record
        strsql = "Insert into AutopInfo(pid,pname,ptype,company,rate,adesc) values(" & txtpid.Text & ",'" & txtpname.Text & " ','" & cbptype.Text & " ','" & txtcompany.Text & "','" & txtrate.Text & "','" & txtadesc.Text & "' )"
        Connection()
        cmd = New SqlCommand(strsql, con)
        cmd.ExecuteNonQuery()
        Conclose()
        MsgBox("Record Added")
        Clear()
        MaxId()
    End Sub
    'AUTO INFO FORM CLOSE
    Private Sub btncancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancle.Click
        Me.Close()
    End Sub

End Class