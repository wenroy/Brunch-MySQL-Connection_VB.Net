<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdit
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtSet = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblNumber = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblSet = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(219, 150)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 19
        Me.BtnEdit.Text = "修改"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(99, 150)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 18
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(99, 110)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrice.TabIndex = 17
        '
        'TxtSet
        '
        Me.TxtSet.Location = New System.Drawing.Point(99, 70)
        Me.TxtSet.Name = "TxtSet"
        Me.TxtSet.Size = New System.Drawing.Size(100, 22)
        Me.TxtSet.TabIndex = 16
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(99, 30)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 22)
        Me.TxtName.TabIndex = 15
        '
        'LblNumber
        '
        Me.LblNumber.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblNumber.Location = New System.Drawing.Point(31, 150)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(61, 23)
        Me.LblNumber.TabIndex = 14
        Me.LblNumber.Text = "數量："
        Me.LblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPrice
        '
        Me.LblPrice.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(31, 110)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(61, 23)
        Me.LblPrice.TabIndex = 13
        Me.LblPrice.Text = "單價："
        Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSet
        '
        Me.LblSet.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblSet.Location = New System.Drawing.Point(31, 70)
        Me.LblSet.Name = "LblSet"
        Me.LblSet.Size = New System.Drawing.Size(61, 23)
        Me.LblSet.TabIndex = 12
        Me.LblSet.Text = "規格："
        Me.LblSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblName
        '
        Me.LblName.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblName.Location = New System.Drawing.Point(31, 30)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(61, 23)
        Me.LblName.TabIndex = 11
        Me.LblName.Text = "品名："
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 202)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtSet)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblNumber)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.LblSet)
        Me.Controls.Add(Me.LblName)
        Me.Name = "FrmEdit"
        Me.Text = "FrmEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents TxtNumber As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtSet As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents LblNumber As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents LblSet As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
End Class
