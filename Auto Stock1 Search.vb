Imports System.Data
Imports System.Data.SqlClient

Public Class Auto_Stock_Search
    Public Sub GridFill()
        Connection()
        strsql = "select sid,apname as Auto_part_Name,aprate,aqty from Stock"
        cmd = New SqlCommand(strsql, con)
        cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Conclose()
    End Sub

    Private Sub Auto_Part_Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridFill()
        Connection()
        strsql = "select sid from Stock"
        cmd = New SqlCommand(strsql, con)
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            While (dr.Read)
                cbsid.Items.Add(dr(0).ToString())
            End While
        End If
        Conclose()

    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
    'SEARCH BY NAME
    Private Sub txtapname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapname.TextChanged
        If txtapname.Text <> "" Then
            Connection()
            strsql = "select sid,apname,aprate,aqty from Stock where apname like '%" & txtapname.Text & "%'"
            cmd = New SqlCommand(strsql, con)
            cmd.CommandType = CommandType.Text
            da = New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            Conclose()
        Else
            GridFill()
        End If
    End Sub
    'SEARCH BY ID
    Private Sub cbsid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsid.SelectedIndexChanged
        If cbsid.Text <> "" And IsNumeric(cbsid.Text) Then
            Connection()
            strsql = "select sid ,apname,aprate,aqty from Stock where sid= " & cbsid.Text
            cmd = New SqlCommand(strsql, con)
            cmd.CommandType = CommandType.Text
            da = New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            Conclose()
        End If
    End Sub

    'Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click

    '    cbsid.Text = ""
    '    txtapname.Text = ""
    '    Auto_Part_Search_Load(sender, e)
    'End Sub

    Private Sub txtapname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtapname.GotFocus
        cbsid.Text = ""
        GridFill()
    End Sub

    Private Sub cbsid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsid.GotFocus
        txtapname.Text = ""
        GridFill()
    End Sub
End Class