﻿
Imports System.Data.Odbc
Module Mod_connection



    Public Sub connectMe()
        If con.State = System.Data.ConnectionState.Open Then con.Close()
        constring = "driver=MYSQL ODBC 5.3 ANSI Driver;localhost;port=3306;uid ='root';pwd=;database=bbb"
        con.ConnectionString = constring
        con.Open()

    End Sub

End Module





