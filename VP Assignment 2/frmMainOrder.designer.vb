<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainOrder
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
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnViewOrder = New System.Windows.Forms.Button()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Location = New System.Drawing.Point(74, 62)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(92, 29)
        Me.btnAddOrder.TabIndex = 1
        Me.btnAddOrder.Text = "&Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(157, 255)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnViewOrder
        '
        Me.btnViewOrder.Location = New System.Drawing.Point(74, 97)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(92, 29)
        Me.btnViewOrder.TabIndex = 6
        Me.btnViewOrder.Text = "&View Order"
        Me.btnViewOrder.UseVisualStyleBackColor = True
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Location = New System.Drawing.Point(74, 132)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(92, 29)
        Me.btnUpdateOrder.TabIndex = 7
        Me.btnUpdateOrder.Text = "&Update Order"
        Me.btnUpdateOrder.UseVisualStyleBackColor = True
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Location = New System.Drawing.Point(74, 167)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(92, 29)
        Me.btnDeleteOrder.TabIndex = 8
        Me.btnDeleteOrder.Text = "&Delete Order"
        Me.btnDeleteOrder.UseVisualStyleBackColor = True
        '
        'frmMainOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(253, 300)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnUpdateOrder)
        Me.Controls.Add(Me.btnViewOrder)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Name = "frmMainOrder"
        Me.Text = "Order"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddOrder As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnViewOrder As Button
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents btnDeleteOrder As Button
End Class
