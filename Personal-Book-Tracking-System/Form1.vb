Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO


Public Class Form1

    Dim conn As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dbPath As String = Path.Combine(Application.StartupPath, "..\..\..\MS Access\BookTracker.accdb")


        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"
        conn = New OleDbConnection(connString)

        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            dt = New DataTable()
        conn.Open()
        adapter = New OleDbDataAdapter("SELECT * FROM Books", conn)
        adapter.Fill(dt)
        conn.Close()
        dgvBooks.DataSource = dt

            For Each row As DataRow In dt.Rows
                If row("YearPublished") IsNot Nothing Then
                    Dim yearValue = row("YearPublished").ToString()
                    If yearValue = "0" Then
                        row("YearPublished") = DBNull.Value
                    End If
                End If
            Next
            dgvBooks.Columns("ID").Visible = False 'hide ID column
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim f2 As New Form2()

        f2.ShowDialog()

        LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to edit.")
            Return
        End If

        Dim selectedISBN As String = dgvBooks.SelectedRows(0).Cells("ISBN").Value.ToString()

        Dim f3 As New Form3()
        f3.EditISBN = selectedISBN
        f3.ShowDialog()
        LoadData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim f4 As New Form4()

        f4.ShowDialog()
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.")
            Return
        End If

        Dim bookName As String = dgvBooks.SelectedRows(0).Cells("bookName").Value.ToString()

        Dim id As Integer = CInt(dgvBooks.SelectedRows(0).Cells("ID").Value)

        If MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            Dim sql As String = "DELETE FROM Books WHERE [ID] = ?"
            Using cmd As New OleDbCommand(sql, conn)

                cmd.Parameters.AddWithValue("?", id)


                Try
                    conn.Open()
                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    conn.Close()

                    If rows > 0 Then
                        MessageBox.Show("Book deleted successfully.")
                    Else
                        MessageBox.Show("No book was deleted.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error deleting book: " & ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End Using

            LoadData()
        End If

    End Sub

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If e.RowIndex >= 0 Then
            dgvBooks.Rows(e.RowIndex).Selected = True
        End If
    End Sub
End Class
