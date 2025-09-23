Imports System.Configuration
Imports System.Data.OleDb


Public Class Form2

    Dim conn As OleDbConnection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        conn = New OleDbConnection(connString)

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'adjust table/field names to match your Access table
        Dim sql As String = "INSERT INTO Books ([BookName], [Author], [ISBN], [YearPublished], [Status]) " &
                            "VALUES (@BookName, @Author, @ISBN, @YearPublished, @Status)"

        Using cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@BookName", txtBookName.Text)
            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text)
            cmd.Parameters.AddWithValue("@YearPublished", txtYear.Text)
            cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Book added successfully.")
            Catch ex As Exception
                MessageBox.Show("Error adding book: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBookName.Clear()
        txtAuthor.Clear()
        txtISBN.Clear()
        txtYear.Clear()
        cmbStatus.SelectedIndex = -1 'reset combo
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class
