Imports System.Data
Imports System.Data.SqlClient
Public Class Auto_Mob_Shop
    Private Sub Auto_Mob_Shop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ut = 0 Then
            Usermainmenu.Enabled = False
        End If
    End Sub
    'Auto Part Add Form
    Private Sub AddAutoPartInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAutoPartInfo.Click
        Auto_Part_Info.Show()
    End Sub
    ' Update Auto Part Info
    Private Sub UpdateAutoPartInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAutoPartInfo.Click
        mid = 0
        Aotop_Search_edit_del.Show()
    End Sub
    'Delete Auto Part Info
    Private Sub Delete_auto_part_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAutoPart.Click
        mid = 1
        Aotop_Search_edit_del.Show()
    End Sub
    'Search Auto Part Info
    Private Sub SearchAutoPart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAutoPart.Click
        mid = 2
        Aotop_Search_edit_del.Show()
    End Sub


    'User Reg Form
    Private Sub RegisterUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterUserInfo.Click
        mid = 0
        Users_Registration.Show()
    End Sub
    'User Update Search
    Private Sub UpdateUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateUserInfo.Click
        mid = 1
        Users_Registration.Show()
    End Sub
    'User Delete Search
    Private Sub DeleteUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserInfo.Click
        mid = 2
        Users_Registration.Show()
    End Sub


    'Customer Reg Form
    Private Sub RegisterCustomerInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterCustomerInfo.Click
        Customer_Information.Show()
    End Sub

    'Customer Search Form
    Private Sub SearchCustomerInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCustomerInfo.Click
        Customer_Search.Show()
    End Sub
    'Customer Del Form
    Private Sub DeleteCustomerInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCustomerInfo.Click
        mid = 1
        Cust_Edit_Del.Show()
    End Sub
    'Customer Update Form
    Private Sub UpdateCustomerInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCustomerInfo.Click
        mid = 0
        Cust_Edit_Del.Show()
    End Sub


    'Stock search Form
    Private Sub StockSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockSearch.Click
        Auto_Stock_Search.Show()
    End Sub
    'Stock Add Form
    Private Sub AddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStock.Click
        Stock_Form.Show()
    End Sub

    Private Sub CustomerInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerInfoToolStripMenuItem.Click
        Cust_Report.Show()
    End Sub

    Private Sub AutoPartInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoPartInfoToolStripMenuItem.Click
        AutoInfo_Report.Show()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockReportToolStripMenuItem.Click
        StockReport.Show()
    End Sub

    Private Sub SaleDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleDetailToolStripMenuItem.Click
        Sales_Form1.Show()
    End Sub

    Private Sub SaleReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleReportToolStripMenuItem.Click
        SaleREport.Show()
    End Sub
End Class