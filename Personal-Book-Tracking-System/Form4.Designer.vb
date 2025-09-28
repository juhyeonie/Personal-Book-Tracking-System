<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblProgress As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents cmbProgress As ComboBox
    Friend WithEvents lstResults As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.cmbProgress = New System.Windows.Forms.ComboBox()
        Me.lstResults = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkNoYear = New System.Windows.Forms.CheckBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.pnlSearch.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Goldenrod
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 4, 0, 4)
        Me.lblTitle.Size = New System.Drawing.Size(560, 45)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "🔍 Search Books"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.chkNoYear)
        Me.pnlSearch.Controls.Add(Me.cmbYear)
        Me.pnlSearch.Controls.Add(Me.lblName)
        Me.pnlSearch.Controls.Add(Me.txtName)
        Me.pnlSearch.Controls.Add(Me.lblAuthor)
        Me.pnlSearch.Controls.Add(Me.txtAuthor)
        Me.pnlSearch.Controls.Add(Me.lblISBN)
        Me.pnlSearch.Controls.Add(Me.txtISBN)
        Me.pnlSearch.Controls.Add(Me.lblYear)
        Me.pnlSearch.Controls.Add(Me.lblProgress)
        Me.pnlSearch.Controls.Add(Me.cmbProgress)
        Me.pnlSearch.Location = New System.Drawing.Point(20, 60)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlSearch.Size = New System.Drawing.Size(520, 160)
        Me.pnlSearch.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(20, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(131, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "📖 Book Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 22)
        Me.txtName.TabIndex = 1
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(20, 42)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(95, 23)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "✍️ Author:"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(150, 39)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(180, 22)
        Me.txtAuthor.TabIndex = 3
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(20, 68)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(79, 23)
        Me.lblISBN.TabIndex = 4
        Me.lblISBN.Text = "🔖 ISBN:"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(150, 65)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(180, 22)
        Me.txtISBN.TabIndex = 5
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(23, 94)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(74, 23)
        Me.lblYear.TabIndex = 6
        Me.lblYear.Text = "📅 Year:"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.Location = New System.Drawing.Point(23, 120)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(107, 23)
        Me.lblProgress.TabIndex = 8
        Me.lblProgress.Text = "📊 Progress:"
        '
        'cmbProgress
        '
        Me.cmbProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgress.Items.AddRange(New Object() {"Not Started", "In Progress", "Completed", "Dropped"})
        Me.cmbProgress.Location = New System.Drawing.Point(150, 117)
        Me.cmbProgress.Name = "cmbProgress"
        Me.cmbProgress.Size = New System.Drawing.Size(130, 24)
        Me.cmbProgress.TabIndex = 9
        '
        'lstResults
        '
        Me.lstResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResults.BackColor = System.Drawing.Color.White
        Me.lstResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstResults.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lstResults.FullRowSelect = True
        Me.lstResults.GridLines = True
        Me.lstResults.HideSelection = False
        Me.lstResults.Location = New System.Drawing.Point(20, 230)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(520, 230)
        Me.lstResults.TabIndex = 0
        Me.lstResults.UseCompatibleStateImageBehavior = False
        Me.lstResults.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Book Name"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Author"
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ISBN"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Year"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Progress"
        Me.ColumnHeader5.Width = 100
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlFooter.Controls.Add(Me.btnSearch)
        Me.pnlFooter.Controls.Add(Me.btnClear)
        Me.pnlFooter.Controls.Add(Me.btnCancel)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 465)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(560, 55)
        Me.pnlFooter.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(228, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 32)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "🔍 Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(334, 11)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 32)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "🧹 Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(440, 11)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "❌ Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'chkNoYear
        '
        Me.chkNoYear.AutoSize = True
        Me.chkNoYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoYear.Location = New System.Drawing.Point(256, 93)
        Me.chkNoYear.Name = "chkNoYear"
        Me.chkNoYear.Size = New System.Drawing.Size(174, 20)
        Me.chkNoYear.TabIndex = 26
        Me.chkNoYear.Text = "Check if year is unknown"
        Me.chkNoYear.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownHeight = 75
        Me.cmbYear.DropDownWidth = 75
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.IntegralHeight = False
        Me.cmbYear.Location = New System.Drawing.Point(150, 89)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(100, 24)
        Me.cmbYear.TabIndex = 25
        '
        'Form4
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(560, 520)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlFooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Book"
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkNoYear As CheckBox
    Friend WithEvents cmbYear As ComboBox
End Class
