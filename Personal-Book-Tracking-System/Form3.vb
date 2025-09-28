Public Class Form3

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For year As Integer = DateTime.Now.Year To 1500 Step -1
            cmbYear.Items.Add(year.ToString())
        Next
    End Sub

End Class