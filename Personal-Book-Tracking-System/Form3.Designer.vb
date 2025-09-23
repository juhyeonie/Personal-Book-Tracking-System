<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblProgress As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents cmbProgress As ComboBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cmbProgress = New System.Windows.Forms.ComboBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
        Me.lblTitle.Size = New System.Drawing.Size(400, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "✏️ Edit Book Details"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(30, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "📖 Book Name:"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(30, 110)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(62, 15)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "✍️ Author:"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(30, 150)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(43, 15)
        Me.lblISBN.TabIndex = 3
        Me.lblISBN.Text = "🔖 ISBN:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(30, 190)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(97, 15)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "📅 Year Published:"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(30, 230)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(94, 15)
        Me.lblProgress.TabIndex = 5
        Me.lblProgress.Text = "📊 Book Progress:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 23)
        Me.txtName.TabIndex = 6
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(150, 107)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(220, 23)
        Me.txtAuthor.TabIndex = 7
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(150, 147)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(220, 23)
        Me.txtISBN.TabIndex = 8
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(150, 187)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(220, 23)
        Me.txtYear.TabIndex = 9
        '
        'cmbProgress
        '
        Me.cmbProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgress.FormattingEnabled = True
        Me.cmbProgress.Items.AddRange(New Object() {"Not Started", "In Progress", "Completed"})
        Me.cmbProgress.Location = New System.Drawing.Point(150, 227)
        Me.cmbProgress.Name = "cmbProgress"
        Me.cmbProgress.Size = New System.Drawing.Size(220, 23)
        Me.cmbProgress.TabIndex = 10
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(100, 280)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(90, 35)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "✅ Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(210, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 35)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "❌ Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(400, 340)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.cmbProgress)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
