<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TCar = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.TName = New System.Windows.Forms.TextBox
        Me.TYear = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TPrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BCalculate = New System.Windows.Forms.Button
        Me.BEdit = New System.Windows.Forms.Button
        Me.BDelete = New System.Windows.Forms.Button
        Me.TTotal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TRent = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TDay = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BAdd = New System.Windows.Forms.Button
        CType(Me.TCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCar
        '
        Me.TCar.AllowUserToAddRows = False
        Me.TCar.AllowUserToDeleteRows = False
        Me.TCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TCar.Location = New System.Drawing.Point(12, 12)
        Me.TCar.Name = "TCar"
        Me.TCar.Size = New System.Drawing.Size(491, 421)
        Me.TCar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(509, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'TName
        '
        Me.TName.Location = New System.Drawing.Point(546, 12)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(158, 20)
        Me.TName.TabIndex = 2
        '
        'TYear
        '
        Me.TYear.Location = New System.Drawing.Point(546, 38)
        Me.TYear.Name = "TYear"
        Me.TYear.Size = New System.Drawing.Size(158, 20)
        Me.TYear.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(509, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Year"
        '
        'TPrice
        '
        Me.TPrice.Location = New System.Drawing.Point(546, 64)
        Me.TPrice.Name = "TPrice"
        Me.TPrice.Size = New System.Drawing.Size(158, 20)
        Me.TPrice.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(509, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Price"
        '
        'BCalculate
        '
        Me.BCalculate.Location = New System.Drawing.Point(546, 295)
        Me.BCalculate.Name = "BCalculate"
        Me.BCalculate.Size = New System.Drawing.Size(61, 23)
        Me.BCalculate.TabIndex = 7
        Me.BCalculate.Text = "Calculate"
        Me.BCalculate.UseVisualStyleBackColor = True
        '
        'BEdit
        '
        Me.BEdit.Location = New System.Drawing.Point(579, 108)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(61, 23)
        Me.BEdit.TabIndex = 8
        Me.BEdit.Text = "Edit"
        Me.BEdit.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Location = New System.Drawing.Point(646, 108)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(61, 23)
        Me.BDelete.TabIndex = 9
        Me.BDelete.Text = "Delete"
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'TTotal
        '
        Me.TTotal.Location = New System.Drawing.Point(546, 324)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.Size = New System.Drawing.Size(158, 20)
        Me.TTotal.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(509, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total"
        '
        'TRent
        '
        Me.TRent.Location = New System.Drawing.Point(546, 269)
        Me.TRent.Name = "TRent"
        Me.TRent.Size = New System.Drawing.Size(158, 20)
        Me.TRent.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(509, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cars"
        '
        'TDay
        '
        Me.TDay.Location = New System.Drawing.Point(546, 243)
        Me.TDay.Name = "TDay"
        Me.TDay.Size = New System.Drawing.Size(158, 20)
        Me.TDay.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(509, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Days"
        '
        'BAdd
        '
        Me.BAdd.Location = New System.Drawing.Point(509, 108)
        Me.BAdd.Name = "BAdd"
        Me.BAdd.Size = New System.Drawing.Size(61, 23)
        Me.BAdd.TabIndex = 16
        Me.BAdd.Text = "Add"
        Me.BAdd.UseVisualStyleBackColor = True
        '
        'CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 445)
        Me.Controls.Add(Me.BAdd)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TRent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TDay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BDelete)
        Me.Controls.Add(Me.BEdit)
        Me.Controls.Add(Me.BCalculate)
        Me.Controls.Add(Me.TPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TCar)
        Me.Name = "CRUD"
        Me.Text = "Rental"
        CType(Me.TCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TCar As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TName As System.Windows.Forms.TextBox
    Friend WithEvents TYear As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BCalculate As System.Windows.Forms.Button
    Friend WithEvents BEdit As System.Windows.Forms.Button
    Friend WithEvents BDelete As System.Windows.Forms.Button
    Friend WithEvents TTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TRent As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TDay As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BAdd As System.Windows.Forms.Button

End Class
