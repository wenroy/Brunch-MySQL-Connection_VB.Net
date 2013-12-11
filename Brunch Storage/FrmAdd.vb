Imports MySql.Data.MySqlClient

Public Class FrmAdd

    Public sConnection As New MySqlConnection
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
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

        Dim sqlQuery As String = "INSERT INTO Storage(Storage_Company,Storage_Item,Storage_Name,Storage_Set," & _
            "Storage_Price,Storage_Number,Storage_Sum) VALUES ('" & CmbCompany.Text & "','" & TxtItem.Text & _
            "','" & TxtName.Text & "','" & TxtSet.Text & "','" & TxtPrice.Text & "','" & TxtNumber.Text & _
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