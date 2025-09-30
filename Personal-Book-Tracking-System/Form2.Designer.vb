<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents lblBookName As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblProgress As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents pnlFooter As Panel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.chkNoYear = New System.Windows.Forms.CheckBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.grpDetails.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBookName.Location = New System.Drawing.Point(17, 30)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(119, 19)
        Me.lblBookName.TabIndex = 14
        Me.lblBookName.Text = "📖 Name of Book"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAuthor.Location = New System.Drawing.Point(17, 65)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(75, 19)
        Me.lblAuthor.TabIndex = 15
        Me.lblAuthor.Text = "✍ Author"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblISBN.Location = New System.Drawing.Point(17, 100)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(61, 19)
        Me.lblISBN.TabIndex = 16
        Me.lblISBN.Text = "🔖 ISBN"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblYear.Location = New System.Drawing.Point(17, 134)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(121, 19)
        Me.lblYear.TabIndex = 17
        Me.lblYear.Text = "📅 Year Published"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblProgress.Location = New System.Drawing.Point(17, 169)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(120, 19)
        Me.lblProgress.TabIndex = 18
        Me.lblProgress.Text = "📊 Book Progress"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(137, 28)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(215, 20)
        Me.txtBookName.TabIndex = 19
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(137, 62)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(215, 20)
        Me.txtAuthor.TabIndex = 20
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(137, 97)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(215, 20)
        Me.txtISBN.TabIndex = 21
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(106, 10)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(90, 30)
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.Text = "✅ Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(202, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "🧹 Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(288, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "❌ Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(9, 4, 0, 4)
        Me.lblTitle.Size = New System.Drawing.Size(386, 35)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "📖 Add a New Book"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpDetails
        '
        Me.grpDetails.BackColor = System.Drawing.Color.White
        Me.grpDetails.Controls.Add(Me.chkNoYear)
        Me.grpDetails.Controls.Add(Me.cmbYear)
        Me.grpDetails.Controls.Add(Me.cmbStatus)
        Me.grpDetails.Controls.Add(Me.lblBookName)
        Me.grpDetails.Controls.Add(Me.lblAuthor)
        Me.grpDetails.Controls.Add(Me.lblISBN)
        Me.grpDetails.Controls.Add(Me.lblYear)
        Me.grpDetails.Controls.Add(Me.lblProgress)
        Me.grpDetails.Controls.Add(Me.txtBookName)
        Me.grpDetails.Controls.Add(Me.txtAuthor)
        Me.grpDetails.Controls.Add(Me.txtISBN)
        Me.grpDetails.Location = New System.Drawing.Point(17, 45)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(351, 200)
        Me.grpDetails.TabIndex = 14
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = " Book Details "
        '
        'chkNoYear
        '
        Me.chkNoYear.AutoSize = True
        Me.chkNoYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoYear.Location = New System.Drawing.Point(242, 127)
        Me.chkNoYear.Name = "chkNoYear"
        Me.chkNoYear.Size = New System.Drawing.Size(91, 30)
        Me.chkNoYear.TabIndex = 24
        Me.chkNoYear.Text = "Check if year " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is unknown"
        Me.chkNoYear.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYear.DropDownHeight = 75
        Me.cmbYear.DropDownWidth = 75
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.IntegralHeight = False
        Me.cmbYear.Location = New System.Drawing.Point(137, 133)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(101, 21)
        Me.cmbYear.TabIndex = 23
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Not Started", "In Progress", "Completed", "Dropped"})
        Me.cmbStatus.Location = New System.Drawing.Point(137, 167)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(214, 21)
        Me.cmbStatus.TabIndex = 13
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlFooter.Controls.Add(Me.btnConfirm)
        Me.pnlFooter.Controls.Add(Me.btnClear)
        Me.pnlFooter.Controls.Add(Me.btnCancel)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 262)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(386, 50)
        Me.pnlFooter.TabIndex = 15
        '
        'Form2
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(386, 312)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlFooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Book"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents chkNoYear As CheckBox
End Class
