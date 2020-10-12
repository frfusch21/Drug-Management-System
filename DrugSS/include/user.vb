﻿Imports MySql.Data.MySqlClient

Module user
    Public con As MySqlConnection = mysqldb()

    Public Sub login(ByVal username As Object, ByVal pass As Object)
        Try

            con.Open()
            reloadtxt("SELECT * FROM user WHERE user_name= '" & username.text & "' and pass = sha1('" & pass.text & "')")


            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("type") = "Administrator" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("type"))
                    enable_disable(True)

                    With Home
                        .ts_Transaction.Enabled = False
                        .ts_StockMaster.Enabled = False
                        .ts_Customer.Enabled = False
                        .ts_Report.Enabled = False
                        .ts_Login.Text = "LOGOUT"
                        .ts_Login.Image = My.Resources.logout
                        LoginForm.Close()
                    End With
                ElseIf dt.Rows(0).Item("type") = "Staff" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("type"))
                    enable_disable(True)
                    With Home
                        .ts_ManageUser.Enabled = False
                        .ts_Login.Text = "LOGOUT"
                        .ts_Login.Image = My.Resources.logout
                        LoginForm.Close()
                    End With
                End If

            Else
                MsgBox("Acount doest not exits!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub

    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Module

