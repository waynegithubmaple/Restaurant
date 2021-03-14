<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstPendingOrders = New System.Windows.Forms.ListBox()
        Me.lblPaymentlabel = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblOrderNo = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.grpSelectedOrder = New System.Windows.Forms.GroupBox()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.lblTableNumber = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumberOfOrders = New System.Windows.Forms.Label()
        Me.grpSelectedOrder.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPendingOrders
        '
        Me.lstPendingOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPendingOrders.FormattingEnabled = True
        Me.lstPendingOrders.ItemHeight = 15
        Me.lstPendingOrders.Location = New System.Drawing.Point(6, 19)
        Me.lstPendingOrders.Name = "lstPendingOrders"
        Me.lstPendingOrders.Size = New System.Drawing.Size(290, 169)
        Me.lstPendingOrders.TabIndex = 0
        '
        'lblPaymentlabel
        '
        Me.lblPaymentlabel.AutoSize = True
        Me.lblPaymentlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentlabel.Location = New System.Drawing.Point(13, 9)
        Me.lblPaymentlabel.Name = "lblPaymentlabel"
        Me.lblPaymentlabel.Size = New System.Drawing.Size(96, 25)
        Me.lblPaymentlabel.TabIndex = 1
        Me.lblPaymentlabel.Text = "Payment"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(518, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.Green
        Me.btnPay.Location = New System.Drawing.Point(409, 231)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 33)
        Me.btnPay.TabIndex = 3
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'txtPayment
        '
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(80, 117)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(119, 23)
        Me.txtPayment.TabIndex = 4
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(10, 120)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(64, 17)
        Me.lblPayment.TabIndex = 5
        Me.lblPayment.Text = "Amount :"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(10, 59)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(78, 17)
        Me.lblTotalAmount.TabIndex = 6
        Me.lblTotalAmount.Text = "Total Due :"
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNo.Location = New System.Drawing.Point(10, 30)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(107, 17)
        Me.lblOrderNo.TabIndex = 7
        Me.lblOrderNo.Text = "Order Number :"
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNumber.Location = New System.Drawing.Point(123, 32)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(0, 15)
        Me.lblOrderNumber.TabIndex = 8
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDue.Location = New System.Drawing.Point(94, 61)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(0, 15)
        Me.lblTotalDue.TabIndex = 9
        '
        'grpSelectedOrder
        '
        Me.grpSelectedOrder.Controls.Add(Me.lblTableNumber)
        Me.grpSelectedOrder.Controls.Add(Me.lblTable)
        Me.grpSelectedOrder.Controls.Add(Me.txtPayment)
        Me.grpSelectedOrder.Controls.Add(Me.lblTotalDue)
        Me.grpSelectedOrder.Controls.Add(Me.lblPayment)
        Me.grpSelectedOrder.Controls.Add(Me.lblOrderNumber)
        Me.grpSelectedOrder.Controls.Add(Me.lblTotalAmount)
        Me.grpSelectedOrder.Controls.Add(Me.lblOrderNo)
        Me.grpSelectedOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectedOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grpSelectedOrder.Location = New System.Drawing.Point(329, 66)
        Me.grpSelectedOrder.Name = "grpSelectedOrder"
        Me.grpSelectedOrder.Size = New System.Drawing.Size(264, 154)
        Me.grpSelectedOrder.TabIndex = 10
        Me.grpSelectedOrder.TabStop = False
        Me.grpSelectedOrder.Text = "Selected Order:"
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.Location = New System.Drawing.Point(10, 89)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(52, 17)
        Me.lblTable.TabIndex = 10
        Me.lblTable.Text = "Table :"
        '
        'lblTableNumber
        '
        Me.lblTableNumber.AutoSize = True
        Me.lblTableNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNumber.Location = New System.Drawing.Point(77, 89)
        Me.lblTableNumber.Name = "lblTableNumber"
        Me.lblTableNumber.Size = New System.Drawing.Size(0, 17)
        Me.lblTableNumber.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNumberOfOrders)
        Me.GroupBox1.Controls.Add(Me.lstPendingOrders)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 217)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pending Orders"
        '
        'lblNumberOfOrders
        '
        Me.lblNumberOfOrders.AutoSize = True
        Me.lblNumberOfOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfOrders.ForeColor = System.Drawing.Color.Teal
        Me.lblNumberOfOrders.Location = New System.Drawing.Point(6, 193)
        Me.lblNumberOfOrders.Name = "lblNumberOfOrders"
        Me.lblNumberOfOrders.Size = New System.Drawing.Size(93, 15)
        Me.lblNumberOfOrders.TabIndex = 1
        Me.lblNumberOfOrders.Text = "0 orders loaded"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 278)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpSelectedOrder)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPaymentlabel)
        Me.Name = "frmPayment"
        Me.Text = "frmPayment"
        Me.grpSelectedOrder.ResumeLayout(False)
        Me.grpSelectedOrder.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstPendingOrders As ListBox
    Friend WithEvents lblPaymentlabel As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblOrderNo As Label
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents grpSelectedOrder As GroupBox
    Friend WithEvents lblTableNumber As Label
    Friend WithEvents lblTable As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNumberOfOrders As Label
End Class
