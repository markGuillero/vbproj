Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports Oracle.ManagedDataAccess.Client
Public Class registration

    Private Sub Signupbtn_Click(sender As Object, e As EventArgs) Handles Signupbtn.Click


        Dim email As String = TextBox2.Text
        Dim emailres = Regex.IsMatch(email, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        If emailres = True Then
            database()
            Me.Hide()
            mainlogin.Show()
        Else
            MsgBox("Invalid email")
        End If
    End Sub

    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub database()
        Using conn As New OracleConnection("Data Source=127.0.0.1:1521/orcl;User Id=ADMIN;Password=admin;")
            Dim query As String = "INSERT INTO REGISTERED_USER VALUES (:name, :email, :pass)"
            Dim cmd As OracleCommand = New OracleCommand(query, conn)
            cmd.Parameters.Add(New OracleParameter("name", TextBox1.Text))
            cmd.Parameters.Add(New OracleParameter("email", TextBox2.Text))
            cmd.Parameters.Add(New OracleParameter("pass", TextBox3.Text))
            Try
                conn.Open()
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                MessageBox.Show("User Registed!")
                conn.Close()
            Catch ex As SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Message")
            End Try
        End Using
    End Sub
End Class