Imports System.Data.SqlClient
Imports Oracle.DataAccess.Client
Imports System.IO
Module SQLConnectionMOD
    Public conn As SqlConnection
    Public Server As String
    Public DataBase1 As String
    Public UserName As String
    Public Password As String


    Public Function GetConnect() As Boolean
        Try
            conn = New SqlConnection("Data Source= traceability\flat; Initial Catalog= ; User Id = volodin; Password = volodin;")
            conn.Open()
            Return 1
        Catch ex As Exception
            MsgBox("Ошибка подключения к SQL сервер. " & ex.Message)
            Return 0
        End Try
    End Function


    Public Function ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, conn)
        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()

    End Function


    Public Sub LoadGridFromDB(ByVal Grid1 As DataGridView, cmd As String)
        GetConnect()
        Dim c As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        c = conn.CreateCommand
        c.CommandText = cmd

        da.SelectCommand = c
        da.Fill(ds, "Table1")

        Grid1.DataSource = ds
        Grid1.DataMember = "Table1"
        conn.Close()
    End Sub

    Public Sub RunCommand(cmd As String)
        Dim c As New SqlCommand
        c = conn.CreateCommand
        c.Connection = conn
        c.CommandType = CommandType.Text
        c.CommandText = cmd
        c.ExecuteNonQuery()

    End Sub

    Public Function SelectString(cmd As String) As String
        GetConnect()
        Dim c As New SqlCommand
        Dim r As SqlDataReader
        Dim k As String
        k = ""
        c = conn.CreateCommand
        c.CommandType = CommandType.Text
        c.CommandText = cmd

        r = c.ExecuteReader
        If r.Read Then
            k = r.Item(0)
            r.Close()
        End If

        Return k
        conn.Close()
    End Function

    Private Declare Function GetComputerName Lib "kernel32" Alias "GetComputerNameA" (ByVal lpBuffer As String, ByRef nSize As Long) As Long
    Public Function GetPCName() As String
        Dim strBuffer As String
        Dim strAns As Long
        strBuffer = Space(255)
        strAns = GetComputerName(strBuffer, 255)
        Return strBuffer
    End Function

    Public Function SelectFloat(cmd As String) As Double
        Dim c As New SqlCommand
        Dim r As SqlDataReader
        Dim k As Double

        c = conn.CreateCommand
        c.CommandType = CommandType.Text
        c.CommandText = cmd

        r = c.ExecuteReader
        If r.Read Then
            k = r.Item(0)
            r.Close()
        End If

        Return k
    End Function



    Public Function SelectBoolean(cmd As String) As Boolean
        Dim c As New SqlCommand
        Dim r As SqlDataReader
        Dim k As Boolean

        c = conn.CreateCommand
        c.CommandType = CommandType.Text
        c.CommandText = cmd

        r = c.ExecuteReader
        If r.Read Then
            k = r.Item(0)
            r.Close()
        End If

        Return k
    End Function

    Public Function addGridParam(N As String(), Grid As DataGridView)
        'если длинна массива больше чем количество элементов массива то добавляем столбцы
        While (N.Length > Grid.ColumnCount)
            'если колонок нехватает добавляем их пока их будет хватать
            Grid.Columns.Add("", "")
            'пока столбцов не станет нужное количество
        End While
        'создаем новую запись, вносим целиком массив
        Grid.Rows.Add(N)
    End Function


End Module

