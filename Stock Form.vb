Imports System.Data
Imports System.Data.SqlClient
Public Class Stock_Form
    Public Sub Clear()
        txtsid.Text = ""
        cbapname.Text = ""
        txtaprate.Text = ""
        txtpid.Text = ""
        txtaprate.Text = ""
        txtaqty.Text = ""
    End Sub
    'Select Max Id
    Public Sub MaxID()
        Dim sid As Integer
        strsql = "select MAX(Sid)  From Stock"
        Connection()
        cmd = New SqlCommand(strsql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If dr(0).ToString = "" Then
                    txtsid.Text = "101"
                Else
                    sid = dr(0).ToString
                    txtsid.Text = sid + 1
                End If
            End While
        End If
        Conclose()
    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtsid.Text = "" Then
            MsgBox("Stock ID Not Generated")
            btnadd.Focus()
            btnadd.BackColor = Color.Red
            Exit Sub
        End If
        If cbapname.Text = "" Then
            MsgBox("Select Part  Name")
            cbapname.Focus()
            Exit Sub
        End If
        If txtaqty.Text = "" Then
            MsgBox("Enter Quantity")
            txtaqty.Focus()
            Exit Sub
        End If
        'Insert Record
        strsql = "Insert into Stock(sid,regdate,apname,aprate,pid,aqty) values(" & txtsid.Text & ",'" & DateTimePicker1.Value & " ','" & cbapname.Text & " '," & txtaprate.Text & " ," & txtpid.Text & "," & txtaqty.Text & ")"
        Connection()
        cmd = New SqlCommand(strsql, con)
        cmd.ExecuteNonQuery()
        Conclose()
        MsgBox("Record Added")
        Clear()
        strsql = "select MAX(Sid)  From Stock"
        Connection()
        cmd = New SqlCommand(strsql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                txtsid.Text = CInt(dr(0).ToString) + 1
                txtsid.Enabled = False
                'btnreg.BackColor = Color.GreenYellow
            End While
        End If
        Conclose()
    End Sub

    Private Sub Stock_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaxID()
        txtsid.Enabled = False
        'ACCESS ID
        Connection()
        strsql = "select pname from AutopInfo"
        cmd = New SqlCommand(strsql, con)
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            While (dr.Read)
                cbapname.Items.Add(dr(0).ToString())
            End While
        End If
        Conclose()
        txtaprate.Enabled = False
        txtpid.Enabled = False

    End Sub


    Private Sub cbapname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbapname.SelectedIndexChanged
        If cbapname.Text <> "" Then
            Connection()
            strsql = "select pid,rate from AutopInfo where pname like '%" & cbapname.Text & "%'"

            cmd = New SqlCommand(strsql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    txtpid.Text = dr(0).ToString
                    txtaprate.Text = dr(1).ToString
                End While

            Else
                MsgBox("Part is Not Available")
            End If
            Conclose()
        Else
            MsgBox("SelectPart Name")
            Exit Sub
        End If
    End Sub
End Class