﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdd
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
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblSet = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblNumber = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtSet = New System.Windows.Forms.TextBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.LblItem = New System.Windows.Forms.Label()
        Me.LblCompany = New System.Windows.Forms.Label()
        Me.CmbCompany = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LblName
        '
        Me.LblName.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblName.Location = New System.Drawing.Point(40, 100)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(60, 25)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "品名："
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSet
        '
        Me.LblSet.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblSet.Location = New System.Drawing.Point(40, 140)
        Me.LblSet.Name = "LblSet"
        Me.LblSet.Size = New System.Drawing.Size(60, 25)
        Me.LblSet.TabIndex = 1
        Me.LblSet.Text = "規格："
        Me.LblSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPrice
        '
        Me.LblPrice.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(40, 180)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(60, 25)
        Me.LblPrice.TabIndex = 2
        Me.LblPrice.Text = "單價："
        Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNumber
        '
        Me.LblNumber.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblNumber.Location = New System.Drawing.Point(40, 220)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(60, 25)
        Me.LblNumber.TabIndex = 3
        Me.LblNumber.Text = "數量："
        Me.LblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(100, 100)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 22)
        Me.TxtName.TabIndex = 5
        '
        'TxtSet
        '
        Me.TxtSet.Location = New System.Drawing.Point(100, 140)
        Me.TxtSet.Name = "TxtSet"
        Me.TxtSet.Size = New System.Drawing.Size(100, 22)
        Me.TxtSet.TabIndex = 6
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(100, 180)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrice.TabIndex = 7
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(100, 220)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 8
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(230, 220)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "儲存"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtItem
        '
        Me.TxtItem.Location = New System.Drawing.Point(100, 60)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(100, 22)
        Me.TxtItem.TabIndex = 12
        '
        'LblItem
        '
        Me.LblItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblItem.Location = New System.Drawing.Point(40, 60)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(60, 25)
        Me.LblItem.TabIndex = 11
        Me.LblItem.Text = "貨號："
        Me.LblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCompany
        '
        Me.LblCompany.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblCompany.Location = New System.Drawing.Point(40, 20)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.Size = New System.Drawing.Size(60, 25)
        Me.LblCompany.TabIndex = 13
        Me.LblCompany.Text = "廠商："
        Me.LblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCompany
        '
        Me.CmbCompany.FormattingEnabled = True
        Me.CmbCompany.Items.AddRange(New Object() {"", "來來", "福記", "吉得堡", "信昌", "冠玨"})
        Me.CmbCompany.Location = New System.Drawing.Point(100, 25)
        Me.CmbCompany.Name = "CmbCompany"
        Me.CmbCompany.Size = New System.Drawing.Size(121, 20)
        Me.CmbCompany.TabIndex = 14
        Me.CmbCompany.TabStop = False
        '
        'FrmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 262)
        Me.Controls.Add(Me.CmbCompany)
        Me.Controls.Add(Me.LblCompany)
        Me.Controls.Add(Me.TxtItem)
        Me.Controls.Add(Me.LblItem)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtSet)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblNumber)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.LblSet)
        Me.Controls.Add(Me.LblName)
        Me.Name = "FrmAdd"
        Me.Text = "FrmAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblSet As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents LblNumber As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSet As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumber As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtItem As System.Windows.Forms.TextBox
    Friend WithEvents LblItem As System.Windows.Forms.Label
    Friend WithEvents LblCompany As System.Windows.Forms.Label
    Friend WithEvents CmbCompany As System.Windows.Forms.ComboBox
End Class
