'importing of vb references to be used in the project
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
Imports System.Drawing.Text
Imports System.Net.Mail
Public Class Form4


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This procedure will run as soon as the client is logged into his/her user profile
        'Try catch block used to catch system exceptions when the program is run
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to the online database
                conn.Open()
                'declaration of local variables
                'SQL query to extract data from the online database
                Dim command As New MySqlCommand("SELECT * FROM users_profile where username ='" & organisation_name.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision on loading of profile picture from the online database
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    profile_pic.Image = Image.FromStream(ms)

                End If
                'closing of the connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying a system exception if there are any at all
            MessageBox.Show(ex.Message)
        End Try

        'adjusting of graphics to make up a suitable graphical user interface for the process at hand
        hidden_agent_1.Hide()
        hidden_agent2.Hide()
        hidden_agent3.Hide()
        view_booking_cargo_label.Hide()
        view_booking_cargo.Hide()
        view_booking_contact.Hide()
        view_booking_contact_label.Hide()
        view_booking_date.Hide()
        view_booking_date_label.Hide()
        view_booking_decription.Hide()
        view_booking_description_label.Hide()
        view_booking_email.Hide()
        view_booking_email_label.Hide()
        view_booking_mass.Hide()
        view_booking_mass_label.Hide()
        view_booking_organisation.Hide()
        view_booking_organisation_label.Hide()

        contact_us_label.Hide()
        message.Hide()
        send_message_button.Hide()
        email1.Hide()

        contact_us_background_pic.Hide()
        profile_pic1.Hide()
        agent.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()
        home_button.Hide()
        Label17.Hide()

        home_button2.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()
        heading_label.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        PictureBox8.Hide()
        profile_pic2.Hide()
        PictureBox10.Hide()
        down_arrow.Hide()
        up_arrow.Hide()

        contact_person.Hide()
        email.Hide()
        goods_description.Hide()
        book_button.Hide()

        view_booking1.Hide()
        cancel_booking1.Hide()
        veiw_booking2.Hide()
        cancel_booking2.Hide()
        view_booking3.Hide()
        cancel_booking3.Hide()

        'assigning of one text box to another text box
        organisation_name.Text = Form3.TextBox1.Text

        'declaration of a local variable in which a custom font is stored
        Dim pfc As PrivateFontCollection = New PrivateFontCollection
        'adding of the custom font file to the project
        pfc.AddFontFile("Segoe UI Light.ttf")

        'assigning of font values to variables of the form 
        mass.Font = New Font(pfc.Families(0), 16)
        current_location.Font = New Font(pfc.Families(0), 16)
        price_range.Font = New Font(pfc.Families(0), 16)
        end_location.Font = New Font(pfc.Families(0), 16)
        date_to_go.Font = New Font(pfc.Families(0), 16)
        cargo.Font = New Font(pfc.Families(0), 16)
        contact_person.Font = New Font(pfc.Families(0), 16)
        email.Font = New Font(pfc.Families(0), 16)
        goods_description.Font = New Font(pfc.Families(0), 16)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'This procedure is run when the close icon at the corner of the screen is clicked on 
        'this code closes the form and program itself
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'This procedure is run when the minimise icon at the corner of the screen is is clicked on
        'this code minimises the program
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles search_button.Click
        'This procedure is run when the search button is clicked on 
        'adjusting of graphical user interface to suit the processes to come
        If (cargo.Text = "" Or mass.Text = "" Or current_location.Text = "" Or end_location.Text = "" Or price_range.Text = "" Or date_to_go.Text = "" Or price_range.Text = "") Then
            MessageBox.Show("please ensure that you have filled all fields in! ")
        Else
            profile_pic1.Hide()
            agent.Hide()
            view_booking_cargo_label.Hide()
            view_booking_cargo.Hide()
            view_booking_contact.Hide()
            view_booking_contact_label.Hide()
            view_booking_date.Hide()
            view_booking_date_label.Hide()
            view_booking_decription.Hide()
            view_booking_description_label.Hide()
            view_booking_email.Hide()
            view_booking_email_label.Hide()
            view_booking_mass.Hide()
            view_booking_mass_label.Hide()
            view_booking_organisation.Hide()
            view_booking_organisation_label.Hide()

            'assigning of text to a label 
            heading_label.Text = "These are the companies offering your requirements..."
            view_booking1.Hide()
            cancel_booking1.Hide()
            veiw_booking2.Hide()
            cancel_booking2.Hide()
            view_booking3.Hide()
            cancel_booking3.Hide()

            contact_us_label.Hide()
            message.Hide()
            send_message_button.Hide()
            email1.Hide()
            contact_us_background_pic.Hide()


            bookings_button.Hide()
            contact_us_button.Hide()
            make_payment_button.Hide()
            home_button2.Show()
            make_booking_button1.Show()
            make_booking_button2.Show()
            make_booking_button3.Show()
            heading_label.Show()
            Label3.Show()
            Label4.Show()
            Label5.Show()
            search_result1.Show()
            search_result2.Show()
            search_result3.Show()
            PictureBox8.Show()
            profile_pic2.Show()
            PictureBox10.Show()
            down_arrow.Show()
            up_arrow.Show()

            'declaration of local variables of which one of them is a connection string to the online database
            Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
            Dim cmd As New MySqlCommand
            Dim dz As New MySqlDataAdapter
            Dim ds, ds1 As New DataSet
            Dim a1 As Integer = 0
            Dim a2 As Integer = 1
            Dim a3 As Integer = 2

            dz = New MySqlDataAdapter(cmd)
            'assigning of blank values to labels
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""

            'try catch block to catch system exceptions that may occur
            Try
                'clearing of a data store
                ds.Clear()
                'opening of a connection to the online database
                c.Open()
                'SQL query to extract data from the online database
                cmd = New MySqlCommand("select organisation_name from offers WHERE cargo='" + cargo.Text + "'", c)
                dz = New MySqlDataAdapter(cmd)
                'filling of a datastore with data extracted from the online database
                dz.Fill(ds, "offers")
                Label3.Text = ds.Tables(0).Rows(a1).Item(0)
                Label4.Text = ds.Tables(0).Rows(a2).Item(0)
                Label5.Text = ds.Tables(0).Rows(a3).Item(0)

            Catch ex As Exception
                'message displaying any system exceptions that may have occured 
                MsgBox(ex.Message)
            Finally
                'closing of connection to the online database
                c.Close()
            End Try

            'decision making on how to adjust graphics according to data obtained from online database
            If Label3.Text = "" Then
                search_result1.Hide()
                PictureBox8.Hide()
                make_booking_button1.Hide()

            End If
            If Label4.Text = "" Then
                search_result2.Hide()
                profile_pic2.Hide()
                make_booking_button2.Hide()

            End If
            If Label5.Text = "" Then
                search_result3.Hide()
                PictureBox10.Hide()
                make_booking_button3.Hide()

            End If

            'try catch block to catch any system exceptions that may occur 
            Try
                'connection string to online database
                Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                    'opening of a connection to the online database
                    conn.Open()
                    'declaring of local variables 
                    'SQL query used to extract data from the online database
                    Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label3.Text & "'", conn)

                    Dim data As MySqlDataReader = command.ExecuteReader()
                    'decision on loading of a profile picture 
                    If data.HasRows = True Then
                        data.Read()
                        Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                        Dim ms As New MemoryStream(bt)
                        PictureBox8.Image = Image.FromStream(ms)

                    End If
                    'closing of connection to the online database
                    command.Dispose()
                    data.Close()
                    conn.Close()
                End Using
            Catch ex As Exception
                'message displaying system exception if an exception is encountered
                MessageBox.Show(ex.Message)
            End Try

            'try catch block used to catch system exceptions 
            Try
                'connection string to online database
                Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                    'opening of a connection to the online database
                    conn.Open()
                    'SQL query to extract data from the online database
                    Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label4.Text & "'", conn)
                    'declaration of a local variable
                    Dim data As MySqlDataReader = command.ExecuteReader()

                    'decision making on the loading of a profile photo
                    If data.HasRows = True Then
                        data.Read()
                        Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                        Dim ms As New MemoryStream(bt)

                        profile_pic2.Image = Image.FromStream(ms)
                    End If

                    'closing of the connection to the online database
                    command.Dispose()
                    data.Close()
                    conn.Close()
                End Using
            Catch ex As Exception
                'message displaying any system exceptions if there is any 
                MessageBox.Show(ex.Message)
            End Try

            'try catch block to catch system exceptions 
            Try
                'connection string to online database
                Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")

                    'establishing of  a connection to the online database
                    conn.Open()

                    'SQL query to extract information from the database
                    Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label5.Text & "'", conn)
                    'declaration of a local variable
                    Dim data As MySqlDataReader = command.ExecuteReader()

                    'decision making on the loading of a profile pic
                    If data.HasRows = True Then
                        data.Read()
                        Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                        Dim ms As New MemoryStream(bt)

                        PictureBox10.Image = Image.FromStream(ms)
                    End If

                    'closing of a connection to the online database
                    command.Dispose()
                    data.Close()
                    conn.Close()
                End Using
            Catch ex As Exception
                'message displaying the system exception if any is encountered
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'This procedure is run when the home button is clicked on 
        'adjusting of graphics to suit the home profile page
        view_booking1.Hide()
        cancel_booking1.Hide()
        veiw_booking2.Hide()
        cancel_booking2.Hide()
        view_booking3.Hide()
        cancel_booking3.Hide()
        home_button2.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()
        heading_label.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        PictureBox8.Hide()
        profile_pic2.Hide()
        PictureBox10.Hide()
        down_arrow.Hide()
        up_arrow.Hide()
        bookings_button.Show()
        contact_us_button.Show()
        make_payment_button.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles make_booking_button1.Click
        'This procedure is run when a user clicks on make booking button after a search has been done

        'adjusting of graphics to suit the processes to take place
        contact_us_background_pic.Show()
        profile_pic1.Show()
        agent.Show()
        Label9.Show()
        Label10.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()
        home_button.Show()
        heading_label.Show()
        Label17.Show()

        bookings_button.Hide()
        contact_us_button.Hide()
        make_payment_button.Hide()
        home_button2.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()

        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        PictureBox8.Hide()
        profile_pic2.Hide()
        PictureBox10.Hide()
        down_arrow.Hide()
        up_arrow.Hide()

        current_location.Hide()
        end_location.Hide()
        price_range.Hide()
        date_to_go.Hide()
        search_button.Hide()

        contact_person.Show()
        email.Show()
        goods_description.Show()
        book_button.Show()

        'assigning of one text box to another text box
        agent.Text = Label3.Text
        'try catch block used to catch system exceptions
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'openning of a connectio to the database
                conn.Open()
                'declaration of local variables 
                'SQL query to extract data from the online database 
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label3.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()

                'decision making on the loading of a profile picture 
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    profile_pic1.Image = Image.FromStream(ms)

                End If
                'closing of a connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to display a system exception if any is encountered 
            MessageBox.Show(ex.Message)
        End Try

        'declaration of local variables 
        Dim free_space As Integer
        Dim max As Integer
        Dim booked As Integer

        'connection sting to online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'SQL query to extract data from database
        Dim sql As String = "SELECT * FROM offers where organisation_name ='" & Label3.Text & "' and cargo='" & cargo.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data in labels
        Label10.DataBindings.Clear()
        Label13.DataBindings.Clear()
        Label17.DataBindings.Clear()
        Label18.DataBindings.Clear()

        'filling up of the datastore with data extracted from the database 
        da.Fill(DataSet1, "db")
        'assigning data from the datastore to variables
        Label10.DataBindings.Add("text", DataSet1, "db.booked")
        Label13.DataBindings.Add("text", DataSet1, "db.price_per_tonne")
        Label17.DataBindings.Add("text", DataSet1, "db.transport_type")
        Label18.DataBindings.Add("text", DataSet1, "db.maximum_bookings")

        'calculations to be done on bookings 
        max = Val(Label18.Text)
        booked = Val(Label10.Text)
        free_space = max - booked
        Label11.Text = free_space
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs)
        'This procedure is run when the make booking button is clicked after a search has taken place 

        'adjusting of graphics to suit the booking page where clients can see all information and make a booking
        contact_us_label.Hide()
        message.Hide()
        send_message_button.Hide()
        email1.Hide()

        Label17.Hide()
        contact_us_background_pic.Hide()
        profile_pic1.Hide()
        agent.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()
        home_button.Hide()
        heading_label.Hide()
        home_button2.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()
        heading_label.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        PictureBox8.Hide()
        profile_pic2.Hide()
        PictureBox10.Hide()
        down_arrow.Hide()
        up_arrow.Hide()
        bookings_button.Show()
        contact_us_button.Show()
        make_payment_button.Show()

        current_location.Show()
        end_location.Show()
        price_range.Show()
        date_to_go.Show()
        search_button.Show()

        contact_person.Hide()
        email.Hide()
        goods_description.Hide()
        book_button.Hide()
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles book_button.Click
        'This procedure is run when the user has typed in all the data to make a booking and has clicked book 
        If (cargo.Text = "" Or mass.Text = "" Or contact_person.Text = "" Or email.Text = "" Or goods_description.Text = "" Or date_to_go.Text = "") Then
            MessageBox.Show("please ensure that you have filled all fields in! ")
        Else
            'connection string to the online database
            Dim connectionString As String = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"
            'declaration of local variables 
            Dim mstream As New System.IO.MemoryStream()
            profile_pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            Dim iReturn As Boolean
            Dim tun As String = ""
            Using SQLConnection As New MySqlConnection(connectionString)
                Using sqlCommand As New MySqlCommand()
                    mstream.Close()
                    With sqlCommand
                        'SQL query used to insert booking data into the database
                        .CommandText = "INSERT INTO logisys1.bookings ( `cargo`, `mass`, `contact_person`, `email`, `goods_description`, `agent`, `organisation`, `profile_pic`) values (@cargo,@mass,@contact_person,@email,@goods_description,@agent,@organisation,@profile_pic)"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        'assigning of text fields with matching values in database
                        .Parameters.AddWithValue("@id", tun)
                        .Parameters.AddWithValue("@cargo", cargo.Text)
                        .Parameters.AddWithValue("@mass", mass.Text)
                        .Parameters.AddWithValue("@contact_person", contact_person.Text)
                        .Parameters.AddWithValue("@email", email.Text)
                        .Parameters.AddWithValue("@goods_description", goods_description.Text)
                        .Parameters.AddWithValue("@agent", agent.Text)
                        .Parameters.AddWithValue("@organisation", organisation_name.Text)
                        .Parameters.AddWithValue("@profile_pic", arrImage)


                    End With

                    'try catch block used to catch system exceptions 
                    Try
                        SQLConnection.Open()
                        sqlCommand.ExecuteNonQuery()
                        iReturn = True
                    Catch ex As MySqlException
                        MsgBox(ex.Message.ToString)
                        iReturn = False
                    Finally
                        'closing of the SQL connection 
                        SQLConnection.Close()

                        'message to be displayed on successful cretion of a booking 
                        MessageBox.Show("Your space has been successfully booked , we will get intouch with you as soon as possible")
                    End Try
                End Using
            End Using

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bookings_button.Click
        'This procedure is run when the bookings button is clicked 
        'adjusting of graphics to display the bookings made
        view_booking1.Show()
        cancel_booking1.Show()
        veiw_booking2.Show()
        cancel_booking2.Show()
        view_booking3.Show()
        cancel_booking3.Show()
        Label3.Show()
        PictureBox8.Show()
        search_result1.Show()
        home_button2.Show()
        bookings_button.Hide()
        contact_us_button.Hide()
        make_payment_button.Hide()
        heading_label.Show()

        Label4.Show()
        Label5.Show()
        search_result2.Show()
        search_result3.Show()
        profile_pic2.Show()
        PictureBox10.Show()

        'assigning of blank values to labels
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

        'assigning of text to a label 
        heading_label.Text = "Your bookings are listed below..."

        'declaration of local variables one of which consists of the connection string to the database
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 0
        Dim a2 As Integer = 1
        Dim a3 As Integer = 2

        dz = New MySqlDataAdapter(cmd)


        'assigning of blank values to labels
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

        'try catch block used to catch system exceptions 
        Try
            'clearing of  datastore
            ds.Clear()
            'opening of a connection to the database
            c.Open()
            'SQL query to extract data from the database 
            cmd = New MySqlCommand("select agent from bookings WHERE organisation='" + organisation_name.Text + "'", c)
            dz = New MySqlDataAdapter(cmd)

            'filling of a datastore with data fro the database
            dz.Fill(ds, "offers")
            Label3.Text = ds.Tables(0).Rows(a1).Item(0)
            Label4.Text = ds.Tables(0).Rows(a2).Item(0)
            Label5.Text = ds.Tables(0).Rows(a3).Item(0)

        Catch ex As Exception
            'message telling user that the bookings displayed were the only bookings found
            MsgBox("These are the bookings we found related to your account!")
        Finally
            'closing of a connection to the database
            c.Close()

        End Try

        'assigning of blank values to labels mensioned
        hidden_agent_1.Text = ""
        hidden_agent2.Text = ""
        hidden_agent3.Text = ""

        'declaration of local variables 
        'connection string to database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet

        'SQL query to extract data from the online database
        Dim sql As String = "SELECT * FROM bookings where agent ='" & Label3.Text & "' and organisation='" & organisation_name.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data in the hidden agent label
        hidden_agent_1.DataBindings.Clear()
        'fielling of a dataset with data from the database
        da.Fill(DataSet1, "db")
        hidden_agent_1.DataBindings.Add("text", DataSet1, "db.cargo")

        'assigning of a blank value to the label mensioned 
        hidden_agent2.Text = ""

        'declaration of a dataset
        Dim DataSet2 As New DataSet
        'SQL query to extract data from the online database
        Dim sql1 As String = "SELECT * FROM bookings where agent ='" & Label4.Text & "' and organisation='" & organisation_name.Text & "'"
        Dim da1 As New MySqlDataAdapter(sql1, thisConnection)

        'clearing of data in the mensioned label
        hidden_agent2.DataBindings.Clear()
        'filling of dataset with data from the database
        da1.Fill(DataSet2, "db")
        'assigning of data to label
        hidden_agent2.DataBindings.Add("text", DataSet2, "db.cargo")

        'declaration of dataset
        Dim DataSet3 As New DataSet

        'SQL query used to extract data from the database
        Dim sql2 As String = "SELECT * FROM bookings where agent ='" & Label5.Text & "' and organisation='" & organisation_name.Text & "'"
        Dim da2 As New MySqlDataAdapter(sql2, thisConnection)

        'clearing of data from a label 
        hidden_agent3.DataBindings.Clear()
        'filling of a dataset with data from the database
        da2.Fill(DataSet3, "db")
        'assigning of data from dataset to label mensioned
        hidden_agent3.DataBindings.Add("text", DataSet3, "db.cargo")

        'decision making to adjust graphics to suit results obtained
        If Label3.Text = "" Then
            search_result1.Hide()
            PictureBox8.Hide()
            view_booking1.Hide()
            cancel_booking1.Hide()
        End If
        If Label4.Text = "" Then
            search_result2.Hide()
            profile_pic2.Hide()
            veiw_booking2.Hide()
            cancel_booking2.Hide()
        End If
        If Label5.Text = "" Then
            search_result3.Hide()
            PictureBox10.Hide()
            view_booking3.Hide()
            cancel_booking3.Hide()
        End If

        'try catch block used to catch user exceptions 
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of a connection to the online database
                conn.Open()

                'SQL query to extract data from the database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label3.Text & "'", conn)
                'declaration of local variables used to extract the profile picture
                Dim data As MySqlDataReader = command.ExecuteReader()
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    PictureBox8.Image = Image.FromStream(ms)

                End If
                'closing of connection to database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to display any system exceptions encountered
            MessageBox.Show(ex.Message)
        End Try

        'try catch block to catch syste exceptions 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to online database
                conn.Open()
                'SQL query to extract data from the database 
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label4.Text & "'", conn)
                'declaration of local variable used to extract image from database
                Dim data As MySqlDataReader = command.ExecuteReader()
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    'assigning of extracted image to a picturebox on the form
                    profile_pic2.Image = Image.FromStream(ms)
                End If

                'closing of the connection to the database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to display any system exceptions that were encountered
            MessageBox.Show(ex.Message)
        End Try

        'try catch block used to catch system exceptions 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to the database 
                conn.Open()
                'SQL query used to extract data from the database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label5.Text & "'", conn)

                'declaration of local variables to be used to extracct an image from the database
                Dim data As MySqlDataReader = command.ExecuteReader()
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    'assigning of image extracted to a picture box on the form 
                    PictureBox10.Image = Image.FromStream(ms)
                End If
                'closing of a connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying any system exceptions encountered
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles logout_button.Click
        'This procedure is run when the user clicks on the logout button 
        'the client profile closes and the login form is displayed 
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub cancel_booking_Click(sender As Object, e As EventArgs) Handles cancel_booking1.Click
        'This procedure is run when the cancel booking button is clicked

        'try catch block used to catch system exceptions 
        Try
            'connection string to database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of a connection to online database 
                conn.Open()
                'SQL query to extract data from the online database
                Dim command As New MySqlCommand("DELETE  FROM bookings where organisation ='" & organisation_name.Text & "'and agent='" & Label3.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()

                'message telling the user that the booking has been cancelled
                MessageBox.Show("Booking has been cancelled , please note this cancelation will only be reflected on your profile at next login")

                'decision checking if data is present or not
                If data.HasRows = True Then
                    data.Read()

                End If
                'closing of connection to the database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying encountered system exceptions
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles make_booking_button2.Click
        'This procedure is run when the second make booking button is clicked

        'adjusting of graphics to suit the processes taking place
        contact_us_background_pic.Show()
        profile_pic1.Show()
        agent.Show()
        Label9.Show()
        Label10.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()
        home_button.Show()
        heading_label.Show()
        Label17.Show()

        bookings_button.Hide()
        contact_us_button.Hide()
        make_payment_button.Hide()
        home_button2.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()

        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        PictureBox8.Hide()
        profile_pic2.Hide()
        PictureBox10.Hide()
        down_arrow.Hide()
        up_arrow.Hide()

        current_location.Hide()
        end_location.Hide()
        price_range.Hide()
        date_to_go.Hide()
        search_button.Hide()

        contact_person.Show()
        email.Show()
        goods_description.Show()
        book_button.Show()

        'assigning of one textbox to another textbox
        agent.Text = Label4.Text

        'try catch block to catch any system exceptions 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to the online database
                conn.Open()

                'SQL query to extract data from the online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & agent.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()

                'decision made according on data recieved to display a profile pic
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    profile_pic1.Image = Image.FromStream(ms)

                End If
                'closing of a connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying any system exception that may have been encountered
            MessageBox.Show(ex.Message)
        End Try

        'connection string to online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet

        'declaration of local variables
        'SQL query used to extract data from the database
        Dim sql As String = "SELECT * FROM offers where organisation_name ='" & agent.Text & "' and cargo='" & cargo.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)
        Dim free_space As Integer
        Dim max As Integer
        Dim booked As Integer

        'clearing of data within the lables mensioned
        Label10.DataBindings.Clear()
        Label13.DataBindings.Clear()
        Label17.DataBindings.Clear()
        Label18.DataBindings.Clear()

        'filling of  a datast with data obtained from the online database
        da.Fill(DataSet1, "db")
        'assigning of data in the data set to labels within the system
        Label10.DataBindings.Add("text", DataSet1, "db.booked")
        Label13.DataBindings.Add("text", DataSet1, "db.price_per_tonne")
        Label17.DataBindings.Add("text", DataSet1, "db.transport_type")
        Label18.DataBindings.Add("text", DataSet1, "db.maximum_bookings")
        'calculations for the client profile
        max = Val(Label18.Text)
        booked = Val(Label10.Text)
        free_space = max - booked
        Label11.Text = free_space
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles make_booking_button3.Click
        'This procedure is run when the 3rd make booking button is clicked
        'adjusting of graphics to suit the make booking page
        contact_us_background_pic.Show()
        profile_pic1.Show()
        agent.Show()
        Label9.Show()
        Label10.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()
        home_button.Show()
        heading_label.Show()
        Label17.Show()

        bookings_button.Hide()
        contact_us_button.Hide()
        make_payment_button.Hide()
        home_button2.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()

        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        PictureBox8.Hide()
        profile_pic2.Hide()
        PictureBox10.Hide()
        down_arrow.Hide()
        up_arrow.Hide()

        current_location.Hide()
        end_location.Hide()
        price_range.Hide()
        date_to_go.Hide()
        search_button.Hide()

        contact_person.Show()
        email.Show()
        goods_description.Show()
        book_button.Show()

        'assiging of one label to another label
        agent.Text = Label5.Text

        'try catch block used to catch system exceptions 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of a connection to the online database
                conn.Open()
                'SQL query to extract data from the online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label5.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on wheather to display profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    PictureBox10.Image = Image.FromStream(ms)

                End If
                'closing of a connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying system exceptions if any are encountered
            MessageBox.Show(ex.Message)
        End Try

        'declaration of local variables
        'connection string to online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet

        'declaration of local variables
        'SQL query used to extract data from the online database
        Dim sql As String = "SELECT * FROM offers where organisation_name ='" & Label5.Text & "' and cargo='" & cargo.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)
        Dim free_space As Integer
        Dim max As Integer
        Dim booked As Integer

        'clearing of data stored in labels mensioned
        Label10.DataBindings.Clear()
        Label13.DataBindings.Clear()
        Label17.DataBindings.Clear()
        Label18.DataBindings.Clear()
        'filling of dataset with data extracted from the database
        da.Fill(DataSet1, "db")
        'assigning of data from dataset to labels within the system
        Label10.DataBindings.Add("text", DataSet1, "db.booked")
        Label13.DataBindings.Add("text", DataSet1, "db.price_per_tonne")
        Label17.DataBindings.Add("text", DataSet1, "db.transport_type")
        Label18.DataBindings.Add("text", DataSet1, "db.maximum_bookings")

        'calculations for a booking 
        max = Val(Label18.Text)
        booked = Val(Label10.Text)
        free_space = max - booked
        Label11.Text = free_space
    End Sub

    Private Sub cancel_booking2_Click(sender As Object, e As EventArgs) Handles cancel_booking2.Click
        'This procedure is run when the 2nd cancel booking button is clicked
        'try catch block used to catch system exceptions
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'openning of connection to database
                conn.Open()
                'decalaration of local variables
                'SQL query used to delete data from database
                Dim command As New MySqlCommand("DELETE  FROM bookings where organisation ='" & organisation_name.Text & "'and agent='" & Label4.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()
                'message displaying to the user that the booking has been cancelled
                MessageBox.Show("Booking has been cancelled , please note this cancelation will only be reflected on your profile at next login")

                'decision making to see wheather the booking has been deleted
                If data.HasRows = True Then
                    data.Read()
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying system exceptions if any were encountered
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cancel_booking3_Click(sender As Object, e As EventArgs) Handles cancel_booking3.Click
        'This procedure is run when the 3rd cancel booking button is clicked on 

        'try catch block to catch system exceptions
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'openning of connection to database
                conn.Open()

                'declaration of local variables
                'SQL query used to extract data from online database
                Dim command As New MySqlCommand("DELETE  FROM bookings where organisation ='" & organisation_name.Text & "'and agent='" & Label5.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()

                'message to tell user that the booking has been cancelled
                MessageBox.Show("Booking has been cancelled , please note this cancelation will only be reflected on your profile at next login")
                'decision making to see if data has been deleted from the online database
                If data.HasRows = True Then
                    data.Read()


                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying system exception if ny encountered
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles down_arrow.Click
        'This procedure is run when the down arrow is clicked on

        'declaration of local variables one of which consists of the connection string to the online database
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 3
        Dim a2 As Integer = 4
        Dim a3 As Integer = 5
        down_arrow.Hide()
        dz = New MySqlDataAdapter(cmd)

        'assigning of blank values to labels 
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

        'try catch block to catch system exceptions
        Try
            'clearing of a datastore
            ds.Clear()
            'opening of connection to online database
            c.Open()
            'SQL query to extract data from online database
            cmd = New MySqlCommand("select organisation_name from offers WHERE cargo='" + cargo.Text + "'", c)
            dz = New MySqlDataAdapter(cmd)

            'filling of labels with data from datastore 
            dz.Fill(ds, "offers")
            Label3.Text = ds.Tables(0).Rows(a1).Item(0)
            Label4.Text = ds.Tables(0).Rows(a2).Item(0)
            Label5.Text = ds.Tables(0).Rows(a3).Item(0)

        Catch ex As Exception
            'message to tell the user that the data that is displayed is what was found in the database
            MsgBox("This is what we found relating to your search!")
        Finally
            'closing of connection to the online databse
            c.Close()

        End Try
        'decision making and ajusting of graphics to suit the results obtained from the database
        If Label3.Text = "" Then
            search_result1.Hide()
            PictureBox8.Hide()
            make_booking_button1.Hide()

        End If
        If Label4.Text = "" Then
            search_result2.Hide()
            profile_pic2.Hide()
            make_booking_button2.Hide()

        End If
        If Label5.Text = "" Then
            search_result3.Hide()
            PictureBox10.Hide()
            make_booking_button3.Hide()

        End If

        'try catch block used to catch system exceptions 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of connection to online database 
                conn.Open()
                'declaration of local variables
                'SQL query used to extract data from online database 
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label3.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the loading of a profile picture 
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    PictureBox8.Image = Image.FromStream(ms)

                End If
                ''closing of the connection to the online databse
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying system exception if any encountered 
            MessageBox.Show(ex.Message)
        End Try

        'try catch block used to catch user exception 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing to online database
                conn.Open()
                'declaring of local va3riables
                'SQL query used to extract data from online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label4.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the loading of the profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    profile_pic2.Image = Image.FromStream(ms)
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying system exception if any encountered
            MessageBox.Show(ex.Message)
        End Try

        'try catch block used to catch system exceptions
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of connection to online database
                conn.Open()
                'declaration of local variables
                'SQL query used to extract data from online database 
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label5.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the loading of profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    PictureBox10.Image = Image.FromStream(ms)
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying any system exceptions if any are encountered
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles up_arrow.Click
        'This procedure is run when the up arrow is clicked on

        'declaration of local variables one of which is the connection string to the online database
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 0
        Dim a2 As Integer = 1
        Dim a3 As Integer = 2
        down_arrow.Hide()
        dz = New MySqlDataAdapter(cmd)

        'assigning of blank values to labels mensioned
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

        'try catch block used to catch system exceptions
        Try
            'clearing of data in the datastore
            ds.Clear()
            'opening of the connection to the online database
            c.Open()
            'SQL query used to extract data from the onine database
            cmd = New MySqlCommand("select organisation_name from offers WHERE cargo='" + cargo.Text + "'", c)
            dz = New MySqlDataAdapter(cmd)
            'filling of the datastore with data obtained from the online database
            dz.Fill(ds, "offers")
            Label3.Text = ds.Tables(0).Rows(a1).Item(0)
            Label4.Text = ds.Tables(0).Rows(a2).Item(0)
            Label5.Text = ds.Tables(0).Rows(a3).Item(0)

        Catch ex As Exception
            'message displaying system exception if any encountered
            MsgBox(ex.Message)
        Finally
            'closing of a connectionto online database
            c.Close()

        End Try

        'adjusting of graphics to suit data obtained from the online database
        If Label3.Text = "" Then
            search_result1.Hide()
            PictureBox8.Hide()
            make_booking_button1.Hide()

        End If
        If Label4.Text = "" Then
            search_result2.Hide()
            profile_pic2.Hide()
            make_booking_button2.Hide()

        End If
        If Label5.Text = "" Then
            search_result3.Hide()
            PictureBox10.Hide()
            make_booking_button3.Hide()

        End If

        'try catch block used to catch system exceptions 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to the online database 
                conn.Open()

                'declaring of local variables 
                'SQL query used to extract data from the online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label3.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()

                'decision making on the loading of a profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    PictureBox8.Image = Image.FromStream(ms)

                End If
                'closing of a connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying any system exceptions if at all any
            MessageBox.Show(ex.Message)
        End Try

        'try catch block used to catch system exceptions 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of connection to the online database
                conn.Open()
                'declaration of local variables
                'SQL query used to extract data from online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label4.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making used for the loading of a profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    profile_pic2.Image = Image.FromStream(ms)
                End If
                'closing of a connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying any system exceptions encountered 
            MessageBox.Show(ex.Message)
        End Try

        'try catch block used to catch system exceptions 
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to the online database
                conn.Open()
                'declaration of local variables 
                'SQL query used to extract data from the online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & Label5.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()

                'decision making on the loading of a profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    'assigning of data retreived from database to picturebox
                    PictureBox10.Image = Image.FromStream(ms)
                End If
                'closing of the connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message diplaying any syste exceptions encountered
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles contact_us_button.Click
        'This procedure is run when the contact us button is clicked

        'adjusting of graphics to create the contact us form 
        contact_us_label.Show()
        message.Show()
        send_message_button.Show()
        email1.Show()
        contact_us_background_pic.Show()
        home_button.Show()
    End Sub

    Private Sub send_message_button_Click(sender As Object, e As EventArgs) Handles send_message_button.Click
        'This procedure is run when the send message button is clicked on

        'try catch black used to catch system exceptions
        Try
            'declaration of local variabes where email information is to be kept 
            Dim dan As String = "danielgoncalves62@gmail.com"
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("danielgoncalves62@gmail.com", "237achirembaroadhatfield")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            'transmission of data to my system developers email address
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(email1.Text)
            e_mail.To.Add(dan)
            e_mail.Subject = "LOGI - from " & organisation_name.Text & " contact " & email1.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = message.Text
            Smtp_Server.Send(e_mail)
            'message to be displayed to user 
            MsgBox("Email Sent we will get intouch with you shortly!")

        Catch error_t As Exception
            'error message initcating to the user that the message has not been sent
            MsgBox("your internet connection or email is not correct , please retype the correct email and make sure you ae online")
        End Try
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles home_button2.Click
        'This procedure is run when the home button is clicked on

        'adjusting of graphics to suit the homepage layout
        agent.Hide()
        view_booking_cargo_label.Hide()
        view_booking_cargo.Hide()
        view_booking_contact.Hide()
        view_booking_contact_label.Hide()
        view_booking_date.Hide()
        view_booking_date_label.Hide()
        view_booking_decription.Hide()
        view_booking_description_label.Hide()
        view_booking_email.Hide()
        view_booking_email_label.Hide()
        view_booking_mass.Hide()
        view_booking_mass_label.Hide()
        view_booking_organisation.Hide()
        view_booking_organisation_label.Hide()

        heading_label.Hide()
        contact_us_label.Hide()

        email1.Hide()
        message.Hide()
        send_message_button.Hide()
        contact_us_background_pic.Hide()
        profile_pic1.Hide()
        profile_pic2.Hide()
        cancel_booking1.Hide()
        cancel_booking2.Hide()
        cancel_booking3.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()

        view_booking1.Hide()
        veiw_booking2.Hide()
        view_booking3.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()

        PictureBox10.Hide()
        PictureBox8.Hide()
        up_arrow.Hide()
        down_arrow.Hide()
        book_button.Hide()

        bookings_button.Show()
        contact_us_button.Show()
        make_payment_button.Show()
        home_button2.Hide()

    End Sub

    Private Sub home_button_Click(sender As Object, e As EventArgs) Handles home_button.Click
        'This procedure is run when the home button is clicked

        'adjusting of graphics to suit the homepage layout by hiding and displaying of graphic components
        view_booking_cargo_label.Hide()
        view_booking_cargo.Hide()
        view_booking_contact.Hide()
        view_booking_contact_label.Hide()
        view_booking_date.Hide()
        view_booking_date_label.Hide()
        view_booking_decription.Hide()
        view_booking_description_label.Hide()
        view_booking_email.Hide()
        view_booking_email_label.Hide()
        view_booking_mass.Hide()
        view_booking_mass_label.Hide()
        view_booking_organisation.Hide()
        view_booking_organisation_label.Hide()

        heading_label.Hide()
        contact_us_label.Hide()

        email1.Hide()
        message.Hide()
        send_message_button.Hide()
        contact_us_background_pic.Hide()
        profile_pic1.Hide()
        profile_pic2.Hide()
        cancel_booking1.Hide()
        cancel_booking2.Hide()
        cancel_booking3.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()

        agent.Hide()
        Label10.Hide()
        Label9.Hide()
        Label11.Hide()
        Label12.Hide()
        Label16.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label17.Hide()

        contact_person.Hide()
        email.Hide()
        goods_description.Hide()
        current_location.Show()
        end_location.Show()
        price_range.Show()
        date_to_go.Show()
        search_button.Show()


        view_booking1.Hide()
        veiw_booking2.Hide()
        view_booking3.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()

        PictureBox10.Hide()
        PictureBox8.Hide()
        up_arrow.Hide()
        down_arrow.Hide()
        book_button.Hide()

        bookings_button.Show()
        contact_us_button.Show()
        make_payment_button.Show()
        home_button.Hide()
    End Sub


    Private Sub view_booking1_Click(sender As Object, e As EventArgs) Handles view_booking1.Click
        'This procedure is run when the first veiw booking button is clicked

        'adjusting of graphics to suit the veiwing of a booking by hiding and displaying of graphics
        view_booking_cargo_label.Hide()
        view_booking_cargo.Hide()
        view_booking_contact.Hide()
        view_booking_contact_label.Hide()
        view_booking_date.Hide()
        view_booking_date_label.Hide()
        view_booking_decription.Hide()
        view_booking_description_label.Hide()
        view_booking_email.Hide()
        view_booking_email_label.Hide()
        view_booking_mass.Hide()
        view_booking_mass_label.Hide()
        view_booking_organisation.Hide()
        view_booking_organisation_label.Hide()

        heading_label.Hide()
        contact_us_label.Hide()

        email1.Hide()
        message.Hide()
        send_message_button.Hide()
        contact_us_background_pic.Show()
        profile_pic1.Hide()
        profile_pic2.Hide()
        cancel_booking1.Hide()
        cancel_booking2.Hide()
        cancel_booking3.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()

        view_booking1.Hide()
        veiw_booking2.Hide()
        view_booking3.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()

        PictureBox10.Hide()
        PictureBox8.Hide()
        up_arrow.Hide()
        down_arrow.Hide()
        book_button.Hide()

        bookings_button.Hide()
        contact_us_button.Hide()
        make_payment_button.Hide()
        home_button2.Show()

        view_booking_cargo.Show()
        view_booking_cargo_label.Show()
        view_booking_contact.Show()
        view_booking_contact_label.Show()
        view_booking_date.Show()
        view_booking_date_label.Show()
        view_booking_decription.Show()
        view_booking_description_label.Show()
        view_booking_email.Show()
        view_booking_email_label.Show()
        view_booking_mass.Show()
        view_booking_mass_label.Show()
        view_booking_organisation.Show()
        view_booking_organisation_label.Show()
        profile_pic1.Show()
        agent.Show()

        'assigning of one label to another label
        agent.Text = Label3.Text

        'try catch block used to catch system exceptions
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to the online database
                conn.Open()
                'declaration of local variables
                'SQL query used to extract data from online database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & agent.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the loading of a profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    'assigning of the image extracted from database to picturebox
                    profile_pic1.Image = Image.FromStream(ms)
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message advising user that the profile picture cannot be displayed
            MessageBox.Show("You have no profile photo or internet connection is bad!")
        End Try
        'declaration of local variables
        'connection string to online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet

        'SQL query used to extract data from the online database
        Dim sql As String = "SELECT * FROM bookings where organisation ='" & organisation_name.Text & "' and cargo='" & hidden_agent_1.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data in labels mensioned 
        view_booking_organisation.DataBindings.Clear()
        view_booking_cargo.DataBindings.Clear()
        view_booking_mass.DataBindings.Clear()
        view_booking_contact.DataBindings.Clear()
        view_booking_email.DataBindings.Clear()
        view_booking_decription.DataBindings.Clear()

        'filling of dataset with data extracted from online database
        da.Fill(DataSet1, "db")
        'assigning of data from dataset to labels within the system
        view_booking_organisation.DataBindings.Add("text", DataSet1, "db.organisation")
        view_booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        view_booking_mass.DataBindings.Add("text", DataSet1, "db.mass")
        view_booking_contact.DataBindings.Add("text", DataSet1, "db.contact_person")
        view_booking_email.DataBindings.Add("text", DataSet1, "db.email")
        view_booking_decription.DataBindings.Add("text", DataSet1, "db.goods_description")

    End Sub

    
    Private Sub veiw_booking2_Click(sender As Object, e As EventArgs) Handles veiw_booking2.Click
        'This procedure is run when the second view booking button is clicked on 

        'adjusting of graphics to suit the view bookings process
        view_booking_cargo_label.Hide()
        view_booking_cargo.Hide()
        view_booking_contact.Hide()
        view_booking_contact_label.Hide()
        view_booking_date.Hide()
        view_booking_date_label.Hide()
        view_booking_decription.Hide()
        view_booking_description_label.Hide()
        view_booking_email.Hide()
        view_booking_email_label.Hide()
        view_booking_mass.Hide()
        view_booking_mass_label.Hide()
        view_booking_organisation.Hide()
        view_booking_organisation_label.Hide()

        heading_label.Hide()
        contact_us_label.Hide()

        email1.Hide()
        message.Hide()
        send_message_button.Hide()
        contact_us_background_pic.Show()
        profile_pic1.Hide()
        profile_pic2.Hide()
        cancel_booking1.Hide()
        cancel_booking2.Hide()
        cancel_booking3.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()

        view_booking1.Hide()
        veiw_booking2.Hide()
        view_booking3.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()

        PictureBox10.Hide()
        PictureBox8.Hide()
        up_arrow.Hide()
        down_arrow.Hide()
        book_button.Hide()

        bookings_button.Hide()
        contact_us_button.Hide()
        make_payment_button.Hide()
        home_button2.Show()

        view_booking_cargo.Show()
        view_booking_cargo_label.Show()
        view_booking_contact.Show()
        view_booking_contact_label.Show()
        view_booking_date.Show()
        view_booking_date_label.Show()
        view_booking_decription.Show()
        view_booking_description_label.Show()
        view_booking_email.Show()
        view_booking_email_label.Show()
        view_booking_mass.Show()
        view_booking_mass_label.Show()
        view_booking_organisation.Show()
        view_booking_organisation_label.Show()
        profile_pic1.Show()
        agent.Show()

        'assigning of one label to another label
        agent.Text = Label4.Text

        'try catch block used to catch system exceptions
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of connection to the online database
                conn.Open()
                'declaration of local variables
                'SQL query used to extract data from the online database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & organisation_name.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision on displaying of profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    'assigning of image retreived from database to the picturebox on the form
                    profile_pic1.Image = Image.FromStream(ms)
                End If
                'closing of connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying the system exception if any is encountered
            MessageBox.Show("You have no profile photo or internet connection is bad!")
        End Try
        'declaration of local variables on of which includes the connection string to the database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'SQL query used to extract data from the online database
        Dim sql As String = "SELECT * FROM bookings where organisation ='" & organisation_name.Text & "' and cargo='" & hidden_agent2.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data within labels mensioned
        view_booking_organisation.DataBindings.Clear()
        view_booking_cargo.DataBindings.Clear()
        view_booking_mass.DataBindings.Clear()
        view_booking_contact.DataBindings.Clear()
        view_booking_email.DataBindings.Clear()
        view_booking_decription.DataBindings.Clear()

        'filling of the dataset with data from the online database
        da.Fill(DataSet1, "db")
        'assigning of data from dataset to label within the system
        view_booking_organisation.DataBindings.Add("text", DataSet1, "db.organisation")
        view_booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        view_booking_mass.DataBindings.Add("text", DataSet1, "db.mass")
        view_booking_contact.DataBindings.Add("text", DataSet1, "db.contact_person")
        view_booking_email.DataBindings.Add("text", DataSet1, "db.email")
        view_booking_decription.DataBindings.Add("text", DataSet1, "db.goods_description")

    End Sub



    Private Sub view_booking3_Click(sender As Object, e As EventArgs) Handles view_booking3.Click
        'This procedure is run when the third veiw bookings button is clicked 

        'adjusting of graphics to suit the veiw bookings page
        view_booking_cargo_label.Hide()
        view_booking_cargo.Hide()
        view_booking_contact.Hide()
        view_booking_contact_label.Hide()
        view_booking_date.Hide()
        view_booking_date_label.Hide()
        view_booking_decription.Hide()
        view_booking_description_label.Hide()
        view_booking_email.Hide()
        view_booking_email_label.Hide()
        view_booking_mass.Hide()
        view_booking_mass_label.Hide()
        view_booking_organisation.Hide()
        view_booking_organisation_label.Hide()

        heading_label.Hide()
        contact_us_label.Hide()

        email1.Hide()
        message.Hide()
        send_message_button.Hide()
        contact_us_background_pic.Show()
        profile_pic1.Hide()
        profile_pic2.Hide()
        cancel_booking1.Hide()
        cancel_booking2.Hide()
        cancel_booking3.Hide()
        make_booking_button1.Hide()
        make_booking_button2.Hide()
        make_booking_button3.Hide()

        view_booking1.Hide()
        veiw_booking2.Hide()
        view_booking3.Hide()
        search_result1.Hide()
        search_result2.Hide()
        search_result3.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()

        PictureBox10.Hide()
        PictureBox8.Hide()
        up_arrow.Hide()
        down_arrow.Hide()
        book_button.Hide()

        bookings_button.Hide()
        contact_us_button.Hide()
        make_payment_button.Hide()
        home_button2.Show()

        view_booking_cargo.Show()
        view_booking_cargo_label.Show()
        view_booking_contact.Show()
        view_booking_contact_label.Show()
        view_booking_date.Show()
        view_booking_date_label.Show()
        view_booking_decription.Show()
        view_booking_description_label.Show()
        view_booking_email.Show()
        view_booking_email_label.Show()
        view_booking_mass.Show()
        view_booking_mass_label.Show()
        view_booking_organisation.Show()
        view_booking_organisation_label.Show()
        profile_pic1.Show()
        agent.Show()
        'assigning of one textbox to another textbox
        agent.Text = Label5.Text

        'try catch block used to catch user exceptions
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to online database
                conn.Open()
                'declaration of local variables
                'SQL uery used to extract data from online database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & organisation_name.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the loading of a profile picture 
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    'assigning of image obtained from online database to picturebox within the form
                    profile_pic1.Image = Image.FromStream(ms)
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message telling the user that the profile picture cannot be loaded
            MessageBox.Show("You have no profile photo or internet connection is bad!")
        End Try
        'declaration of local variables one of whic includes connection string to online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'SQL query used to extract data from online database
        Dim sql As String = "SELECT * FROM bookings where organisation ='" & organisation_name.Text & "' and cargo='" & hidden_agent3.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data from labels mensioned
        view_booking_organisation.DataBindings.Clear()
        view_booking_cargo.DataBindings.Clear()
        view_booking_mass.DataBindings.Clear()
        view_booking_contact.DataBindings.Clear()
        view_booking_email.DataBindings.Clear()
        view_booking_decription.DataBindings.Clear()

        'filling of a dataset with data extracted from database
        da.Fill(DataSet1, "db")
        'assigning of data from data set to the labels indicated
        view_booking_organisation.DataBindings.Add("text", DataSet1, "db.organisation")
        view_booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        view_booking_mass.DataBindings.Add("text", DataSet1, "db.mass")
        view_booking_contact.DataBindings.Add("text", DataSet1, "db.contact_person")
        view_booking_email.DataBindings.Add("text", DataSet1, "db.email")
        view_booking_decription.DataBindings.Add("text", DataSet1, "db.goods_description")

    End Sub

    Private Sub mass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mass.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub

    Private Sub price_range_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price_range.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub

    Private Sub date_to_go_LostFocus(sender As Object, e As EventArgs) Handles date_to_go.LostFocus
        Dim test As Date
        If Date.TryParseExact(date_to_go.Text.ToString(), "yyyy-mm-dd", _
                              System.Globalization.CultureInfo.CurrentCulture, _
                              Globalization.DateTimeStyles.None, test) Then
         
        Else
            MessageBox.Show("Please enter the date in the correct format yyyy-mm-dd !")
            'TODO: not ok
        End If
    End Sub
End Class