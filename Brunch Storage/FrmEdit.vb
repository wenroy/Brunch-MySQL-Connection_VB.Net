Imports MySql.Data.MySqlClient

Public Class FrmEdit

    Friend ID As Integer
    Friend LaiLia_Name As String
    Friend LaiLia_Set As String
    Friend LaiLia_Price As String
    Friend LaiLia_Number As String

    Public sConnection As New MySqlConnection
    Private Sub FrmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtName.Text = LaiLia_Name
        TxtSet.Text = LaiLia_Set
        TxtPrice.Text = LaiLia_Price
        TxtNumber.Text = LaiLia_Number

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server = 127.0.0.1;UserID = brunch;Password = brunch;Database = brunch"
            sConnection.Open()
        End If

        Dim sqlQuery As String = "UPDATE lailai SET LaiLai_Name = '" & TxtName.Text & _
            "',LaiLai_Set = '" & TxtSet.Text & "',LaiLai_Price = '" & TxtPrice.Text & _
            "',LaiLai_Number = '" & TxtNumber.Text & "' WHERE ID = '" & ID & "'"
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