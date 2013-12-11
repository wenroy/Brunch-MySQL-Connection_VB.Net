Imports MySql.Data.MySqlClient

Public Class FrmStorage

    Public sConnection As New MySqlConnection
    Dim Id As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server = 127.0.0.1;UserID = brunch;Password = brunch;Database = brunch;CharSet=utf8"
            sConnection.Open()
        End If

        LoadStorage()

    End Sub

    Public Sub LoadStorage()

        Dim sqlQuery As String = "SELECT * FROM Storage"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Dim sqlTable As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = sqlQuery
            .Connection = sConnection
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(sqlTable)
        End With

        'Fix for listview
        ListStorage.Items.Clear()

        For i = 0 To sqlTable.Rows.Count - 1
            With ListStorage
                .Items.Add(sqlTable.Rows(i)("Storage_ID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(sqlTable.Rows(i)("Storage_Company"))
                    .Add(sqlTable.Rows(i)("Storage_Item"))
                    .Add(sqlTable.Rows(i)("Storage_Name"))
                    .Add(sqlTable.Rows(i)("Storage_Set"))
                    .Add(sqlTable.Rows(i)("Storage_Price"))
                    .Add(sqlTable.Rows(i)("Storage_Number"))
                    .Add(sqlTable.Rows(i)("Storage_Sum"))
                End With
            End With
        Next

        'Show Database Count
        TxtCount.Text = sqlTable.Rows.Count

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmAdd.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Id = Nothing Then
            MsgBox("請選擇修改項目", MsgBoxStyle.Exclamation)
        Else
            Dim sqlQuery As String = "SELECT Storage_Company,Storage_Item,Storage_Name,Storage_Set,Storage_Price," & _
                "Storage_Number FROM Storage WHERE Storage_ID = '" & ListStorage.SelectedItems(0).Text & "'"

            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlCommand As New MySqlCommand
            Dim sqlTable As New DataTable

            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sConnection
            End With

            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(sqlTable)
            End With

            FrmEdit.ID = ListStorage.SelectedItems(0).Text
            FrmEdit.Storage_Company = sqlTable.Rows(0)("Storage_Company")
            FrmEdit.Storage_Item = sqlTable.Rows(0)("Storage_Item")
            FrmEdit.Storage_Name = sqlTable.Rows(0)("Storage_Name")
            FrmEdit.Storage_Set = sqlTable.Rows(0)("Storage_Set")
            FrmEdit.Storage_Price = sqlTable.Rows(0)("Storage_Price")
            FrmEdit.Storage_Number = sqlTable.Rows(0)("Storage_Number")
            FrmEdit.ShowDialog()
        End If
    End Sub

    Private Sub ListStorage_MouseClick(sender As Object, e As MouseEventArgs) Handles ListStorage.MouseClick
        Id = ListStorage.SelectedItems(0).Text
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If Id = Nothing Then
            MsgBox("請選擇刪除項目", MsgBoxStyle.Exclamation)
        Else
            Dim sqlQuery As String = "DELETE FROM Storage WHERE Storage_ID = '" & Id & "'"
            Dim sqlCommand As New MySqlCommand

            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sConnection
                .ExecuteNonQuery()
            End With

            MsgBox("刪除成功！", MsgBoxStyle.Information)

            LoadStorage()
        End If
    End Sub

End Class
