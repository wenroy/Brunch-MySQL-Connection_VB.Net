Imports MySql.Data.MySqlClient

Public Class FrmAdd

    Public sConnection As New MySqlConnection
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server = 127.0.0.1;UserID = brunch;Password = brunch;Database = brunch"
            sConnection.Open()
        End If

        Dim xSum As Integer = (TxtPrice.Text) * (TxtNumber.Text)

        Dim sqlQuery As String = "INSERT INTO Storage(Storage_Item,Storage_Name,Storage_Set,Storage_Price,Storage_Number,Storage_Sum)" & _
            " VALUES ('" & TxtItem.Text & "','" & TxtName.Text & "','" & TxtSet.Text & "','" & TxtPrice.Text & "','" & TxtNumber.Text & _
            "','" & xSum & "')"
        Dim sqlCommand As New MySqlCommand
        With sqlCommand
            .CommandText = sqlQuery
            .Connection = sConnection
            .ExecuteNonQuery()
        End With

        MsgBox("新增完成！")
        Dispose()
        Close()

        'Load the all the data again from our main form
        FrmStorage.LoadStorage()
    End Sub
End Class