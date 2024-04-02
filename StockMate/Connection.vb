Imports MySql.Data.MySqlClient

Public Class Connection

    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader
    Public username As String
    Public password As String
    Public query As String
    Public found As Boolean
    Public connString As String

    Public Sub New()
        Me.connString = "server=4.tcp.eu.ngrok.io;port=13058;user=root;password='';database=stocksasadb;"
        Me.conn = New MySqlConnection(connString)
    End Sub

End Class
