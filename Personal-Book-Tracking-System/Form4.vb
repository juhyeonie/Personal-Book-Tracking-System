Imports System.Configuration
Imports System.Data.OleDb

Public Class Form4
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For year As Integer = DateTime.Now.Year To 1500 Step -1
            cmbYear.Items.Add(year.ToString())
        Next
    End Sub


End Class