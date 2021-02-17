<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpTable = New System.Windows.Forms.GroupBox()
        Me.chkTable6 = New System.Windows.Forms.CheckBox()
        Me.chkTable5 = New System.Windows.Forms.CheckBox()
        Me.chkTable4 = New System.Windows.Forms.CheckBox()
        Me.chkTable3 = New System.Windows.Forms.CheckBox()
        Me.chkTable2 = New System.Windows.Forms.CheckBox()
        Me.chkTable1 = New System.Windows.Forms.CheckBox()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblResId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.cboNoPerson = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpResTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpResDate = New System.Windows.Forms.DateTimePicker()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lstvData = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpTable.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTable
        '
        Me.grpTable.Controls.Add(Me.chkTable6)
        Me.grpTable.Controls.Add(Me.chkTable5)
        Me.grpTable.Controls.Add(Me.chkTable4)
        Me.grpTable.Controls.Add(Me.chkTable3)
        Me.grpTable.Controls.Add(Me.chkTable2)
        Me.grpTable.Controls.Add(Me.chkTable1)
        Me.grpTable.Location = New System.Drawing.Point(490, 305)
        Me.grpTable.Name = "grpTable"
        Me.grpTable.Size = New System.Drawing.Size(402, 264)
        Me.grpTable.TabIndex = 94
        Me.grpTable.TabStop = False
        Me.grpTable.Text = "Table"
        '
        'chkTable6
        '
        Me.chkTable6.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTable6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkTable6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkTable6.Location = New System.Drawing.Point(278, 131)
        Me.chkTable6.Name = "chkTable6"
        Me.chkTable6.Size = New System.Drawing.Size(90, 83)
        Me.chkTable6.TabIndex = 5
        Me.chkTable6.Text = "Table 6"
        Me.chkTable6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTable6.UseVisualStyleBackColor = False
        '
        'chkTable5
        '
        Me.chkTable5.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTable5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkTable5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkTable5.Location = New System.Drawing.Point(153, 130)
        Me.chkTable5.Name = "chkTable5"
        Me.chkTable5.Size = New System.Drawing.Size(90, 83)
        Me.chkTable5.TabIndex = 4
        Me.chkTable5.Text = "Table 5"
        Me.chkTable5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTable5.UseVisualStyleBackColor = False
        '
        'chkTable4
        '
        Me.chkTable4.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTable4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkTable4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkTable4.Location = New System.Drawing.Point(19, 131)
        Me.chkTable4.Name = "chkTable4"
        Me.chkTable4.Size = New System.Drawing.Size(90, 83)
        Me.chkTable4.TabIndex = 3
        Me.chkTable4.Text = "Table 4"
        Me.chkTable4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTable4.UseVisualStyleBackColor = False
        '
        'chkTable3
        '
        Me.chkTable3.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTable3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkTable3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkTable3.Location = New System.Drawing.Point(278, 27)
        Me.chkTable3.Name = "chkTable3"
        Me.chkTable3.Size = New System.Drawing.Size(90, 83)
        Me.chkTable3.TabIndex = 2
        Me.chkTable3.Text = "Table 3"
        Me.chkTable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTable3.UseVisualStyleBackColor = False
        '
        'chkTable2
        '
        Me.chkTable2.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTable2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkTable2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkTable2.Location = New System.Drawing.Point(153, 27)
        Me.chkTable2.Name = "chkTable2"
        Me.chkTable2.Size = New System.Drawing.Size(90, 83)
        Me.chkTable2.TabIndex = 1
        Me.chkTable2.Text = "Table 2"
        Me.chkTable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTable2.UseVisualStyleBackColor = False
        '
        'chkTable1
        '
        Me.chkTable1.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTable1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkTable1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkTable1.Location = New System.Drawing.Point(19, 27)
        Me.chkTable1.Name = "chkTable1"
        Me.chkTable1.Size = New System.Drawing.Size(90, 83)
        Me.chkTable1.TabIndex = 0
        Me.chkTable1.Text = "Table 1"
        Me.chkTable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTable1.UseVisualStyleBackColor = False
        '
        'dtpEndTime
        '
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(26, 157)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(116, 20)
        Me.dtpEndTime.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Reservation End Time"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(186, 579)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 91
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Location = New System.Drawing.Point(86, 579)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 90
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(289, 579)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 89
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblResId
        '
        Me.lblResId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResId.Location = New System.Drawing.Point(23, 21)
        Me.lblResId.Name = "lblResId"
        Me.lblResId.Size = New System.Drawing.Size(119, 23)
        Me.lblResId.TabIndex = 88
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Reservation ID :"
        '
        'mskContactNo
        '
        Me.mskContactNo.Location = New System.Drawing.Point(23, 321)
        Me.mskContactNo.Mask = "+6000-0000000"
        Me.mskContactNo.Name = "mskContactNo"
        Me.mskContactNo.Size = New System.Drawing.Size(119, 20)
        Me.mskContactNo.TabIndex = 86
        '
        'cboNoPerson
        '
        Me.cboNoPerson.FormattingEnabled = True
        Me.cboNoPerson.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboNoPerson.Location = New System.Drawing.Point(23, 269)
        Me.cboNoPerson.Name = "cboNoPerson"
        Me.cboNoPerson.Size = New System.Drawing.Size(119, 21)
        Me.cboNoPerson.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Number of Person"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Contect Number :"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(23, 207)
        Me.txtCustName.Multiline = True
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(194, 23)
        Me.txtCustName.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Name of Customer :"
        '
        'dtpResTime
        '
        Me.dtpResTime.CustomFormat = "hh:mm tt"
        Me.dtpResTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpResTime.Location = New System.Drawing.Point(23, 118)
        Me.dtpResTime.Name = "dtpResTime"
        Me.dtpResTime.ShowUpDown = True
        Me.dtpResTime.Size = New System.Drawing.Size(119, 20)
        Me.dtpResTime.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Reservation Time :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Reservation Date :"
        '
        'dtpResDate
        '
        Me.dtpResDate.AllowDrop = True
        Me.dtpResDate.Location = New System.Drawing.Point(23, 69)
        Me.dtpResDate.MinDate = New Date(2020, 1, 10, 0, 0, 0, 0)
        Me.dtpResDate.Name = "dtpResDate"
        Me.dtpResDate.Size = New System.Drawing.Size(194, 20)
        Me.dtpResDate.TabIndex = 77
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'lstvData
        '
        Me.lstvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstvData.HideSelection = False
        Me.lstvData.Location = New System.Drawing.Point(423, 12)
        Me.lstvData.Name = "lstvData"
        Me.lstvData.Size = New System.Drawing.Size(478, 222)
        Me.lstvData.TabIndex = 95
        Me.lstvData.UseCompatibleStateImageBehavior = False
        Me.lstvData.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Reservation ID"
        Me.ColumnHeader1.Width = 107
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Reservation Start"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Reservation End Time"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Table No"
        Me.ColumnHeader4.Width = 96
        '
        'Form2
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(957, 682)
        Me.Controls.Add(Me.lstvData)
        Me.Controls.Add(Me.grpTable)
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblResId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mskContactNo)
        Me.Controls.Add(Me.cboNoPerson)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpResTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpResDate)
        Me.Name = "Form2"
        Me.Text = "Reservation"
        Me.grpTable.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpTable As GroupBox
    Friend WithEvents chkTable6 As CheckBox
    Friend WithEvents chkTable5 As CheckBox
    Friend WithEvents chkTable4 As CheckBox
    Friend WithEvents chkTable3 As CheckBox
    Friend WithEvents chkTable2 As CheckBox
    Friend WithEvents chkTable1 As CheckBox
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblResId As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mskContactNo As MaskedTextBox
    Friend WithEvents cboNoPerson As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpResTime As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpResDate As DateTimePicker
    Friend WithEvents err As ErrorProvider
    Friend WithEvents lstvData As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
