Imports MySql.Data.MySqlClient

Module connection

    Public server As String = My.Settings.server
    Public db As String = My.Settings.database
    Public uid As String = My.Settings.username
    Public password As String = My.Settings.password
    Public port As String = My.Settings.port

    Public ReadOnly str As String = "Server=" & server & ";Userid=" & uid & ";Password=" & password & ";Port=" & port & ";Database=" & db & ";Convert Zero Datetime=True"

End Module
