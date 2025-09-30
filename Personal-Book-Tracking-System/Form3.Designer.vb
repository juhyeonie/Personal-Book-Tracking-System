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
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(9, 4, 0, 4)
        Me.lblTitle.Size = New System.Drawing.Size(343, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "✏️ Edit Book Details"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(26, 61)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(97, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "📖 Book Name:"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(26, 95)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(72, 17)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "✍️ Author:"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(26, 130)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(59, 17)
        Me.lblISBN.TabIndex = 3
        Me.lblISBN.Text = "🔖 ISBN:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(26, 165)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(115, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "📅 Year Published:"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.Location = New System.Drawing.Point(26, 199)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(113, 17)
        Me.lblProgress.TabIndex = 5
        Me.lblProgress.Text = "📊 Book Progress:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(140, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 20)
        Me.txtName.TabIndex = 6
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(140, 93)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(178, 20)
        Me.txtAuthor.TabIndex = 7
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(140, 127)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(178, 20)
        Me.txtISBN.TabIndex = 8
        '
        'cmbProgress
        '
        Me.cmbProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgress.FormattingEnabled = True
        Me.cmbProgress.Items.AddRange(New Object() {"Not Started", "In Progress", "Completed", "Dropped"})
        Me.cmbProgress.Location = New System.Drawing.Point(140, 197)
        Me.cmbProgress.Name = "cmbProgress"
        Me.cmbProgress.Size = New System.Drawing.Size(178, 21)
        Me.cmbProgress.TabIndex = 10
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlFooter.Controls.Add(Me.btnConfirm)
        Me.pnlFooter.Controls.Add(Me.btnCancel)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 245)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(343, 50)
        Me.pnlFooter.TabIndex = 11
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(125, 9)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 29)
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
        Me.btnCancel.Location = New System.Drawing.Point(231, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "❌ Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'chkNoYear
        '
        Me.chkNoYear.AutoSize = True
        Me.chkNoYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoYear.Location = New System.Drawing.Point(235, 159)
        Me.chkNoYear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkNoYear.Name = "chkNoYear"
        Me.chkNoYear.Size = New System.Drawing.Size(91, 30)
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
        Me.cmbYear.Location = New System.Drawing.Point(140, 164)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(92, 21)
        Me.cmbYear.TabIndex = 25
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(343, 295)
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
