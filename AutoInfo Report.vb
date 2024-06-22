Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Public Class AutoInfo_Report

    Private Sub AutoInfo_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cryRpt As New ReportDocument
        cryRpt.Load("D:\Auto_Mgmt\Code\Auto_Mgmt\Auto_Mgmt\Auto Info Report.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class