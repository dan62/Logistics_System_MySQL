'importing of libraries to be used in the system
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Drawing.Text





Public Class Form2

    'declaration of a global variable used for the connection string
    Dim connectionString As String = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (organisation_name.Text = "" Or country.Text = "" Or language.Text = "" Or currency.Text = "" Or purpose.Text = "" Or username.Text = "" Or password.Text = "") Then
            MessageBox.Show("please ensure that you have filled all fields in! ")
        Else
            'declaration of local variables
            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            Dim iReturn As Boolean
            Dim tun As String = ""

            'code to use command to insert data into the database
            Using SQLConnection As New MySqlConnection(connectionString)
                Using sqlCommand As New MySqlCommand()
                    mstream.Close()
                    With sqlCommand

                        'SQL statement to insert the data 
                        .CommandText = "INSERT INTO users_profile ( `organisation_name`, `country`, `language`, `currency`, `purpose`, `username`, `password`,`profile_pic`) values (@organisation_name,@country,@language,@currency,@purpose,@username,@password,@Image_data)"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text

                        'values inserted into the database using the SQL above
                        .Parameters.AddWithValue("@id", tun)
                        .Parameters.AddWithValue("@organisation_name", organisation_name.Text)
                        .Parameters.AddWithValue("@country", country.Text)
                        .Parameters.AddWithValue("@language", language.Text)
                        .Parameters.AddWithValue("@currency", currency.Text)
                        .Parameters.AddWithValue("@purpose", purpose.Text)
                        .Parameters.AddWithValue("@username", username.Text)
                        .Parameters.AddWithValue("@password", password.Text)
                        .Parameters.AddWithValue("@Image_data", arrImage)


                    End With
                    'try catch block to handle system exceptions that may be thrown during execution of the program
                    Try
                        SQLConnection.Open()
                        sqlCommand.ExecuteNonQuery()
                        iReturn = True
                    Catch ex As MySqlException

                        'message to display the computer generated error after converting it to a string
                        MsgBox(ex.Message.ToString)
                        iReturn = False
                    Finally
                        SQLConnection.Close()
                    End Try
                End Using
            End Using

            'closing the current form and displaying the next form
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'declaration of a local variable 
        Dim pfc As PrivateFontCollection = New PrivateFontCollection

        'adding of a custom font for all text feilds
        pfc.AddFontFile("Segoe UI Light.ttf")
        organisation_name.Font = New Font(pfc.Families(0), 16)
        country.Font = New Font(pfc.Families(0), 16)
        language.Font = New Font(pfc.Families(0), 16)
        currency.Font = New Font(pfc.Families(0), 16)
        purpose.Font = New Font(pfc.Families(0), 16)
        username.Font = New Font(pfc.Families(0), 16)
        password.Font = New Font(pfc.Families(0), 16)
    End Sub
End Class