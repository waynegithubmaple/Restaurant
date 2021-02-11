<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateFood
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpFoodDetails = New System.Windows.Forms.GroupBox()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.lblFoodCategory = New System.Windows.Forms.Label()
        Me.lblFoodPrice = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblFoodDetail = New System.Windows.Forms.Label()
        Me.lblFoodPicture = New System.Windows.Forms.Label()
        Me.lblUploadPicture = New System.Windows.Forms.Button()
        Me.lblSpicyLevel = New System.Windows.Forms.Label()
        Me.lblAllergic = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.btnCancelAdd = New System.Windows.Forms.Button()
        Me.btnAddFood = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.radAvailable = New System.Windows.Forms.RadioButton()
        Me.radUnavailable = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFoodDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 260)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'grpFoodDetails
        '
        Me.grpFoodDetails.Controls.Add(Me.radUnavailable)
        Me.grpFoodDetails.Controls.Add(Me.radAvailable)
        Me.grpFoodDetails.Controls.Add(Me.TextBox1)
        Me.grpFoodDetails.Controls.Add(Me.lblAvailability)
        Me.grpFoodDetails.Controls.Add(Me.lblAllergic)
        Me.grpFoodDetails.Controls.Add(Me.lblSpicyLevel)
        Me.grpFoodDetails.Controls.Add(Me.lblDescription)
        Me.grpFoodDetails.Controls.Add(Me.lblFoodPrice)
        Me.grpFoodDetails.Controls.Add(Me.lblFoodCategory)
        Me.grpFoodDetails.Controls.Add(Me.lblFoodName)
        Me.grpFoodDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFoodDetails.Location = New System.Drawing.Point(12, 36)
        Me.grpFoodDetails.Name = "grpFoodDetails"
        Me.grpFoodDetails.Size = New System.Drawing.Size(486, 379)
        Me.grpFoodDetails.TabIndex = 1
        Me.grpFoodDetails.TabStop = False
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName.Location = New System.Drawing.Point(6, 16)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(104, 20)
        Me.lblFoodName.TabIndex = 0
        Me.lblFoodName.Text = "Food name:"
        '
        'lblFoodCategory
        '
        Me.lblFoodCategory.AutoSize = True
        Me.lblFoodCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodCategory.Location = New System.Drawing.Point(6, 56)
        Me.lblFoodCategory.Name = "lblFoodCategory"
        Me.lblFoodCategory.Size = New System.Drawing.Size(86, 20)
        Me.lblFoodCategory.TabIndex = 1
        Me.lblFoodCategory.Text = "Category:"
        '
        'lblFoodPrice
        '
        Me.lblFoodPrice.AutoSize = True
        Me.lblFoodPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodPrice.Location = New System.Drawing.Point(6, 176)
        Me.lblFoodPrice.Name = "lblFoodPrice"
        Me.lblFoodPrice.Size = New System.Drawing.Size(98, 20)
        Me.lblFoodPrice.TabIndex = 2
        Me.lblFoodPrice.Text = "Price (RM):"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(6, 259)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(105, 20)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description:"
        '
        'lblFoodDetail
        '
        Me.lblFoodDetail.AutoSize = True
        Me.lblFoodDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodDetail.Location = New System.Drawing.Point(12, 9)
        Me.lblFoodDetail.Name = "lblFoodDetail"
        Me.lblFoodDetail.Size = New System.Drawing.Size(127, 24)
        Me.lblFoodDetail.TabIndex = 2
        Me.lblFoodDetail.Text = "Food Details"
        '
        'lblFoodPicture
        '
        Me.lblFoodPicture.AutoSize = True
        Me.lblFoodPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodPicture.Location = New System.Drawing.Point(511, 9)
        Me.lblFoodPicture.Name = "lblFoodPicture"
        Me.lblFoodPicture.Size = New System.Drawing.Size(130, 24)
        Me.lblFoodPicture.TabIndex = 3
        Me.lblFoodPicture.Text = "Food Picture"
        '
        'lblUploadPicture
        '
        Me.lblUploadPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUploadPicture.ForeColor = System.Drawing.Color.Blue
        Me.lblUploadPicture.Location = New System.Drawing.Point(190, 285)
        Me.lblUploadPicture.Name = "lblUploadPicture"
        Me.lblUploadPicture.Size = New System.Drawing.Size(111, 36)
        Me.lblUploadPicture.TabIndex = 4
        Me.lblUploadPicture.Text = "Upload Picture"
        Me.lblUploadPicture.UseVisualStyleBackColor = True
        '
        'lblSpicyLevel
        '
        Me.lblSpicyLevel.AutoSize = True
        Me.lblSpicyLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpicyLevel.Location = New System.Drawing.Point(6, 96)
        Me.lblSpicyLevel.Name = "lblSpicyLevel"
        Me.lblSpicyLevel.Size = New System.Drawing.Size(104, 20)
        Me.lblSpicyLevel.TabIndex = 4
        Me.lblSpicyLevel.Text = "Spicy Level:"
        '
        'lblAllergic
        '
        Me.lblAllergic.AutoSize = True
        Me.lblAllergic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllergic.Location = New System.Drawing.Point(6, 136)
        Me.lblAllergic.Name = "lblAllergic"
        Me.lblAllergic.Size = New System.Drawing.Size(160, 20)
        Me.lblAllergic.TabIndex = 5
        Me.lblAllergic.Text = "Allergic Ingredient:"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.Location = New System.Drawing.Point(6, 216)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(98, 20)
        Me.lblAvailability.TabIndex = 6
        Me.lblAvailability.Text = "Availability:"
        '
        'btnCancelAdd
        '
        Me.btnCancelAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelAdd.ForeColor = System.Drawing.Color.Red
        Me.btnCancelAdd.Location = New System.Drawing.Point(505, 379)
        Me.btnCancelAdd.Name = "btnCancelAdd"
        Me.btnCancelAdd.Size = New System.Drawing.Size(141, 36)
        Me.btnCancelAdd.TabIndex = 5
        Me.btnCancelAdd.Text = "Cancel"
        Me.btnCancelAdd.UseVisualStyleBackColor = True
        '
        'btnAddFood
        '
        Me.btnAddFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFood.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddFood.Location = New System.Drawing.Point(674, 379)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(141, 36)
        Me.btnAddFood.TabIndex = 6
        Me.btnAddFood.Text = "Confirm"
        Me.btnAddFood.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblUploadPicture)
        Me.GroupBox1.Location = New System.Drawing.Point(505, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 334)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(364, 20)
        Me.TextBox1.TabIndex = 7
        '
        'radAvailable
        '
        Me.radAvailable.AutoSize = True
        Me.radAvailable.Location = New System.Drawing.Point(116, 218)
        Me.radAvailable.Name = "radAvailable"
        Me.radAvailable.Size = New System.Drawing.Size(68, 17)
        Me.radAvailable.TabIndex = 8
        Me.radAvailable.TabStop = True
        Me.radAvailable.Text = "Available"
        Me.radAvailable.UseVisualStyleBackColor = True
        '
        'radUnavailable
        '
        Me.radUnavailable.AutoSize = True
        Me.radUnavailable.Location = New System.Drawing.Point(218, 219)
        Me.radUnavailable.Name = "radUnavailable"
        Me.radUnavailable.Size = New System.Drawing.Size(81, 17)
        Me.radUnavailable.TabIndex = 9
        Me.radUnavailable.TabStop = True
        Me.radUnavailable.Text = "Unavailable"
        Me.radUnavailable.UseVisualStyleBackColor = True
        '
        'frmCreateFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 424)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddFood)
        Me.Controls.Add(Me.btnCancelAdd)
        Me.Controls.Add(Me.lblFoodPicture)
        Me.Controls.Add(Me.lblFoodDetail)
        Me.Controls.Add(Me.grpFoodDetails)
        Me.Name = "frmCreateFood"
        Me.Text = "Register Food"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFoodDetails.ResumeLayout(False)
        Me.grpFoodDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpFoodDetails As GroupBox
    Friend WithEvents lblAllergic As Label
    Friend WithEvents lblSpicyLevel As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblFoodPrice As Label
    Friend WithEvents lblFoodCategory As Label
    Friend WithEvents lblFoodName As Label
    Friend WithEvents lblFoodDetail As Label
    Friend WithEvents lblFoodPicture As Label
    Friend WithEvents lblUploadPicture As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblAvailability As Label
    Friend WithEvents btnCancelAdd As Button
    Friend WithEvents btnAddFood As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radUnavailable As RadioButton
    Friend WithEvents radAvailable As RadioButton
End Class
