Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO

Public Class Form3

    Public Property EditISBN As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbPath As String = Path.Combine(Application.StartupPath, "..\..\..\MS Access\BookTracker.accdb")
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"
        Dim conn As New OleDbConnection(connString)

        For year As Integer = DateTime.Now.Year To 1500 Step -1
            cmbYear.Items.Add(year.ToString())
        Next

        If Not String.IsNullOrWhiteSpace(EditISBN) Then
            Try
                conn.Open()
                Dim sql As String = "SELECT [BookName], [Author], [ISBN], [YearPublished], [Status] FROM Books WHERE [ISBN] = ?"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", EditISBN)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtName.Text = reader("BookName").ToString()
                            txtAuthor.Text = reader("Author").ToString()
                            txtISBN.Text = reader("ISBN").ToString()

                            Dim yearPublished As Integer = 0
                            If Integer.TryParse(reader("YearPublished").ToString(), yearPublished) AndAlso yearPublished > 0 Then
                                cmbYear.Text = yearPublished.ToString()
                                chkNoYear.Checked = False
                                cmbYear.Enabled = True
                            Else
                                cmbYear.Text = ""
                                chkNoYear.Checked = True
                                cmbYear.Enabled = False
                            End If

                            Dim statusValue As String = reader("Status").ToString()
                            If cmbProgress.Items.Contains(statusValue) Then
                                cmbProgress.SelectedItem = statusValue
                            Else
                                cmbProgress.SelectedIndex = -1
                            End If
                        Else
                            MessageBox.Show("Book not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading book data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("No book selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    'Validation for buttons
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a book title.")
            txtName.Focus()
            Return
        End If

        Dim dbPath As String = Path.Combine(Application.StartupPath, "..\..\..\MS Access\BookTracker.accdb")
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()
            Dim checkNameSql As String = "SELECT COUNT(*) FROM Books WHERE [BookName] = ? AND [ISBN] <> ?"
            Using checkNameCmd As New OleDbCommand(checkNameSql, conn)
                checkNameCmd.Parameters.AddWithValue("?", txtName.Text.Trim())
                checkNameCmd.Parameters.AddWithValue("?", txtISBN.Text.Trim())
                Dim nameCount As Integer = CInt(checkNameCmd.ExecuteScalar())
                If nameCount > 0 Then
                    MessageBox.Show("A book with this name already exists. Please enter a different book name.", "Duplicate Book Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtName.Focus()
                    conn.Close()
                    Return
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error checking for duplicate book name: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
            Return
        End Try

        Dim rawISBN As String = txtISBN.Text.Trim()

        If Not IsNumeric(rawISBN) Then
            MessageBox.Show("ISBN must contain digits only.", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtISBN.Focus()
            Exit Sub
        End If

        If rawISBN.Length = 13 Then
            If Not (rawISBN.StartsWith("978") Or rawISBN.StartsWith("979")) Then
                MessageBox.Show("ISBN must start with 978 or 979 when 13 digits long.", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtISBN.Focus()
                Exit Sub
            End If

        ElseIf rawISBN.Length = 10 Then
            rawISBN = "978" & rawISBN
            txtISBN.Text = rawISBN

        Else
            MessageBox.Show("ISBN must be exactly 10 or 13 digits.", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtISBN.Focus()
            Exit Sub
        End If

        If Not chkNoYear.Checked Then
            If String.IsNullOrWhiteSpace(cmbYear.Text) Then
                MessageBox.Show("Please select a year or check the checkbox if year is unknown.")
                cmbYear.Focus()
                Return
            End If

            Dim yearValue As Integer
            If Not Integer.TryParse(cmbYear.Text, yearValue) OrElse cmbYear.Text.Length <> 4 OrElse Not cmbYear.Items.Contains(cmbYear.Text) Then
                MessageBox.Show("Please enter a valid 4-digit year from the list.")
                cmbYear.Focus()
                Return
            End If
        End If

        If cmbProgress.SelectedItem Is Nothing AndAlso Not cmbProgress.Items.Contains(cmbProgress.Text) Then
            MessageBox.Show("Please select a valid book progress from the list.")
            cmbProgress.Focus()
            Return
        End If

        Try
            conn.Open()
            Dim checkSql As String = "SELECT COUNT(*) FROM Books WHERE [ISBN] = ? AND [ISBN] <> ?"
            Using checkCmd As New OleDbCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("?", txtISBN.Text.Trim())
                checkCmd.Parameters.AddWithValue("?", EditISBN)
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
        Dim sql As String = "UPDATE Books SET [BookName]=@BookName, [Author]=@Author, [ISBN]=@ISBN, [YearPublished]=@YearPublished, [Status]=@Status WHERE [ISBN]=@OldISBN"

        Using cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@BookName", txtName.Text)
            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text)

            If chkNoYear.Checked Then
                cmd.Parameters.AddWithValue("@YearPublished", 0)
            Else
                cmd.Parameters.AddWithValue("@YearPublished", CInt(cmbYear.Text))
            End If

            cmd.Parameters.AddWithValue("@Status", cmbProgress.Text)
            cmd.Parameters.AddWithValue("@OldISBN", EditISBN)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Book updated successfully.")
            Catch ex As Exception
                MessageBox.Show("Error updating book: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using

        Me.Close()
    End Sub

End Class