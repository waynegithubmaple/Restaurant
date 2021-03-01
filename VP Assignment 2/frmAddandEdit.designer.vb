<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddandEdit
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
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtFoodName = New System.Windows.Forms.TextBox()
        Me.radMaincourse = New System.Windows.Forms.RadioButton()
        Me.radAppetizer = New System.Windows.Forms.RadioButton()
        Me.radBeverage = New System.Windows.Forms.RadioButton()
        Me.radDrink = New System.Windows.Forms.RadioButton()
        Me.grpEditbox = New System.Windows.Forms.GroupBox()
        Me.mskPrice = New System.Windows.Forms.MaskedTextBox()
        Me.radDessert = New System.Windows.Forms.RadioButton()
        Me.radUnavailable = New System.Windows.Forms.RadioButton()
        Me.radAvailable = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClearpic = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grpEditbox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBox
        '
        Me.picBox.Location = New System.Drawing.Point(12, 39)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(470, 370)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox.TabIndex = 1
        Me.picBox.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(12, 437)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(105, 43)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "&Upload Image"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName.Location = New System.Drawing.Point(6, 29)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(111, 20)
        Me.lblFoodName.TabIndex = 3
        Me.lblFoodName.Text = "Food Name :"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(26, 71)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(91, 20)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "Category :"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(14, 199)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(103, 20)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Price (RM) :"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.Location = New System.Drawing.Point(14, 27)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(103, 20)
        Me.lblAvailability.TabIndex = 6
        Me.lblAvailability.Text = "Availability :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(504, 335)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 99)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controls"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(311, 22)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 58)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(6, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 58)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "&Add item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(160, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 58)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtFoodName
        '
        Me.txtFoodName.Location = New System.Drawing.Point(123, 31)
        Me.txtFoodName.Name = "txtFoodName"
        Me.txtFoodName.Size = New System.Drawing.Size(262, 23)
        Me.txtFoodName.TabIndex = 11
        '
        'radMaincourse
        '
        Me.radMaincourse.AutoSize = True
        Me.radMaincourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMaincourse.Location = New System.Drawing.Point(123, 71)
        Me.radMaincourse.Name = "radMaincourse"
        Me.radMaincourse.Size = New System.Drawing.Size(108, 22)
        Me.radMaincourse.TabIndex = 12
        Me.radMaincourse.TabStop = True
        Me.radMaincourse.Text = "Main course"
        Me.radMaincourse.UseVisualStyleBackColor = True
        '
        'radAppetizer
        '
        Me.radAppetizer.AutoSize = True
        Me.radAppetizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAppetizer.Location = New System.Drawing.Point(258, 71)
        Me.radAppetizer.Name = "radAppetizer"
        Me.radAppetizer.Size = New System.Drawing.Size(87, 22)
        Me.radAppetizer.TabIndex = 13
        Me.radAppetizer.TabStop = True
        Me.radAppetizer.Text = "Appetizer"
        Me.radAppetizer.UseVisualStyleBackColor = True
        '
        'radBeverage
        '
        Me.radBeverage.AutoSize = True
        Me.radBeverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBeverage.Location = New System.Drawing.Point(123, 113)
        Me.radBeverage.Name = "radBeverage"
        Me.radBeverage.Size = New System.Drawing.Size(88, 22)
        Me.radBeverage.TabIndex = 14
        Me.radBeverage.TabStop = True
        Me.radBeverage.Text = "Beverage"
        Me.radBeverage.UseVisualStyleBackColor = True
        '
        'radDrink
        '
        Me.radDrink.AutoSize = True
        Me.radDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDrink.Location = New System.Drawing.Point(258, 113)
        Me.radDrink.Name = "radDrink"
        Me.radDrink.Size = New System.Drawing.Size(61, 22)
        Me.radDrink.TabIndex = 15
        Me.radDrink.TabStop = True
        Me.radDrink.Text = "Drink"
        Me.radDrink.UseVisualStyleBackColor = True
        '
        'grpEditbox
        '
        Me.grpEditbox.Controls.Add(Me.mskPrice)
        Me.grpEditbox.Controls.Add(Me.radDessert)
        Me.grpEditbox.Controls.Add(Me.lblFoodName)
        Me.grpEditbox.Controls.Add(Me.radBeverage)
        Me.grpEditbox.Controls.Add(Me.radDrink)
        Me.grpEditbox.Controls.Add(Me.lblCategory)
        Me.grpEditbox.Controls.Add(Me.lblPrice)
        Me.grpEditbox.Controls.Add(Me.txtFoodName)
        Me.grpEditbox.Controls.Add(Me.radAppetizer)
        Me.grpEditbox.Controls.Add(Me.radMaincourse)
        Me.grpEditbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEditbox.Location = New System.Drawing.Point(504, 26)
        Me.grpEditbox.Name = "grpEditbox"
        Me.grpEditbox.Size = New System.Drawing.Size(407, 233)
        Me.grpEditbox.TabIndex = 16
        Me.grpEditbox.TabStop = False
        Me.grpEditbox.Text = "Details"
        '
        'mskPrice
        '
        Me.mskPrice.Location = New System.Drawing.Point(124, 198)
        Me.mskPrice.Mask = "000"
        Me.mskPrice.Name = "mskPrice"
        Me.mskPrice.Size = New System.Drawing.Size(77, 23)
        Me.mskPrice.TabIndex = 19
        Me.mskPrice.ValidatingType = GetType(Integer)
        '
        'radDessert
        '
        Me.radDessert.AutoSize = True
        Me.radDessert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDessert.Location = New System.Drawing.Point(123, 154)
        Me.radDessert.Name = "radDessert"
        Me.radDessert.Size = New System.Drawing.Size(78, 22)
        Me.radDessert.TabIndex = 18
        Me.radDessert.TabStop = True
        Me.radDessert.Text = "Dessert"
        Me.radDessert.UseVisualStyleBackColor = True
        '
        'radUnavailable
        '
        Me.radUnavailable.AutoSize = True
        Me.radUnavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUnavailable.Location = New System.Drawing.Point(258, 25)
        Me.radUnavailable.Name = "radUnavailable"
        Me.radUnavailable.Size = New System.Drawing.Size(101, 22)
        Me.radUnavailable.TabIndex = 17
        Me.radUnavailable.TabStop = True
        Me.radUnavailable.Text = "Unavailable"
        Me.radUnavailable.UseVisualStyleBackColor = True
        '
        'radAvailable
        '
        Me.radAvailable.AutoSize = True
        Me.radAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAvailable.Location = New System.Drawing.Point(123, 25)
        Me.radAvailable.Name = "radAvailable"
        Me.radAvailable.Size = New System.Drawing.Size(83, 22)
        Me.radAvailable.TabIndex = 16
        Me.radAvailable.TabStop = True
        Me.radAvailable.Text = "Available"
        Me.radAvailable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAvailability)
        Me.GroupBox1.Controls.Add(Me.radAvailable)
        Me.GroupBox1.Controls.Add(Me.radUnavailable)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(504, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 63)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'btnClearpic
        '
        Me.btnClearpic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearpic.Location = New System.Drawing.Point(136, 437)
        Me.btnClearpic.Name = "btnClearpic"
        Me.btnClearpic.Size = New System.Drawing.Size(105, 43)
        Me.btnClearpic.TabIndex = 19
        Me.btnClearpic.Text = "&Clear Image"
        Me.btnClearpic.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'frmAddandEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(978, 516)
        Me.Controls.Add(Me.btnClearpic)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpEditbox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.picBox)
        Me.Name = "frmAddandEdit"
        Me.Text = "frmAddandEdit"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.grpEditbox.ResumeLayout(False)
        Me.grpEditbox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBox As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents lblFoodName As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtFoodName As TextBox
    Friend WithEvents radMaincourse As RadioButton
    Friend WithEvents radAppetizer As RadioButton
    Friend WithEvents radBeverage As RadioButton
    Friend WithEvents radDrink As RadioButton
    Friend WithEvents grpEditbox As GroupBox
    Friend WithEvents radUnavailable As RadioButton
    Friend WithEvents radAvailable As RadioButton
    Friend WithEvents radDessert As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearpic As Button
    Friend WithEvents mskPrice As MaskedTextBox
    Friend WithEvents err As ErrorProvider
End Class
