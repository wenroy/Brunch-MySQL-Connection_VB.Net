Imports MySql.Data.MySqlClient

Public Class FrmEdit

    Friend ID As Integer
    Friend LaiLai_Item As String
    Friend LaiLai_Name As String
    Friend LaiLai_Set As String
    Friend LaiLai_Price As String
    Friend LaiLai_Number As String

    Public sConnection As New MySqlConnection
    Private Sub FrmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtItem.Text = LaiLai_Item
        TxtName.Text = LaiLai_Name
        TxtSet.Text = LaiLai_Set
        TxtPrice.Text = LaiLai_Price
        TxtNumber.Text = LaiLai_Number

    End Sub

    Private Sub BtnEdit_Click_1(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server = 127.0.0.1;UserID = brunch;Password = brunch;Database = brunch"
            sConnection.Open()
        End If

        Dim sqlQuery As String = "UPDATE lailai SET LaiLai_Item = '" & TxtItem.Text & _
            "',LaiLai_Name = '" & TxtName.Text & "',LaiLai_Set = '" & TxtSet.Text & _
            "',LaiLai_Price = '" & TxtPrice.Text & "',LaiLai_Number = '" & TxtNumber.Text & _
            "' WHERE ID = '" & ID & "'"
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