<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStaffRUProfile
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
        Me.txtContact = New System.Windows.Forms.MaskedTextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblGender1 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblIC1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBoxAddress = New System.Windows.Forms.RichTextBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(84, 192)
        Me.txtContact.Mask = "000-0000000"
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(166, 26)
        Me.txtContact.TabIndex = 73
        '
        'lblGender
        '
        Me.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(365, 162)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(100, 23)
        Me.lblGender.TabIndex = 69
        '
        'lblIC
        '
        Me.lblIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(84, 162)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(166, 23)
        Me.lblIC.TabIndex = 68
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(468, 308)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(83, 34)
        Me.btnUpdate.TabIndex = 66
        Me.btnUpdate.Text = "E&dit"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblGender1
        '
        Me.lblGender1.AutoSize = True
        Me.lblGender1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender1.Location = New System.Drawing.Point(295, 165)
        Me.lblGender1.Name = "lblGender1"
        Me.lblGender1.Size = New System.Drawing.Size(75, 20)
        Me.lblGender1.TabIndex = 61
        Me.lblGender1.Text = "&Gender : "
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(10, 225)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(80, 20)
        Me.lblAddress.TabIndex = 60
        Me.lblAddress.Text = "&Address : "
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(365, 191)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(167, 26)
        Me.txtEmail.TabIndex = 57
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(308, 194)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(60, 20)
        Me.lblEmail.TabIndex = 59
        Me.lblEmail.Text = "&Email : "
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(15, 194)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(77, 20)
        Me.lblContact.TabIndex = 56
        Me.lblContact.Text = "C&ontact : "
        '
        'lblIC1
        '
        Me.lblIC1.AutoSize = True
        Me.lblIC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC1.Location = New System.Drawing.Point(51, 165)
        Me.lblIC1.Name = "lblIC1"
        Me.lblIC1.Size = New System.Drawing.Size(37, 20)
        Me.lblIC1.TabIndex = 55
        Me.lblIC1.Text = "&IC : "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(84, 127)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 26)
        Me.txtName.TabIndex = 53
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(24, 130)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 20)
        Me.lblName.TabIndex = 54
        Me.lblName.Text = "&Name : "
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(84, 93)
        Me.txtID.MaxLength = 50
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(84, 26)
        Me.txtID.TabIndex = 51
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(19, 96)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(77, 20)
        Me.lblId.TabIndex = 50
        Me.lblId.Text = "Staff ID : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 37)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Personal Detail"
        '
        'RichTextBoxAddress
        '
        Me.RichTextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxAddress.Location = New System.Drawing.Point(84, 225)
        Me.RichTextBoxAddress.MaxLength = 100
        Me.RichTextBoxAddress.Name = "RichTextBoxAddress"
        Me.RichTextBoxAddress.Size = New System.Drawing.Size(279, 71)
        Me.RichTextBoxAddress.TabIndex = 58
        Me.RichTextBoxAddress.Text = ""
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(349, 308)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(113, 32)
        Me.btnLogout.TabIndex = 74
        Me.btnLogout.Text = "&Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'FrmStaffRUProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 369)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblIC)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblGender1)
        Me.Controls.Add(Me.RichTextBoxAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblIC1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmStaffRUProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmStaffRUProfile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContact As MaskedTextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblGender1 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblIC1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBoxAddress As RichTextBox
    Friend WithEvents btnLogout As Button
End Class
