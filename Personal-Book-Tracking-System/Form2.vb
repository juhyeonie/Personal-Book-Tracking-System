Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO


Public Class Form2

    Dim conn As OleDbConnection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dbPath As String = Path.Combine(Application.StartupPath, "..\..\..\MS Access\BookTracker.accdb")
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"
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

        Try
            conn.Open()
            Dim checkNameSql As String = "SELECT COUNT(*) FROM Books WHERE [BookName] = ?"
            Using checkNameCmd As New OleDbCommand(checkNameSql, conn)
                checkNameCmd.Parameters.AddWithValue("?", txtBookName.Text.Trim())
                Dim nameCount As Integer = CInt(checkNameCmd.ExecuteScalar())
                If nameCount > 0 Then
                    MessageBox.Show("A book with this name already exists. Please enter a different book name.", "Duplicate Book Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtBookName.Focus()
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

        If cmbStatus.SelectedItem Is Nothing AndAlso Not cmbStatus.Items.Contains(cmbStatus.Text) Then
            MessageBox.Show("Please select a valid book progress from the list.")
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
        cmbYear.Text = ""
        cmbStatus.SelectedIndex = -1 'reset combo
        cmbStatus.Text = ""
        chkNoYear.Checked = False
        cmbYear.Enabled = True
        txtBookName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chkNoYear_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoYear.CheckedChanged
        If chkNoYear.Checked Then
            cmbYear.Enabled = False
            cmbYear.SelectedIndex = -1 ' Clear selection
        Else
            cmbYear.Enabled = True
        End If
    End Sub

End Class
