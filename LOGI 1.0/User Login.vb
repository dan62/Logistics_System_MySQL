'importing of libraries to be used
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Drawing.Text

Public Class Form3
    'declaration of a global variable for a connection string
    Dim connectionString As String = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declaration of a local variable 
        Dim flag As Boolean = False

        'checking if the user has entered login credentials
        If (String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text)) Then

            'message to be displayed if loging credentials are not present
            MessageBox.Show("Credentials are missing!!")
            Exit Sub
        End If
        flag = CheckClient(TextBox1.Text, TextBox2.Text)


        If flag = True Then

            'message to be displayed if the login credentials matched those in the database
            MessageBox.Show("Login was succesful")

            'closing of login form and diplaying the next form
            Me.Hide()
            Form4.Show()
        Else

            'message to be displayed if the login credentials entered are incorrect 
            MessageBox.Show("Login was unsuccessful")
        End If
    End Sub
    Private Function CheckClient(ByVal u As String, ByVal p As String) As Boolean
        'declaration of local variables to a function named CheckClient
        Dim flag As Boolean = False
        Dim cnn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader

        'connecting to the database and retreiving credentials for comparison
        cnn.ConnectionString = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"
        cmd.CommandText = "select * from users_profile where username='" + u.Trim() + "' and password='" + p.Trim() + "'"
        cmd.Connection = cnn

        'opening of the connection to the database
        cnn.Open()
        reader = cmd.ExecuteReader()

        'checking if there is data retreived from the database
        If (reader.HasRows) Then
            flag = True

        End If

        'closing of the connection to the database
        cnn.Close()

        'returning of data from the function
        Return flag
    End Function

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'closing of the form initiated by clicking on the close button in the top right corner
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'minimising the form initiated by clicking on the minimise button in the top right corner
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'declaration of a local variable to store cus4tom font
        Dim pfc As PrivateFontCollection = New PrivateFontCollection

        'specifyig the font properties
        pfc.AddFontFile("Segoe UI Light.ttf")
        TextBox1.Font = New Font(pfc.Families(0), 16)
        TextBox2.Font = New Font(pfc.Families(0), 16)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'declaration of a variable 
        Dim flag As Boolean = False

        'searching for login credentials for comparison with user input
        If (String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text)) Then

            'message to be displayed if credentials are unavailable
            MessageBox.Show("Credentials are missing!!")
            Exit Sub
        End If
        flag = CheckSupplier(TextBox1.Text, TextBox2.Text)
        If flag = True Then

            'message to be displayed if the credentials are found on the database
            MessageBox.Show("Login was succesful")
            Me.Hide()
            Supplier_Profile.Show()
        Else

            'message to be displayed if the credentials are not found
            MessageBox.Show("Login was unsuccessful")
        End If
    End Sub
    Private Function CheckSupplier(ByVal u As String, ByVal p As String) As Boolean
        'declaration of local variables within a function
        Dim flag As Boolean = False
        Dim cnn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader

        'connecting to the database and retreiving the login credentials for the supplier
        cnn.ConnectionString = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"
        cmd.CommandText = "select * from users_profile where username='" + u.Trim() + "' and password='" + p.Trim() + "'"
        cmd.Connection = cnn

        'opening of the connection to the database
        cnn.Open()
        reader = cmd.ExecuteReader()

        'checking to see if there is any data retreived with user input
        If (reader.HasRows) Then
            flag = True

        End If

        'closing of the connection to the database
        cnn.Close()

        'returning of data from the function
        Return flag

        'declaring the end of the function
    End Function

End Class