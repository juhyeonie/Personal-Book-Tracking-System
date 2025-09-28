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
    Friend WithEvents cmbProgress As ComboBox
    Friend WithEvents pnlFooter As Panel
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
        Me.cmbProgress = New System.Windows.Forms.ComboBox()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkNoYear = New System.Windows.Forms.CheckBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(12, 5, 0, 5)
        Me.lblTitle.Size = New System.Drawing.Size(457, 48)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "✏️ Edit Book Details"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(35, 75)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(131, 23)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "📖 Book Name:"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(35, 117)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(95, 23)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "✍️ Author:"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(35, 160)
        Me.lblISBN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(79, 23)
        Me.lblISBN.TabIndex = 3
        Me.lblISBN.Text = "🔖 ISBN:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(35, 203)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(153, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "📅 Year Published:"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.Location = New System.Drawing.Point(35, 245)
        Me.lblProgress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(150, 23)
        Me.lblProgress.TabIndex = 5
        Me.lblProgress.Text = "📊 Book Progress:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(187, 71)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(236, 22)
        Me.txtName.TabIndex = 6
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(187, 114)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(236, 22)
        Me.txtAuthor.TabIndex = 7
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(187, 156)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(236, 22)
        Me.txtISBN.TabIndex = 8
        '
        'cmbProgress
        '
        Me.cmbProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgress.FormattingEnabled = True
        Me.cmbProgress.Items.AddRange(New Object() {"Not Started", "In Progress", "Completed", "Dropped"})
        Me.cmbProgress.Location = New System.Drawing.Point(187, 242)
        Me.cmbProgress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbProgress.Name = "cmbProgress"
        Me.cmbProgress.Size = New System.Drawing.Size(236, 24)
        Me.cmbProgress.TabIndex = 10
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlFooter.Controls.Add(Me.btnConfirm)
        Me.pnlFooter.Controls.Add(Me.btnCancel)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 301)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(457, 62)
        Me.pnlFooter.TabIndex = 11
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(167, 11)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(133, 36)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "✅ Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(308, 11)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 36)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "❌ Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'chkNoYear
        '
        Me.chkNoYear.AutoSize = True
        Me.chkNoYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoYear.Location = New System.Drawing.Point(313, 196)
        Me.chkNoYear.Name = "chkNoYear"
        Me.chkNoYear.Size = New System.Drawing.Size(109, 36)
        Me.chkNoYear.TabIndex = 26
        Me.chkNoYear.Text = "Check if year " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is unknown"
        Me.chkNoYear.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownHeight = 75
        Me.cmbYear.DropDownWidth = 75
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.IntegralHeight = False
        Me.cmbYear.Location = New System.Drawing.Point(187, 202)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(122, 24)
        Me.cmbYear.TabIndex = 25
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(457, 363)
        Me.Controls.Add(Me.chkNoYear)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.cmbProgress)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Book"
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkNoYear As CheckBox
    Friend WithEvents cmbYear As ComboBox
End Class
