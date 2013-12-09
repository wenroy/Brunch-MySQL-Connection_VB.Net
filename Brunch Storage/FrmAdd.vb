Imports MySql.Data.MySqlClient

Public Class FrmAdd

    Public sConnection As New MySqlConnection
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server = 127.0.0.1;UserID = brunch;Password = brunch;Database = brunch"
            sConnection.Open()
        End If

        Dim sqlQuery As String = "INSERT INTO lailai(LaiLai_Name,LaiLai_Set,LaiLai_Price,LaiLai_Number,LaiLai_Sum) VALUES ('" & TxtName.Text & _
            "','" & TxtSet.Text & "','" & TxtPrice.Text & "','" & TxtNumber.Text & "','0')"
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