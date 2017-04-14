'importing of libraries to be used in my system
Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Form1
    'declaration of a global variable for a connection string
    Dim connectionString As String = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"
  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'code used to make a decision to check wheather the system has been registered on the computer before
        If My.Computer.FileSystem.FileExists("D:\LOGI\verified.txt") Then
            'displaying of a message box with feedback to the user
            MessageBox.Show("welldone on registering your product !!")
            'dispaying the next form after the decision is successful
            Me.Hide()
            Form3.Show()
        Else
            'feedback displayed for an unsuccessful decision
            MsgBox("Please verify your package with the product key provided on purchase!")
            Form5.Show()
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
