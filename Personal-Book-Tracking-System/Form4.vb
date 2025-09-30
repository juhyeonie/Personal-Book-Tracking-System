Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbPath As String = Path.Combine(Application.StartupPath, "..\..\..\MS Access\BookTracker.accdb")
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"
        conn = New OleDbConnection(connString)

        For year As Integer = DateTime.Now.Year To 1500 Step -1
            cmbYear.Items.Add(year.ToString())
        Next
    End Sub


End Class