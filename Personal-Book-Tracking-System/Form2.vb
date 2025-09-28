Imports System.Configuration
Imports System.Data.OleDb


Public Class Form2

    Dim conn As OleDbConnection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        conn = New OleDbConnection(connString)
        txtBookName.Focus()
        txtBookName.Select()

        For year As Integer = DateTime.Now.Year To 1500 Step -1
            cmbYear.Items.Add(year.ToString())
        Next


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'VALIDATION
        If String.IsNullOrWhiteSpace(txtBookName.Text) Then
            MessageBox.Show("Please enter a book title.")
            txtBookName.Focus()
            Return
        End If

        If Not chkNoYear.Checked AndAlso (cmbYear.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(cmbYear.Text)) Then
            MessageBox.Show("Please select a year or check the checkbox if year is unknown.")
            cmbYear.Focus()
            Return
        End If

        If cmbStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a book progress.")
            cmbStatus.Focus()
            Return
        End If

        Try
            conn.Open()
            Dim checkSql As String = "SELECT COUNT(*) FROM Books WHERE [ISBN] = ?"
            Using checkCmd As New OleDbCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("?", txtISBN.Text.Trim())
                Dim count As Integer = CInt(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("A book with this ISBN already exists. Please enter a different ISBN.")
                    txtISBN.Focus()
                    conn.Close()
                    Return
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error checking for duplicates: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
            Return
        End Try



        'adjust table/field names to match your Access table
        Dim sql As String = "INSERT INTO Books ([BookName], [Author], [ISBN], [YearPublished], [Status]) " &
                            "VALUES (@BookName, @Author, @ISBN, @YearPublished, @Status)"

        Using cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@BookName", txtBookName.Text)
            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text)

            If chkNoYear.Checked Then
                cmd.Parameters.AddWithValue("@YearPublished", 0)
            Else
                cmd.Parameters.AddWithValue("@YearPublished", CInt(cmbYear.Text))
            End If

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
        cmbYear.SelectedIndex = -1 'reset combo
        cmbStatus.SelectedIndex = -1 'reset combo
        chkNoYear.Checked = False
        cmbYear.Enabled = True
        txtBookName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class
