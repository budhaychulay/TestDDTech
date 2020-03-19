Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data



Public Class Conn
    Dim ConnString As String
    Dim ServerHost As String
    Dim UserName As String
    Dim Password As String
    Dim MyComm As MySqlCommand
    Dim MyConn As MySqlConnection



    Public Function GetDataTable(ByVal query As String)
        ConnString = "DataSource=" + "127.0.0.1" + ";Username=" + "root" + ";password=" + "" + ";Database=rental"
        MyConn = New MySqlConnection(ConnString)
        MyConn.Open()

        Dim result As DataTable = New DataTable()

        Dim Command As MySqlCommand = New MySqlCommand(query, MyConn)
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(Command)
        Dim table As DataTable = New DataTable
        adapter.Fill(table)

        MyComm = New MySqlCommand(query, MyConn)
        Dim myReader As MySqlDataReader = MyComm.ExecuteReader()

        result.Load(myReader)
        MyConn.Close()
        Return result

    End Function

    Public Function Proses(ByVal Query As String)
        Dim result As DataTable = New DataTable()

        ConnString = "DataSource=" + "127.0.0.1" + ";Username=" + "root" + ";password=" + "" + ";Database=rental"
        MyConn = New MySqlConnection(ConnString)

        Dim myCommand As MySqlCommand = New MySqlCommand(Query)
        myCommand.Connection = MyConn
        MyConn.Open()
        myCommand.ExecuteNonQuery()
        myCommand.Connection.Close()
        'result.Load(myCommand)
        Return result
    End Function

End Class
