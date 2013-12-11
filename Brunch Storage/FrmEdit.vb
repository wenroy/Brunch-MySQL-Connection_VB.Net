Imports MySql.Data.MySqlClient

Public Class FrmEdit

    Friend ID As Integer
    Friend Storage_Company As String
    Friend Storage_Item As String
    Friend Storage_Name As String
    Friend Storage_Set As String
    Friend Storage_Price As String
    Friend Storage_Number As String

    Public sConnection As New MySqlConnection
    Private Sub FrmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CmbCompany.Text = Storage_Company
        TxtItem.Text = Storage_Item
        TxtName.Text = Storage_Name
        TxtSet.Text = Storage_Set
        TxtPrice.Text = Storage_Price
        TxtNumber.Text = Storage_Number

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server = 127.0.0.1;UserID = brunch;Password = brunch;Database = brunch;CharSet=utf8"
            sConnection.Open()
        End If

        Dim xSum As Integer

        If TxtItem.Text = "" Then TxtItem.Text = "" Else TxtItem.Text = (TxtItem.Text).ToString
        If TxtName.Text = "" Then TxtName.Text = "" Else TxtName.Text = (TxtName.Text).ToString
        If TxtSet.Text = "" Then TxtSet.Text = "" Else TxtSet.Text = (TxtSet.Text).ToString
        If TxtPrice.Text = "" Then TxtPrice.Text = "" Else TxtPrice.Text = Int(TxtPrice.Text)
        If TxtNumber.Text = "" Then TxtNumber.Text = "" Else TxtNumber.Text = Int(TxtNumber.Text)
        If TxtPrice.Text = "" Or TxtNumber.Text = "" Then xSum = 0 Else xSum = (TxtPrice.Text) * (TxtNumber.Text)

        Dim sqlQuery As String = "UPDATE Storage SET Storage_Company = '" & CmbCompany.Text & _
            "',Storage_Item = '" & TxtItem.Text & "',Storage_Name = '" & TxtName.Text & _
            "',Storage_Set = '" & TxtSet.Text & "',Storage_Price = '" & TxtPrice.Text & _
            "',Storage_Number = '" & TxtNumber.Text & "',Storage_Sum = '" & xSum & "' WHERE Storage_ID = '" & ID & "'"
        Dim sqlCommand As New MySqlCommand
        With sqlCommand
            .CommandText = sqlQuery
            .Connection = sConnection
            .ExecuteNonQuery()
        End With

        MsgBox("修改完成！", MsgBoxStyle.Information)
        Dispose()
        Close()

        'Load the all the data again from our main form
        FrmStorage.LoadStorage()
    End Sub
End Class