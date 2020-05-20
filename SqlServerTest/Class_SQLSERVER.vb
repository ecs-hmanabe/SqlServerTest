

Imports System.Data.SqlClient

Public Class Class_SQLSERVER
    Private ReadOnly _conn As New SqlClient.SqlConnection() 'SQLSERVERコネクション用
    Private _cmd As New SqlCommand()  'SQLSERVERコマンド用
    Private _successCount As Integer  'DataProcessing内で実行したSQL(INSERT/UPDATE/DELETE)の成功総数
    Private _failureCount As Integer  'DataProcessing内で実行したSQL(INSERT/UPDATE/DELETE)の失敗総数
    Private _DataTable As New DataTable()
    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    Public Sub New()
        Dim ServerName As String = My.Settings.ServerName 'サーバー名(またはIPアドレス)
        Dim DatabaseName As String = My.Settings.DatabaseName 'データベース
        Dim St As String
        St = "Server=" & ServerName & ";"
        St &= "integrated security=SSPI;"
        St &= "initial catalog = " & DatabaseName & ";"

        '接続文字を作成するコンストラクタ
        _conn.ConnectionString = St

    End Sub

    'データベースのオープン処理
    'データベースオープン成功＝true
    Public Function Open() As Boolean
        Try
            _cmd = _conn.CreateCommand()
            _conn.Open()

            Return True '成功の場合はtrueを返す
        Catch ex As Exception

        End Try

        Return False '接続失敗はFalse

    End Function
    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    'データベース切断処理
    'データベース切断成功＝ture
    Public Function Close() As Boolean
        Try
            If _conn.State = ConnectionState.Open Then 'データベースが開いているか確認
                'データベースが開いていれば閉じる
                _conn.Close()

            End If
            Return True '成功の場合はtrueを返す

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try

        Return False '接続失敗はFalse

    End Function
    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    'SQL（SELECT文）の実行
    'return＝SQLの実行結果
    Protected Function ExecuteQuery(strSQL As String) As DataTable
        Dim dtTbl As New DataTable()

        Try
            'データがオープンしていない場合には、なにもないdtTblを返す
            If _conn.State <> ConnectionState.Open Then Return dtTbl

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(strSQL, _conn)

            'SQLを実行して、結果をdtTblに保存
            adapter.Fill(dtTbl)


        Catch ex As Exception
            Throw New Exception(ex.Message)


        End Try

        Return dtTbl
    End Function
    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    'SQL（INSERT・UPDATE・DELETE）の実行
    'return＝処理件数
    Protected Function ExecuteNonQuery(strSQL As String) As Integer
        Dim count As Integer = -1
        Try
            'データがオープンされていない場合には、「-1」を返す
            If _conn.State <> ConnectionState.Open Then Return count
            strSQL = strSQL.Replace(vbCrLf, " ")
            _cmd.CommandText = strSQL
            count = _cmd.ExecuteNonQuery()

            '成功件数をカウント
            _successCount += count


        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
        Return count

    End Function
    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    ''' DataProcessing内で実行したSQL(INSERT/UPDATE/DELETE)の失敗総数
    Public ReadOnly Property FailureCount() As Integer
        Get
            Return _failureCount
        End Get
    End Property

    ''' DataProcessing内で実行したSQL(INSERT/UPDATE/DELETE)の成功総数
    Public ReadOnly Property SuccessCount() As Integer
        Get
            Return _successCount
        End Get
    End Property
    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    'トランザクション開始処理
    'return＝成功時true
    Public Function BeginTransaction() As Boolean
        Try
            'データベースをオープンする。
            'オープンに失敗した場合には処理を抜ける
            If Not Open() Then Return False

            'データベースがクローズ状態は処理終了
            If _conn.State = ConnectionState.Closed Then Return False

            'トランザクション処理
            _cmd.Transaction = _conn.BeginTransaction()

            Return True

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return False

    End Function
    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    ''' <summary>
    ''' ロールバック処理
    ''' </summary>
    ''' <returns>ロールバック成功時 true</returns>
    Private Function Rollback() As Boolean
        Try
            ' ロールバック実施
            _cmd.Transaction.Rollback()

            Return True



        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try

        Return False
    End Function
    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    ''' トランザクション終了処理
    ''' <returns>コミットおよびデータベース切断が成功した場合 True</returns>

    Private Function EndTransaction() As Boolean
        Try
            'コミット処理
            _cmd.Transaction.Commit()

            Close()

            Return True

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try

        Return False
    End Function
    'Private Sub DataProcessing(d_SQL As String)
    '    If Left(d_SQL, 6) = "SELECT" Then
    '        _DataTable = ExecuteQuery(d_SQL)
    '    Else
    '        ExecuteNonQuery(d_SQL)
    '    End If
    'End Sub

    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    'データベース操作（トランザクション有り）
    '複数SQL可（;で区切られていればOK）
    'Return＝成功時true
    Public Function ExecuteTransaction(e_SQL As String) As Boolean
        Dim result As Boolean = True
        'トランザクション処理がされていない場合には処理を抜ける
        If Not BeginTransaction() Then Return False

        Try
            'データ処理
            'DataProcessing(e_SQL)
            ExecuteNonQuery(e_SQL)

        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            result = False
            Return False
        End Try

        'トランザクションが終了していない場合Falseを返す
        If Not EndTransaction() Then result = False

        Return result

    End Function

    '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
    ''' データベース操作（トランザクションなし）
    ''' <returns>成功時 True</returns>
    Public Function ExecuteWithoutTransaction(e_SQL As String) As Boolean
        Dim result As Boolean = True

        If Open() Then
            ' データ処理
            'DataProcessing(e_SQL)
            _DataTable = Nothing
            _DataTable = ExecuteQuery(e_SQL)
            result = Close()
        End If

        Return result
    End Function
    Public ReadOnly Property DataTable
        Get
            Return _DataTable
        End Get
    End Property
End Class