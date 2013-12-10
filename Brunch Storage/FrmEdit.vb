Imports MySql.Data.MySqlClient

Public Class FrmEdit

    Friend ID As Integer
    Friend Storage_Item As String
    Friend Storage_Name As String
    Friend Storage_Set As String
    Friend Storage_Price As String
    Friend Storage_Number As String

    Public sConnection As New MySqlConnection
    Private Sub FrmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtItem.Text = Storage_Item
        TxtName.Text = Storage_Name
        TxtSet.Text = Storage_Set
        TxtPrice.Text = Storage_Price
        TxtNumber.Text = Storage_Number

    End Sub

    Private Sub BtnEdit_Click_1(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server = 127.0.0.1;UserID = brunch;Password = brunch;Database = brunch"
            sConnection.Open()
        End If

        Dim xSum As Integer = (TxtPrice.Text) * (TxtNumber.Text)

        Dim sqlQuery As String = "UPDATE Storage SET Storage_Item = '" & TxtItem.Text & _
            "',Storage_Name = '" & TxtName.Text & "',Storage_Set = '" & TxtSet.Text & _
            "',Storage_Price = '" & TxtPrice.Text & "',Storage_Number = '" & TxtNumber.Text & _
            "',Storage_Sum = '" & xSum & "' WHERE Storage_ID = '" & ID & "'"
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