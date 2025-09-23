Imports System.Data.OleDb


Public Class Form1

    Dim conn As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dudez\Source\Repos\Personal-Book-Tracking-System\Personal-Book-Tracking-System\Ms Access\BookTracker.accdb;"
        conn = New OleDbConnection(connString)

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

        LoadData()

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.")
            Return
        End If

        Dim bookName As String = dgvBooks.SelectedRows(0).Cells("bookName").Value.ToString()
        Dim author As String = dgvBooks.SelectedRows(0).Cells("Author").Value.ToString()
        Dim isbn As Integer = CInt(dgvBooks.SelectedRows(0).Cells("ISBN").Value)
        Dim id As Integer = CInt(dgvBooks.SelectedRows(0).Cells("ID").Value)

        If MessageBox.Show("Are you sure you want to delete this book?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM Books WHERE [ID] = ? AND [BookName] = ? AND [Author] = ? AND [ISBN] = ?"

            Using cmd As New OleDbCommand(sql, conn)

                cmd.Parameters.AddWithValue("?", id)
                cmd.Parameters.AddWithValue("?", bookName)
                cmd.Parameters.AddWithValue("?", author)
                cmd.Parameters.AddWithValue("?", isbn)

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
End Class
