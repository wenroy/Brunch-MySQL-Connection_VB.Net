Imports MySql.Data.MySqlClient

Public Class FrmStorage

    Public sConnection As New MySqlConnection
    Dim id As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server = 127.0.0.1;UserID = brunch;Password = brunch;Database = brunch"
            sConnection.Open()
        End If

        LoadStorage()
    End Sub

    Public Sub LoadStorage()
        Dim sqlQuery As String = "SELECT * FROM lailai"
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
                .Items.Add(sqlTable.Rows(i)("ID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(sqlTable.Rows(i)("LaiLai_Name"))
                    .Add(sqlTable.Rows(i)("LaiLai_Set"))
                    .Add(sqlTable.Rows(i)("LaiLai_Price"))
                    .Add(sqlTable.Rows(i)("LaiLai_Number"))
                    .Add(sqlTable.Rows(i)("LaiLai_Sum"))
                End With
            End With
        Next
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmAdd.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If id = Nothing Then
            MsgBox("請選擇修改項目", MsgBoxStyle.Exclamation)
        Else
            Dim sqlQuery As String = "SELECT LaiLai_Name,LaiLai_Set,LaiLai_Price,LaiLai_Number FROM lailai" & _
            " WHERE ID = '" & ListStorage.SelectedItems(0).Text & "'"

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
            FrmEdit.LaiLia_Name = sqlTable.Rows(0)("LaiLai_Name")
            FrmEdit.LaiLia_Set = sqlTable.Rows(0)("LaiLai_Set")
            FrmEdit.LaiLia_Price = sqlTable.Rows(0)("LaiLai_Price")
            FrmEdit.LaiLia_Number = sqlTable.Rows(0)("LaiLai_Number")
            FrmEdit.ShowDialog()
        End If
    End Sub

    Private Sub ListStorage_MouseClick(sender As Object, e As MouseEventArgs) Handles ListStorage.MouseClick
        id = ListStorage.SelectedItems(0).Text
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If id = Nothing Then
            MsgBox("請選擇刪除項目", MsgBoxStyle.Exclamation)
        Else
            Dim sqlQuery As String = "DELETE FROM lailai WHERE ID = '" & id & "'"
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
