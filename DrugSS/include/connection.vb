Imports MySql.Data.MySqlClient

Module Connection
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=db_inventory;sslMode=none")
    End Function
    Public con As MySqlConnection = mysqldb()
End Module
