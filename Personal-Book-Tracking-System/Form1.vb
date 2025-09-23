Imports System.Data.OleDb


Public Class Form1

    Dim conn As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dudez\Source\Repos\Personal-Book-Tracking-System\Personal-Book-Tracking-System\Ms Access\BookTracker.accdb;"
        conn = New OleDbConnection(connString)
        'connection test langs
        Try
            conn.Open()
            MessageBox.Show("Connection successful!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        'load data into DataGridView (dgvBooks to)
        LoadData()
    End Sub

    Private Sub LoadData()

        dt = New DataTable()
        conn.Open()
        adapter = New OleDbDataAdapter("SELECT * FROM Books", conn)
        adapter.Fill(dt)
        conn.Close()
        dgvBooks.DataSource = dt
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim f2 As New Form2()

        f2.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim f3 As New Form3()

        f3.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim f4 As New Form4()

        f4.ShowDialog()
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick

    End Sub
End Class
