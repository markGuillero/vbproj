Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports Oracle.ManagedDataAccess.Client
Public Class mainlogin
    Dim int1 As String
    Dim int2 As Integer
    Dim intotal As String

    Private Sub mainlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Signupbtn.Click
        registration.Show()
        Me.Hide()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        database()
    End Sub

    Private Sub database()
        Using conn As New OracleConnection("Data Source=127.0.0.1:1521/orcl;User Id=ADMIN;Password=admin;")
            conn.Open()
            Dim query As String = "SELECT * FROM REGISTERED_USER WHERE Username = :name and Password = :pass"
            Dim cmd As OracleCommand = New OracleCommand(query, conn)
            cmd.Parameters.Add(New OracleParameter("name", TextBox1.Text))
            cmd.Parameters.Add(New OracleParameter("pass", TextBox2.Text))
            Using reader As OracleDataReader = cmd.ExecuteReader
                If reader.HasRows Then
                    main.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid UserName or Password")
                End If
            End Using
        End Using

    End Sub
End Class