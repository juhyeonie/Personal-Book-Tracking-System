Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO

Public Class Form4

    Private conn As OleDbConnection

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbPath As String = Path.Combine(Application.StartupPath, "..\..\..\MS Access\BookTracker.accdb")
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"
        conn = New OleDbConnection(connString)

        For year As Integer = DateTime.Now.Year To 1500 Step -1
            cmbYear.Items.Add(year.ToString())
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtAuthor.Clear()
        txtISBN.Clear()
        cmbYear.SelectedIndex = -1 'reset combo
        cmbYear.Text = ""
        cmbProgress.SelectedIndex = -1 'reset combo
        cmbProgress.Text = ""
        chkNoYear.Checked = False
        cmbYear.Enabled = True
        txtName.Focus()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim conditions As New List(Of String)
        Dim cmd As New OleDbCommand()
        cmd.Connection = conn


        If Not String.IsNullOrWhiteSpace(txtName.Text) Then
            conditions.Add("[BookName] LIKE ?")
            cmd.Parameters.AddWithValue("?", "%" & txtName.Text & "%")
        End If

        If Not String.IsNullOrWhiteSpace(txtAuthor.Text) Then
            conditions.Add("[Author] LIKE ?")
            cmd.Parameters.AddWithValue("?", "%" & txtAuthor.Text & "%")
        End If

        If Not String.IsNullOrWhiteSpace(txtISBN.Text) Then
            conditions.Add("[ISBN] LIKE ?")
            cmd.Parameters.AddWithValue("?", "%" & txtISBN.Text & "%")
        End If

        If chkNoYear.Checked = False AndAlso cmbYear.SelectedIndex <> -1 Then
            conditions.Add("[YearPublished] = ?")
            cmd.Parameters.AddWithValue("?", cmbYear.SelectedItem.ToString())
        End If

        If cmbProgress.SelectedIndex <> -1 Then
            conditions.Add("[Status] = ?")
            cmd.Parameters.AddWithValue("?", cmbProgress.SelectedItem.ToString())
        End If


        Dim sql As String = "SELECT [BookName], [Author], [ISBN], [YearPublished], [Status] FROM Books"


        If conditions.Count > 0 Then
            sql &= " WHERE " & String.Join(" AND ", conditions)
        End If

        cmd.CommandText = sql

        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            conn.Open()
            adapter.Fill(dt)
            conn.Close()


            lstResults.Items.Clear()
            lstResults.View = View.Details
            lstResults.FullRowSelect = True

            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(row("BookName").ToString())
                item.SubItems.Add(row("Author").ToString())
                item.SubItems.Add(row("ISBN").ToString())
                item.SubItems.Add(row("YearPublished").ToString())
                item.SubItems.Add(row("Status").ToString())
                lstResults.Items.Add(item)
            Next

        Catch ex As Exception
            MessageBox.Show("Error while searching: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub
End Class