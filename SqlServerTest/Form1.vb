Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'TextBox1,TextBox2の両方が空っぽのときはエラーを表示したい。
        If TextBox1.Text = "" AndAlso TextBox2.Text = "" Then
            'メッセージボックスを表示する
            MessageBox.Show("値を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            Exit Sub

        End If

        Dim MSG As String = TextBox1.Text & TextBox2.Text

        Label1.Text = MSG

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim sqlcon = New Class_SQLSERVER()
        Dim SQL As String = "SELECT * FROM Students;"
        sqlcon.ExecuteWithoutTransaction(SQL)
        Dim dt As DataTable = sqlcon.DataTable



    End Sub


End Class