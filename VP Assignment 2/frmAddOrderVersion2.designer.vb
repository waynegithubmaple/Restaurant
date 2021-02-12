<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddOrderVersion2
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
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblItemPrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lstViewOrderDetails = New System.Windows.Forms.ListView()
        Me.colItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Main Meals", "Appetizers", "Drinks", "Dessert", "Beverage"})
        Me.cboCategory.Location = New System.Drawing.Point(65, 18)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(126, 21)
        Me.cboCategory.TabIndex = 1
        Me.cboCategory.Text = "Choose -"
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(7, 66)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(184, 225)
        Me.lstItems.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Item : "
        '
        'lblItem
        '
        Me.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(283, 99)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(100, 23)
        Me.lblItem.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price :"
        '
        'lblItemPrice
        '
        Me.lblItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.Location = New System.Drawing.Point(283, 133)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblItemPrice.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(206, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Quantity :"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(528, 313)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(296, 218)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(422, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order Details :"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(438, 313)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(283, 168)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 9
        '
        'lstViewOrderDetails
        '
        Me.lstViewOrderDetails.AutoArrange = False
        Me.lstViewOrderDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItem, Me.colPrice, Me.colQuantity, Me.colTotal})
        Me.lstViewOrderDetails.FullRowSelect = True
        Me.lstViewOrderDetails.HideSelection = False
        Me.lstViewOrderDetails.LabelWrap = False
        Me.lstViewOrderDetails.Location = New System.Drawing.Point(408, 65)
        Me.lstViewOrderDetails.Name = "lstViewOrderDetails"
        Me.lstViewOrderDetails.Size = New System.Drawing.Size(312, 226)
        Me.lstViewOrderDetails.TabIndex = 11
        Me.lstViewOrderDetails.UseCompatibleStateImageBehavior = False
        Me.lstViewOrderDetails.View = System.Windows.Forms.View.Details
        '
        'colItem
        '
        Me.colItem.Text = "Item"
        Me.colItem.Width = 130
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'colQuantity
        '
        Me.colQuantity.Text = "Quantity"
        '
        'colTotal
        '
        Me.colTotal.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Category :"
        '
        'frmAddOrderVersion2
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(814, 348)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstViewOrderDetails)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.cboCategory)
        Me.Name = "frmAddOrderVersion2"
        Me.Text = "Add Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lstItems As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblItemPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lstViewOrderDetails As ListView
    Friend WithEvents colItem As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colQuantity As ColumnHeader
    Friend WithEvents colTotal As ColumnHeader
    Friend WithEvents Label4 As Label
End Class
