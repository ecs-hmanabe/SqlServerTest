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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSELECT.Click

        DataGridSelect()

    End Sub
    Private Sub DataGridSelect()

        Dim sqlcon = New Class_SQLSERVER()
        Dim SQL As String = "SELECT * FROM Students order by 1;"
        sqlcon.ExecuteWithoutTransaction(SQL)
        Dim dt As DataTable = sqlcon.DataTable

        DataGridView1.DataSource = dt
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'DataGridView1.SelectedRows(0).Index
        Dim rowid As Integer = DataGridView1.CurrentCellAddress.Y
        TextBoxStudentID.Text = DataGridView1.Rows(rowid).Cells(0).Value
        TextBoxFirstName.Text = DataGridView1.Rows(rowid).Cells(1).Value
        TextBoxLastName.Text = DataGridView1.Rows(rowid).Cells(2).Value
        TextBoxBirthday.Text = DataGridView1.Rows(rowid).Cells(3).Value
        TextBoxGender.Text = DataGridView1.Rows(rowid).Cells(4).Value
    End Sub

    Private Sub ButtonINSERT_Click(sender As Object, e As EventArgs) Handles ButtonINSERT.Click
        If TextBoxStudentID.Text = "" Then
            Exit Sub
        End If

        If Not StudentID_isUnique() Then
            Exit Sub
        End If

        Dim sqlcon = New Class_SQLSERVER()
        Dim SQL As String =
            "insert Students " &
            "values('" & TextBoxStudentID.Text & "','" & TextBoxFirstName.Text & "','" & TextBoxLastName.Text & "','" & TextBoxBirthday.Text & "','" & TextBoxGender.Text & "');"
        sqlcon.ExecuteTransaction(SQL)
        Dim dt As DataTable = sqlcon.DataTable

        DataGridView1.DataSource = dt

        DataGridSelect()

    End Sub
    Private Function StudentID_isUnique()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If TextBoxStudentID.Text = DataGridView1.Rows(i).Cells(0).Value Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub ButtonUPDATE_Click(sender As Object, e As EventArgs) Handles ButtonUPDATE.Click
        If TextBoxStudentID.Text = "" Then
            Exit Sub
        End If

        Dim sqlcon = New Class_SQLSERVER()
        Dim SQL As String =
"update Students" & vbCrLf &
"Set" & vbCrLf &
"StudentID = '" & TextBoxStudentID.Text & "'" & vbCrLf &
",FirstName = '" & TextBoxFirstName.Text & "'" & vbCrLf &
",LastName = '" & TextBoxLastName.Text & "'" & vbCrLf &
",Birthday = '" & TextBoxBirthday.Text & "'" & vbCrLf &
",Gender = '" & TextBoxGender.Text & "'" & vbCrLf &
"Where " & vbCrLf &
"StudentID = '" & TextBoxStudentID.Text & "';"
        sqlcon.ExecuteTransaction(SQL)
        Dim dt As DataTable = sqlcon.DataTable

        DataGridView1.DataSource = dt

        DataGridSelect()
    End Sub

    Private Sub ButtonDELETE_Click(sender As Object, e As EventArgs) Handles ButtonDELETE.Click

        If TextBoxStudentID.Text = "" Then
            Exit Sub
        End If
        If StudentID_isUnique() Then
            Exit Sub
        End If
        Dim sqlcon = New Class_SQLSERVER()
        Dim SQL As String =
"delete Students" & vbCrLf &
"Where " & vbCrLf &
"StudentID = '" & TextBoxStudentID.Text & "';"
        sqlcon.ExecuteTransaction(SQL)
        Dim dt As DataTable = sqlcon.DataTable

        DataGridView1.DataSource = dt

        DataGridSelect()
    End Sub

    Private Sub formclear()
        TextBoxStudentID.Text = ""
        TextBoxFirstName.Text = ""
        TextBoxLastName.Text = ""
        TextBoxBirthday.Text = ""
        TextBoxGender.Text = ""
    End Sub
End Class