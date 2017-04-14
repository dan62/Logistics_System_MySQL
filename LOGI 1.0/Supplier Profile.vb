'importing of libraries for use in the system
Imports System.Drawing.Text
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
Imports System.Net.Mail

Public Class Supplier_Profile

    Private Sub Supplier_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Hide()
        'assigning of a text box to another text box from another form
        organisation_name.Text = Form3.TextBox1.Text

        'connection to database to retreive username  to display on the user profile

        'use of a try catch block to enable errors to be caught by the system 
        Try
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of a connection to the database
                conn.Open()
                Dim command As New MySqlCommand("SELECT * FROM users_profile where username ='" & organisation_name.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    user_profile_pic.Image = Image.FromStream(ms)

                End If
                command.Dispose()
                data.Close()

                'closing of connection to database
                conn.Close()
            End Using
        Catch ex As Exception

            'computer generated error message to be displayed
            MessageBox.Show(ex.Message)
        End Try

        'displaying and hidding of graphics so that the user interface is adjusted to the user home page
        booking_organisation.Hide()
        booking_cargo.Hide()
        booking_mass.Hide()
        booking_contact_person.Hide()
        booking_email.Hide()
        booking_bak2.Hide()
        booking_pro_pic.Hide()
        organisation_name_label.Hide()
        cargo_booking_label.Hide()
        mass_label.Hide()
        contact_person_label.Hide()
        email_label.Hide()


        booking_print1.Hide()
        booking_print2.Hide()
        booking_print3.Hide()
        booking_print4.Hide()
        booking_print5.Hide()
        booking_print6.Hide()
        booking_print7.Hide()
        booking_print8.Hide()
        booking_details1.Hide()
        booking_details2.Hide()
        booking_details3.Hide()
        booking_details4.Hide()
        booking_details5.Hide()
        booking_details6.Hide()
        booking_details7.Hide()
        booking_details8.Hide()
        booked_member1.Hide()
        booked_member2.Hide()
        booked_member3.Hide()
        booked_member4.Hide()
        booked_member5.Hide()
        booked_member6.Hide()
        booked_member7.Hide()
        booked_member8.Hide()


        up_arrow.Hide()
        down_arrow.Hide()
        contact_us_label.Hide()
        email1.Hide()
        message.Hide()
        send_message_button.Hide()
        bookings_bak_heading.Hide()
        View_bookings_back.Hide()
        home_button.Hide()
        heading.Hide()
        offer_organisation_name1.Hide()
        offer_profile_pic1.Hide()
        offer_result1.Hide()
        view_booking1.Hide()

        offer_organisation_name2.Hide()
        offer_profile_pic2.Hide()
        offer_result2.Hide()
        view_booking2.Hide()

        offer_organisation_name3.Hide()
        offer_profile_pic3.Hide()
        offer_result3.Hide()
        view_booking3.Hide()

        cargo_label1.Hide()
        cargo_label2.Hide()
        cargo_label3.Hide()

        cargo1.Hide()
        cargo2.Hide()
        cargo3.Hide()

        delete_button1.Hide()
        delete_button2.Hide()
        delete_button3.Hide()

        'declaring of a local variable where a custom font is stored
        Dim pfc As PrivateFontCollection = New PrivateFontCollection
        pfc.AddFontFile("Segoe UI Light.ttf")

        'font settings to enable the desired font is used in the textboxes on the profile
        cargo.Font = New Font(pfc.Families(0), 16)
        mass.Font = New Font(pfc.Families(0), 16)
        current_location.Font = New Font(pfc.Families(0), 16)
        end_location.Font = New Font(pfc.Families(0), 16)
        price_range.Font = New Font(pfc.Families(0), 16)
        date_to_go.Font = New Font(pfc.Families(0), 16)
        maximum_bookings.Font = New Font(pfc.Families(0), 16)
        price_per_tonne.Font = New Font(pfc.Families(0), 16)
        transport_type.Font = New Font(pfc.Families(0), 16)

        ' ending of the procedure
    End Sub

    Private Sub create_offer_button_Click(sender As Object, e As EventArgs) Handles create_offer_button.Click
        'this procedure is responsible for the creation of offers in the transport supplier profile 

        If (cargo.Text = "" Or mass.Text = "" Or current_location.Text = "" Or end_location.Text = "" Or price_range.Text = "" Or date_to_go.Text = "" Or maximum_bookings.Text = "" Or price_per_tonne.Text = "" Or transport_type.Text = "") Then
            MessageBox.Show("please ensure that you have filled all fields in! ")
        Else
            'adjustment of graphics to suit the button click by diplaying some grapphics and hiding others
            up_arrow.Hide()
            down_arrow.Hide()

            bookings_bak_heading.Hide()

            booking_organisation.Hide()
            booking_cargo.Hide()
            booking_mass.Hide()
            booking_contact_person.Hide()
            booking_email.Hide()
            booking_bak2.Hide()
            booking_pro_pic.Hide()
            organisation_name_label.Hide()
            cargo_booking_label.Hide()
            mass_label.Hide()
            contact_person_label.Hide()
            email_label.Hide()

            booking_print1.Hide()
            booking_print2.Hide()
            booking_print3.Hide()
            booking_print4.Hide()
            booking_print5.Hide()
            booking_print6.Hide()
            booking_print7.Hide()
            booking_print8.Hide()
            booking_details1.Hide()
            booking_details2.Hide()
            booking_details3.Hide()
            booking_details4.Hide()
            booking_details5.Hide()
            booking_details6.Hide()
            booking_details7.Hide()
            booking_details8.Hide()
            booked_member1.Hide()
            booked_member2.Hide()
            booked_member3.Hide()
            booked_member4.Hide()
            booked_member5.Hide()
            booked_member6.Hide()
            booked_member7.Hide()
            booked_member8.Hide()

            offer_organisation_name2.Hide()
            offer_profile_pic2.Hide()
            offer_result2.Hide()
            view_booking2.Hide()
            delete_button2.Hide()
            cargo_label2.Hide()
            cargo2.Hide()

            offer_organisation_name3.Hide()
            offer_profile_pic3.Hide()
            offer_result3.Hide()
            view_booking3.Hide()
            delete_button3.Hide()
            cargo_label3.Hide()
            cargo3.Hide()

            'declaration of local variables one of which is the database connection
            Dim connectionString As String = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"
            Dim mstream As New System.IO.MemoryStream()
            user_profile_pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            Dim iReturn As Boolean
            Dim tun As String = ""
            Dim zero As Integer
            Using SQLConnection As New MySqlConnection(connectionString)
                Using sqlCommand As New MySqlCommand()
                    mstream.Close()

                    'openning of the sql command
                    With sqlCommand

                        'query to insert the data from the form text feilds into the offers table 
                        .CommandText = "INSERT INTO logisys1.offers ( `cargo`, `mass`, `current_location`, `end_location`, `price_range`, `date_to_go`, `maximum_bookings`, `price_per_tonne`, `transport_type`, `organisation_name`, `profile_pic`, `booked`) values (@cargo,@mass,@current_location,@end_location,@price_range,@date_to_go,@maximum_bookings,@price_per_tonne,@transport_type,@organisation_name,@profile_pic,@booked)"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text

                        'text feilds assigned to their database values for input into the database
                        '.Parameters.AddWithValue("@id", tun)
                        .Parameters.AddWithValue("@cargo", cargo.Text)
                        .Parameters.AddWithValue("@mass", mass.Text)
                        .Parameters.AddWithValue("@current_location", current_location.Text)
                        .Parameters.AddWithValue("@end_location", end_location.Text)
                        .Parameters.AddWithValue("@price_range", price_range.Text)
                        .Parameters.AddWithValue("@date_to_go", date_to_go.Text)
                        .Parameters.AddWithValue("@maximum_bookings", maximum_bookings.Text)
                        .Parameters.AddWithValue("@price_per_tonne", price_per_tonne.Text)
                        .Parameters.AddWithValue("@transport_type", transport_type.Text)
                        .Parameters.AddWithValue("@organisation_name", organisation_name.Text)
                        .Parameters.AddWithValue("@profile_pic", arrImage)
                        .Parameters.AddWithValue("@booked", zero)


                    End With

                    'try catch block to catch system exceptions 
                    Try
                        SQLConnection.Open()
                        sqlCommand.ExecuteNonQuery()
                        iReturn = True
                    Catch ex As MySqlException
                        MsgBox(ex.Message.ToString)
                        iReturn = False
                    Finally

                        'closing of the connection to the database
                        SQLConnection.Close()

                        'message to be displayed when the data has been placed in the online database
                        MessageBox.Show("Your Offer has been submitted and is now online !")

                        'altering of graphics to suit the display of a submitted offer
                        my_offers_button.Hide()
                        contact_us_button.Hide()
                        make_payment_button.Hide()
                        home_button.Show()
                        heading.Show()

                        'declaration of some local variables to be used  as well as initialisation of variables
                        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                        Dim cmd As New MySqlCommand
                        Dim dz As New MySqlDataAdapter
                        Dim ds, ds1 As New DataSet
                        Dim a1 As Integer = 0
                        Dim a2 As Integer = 1
                        Dim a3 As Integer = 2

                        dz = New MySqlDataAdapter(cmd)

                        'assigning of a blank value to a textbox
                        offer_organisation_name1.Text = ""



                        'try catch block to pick up system errors 
                        Try
                            ds.Clear()
                            c.Open()

                            'query to retreive data from the database about the latest offer submitted 
                            cmd = New MySqlCommand("select organisation_name from offers WHERE organisation_name='" + organisation_name.Text + "'", c)
                            dz = New MySqlDataAdapter(cmd)
                            dz.Fill(ds, "offers")
                            offer_organisation_name1.Text = ds.Tables(0).Rows(a1).Item(0)


                        Catch ex As Exception

                            'computer generated error message displayed
                            MsgBox(ex.Message)
                        End Try

                        Try
                            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")

                                'openning of a database connection
                                conn.Open()
                                'declaration of local variables one of which is the cnnection string to the database
                                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & organisation_name.Text & "'", conn)
                                Dim data As MySqlDataReader = command.ExecuteReader()

                                'desision to what to do after data is found in the database
                                If data.HasRows = True Then
                                    data.Read()
                                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                                    Dim ms As New MemoryStream(bt)
                                    offer_profile_pic1.Image = Image.FromStream(ms)

                                End If
                                command.Dispose()
                                data.Close()

                                'closing of the connection to the database
                                conn.Close()
                            End Using
                        Catch ex As Exception

                            'computer generated error message to be displayed
                            MessageBox.Show(ex.Message)
                        End Try


                        'adjusting of graphics by hiding and displaying graphics to form the user interface once an offer is submitted
                        offer_organisation_name1.Show()
                        offer_profile_pic1.Show()
                        cargo_label1.Show()
                        cargo1.Show()
                        offer_result1.Show()
                        view_booking1.Show()

                        contact_us_label.Hide()
                        email1.Hide()
                        send_message_button.Hide()
                        message.Hide()
                        View_bookings_back.Hide()

                        'assigning of data to textboxes
                        heading.Text = "Here is your recently submitted offer..."
                        cargo1.Text = cargo.Text
                    End Try
                End Using
            End Using
        End If

    End Sub

    Private Sub logout_button_Click(sender As Object, e As EventArgs) Handles logout_button.Click
        'closing of current form and opening of the login form for the logout process
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub home_button_Click(sender As Object, e As EventArgs) Handles home_button.Click
        'all processes under this procedure are what occurs when the home button is clicked

        'adjusting of graphics by hiding and displaying graphics to make up the user interface
        up_arrow.Hide()
        down_arrow.Hide()

        organisation_name_label.Hide()
        booking_organisation.Hide()
        booking_cargo.Hide()
        booking_mass.Hide()
        booking_contact_person.Hide()
        booking_email.Hide()
        booking_bak2.Hide()
        booking_pro_pic.Hide()
        cargo_booking_label.Hide()
        mass_label.Hide()
        contact_person_label.Hide()
        email_label.Hide()

        booking_print1.Hide()
        booking_print2.Hide()
        booking_print3.Hide()
        booking_print4.Hide()
        booking_print5.Hide()
        booking_print6.Hide()
        booking_print7.Hide()
        booking_print8.Hide()
        booking_details1.Hide()
        booking_details2.Hide()
        booking_details3.Hide()
        booking_details4.Hide()
        booking_details5.Hide()
        booking_details6.Hide()
        booking_details7.Hide()
        booking_details8.Hide()
        booked_member1.Hide()
        booked_member2.Hide()
        booked_member3.Hide()
        booked_member4.Hide()
        booked_member5.Hide()
        booked_member6.Hide()
        booked_member7.Hide()
        booked_member8.Hide()

        contact_us_label.Hide()
        email1.Hide()
        send_message_button.Hide()
        message.Hide()

        offer_organisation_name1.Hide()
        offer_profile_pic1.Hide()
        offer_result1.Hide()
        view_booking1.Hide()

        home_button.Hide()
        heading.Hide()
        my_offers_button.Show()
        contact_us_button.Show()
        make_payment_button.Show()

       

        offer_organisation_name2.Hide()
        offer_profile_pic2.Hide()
        offer_result2.Hide()
        view_booking2.Hide()

        offer_organisation_name3.Hide()
        offer_profile_pic3.Hide()
        offer_result3.Hide()
        view_booking3.Hide()

        cargo_label1.Hide()
        cargo_label2.Hide()
        cargo_label3.Hide()

        cargo1.Hide()
        cargo2.Hide()
        cargo3.Hide()

        delete_button1.Hide()
        delete_button2.Hide()
        delete_button3.Hide()

        View_bookings_back.Hide()
        bookings_bak_heading.Hide()
    End Sub

    Private Sub my_offers_button_Click(sender As Object, e As EventArgs) Handles my_offers_button.Click
        'all proccesses under this procedure is what happens when the user request to veiw his/her offers

        'adjusting of graphics to make up the graphical user interface by hiding and displaying of graphics
        my_offers_button.Hide()
        contact_us_button.Hide()
        make_payment_button.Hide()

        'assigning of data
        heading.Text = "These are your current offers..."

        heading.Show()
        home_button.Show()
        offer_organisation_name1.Show()
        offer_profile_pic1.Show()
        offer_result1.Show()
        view_booking1.Show()

        offer_organisation_name2.Show()
        offer_profile_pic2.Show()
        offer_result2.Show()
        view_booking2.Show()

        offer_organisation_name3.Show()
        offer_profile_pic3.Show()
        offer_result3.Show()
        view_booking3.Show()

        cargo_label1.Show()
        cargo_label2.Show()
        cargo_label3.Show()

        cargo1.Show()
        cargo2.Show()
        cargo3.Show()

        delete_button1.Show()
        delete_button2.Show()
        delete_button3.Show()

        up_arrow.Show()
        down_arrow.Show()

        'declaration of local variables to be used one of which is the connection string to the database
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 0
        Dim a2 As Integer = 1
        Dim a3 As Integer = 2

        dz = New MySqlDataAdapter(cmd)

        'assigning of blank values to labels 
        offer_organisation_name1.Text = ""
        offer_organisation_name2.Text = ""
        offer_organisation_name3.Text = ""

        cargo1.Text = ""
        cargo2.Text = ""
        cargo3.Text = ""

        'use of a try catch block to allow the system to pick up errors
        Try
            ds.Clear()

            'oppening of a connection to the database 
            c.Open()

            'SQL query which is to retreive data about offers related to the user profile
            cmd = New MySqlCommand("select organisation_name from offers WHERE organisation_name='" + organisation_name.Text + "'", c)
            dz = New MySqlDataAdapter(cmd)
            dz.Fill(ds, "offers")
            offer_organisation_name1.Text = ds.Tables(0).Rows(a1).Item(0)
            offer_organisation_name2.Text = ds.Tables(0).Rows(a2).Item(0)
            offer_organisation_name3.Text = ds.Tables(0).Rows(a3).Item(0)

            

        Catch ex As Exception
            'system generated error message 
            MsgBox("These are your current offers!")
        Finally
            'closing of the connection to the database
            c.Close()
        End Try

        Try
            ds1.Clear()

            'openning of a connection to the database
            c.Open()

            'connection string to the database
            cmd = New MySqlCommand("select cargo from offers WHERE organisation_name='" + offer_organisation_name1.Text + "'", c)
            dz = New MySqlDataAdapter(cmd)
            dz.Fill(ds1, "offers")

            'this fills the labels with data about the cargo of the offers created
            cargo1.Text = ds1.Tables(0).Rows(a1).Item(0)
            cargo2.Text = ds1.Tables(0).Rows(a2).Item(0)
            cargo3.Text = ds1.Tables(0).Rows(a3).Item(0)


            'this catches the errors of the system
        Catch ex As Exception

        Finally
            'this closes the connection to the database 
            c.Close()
        End Try

        'decisions in the form of if statements to set the graphic user interface according to the data retreived
        If offer_organisation_name1.Text = "" Then
            offer_result1.Hide()
            offer_profile_pic1.Hide()
            view_booking1.Hide()
            cargo_label1.Hide()
            cargo1.Hide()
            view_booking1.Hide()
            delete_button1.Hide()

        End If
        If offer_organisation_name2.Text = "" Then
            offer_result2.Hide()
            offer_profile_pic2.Hide()
            view_booking2.Hide()
            cargo_label2.Hide()
            cargo2.Hide()
            view_booking2.Hide()
            delete_button2.Hide()

        End If
        If offer_organisation_name3.Text = "" Then
            offer_result3.Hide()
            offer_profile_pic3.Hide()
            view_booking3.Hide()
            cargo_label3.Hide()
            cargo3.Hide()
            view_booking3.Hide()
            delete_button3.Hide()

        End If

        'try catch block to handle system generated errors in the system 
        Try

            'database connection established to retreive data 
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                conn.Open()

                'diplaying the 1st result from the offers table
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name1.Text & "'", conn)

                'retreiving of the user profile picture
                Dim data As MySqlDataReader = command.ExecuteReader()
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    offer_profile_pic1.Image = Image.FromStream(ms)

                End If
                command.Dispose()
                data.Close()

                'closing of the connection to the database
                conn.Close()
            End Using
        Catch ex As Exception

            'computer generated system error
            MessageBox.Show(ex.Message)
        End Try

        'use of a try catch block to catch system errors
        Try

            'establishing of connection to the database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'oppening a connection to the database
                conn.Open()

                'retreiving of the 2nd offer in the offers table 
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name2.Text & "'", conn)

                'retreiving of users profile picture
                Dim data As MySqlDataReader = command.ExecuteReader()
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    offer_profile_pic2.Image = Image.FromStream(ms)
                End If
                command.Dispose()
                data.Close()

                'closing of connection to the database
                conn.Close()
            End Using
        Catch ex As Exception

            'system generated message displayed
            MessageBox.Show(ex.Message)
        End Try

        'try catch block to catch system errors
        Try

            'establishing of connection to the database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")

                'opening of the connection to the database
                conn.Open()

                'retreiving the 3rd result from the offers table 
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name3.Text & "'", conn)


                'retreiving of users profile picture
                Dim data As MySqlDataReader = command.ExecuteReader()
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    offer_profile_pic3.Image = Image.FromStream(ms)
                End If
                command.Dispose()
                data.Close()

                'closing of connection to the database
                conn.Close()
            End Using
        Catch ex As Exception

            'displaying of computer generated error
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub view_booking1_Click(sender As Object, e As EventArgs) Handles view_booking1.Click
        'this procedure is what occurs when the user clicks on the view bookings button 

        'adjusting of graphics to make up the graphical user interface according to the request from user
        up_arrow.Hide()
        down_arrow.Hide()

        offer_organisation_name1.Hide()
        offer_profile_pic1.Hide()
        offer_result1.Hide()
        cargo_label1.Hide()
        cargo1.Hide()
        delete_button1.Hide()
        view_booking1.Hide()

        offer_organisation_name2.Hide()
        offer_profile_pic2.Hide()
        offer_result2.Hide()
        cargo_label2.Hide()
        cargo2.Hide()
        delete_button2.Hide()
        view_booking2.Hide()

        offer_organisation_name3.Hide()
        offer_profile_pic3.Hide()
        offer_result3.Hide()
        cargo_label3.Hide()
        cargo3.Hide()
        delete_button3.Hide()
        view_booking3.Hide()

        View_bookings_back.Show()
        bookings_bak_heading.Show()

        booking_print1.Show()
        booking_print2.Show()
        booking_print3.Show()
        booking_print4.Show()
        booking_print5.Show()
        booking_print6.Show()
        booking_print7.Show()
        booking_print8.Show()
        booking_details1.Show()
        booking_details2.Show()
        booking_details3.Show()
        booking_details4.Show()
        booking_details5.Show()
        booking_details6.Show()
        booking_details7.Show()
        booking_details8.Show()
        booked_member1.Show()
        booked_member2.Show()
        booked_member3.Show()
        booked_member4.Show()
        booked_member5.Show()
        booked_member6.Show()
        booked_member7.Show()
        booked_member8.Show()

        'assigning of one textbox to another
        heading.Text = cargo1.Text


        'declaration of local variables of which one is to be used as a connection string 
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 0
        Dim a2 As Integer = 1
        Dim a3 As Integer = 2
        Dim a4 As Integer = 3
        Dim a5 As Integer = 4
        Dim a6 As Integer = 5
        Dim a7 As Integer = 6
        Dim a8 As Integer = 7


        dz = New MySqlDataAdapter(cmd)

        'adjusting of graphical user interafce to suit the request
        up_arrow.Hide()
        down_arrow.Hide()

        offer_organisation_name1.Hide()
        offer_profile_pic1.Hide()
        offer_result1.Hide()
        cargo_label1.Hide()
        cargo1.Hide()
        delete_button1.Hide()
        view_booking1.Hide()

        offer_organisation_name2.Hide()
        offer_profile_pic2.Hide()
        offer_result2.Hide()
        cargo_label2.Hide()
        cargo2.Hide()
        delete_button2.Hide()
        view_booking2.Hide()

        offer_organisation_name3.Hide()
        offer_profile_pic3.Hide()
        offer_result3.Hide()
        cargo_label3.Hide()
        cargo3.Hide()
        delete_button3.Hide()
        view_booking3.Hide()

        View_bookings_back.Show()
        bookings_bak_heading.Show()

        'assigning of blank values to the textboxes listed below
        booked_member1.Text = ""
        booked_member2.Text = ""
        booked_member3.Text = ""
        booked_member4.Text = ""
        booked_member5.Text = ""
        booked_member6.Text = ""
        booked_member7.Text = ""
        booked_member8.Text = ""

        'try catch block to catch system errors 
        Try
            ds.Clear()

            'opening of a database connection 
            c.Open()

            'retreival of organisation from bookings 
            cmd = New MySqlCommand("select organisation from bookings WHERE agent='" & organisation_name.Text & "'and cargo='" & cargo1.Text & "'", c)

            dz = New MySqlDataAdapter(cmd)
            dz.Fill(ds, "bookings")

            'assigning of data captured to datastores
            booked_member1.Text = ds.Tables(0).Rows(a1).Item(0)
            booked_member2.Text = ds.Tables(0).Rows(a2).Item(0)
            booked_member3.Text = ds.Tables(0).Rows(a3).Item(0)
            booked_member4.Text = ds.Tables(0).Rows(a4).Item(0)
            booked_member5.Text = ds.Tables(0).Rows(a5).Item(0)
            booked_member6.Text = ds.Tables(0).Rows(a6).Item(0)
            booked_member7.Text = ds.Tables(0).Rows(a7).Item(0)
            booked_member8.Text = ds.Tables(0).Rows(a8).Item(0)

        Catch ex As Exception

            'displaying of a system generated message 
            MsgBox(ex.Message)
        Finally

            'closing of the database connection 
            c.Close()
        End Try

        'adjusting of graphics to make up a suitable graphhical user interface to display bookings 
        If booked_member1.Text = "" Then
            booking_details1.Hide()
            booking_print1.Hide()
        End If
        If booked_member2.Text = "" Then
            booking_details2.Hide()
            booking_print2.Hide()
        End If
        If booked_member3.Text = "" Then
            booking_details3.Hide()
            booking_print3.Hide()
        End If
        If booked_member4.Text = "" Then
            booking_details4.Hide()
            booking_print4.Hide()
        End If
        If booked_member5.Text = "" Then
            booking_details5.Hide()
            booking_print5.Hide()
        End If
        If booked_member6.Text = "" Then
            booking_details6.Hide()
            booking_print6.Hide()
        End If
        If booked_member7.Text = "" Then
            booking_details7.Hide()
            booking_print7.Hide()
        End If
        If booked_member8.Text = "" Then
            booking_details8.Hide()
            booking_print8.Hide()
        End If
    End Sub


    Private Sub view_booking2_Click(sender As Object, e As EventArgs) Handles view_booking2.Click
        'this procedure is is wht happens when the user clicks on the second veiw bookings buton it performs the same functions as the first view booking button

        'adjustingg of graphics to suit the processes being undertaken
        up_arrow.Hide()
        down_arrow.Hide()

        offer_organisation_name1.Hide()
        offer_profile_pic1.Hide()
        offer_result1.Hide()
        cargo_label1.Hide()
        cargo1.Hide()
        delete_button1.Hide()
        view_booking1.Hide()

        offer_organisation_name2.Hide()
        offer_profile_pic2.Hide()
        offer_result2.Hide()
        cargo_label2.Hide()
        cargo2.Hide()
        delete_button2.Hide()
        view_booking2.Hide()

        offer_organisation_name3.Hide()
        offer_profile_pic3.Hide()
        offer_result3.Hide()
        cargo_label3.Hide()
        cargo3.Hide()
        delete_button3.Hide()
        view_booking3.Hide()

        View_bookings_back.Show()
        bookings_bak_heading.Show()

        booking_print1.Show()
        booking_print2.Show()
        booking_print3.Show()
        booking_print4.Show()
        booking_print5.Show()
        booking_print6.Show()
        booking_print7.Show()
        booking_print8.Show()
        booking_details1.Show()
        booking_details2.Show()
        booking_details3.Show()
        booking_details4.Show()
        booking_details5.Show()
        booking_details6.Show()
        booking_details7.Show()
        booking_details8.Show()
        booked_member1.Show()
        booked_member2.Show()
        booked_member3.Show()
        booked_member4.Show()
        booked_member5.Show()
        booked_member6.Show()
        booked_member7.Show()
        booked_member8.Show()

        'initialising a textbox to a value of another text box
        heading.Text = cargo2.Text

        'declaration of local variables one of which consists of a connection string
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 0
        Dim a2 As Integer = 1
        Dim a3 As Integer = 2
        Dim a4 As Integer = 3
        Dim a5 As Integer = 4
        Dim a6 As Integer = 5
        Dim a7 As Integer = 6
        Dim a8 As Integer = 7

        'assigning of a command to a local variable
        dz = New MySqlDataAdapter(cmd)

        'adjusting of graphics to suit the results to be obtained from the database
        up_arrow.Hide()
        down_arrow.Hide()

        offer_organisation_name1.Hide()
        offer_profile_pic1.Hide()
        offer_result1.Hide()
        cargo_label1.Hide()
        cargo1.Hide()
        delete_button1.Hide()
        view_booking1.Hide()

        offer_organisation_name2.Hide()
        offer_profile_pic2.Hide()
        offer_result2.Hide()
        cargo_label2.Hide()
        cargo2.Hide()
        delete_button2.Hide()
        view_booking2.Hide()

        offer_organisation_name3.Hide()
        offer_profile_pic3.Hide()
        offer_result3.Hide()
        cargo_label3.Hide()
        cargo3.Hide()
        delete_button3.Hide()
        view_booking3.Hide()

        View_bookings_back.Show()
        bookings_bak_heading.Show()

        'assigning of blank values to text boxes 
        booked_member1.Text = ""
        booked_member2.Text = ""
        booked_member3.Text = ""
        booked_member4.Text = ""
        booked_member5.Text = ""
        booked_member6.Text = ""
        booked_member7.Text = ""
        booked_member8.Text = ""

        'try catch block inorder to ensure that the program does not crash if it runs into an error instead it will catch the exception aand display it
        Try

            'clearing of a data store
            ds.Clear()

            'opening of a database connection
            c.Open()

            'command with an SQL statement query to the database
            cmd = New MySqlCommand("select organisation from bookings WHERE agent='" & organisation_name.Text & "'and cargo='" & cargo2.Text & "'", c)

            dz = New MySqlDataAdapter(cmd)

            'inserting of data into a datastore 
            dz.Fill(ds, "bookings")
            booked_member1.Text = ds.Tables(0).Rows(a1).Item(0)
            booked_member2.Text = ds.Tables(0).Rows(a2).Item(0)
            booked_member3.Text = ds.Tables(0).Rows(a3).Item(0)
            booked_member4.Text = ds.Tables(0).Rows(a4).Item(0)
            booked_member5.Text = ds.Tables(0).Rows(a5).Item(0)
            booked_member6.Text = ds.Tables(0).Rows(a6).Item(0)
            booked_member7.Text = ds.Tables(0).Rows(a7).Item(0)
            booked_member8.Text = ds.Tables(0).Rows(a8).Item(0)

        Catch ex As Exception
            'displaying of a message if the system encounteres an error at this point 
            MsgBox(ex.Message)
        Finally
            'closing of the connection to the database 
            c.Close()
        End Try
        'adjusting of graphics to suit the results obtained from the database
        If booked_member1.Text = "" Then
            booking_details1.Hide()
            booking_print1.Hide()
        End If
        If booked_member2.Text = "" Then
            booking_details2.Hide()
            booking_print2.Hide()
        End If
        If booked_member3.Text = "" Then
            booking_details3.Hide()
            booking_print3.Hide()
        End If
        If booked_member4.Text = "" Then
            booking_details4.Hide()
            booking_print4.Hide()
        End If
        If booked_member5.Text = "" Then
            booking_details5.Hide()
            booking_print5.Hide()
        End If
        If booked_member6.Text = "" Then
            booking_details6.Hide()
            booking_print6.Hide()
        End If
        If booked_member7.Text = "" Then
            booking_details7.Hide()
            booking_print7.Hide()
        End If
        If booked_member8.Text = "" Then
            booking_details8.Hide()
            booking_print8.Hide()
        End If
    End Sub



    Private Sub view_booking3_Click(sender As Object, e As EventArgs) Handles view_booking3.Click
        ' This procedure is what occurs when the third view bookings button is clicked on and it is the same as the previous procedure

        'adjusting of graphics to suit the procedure function
        booking_print1.Show()
        booking_print2.Show()
        booking_print3.Show()
        booking_print4.Show()
        booking_print5.Show()
        booking_print6.Show()
        booking_print7.Show()
        booking_print8.Show()
        booking_details1.Show()
        booking_details2.Show()
        booking_details3.Show()
        booking_details4.Show()
        booking_details5.Show()
        booking_details6.Show()
        booking_details7.Show()
        booking_details8.Show()
        booked_member1.Show()
        booked_member2.Show()
        booked_member3.Show()
        booked_member4.Show()
        booked_member5.Show()
        booked_member6.Show()
        booked_member7.Show()
        booked_member8.Show()

        'assigning of one text box to another
        heading.Text = cargo3.Text

        'declaring of local variables one of which is the connection string to the database
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 0
        Dim a2 As Integer = 1
        Dim a3 As Integer = 2
        Dim a4 As Integer = 3
        Dim a5 As Integer = 4
        Dim a6 As Integer = 5
        Dim a7 As Integer = 6
        Dim a8 As Integer = 7

        'assigning of a sq command to a local variable
        dz = New MySqlDataAdapter(cmd)

        'adjusting of graphics to suit the results
        up_arrow.Hide()
        down_arrow.Hide()

        offer_organisation_name1.Hide()
        offer_profile_pic1.Hide()
        offer_result1.Hide()
        cargo_label1.Hide()
        cargo1.Hide()
        delete_button1.Hide()
        view_booking1.Hide()

        offer_organisation_name2.Hide()
        offer_profile_pic2.Hide()
        offer_result2.Hide()
        cargo_label2.Hide()
        cargo2.Hide()
        delete_button2.Hide()
        view_booking2.Hide()

        offer_organisation_name3.Hide()
        offer_profile_pic3.Hide()
        offer_result3.Hide()
        cargo_label3.Hide()
        cargo3.Hide()
        delete_button3.Hide()
        view_booking3.Hide()

        View_bookings_back.Show()
        bookings_bak_heading.Show()

        'assigning of blank values to textboxes
        booked_member1.Text = ""
        booked_member2.Text = ""
        booked_member3.Text = ""
        booked_member4.Text = ""
        booked_member5.Text = ""
        booked_member6.Text = ""
        booked_member7.Text = ""
        booked_member8.Text = ""

        'try catch block to catch any exceptions the system may encounter at this time 
        Try
            'clearing of a datastore
            ds.Clear()
            'opening of a connection to the database
            c.Open()
            'SQL qurrey to be run on database
            cmd = New MySqlCommand("select organisation from bookings WHERE agent='" & organisation_name.Text & "'and cargo='" & cargo3.Text & "'", c)
            'assigning of a command to a local variable
            dz = New MySqlDataAdapter(cmd)

            'filling of a datastore 
            dz.Fill(ds, "bookings")
            booked_member1.Text = ds.Tables(0).Rows(a1).Item(0)
            booked_member2.Text = ds.Tables(0).Rows(a2).Item(0)
            booked_member3.Text = ds.Tables(0).Rows(a3).Item(0)
            booked_member4.Text = ds.Tables(0).Rows(a4).Item(0)
            booked_member5.Text = ds.Tables(0).Rows(a5).Item(0)
            booked_member6.Text = ds.Tables(0).Rows(a6).Item(0)
            booked_member7.Text = ds.Tables(0).Rows(a7).Item(0)
            booked_member8.Text = ds.Tables(0).Rows(a8).Item(0)

        Catch ex As Exception
            'message to be displayed if the system encounters an error at this stage
            MsgBox(ex.Message)
        Finally
            'closing of the connection to the database
            c.Close()
        End Try
        'adjusting of graphics to be displayed according to data recieved from the database 
        If booked_member1.Text = "" Then
            booking_details1.Hide()
            booking_print1.Hide()
        End If
        If booked_member2.Text = "" Then
            booking_details2.Hide()
            booking_print2.Hide()
        End If
        If booked_member3.Text = "" Then
            booking_details3.Hide()
            booking_print3.Hide()
        End If
        If booked_member4.Text = "" Then
            booking_details4.Hide()
            booking_print4.Hide()
        End If
        If booked_member5.Text = "" Then
            booking_details5.Hide()
            booking_print5.Hide()
        End If
        If booked_member6.Text = "" Then
            booking_details6.Hide()
            booking_print6.Hide()
        End If
        If booked_member7.Text = "" Then
            booking_details7.Hide()
            booking_print7.Hide()
        End If
        If booked_member8.Text = "" Then
            booking_details8.Hide()
            booking_print8.Hide()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'this procedure is what happens when the close icon at the top corner of the screen is clicked on

        'closing of the form 
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'this procedure is what happens when the minimise button at the top corner of the screen is clicked 

        'minimising of the system 
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub delete_button1_Click(sender As Object, e As EventArgs) Handles delete_button1.Click
        'This procedure is what happens when the delete button is clicked 

        'try catch block used inorder to catch exceptions whilst running the system
        Try

            'connection string to database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of a connection to the database
                conn.Open()

                'declaring of variables  
                'SQL querry which will be executed in the database to perform the deleting process
                Dim command As New MySqlCommand("DELETE  FROM offers where organisation_name ='" & organisation_name.Text & "'and cargo='" & cargo1.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()

                'message to be displayed once the record has been deleted from database
                MessageBox.Show("Your offer has been deleted from our database , changes will reflect on next login!!")

                'decision as to command to database
                If data.HasRows = True Then
                    data.Read()


                End If
                'closing of the connection to the database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception

            'message to be displayed to show user the error if any encountered with the system
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub delete_button2_Click(sender As Object, e As EventArgs) Handles delete_button2.Click
        'this procedure is what happens when the second delete button is clicked on it is the same as the previous delete button

        'try catch block used to catcch syste exceptions 
        Try

            'connection string to database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")

                'opening of a connection to the database
                conn.Open()

                'declareing of local variables
                'SQL statement used to delete from the online database
                Dim command As New MySqlCommand("DELETE  FROM offers where organisation_name ='" & organisation_name.Text & "'and cargo='" & cargo2.Text & "'", conn)
                Dim data As MySqlDataReader = command.ExecuteReader()

                'message to be displayed when the offer has been deleted
                MessageBox.Show("Your offer has been deleted from our database , changes will reflect on next login!!")
                'Desision made according to the data read from the databse
                If data.HasRows = True Then
                    data.Read()


                End If
                'closing of the connection to database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to be displayed if the system encounters an error
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub delete_button3_Click(sender As Object, e As EventArgs) Handles delete_button3.Click
        'This procedure runs when the third delete button is pressed 

        'try catch block to catch system exceptions on running of the system
        Try
            'connection string 
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of a connection to the database
                conn.Open()
                'SQL statement query to delete data from the online mysql database
                Dim command As New MySqlCommand("DELETE  FROM offers where organisation_name ='" & organisation_name.Text & "'and cargo='" & cargo3.Text & "'", conn)
                'declaration of local variables
                Dim data As MySqlDataReader = command.ExecuteReader()

                'messagebox to display to the user that the offer has been submitted
                MessageBox.Show("Your offer has been deleted from our database , changes will reflect on next login!!")
                'decision to see if the query has been executed correctly
                If data.HasRows = True Then
                    data.Read()


                End If

                'closing of connection to database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to display any system errors to the users
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub contact_us_button_Click(sender As Object, e As EventArgs) Handles contact_us_button.Click
        'This procedure is run when the contact us button is clicked on 

        'adjusting of graphics to form the contact us page graphical user interface
        contact_us_label.Show()
        message.Show()
        send_message_button.Show()
        email1.Show()
        View_bookings_back.Show()
        home_button.Show()
    End Sub

    Private Sub send_message_button_Click(sender As Object, e As EventArgs) Handles send_message_button.Click
        'This procedure is run when the send message button is clicked on the contact us page

        'try catch block to catch system exceptions 
        Try
            'declaration of local variables 
            Dim dan As String = "danielgoncalves62@gmail.com"
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()

            'initialising of email ports so that the message can be sent to the system developers email address
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("danielgoncalves62@gmail.com", "237achirembaroadhatfield")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(email1.Text)
            e_mail.To.Add(dan)
            e_mail.Subject = "LOGI - from " & organisation_name.Text & " contact " & email1.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = message.Text
            Smtp_Server.Send(e_mail)
            'message to system user to tell user that the message has been submitted 
            MsgBox("Email Sent we will get intouch with you shortly!")

        Catch error_t As Exception
            'message to the user to indicate a system error
            MsgBox("your internet connection or email is not correct , please retype the correct email and make sure you ae online")
        End Try
    End Sub


    Private Sub down_arrow_Click(sender As Object, e As EventArgs) Handles down_arrow.Click
        'this procedure is run when the down arrow is clicked 

        'declaration of local variables which includes the connection string 
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 3
        Dim a2 As Integer = 4
        Dim a3 As Integer = 5
        down_arrow.Hide()
        dz = New MySqlDataAdapter(cmd)

        'assigning of blank values to textboxes
        offer_organisation_name1.Text = ""
        offer_organisation_name2.Text = ""
        offer_organisation_name3.Text = ""

        cargo1.Text = ""
        cargo2.Text = ""
        cargo3.Text = ""

        'try catch block used to catch system exceptions when the system is run
        Try
            'clering of a datastore 
            ds.Clear()
            'opening of a connection to the database 
            c.Open()
            'SQL query to select data from the online database
            cmd = New MySqlCommand("select organisation_name from offers WHERE organisation_name='" + organisation_name.Text + "'", c)
            dz = New MySqlDataAdapter(cmd)

            'adding of data to a data store
            dz.Fill(ds, "offers")
            offer_organisation_name1.Text = ds.Tables(0).Rows(a1).Item(0)
            offer_organisation_name2.Text = ds.Tables(0).Rows(a2).Item(0)
            offer_organisation_name3.Text = ds.Tables(0).Rows(a3).Item(0)

        Catch ex As Exception
            'message to inform the user that the data that is displayed is what has been found
            MsgBox("This is what we found relating to your search!")
        Finally
            'closing of a connection to database
            c.Close()

            'try catch block to catch system exceptions
            Try

                'clearing of a datastore
                ds1.Clear()

                'opening of a connection to the database
                c.Open()
                'SQL query to select data from the online database
                cmd = New MySqlCommand("select cargo from offers WHERE organisation_name='" + offer_organisation_name1.Text + "'", c)
                dz = New MySqlDataAdapter(cmd)

                'inserting of data into the datastore
                dz.Fill(ds1, "offers")
                cargo1.Text = ds1.Tables(0).Rows(a1).Item(0)
                cargo2.Text = ds1.Tables(0).Rows(a2).Item(0)
                cargo3.Text = ds1.Tables(0).Rows(a3).Item(0)



            Catch ex As Exception

            Finally
                'closing of the connection to the database
                c.Close()
            End Try

        End Try
        'decision making inorder to adjust graphics acording to data obtained
        If offer_organisation_name1.Text = "" Then
            offer_result1.Hide()
            offer_profile_pic1.Hide()
            view_booking1.Hide()
            cargo_label1.Hide()
            cargo1.Hide()
            delete_button1.Hide()

        End If
        If offer_organisation_name2.Text = "" Then
            offer_result2.Hide()
            offer_profile_pic2.Hide()
            view_booking2.Hide()
            cargo_label2.Hide()
            cargo2.Hide()
            delete_button2.Hide()

        End If
        If offer_organisation_name3.Text = "" Then
            offer_result3.Hide()
            offer_profile_pic3.Hide()
            view_booking3.Hide()
            cargo_label3.Hide()
            cargo3.Hide()
            delete_button3.Hide()

        End If

        'try catch block used to catch system exceptions 
        Try
            'connection to database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of the connection
                conn.Open()
                'SQL querry to obtain data from the online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name1.Text & "'", conn)
                'declaration of a local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'desision making on displaying of profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    offer_profile_pic1.Image = Image.FromStream(ms)

                End If
                'closing of connection to the database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message communicating system error that has encountered
            MessageBox.Show(ex.Message)
        End Try

        'try catch block used to catch system exceptions
        Try

            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to database
                conn.Open()
                'SQL query to select data from database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name2.Text & "'", conn)
                'declaration of local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on displaying of the profile picture from the database
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    offer_profile_pic2.Image = Image.FromStream(ms)
                End If
                'closing of connection to database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying any system error encountered
            MessageBox.Show(ex.Message)
        End Try

        'try catch block used to catch any system exceptions 
        Try
            'connection string to the online database 
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to the database
                conn.Open()
                'SQL query used to select data from the database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name3.Text & "'", conn)
                'declaration of local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'desision making on the displaying of the profile picture obtained from database
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    offer_profile_pic3.Image = Image.FromStream(ms)
                End If
                'closing of connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying system errors at this point
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles up_arrow.Click
        'This procedure is run when the up arrow is clicked on 
        'Declaration of local variables  which includes connection string to the database
        Dim c As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim cmd As New MySqlCommand
        Dim dz As New MySqlDataAdapter
        Dim ds, ds1 As New DataSet
        Dim a1 As Integer = 0
        Dim a2 As Integer = 1
        Dim a3 As Integer = 2
        down_arrow.Show()
        dz = New MySqlDataAdapter(cmd)
        'assigning of blank values to text boxes
        offer_organisation_name1.Text = ""
        offer_organisation_name2.Text = ""
        offer_organisation_name3.Text = ""

        cargo1.Text = ""
        cargo2.Text = ""
        cargo3.Text = ""
        'try catch block used to catch system exceptions
        Try
            'clearing of a datastore
            ds.Clear()
            'establishing of connection to database
            c.Open()
            'SQL query to select data from the online database
            cmd = New MySqlCommand("select organisation_name from offers WHERE organisation_name='" + organisation_name.Text + "'", c)
            dz = New MySqlDataAdapter(cmd)

            'filling oof a datastore with data obtained from online database
            dz.Fill(ds, "offers")
            offer_organisation_name1.Text = ds.Tables(0).Rows(a1).Item(0)
            offer_organisation_name2.Text = ds.Tables(0).Rows(a2).Item(0)
            offer_organisation_name3.Text = ds.Tables(0).Rows(a3).Item(0)

        Catch ex As Exception
            'message telling user that the data which is displayed is what was found 
            MsgBox("This is what we found relating to your search!")
        Finally
            'closing of connection to the database
            c.Close()
            'try catch block to catch system exceptions
            Try
                'clearing of datastore
                ds1.Clear()
                'opening of connection to online database
                c.Open()
                ''SQL query used to get required data from the online database
                cmd = New MySqlCommand("select cargo from offers WHERE organisation_name='" + offer_organisation_name1.Text + "'", c)
                dz = New MySqlDataAdapter(cmd)
                'filling up of datastore 
                dz.Fill(ds1, "offers")
                cargo1.Text = ds1.Tables(0).Rows(a1).Item(0)
                cargo2.Text = ds1.Tables(0).Rows(a2).Item(0)
                cargo3.Text = ds1.Tables(0).Rows(a3).Item(0)



            Catch ex As Exception

            Finally
                'closing of connection to the database
                c.Close()
            End Try

        End Try
        'adjusting of graphics acording to the data obtained from the online database
        If offer_organisation_name1.Text = "" Then
            offer_result1.Hide()
            offer_profile_pic1.Hide()
            view_booking1.Hide()
            cargo_label1.Hide()
            cargo1.Hide()
            delete_button1.Hide()

        End If
        If offer_organisation_name2.Text = "" Then
            offer_result2.Hide()
            offer_profile_pic2.Hide()
            view_booking2.Hide()
            cargo_label2.Hide()
            cargo2.Hide()
            delete_button2.Hide()

        End If
        If offer_organisation_name3.Text = "" Then
            offer_result3.Hide()
            offer_profile_pic3.Hide()
            view_booking3.Hide()
            cargo_label3.Hide()
            cargo3.Hide()
            delete_button3.Hide()

        End If

        'try catch block used to catch system exceptions 
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to the online database 
                conn.Open()
                'SQL query used to extract data from the online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name1.Text & "'", conn)
                'declaring of a local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision being made on displaying of profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)
                    offer_profile_pic1.Image = Image.FromStream(ms)

                End If
                'closing of connection to the database 
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying system exception to user if any are encountered
            MessageBox.Show(ex.Message)
        End Try
        'try catch block to catch any system exceptions that may occur
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to the online database
                conn.Open()
                'SQL query used to extract informtion from the database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name2.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'Decision making on the displaying of a profle picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    offer_profile_pic2.Image = Image.FromStream(ms)
                End If
                'closing of the connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to be displayed if the system runs into any system exceptions
            MessageBox.Show(ex.Message)
        End Try
        'try catch block to catch user exeptions 
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to the online database
                conn.Open()
                'SQL query to extract data from the online database
                Dim command As New MySqlCommand("SELECT * FROM offers where organisation_name ='" & offer_organisation_name3.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the displaying of a profile picture 
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    offer_profile_pic3.Image = Image.FromStream(ms)
                End If
                'closing of a connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message diplaying any system exceptions that may occur
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_details1_Click(sender As Object, e As EventArgs) Handles booking_details1.Click
        'This procedure is run when the 1st bookin details button is clicked 
        'Adjusting of graphics to suit processes to take place 
        booking_bak2.Show()
        booking_pro_pic.Show()
        organisation_name_label.Show()
        cargo_booking_label.Show()
        mass_label.Show()
        contact_person_label.Show()
        email_label.Show()
        booking_organisation.Show()
        booking_cargo.Show()
        booking_mass.Show()
        booking_contact_person.Show()
        booking_email.Show()
        'assigning of one text box to another text box
        booking_organisation.Text = booked_member1.Text
        'declaration of local variables 
        'connection string to the online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'SQL query used to select data from the online database
        Dim sql As String = "SELECT * FROM bookings where agent ='" & organisation_name.Text & "'and cargo='" & heading.Text & "' and organisation='" & booking_organisation.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)
      
        'Clearing of data from variables mensioned
        booking_cargo.DataBindings.Clear()
        booking_contact_person.DataBindings.Clear()
        booking_email.DataBindings.Clear()
        booking_mass.DataBindings.Clear()
        'filling of Dataset with data obtained from the online database
        da.Fill(DataSet1, "db")
        booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        booking_contact_person.DataBindings.Add("text", DataSet1, "db.contact_person")
        booking_email.DataBindings.Add("text", DataSet1, "db.email")
        booking_mass.DataBindings.Add("text", DataSet1, "db.mass")

        'try catch block used to catch any system exceptions that may occur
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to the online database 
                conn.Open()
                'SQL query used to extract data from the online database  
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & booking_organisation.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision on displaying of the profile picture from online database
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    booking_pro_pic.Image = Image.FromStream(ms)
                End If
                'closing of connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying any system exception enountered
            MessageBox.Show(ex.Message)
        End Try
        Dim a As String = "                                                          InterLOG Transport System"
        Dim b As String = "Booking Details"
        Dim c As String = ""

        RichTextBox1.Text += a + vbCrLf
        RichTextBox1.Text += b + vbCrLf
        RichTextBox1.Text += c + vbCrLf
        RichTextBox1.Text += organisation_name_label.Text + booking_organisation.Text + vbCrLf
        RichTextBox1.Text += cargo_booking_label.Text + booking_cargo.Text + vbCrLf
        RichTextBox1.Text += mass_label.Text + booking_mass.Text + vbCrLf
        RichTextBox1.Text += contact_person_label.Text + booking_contact_person.Text + vbCrLf
        RichTextBox1.Text += email_label.Text + booking_email.Text + vbCrLf
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
    End Sub

    Private Sub booking_details2_Click(sender As Object, e As EventArgs) Handles booking_details2.Click
        'This procedure is run when the 2nd booking details button is clicked
        'adjusting of graphics to suit the processes to take place
        booking_bak2.Show()
        booking_pro_pic.Show()
        organisation_name_label.Show()
        cargo_booking_label.Show()
        mass_label.Show()
        contact_person_label.Show()
        email_label.Show()
        booking_organisation.Show()
        booking_cargo.Show()
        booking_mass.Show()
        booking_contact_person.Show()
        booking_email.Show()
        'assigning of one text box to another text box
        booking_organisation.Text = booked_member2.Text
        'declaration of local variables
        'connection string to online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'SQL query used to extract data from online database
        Dim sql As String = "SELECT * FROM bookings where agent ='" & organisation_name.Text & "'and cargo='" & heading.Text & "' and organisation='" & booking_organisation.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data from mensioned variables
        booking_cargo.DataBindings.Clear()
        booking_contact_person.DataBindings.Clear()
        booking_email.DataBindings.Clear()
        booking_mass.DataBindings.Clear()
        'filling of dataset with information obtained from database
        da.Fill(DataSet1, "db")
        booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        booking_contact_person.DataBindings.Add("text", DataSet1, "db.contact_person")
        booking_email.DataBindings.Add("text", DataSet1, "db.email")
        booking_mass.DataBindings.Add("text", DataSet1, "db.mass")

        'try catch block to catch system exceptions 
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to online database
                conn.Open()
                'SQL query to select data from online database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & booking_organisation.Text & "'", conn)
                'declaration of local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making o the displaying of a profile pic
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    booking_pro_pic.Image = Image.FromStream(ms)
                End If
                'closing of a connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'messgae to display any system exceptions that may be encountered
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_details3_Click(sender As Object, e As EventArgs) Handles booking_details3.Click
        'This procedure is run when the 3rd booking details button is clicked 
        'adjusting of graphics to suit the processes to take place 
        booking_bak2.Show()
        booking_pro_pic.Show()
        organisation_name_label.Show()
        cargo_booking_label.Show()
        mass_label.Show()
        contact_person_label.Show()
        email_label.Show()
        booking_organisation.Show()
        booking_cargo.Show()
        booking_mass.Show()
        booking_contact_person.Show()
        booking_email.Show()
        'assigning of one textbox to another textbox
        booking_organisation.Text = booked_member3.Text
        'declaration of local variables
        'connection string to the online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'SQL query to select data frorm the online database 
        Dim sql As String = "SELECT * FROM bookings where agent ='" & organisation_name.Text & "'and cargo='" & heading.Text & "' and organisation='" & booking_organisation.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data from the mensioned variables
        booking_cargo.DataBindings.Clear()
        booking_contact_person.DataBindings.Clear()
        booking_email.DataBindings.Clear()
        booking_mass.DataBindings.Clear()
        'filling of a dataset with data obtained from the online database
        da.Fill(DataSet1, "db")
        booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        booking_contact_person.DataBindings.Add("text", DataSet1, "db.contact_person")
        booking_email.DataBindings.Add("text", DataSet1, "db.email")
        booking_mass.DataBindings.Add("text", DataSet1, "db.mass")

        'use of a try catch block to catch system exceptions
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of connection to the online database
                conn.Open()
                'SQL query to select data from the onlinee database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & booking_organisation.Text & "'", conn)
                'declaring of local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the displaying of the profile picture 
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    booking_pro_pic.Image = Image.FromStream(ms)
                End If
                'closing of connection to the online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to display any system exceptions encountered whilst the system was running
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_details4_Click(sender As Object, e As EventArgs) Handles booking_details4.Click
        'This procedure is run when the 4th booking detais button is clicked
        'adjusting of graphics to suit the processes  to occur
        booking_bak2.Show()
        booking_pro_pic.Show()
        organisation_name_label.Show()
        cargo_booking_label.Show()
        mass_label.Show()
        contact_person_label.Show()
        email_label.Show()
        booking_organisation.Show()
        booking_cargo.Show()
        booking_mass.Show()
        booking_contact_person.Show()
        booking_email.Show()
        'assigning of one text box to another text box
        booking_organisation.Text = booked_member4.Text
        'Connection string to access online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'declaring of local variables
        'SQL query to select data from the online database 
        Dim sql As String = "SELECT * FROM bookings where agent ='" & organisation_name.Text & "'and cargo='" & heading.Text & "' and organisation='" & booking_organisation.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'Clearing of data in local variables
        booking_cargo.DataBindings.Clear()
        booking_contact_person.DataBindings.Clear()
        booking_email.DataBindings.Clear()
        booking_mass.DataBindings.Clear()
        'filling of a dataset with data obtained from the online database
        da.Fill(DataSet1, "db")
        booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        booking_contact_person.DataBindings.Add("text", DataSet1, "db.contact_person")
        booking_email.DataBindings.Add("text", DataSet1, "db.email")
        booking_mass.DataBindings.Add("text", DataSet1, "db.mass")

        'try catch block used to catch any system exceptions that may occur 
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'opening of connection to the online database
                conn.Open()
                'SQL query used to select data from the online database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & booking_organisation.Text & "'", conn)
                'declaration of local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the displaying of the profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    booking_pro_pic.Image = Image.FromStream(ms)
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to display any system exceptions thatmay be experianced
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_details5_Click(sender As Object, e As EventArgs) Handles booking_details5.Click
        'This procedure is run when the 5th booking details button is clicked 
        'adjusting of graphics to suit the processes occuring 
        booking_bak2.Show()
        booking_pro_pic.Show()
        organisation_name_label.Show()
        cargo_booking_label.Show()
        mass_label.Show()
        contact_person_label.Show()
        email_label.Show()
        booking_organisation.Show()
        booking_cargo.Show()
        booking_mass.Show()
        booking_contact_person.Show()
        booking_email.Show()

        booking_organisation.Text = booked_member5.Text
        'declaration of local variables
        'connection string to online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'SQL query to select data from the online database
        Dim sql As String = "SELECT * FROM bookings where agent ='" & organisation_name.Text & "'and cargo='" & heading.Text & "' and organisation='" & booking_organisation.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data located in declared variables
        booking_cargo.DataBindings.Clear()
        booking_contact_person.DataBindings.Clear()
        booking_email.DataBindings.Clear()
        booking_mass.DataBindings.Clear()
        'filling of a dataset with information obtained from database
        da.Fill(DataSet1, "db")
        booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        booking_contact_person.DataBindings.Add("text", DataSet1, "db.contact_person")
        booking_email.DataBindings.Add("text", DataSet1, "db.email")
        booking_mass.DataBindings.Add("text", DataSet1, "db.mass")

        'try catch block to catch any system exceptions that may occur
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of a connection to thee online database
                conn.Open()
                'declaring of local variable
                'SQL query to select data from the online database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & booking_organisation.Text & "'", conn)
                'declaration of local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on displaying of profile picture 
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    booking_pro_pic.Image = Image.FromStream(ms)
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message displaying any system exceptions encountered
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_details6_Click(sender As Object, e As EventArgs) Handles booking_details6.Click
        'This procedure is run when the 6th booking details button is clicked
        'adjusting of graphics to suit the process occuring
        booking_bak2.Show()
        booking_pro_pic.Show()
        organisation_name_label.Show()
        cargo_booking_label.Show()
        mass_label.Show()
        contact_person_label.Show()
        email_label.Show()
        booking_organisation.Show()
        booking_cargo.Show()
        booking_mass.Show()
        booking_contact_person.Show()
        booking_email.Show()
        'assigning of one text box to another text box
        booking_organisation.Text = booked_member6.Text
        'declaration of locl variables
        'connection string to the online database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'declaration of local variables
        'SQL query to select data from the online database
        Dim sql As String = "SELECT * FROM bookings where agent ='" & organisation_name.Text & "'and cargo='" & heading.Text & "' and organisation='" & booking_organisation.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of values from selected local variables
        booking_cargo.DataBindings.Clear()
        booking_contact_person.DataBindings.Clear()
        booking_email.DataBindings.Clear()
        booking_mass.DataBindings.Clear()
        'filling of dataset with information from the database
        da.Fill(DataSet1, "db")
        booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        booking_contact_person.DataBindings.Add("text", DataSet1, "db.contact_person")
        booking_email.DataBindings.Add("text", DataSet1, "db.email")
        booking_mass.DataBindings.Add("text", DataSet1, "db.mass")

        'try catch block used to catch system exceptions that may occur
        Try
            'connection string
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to online database
                conn.Open()
                'declaring of local variable
                'SQL query to select data from the online database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & booking_organisation.Text & "'", conn)

                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision making on the displaying of profile picture
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    booking_pro_pic.Image = Image.FromStream(ms)
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to display the system exception if any encountered
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_details7_Click(sender As Object, e As EventArgs) Handles booking_details7.Click
        'this procedure is run when the 7th booking details button is clicked on 
        'adjusting of graphics to suit the feature of the system 
        booking_bak2.Show()
        booking_pro_pic.Show()
        organisation_name_label.Show()
        cargo_booking_label.Show()
        mass_label.Show()
        contact_person_label.Show()
        email_label.Show()
        booking_organisation.Show()
        booking_cargo.Show()
        booking_mass.Show()
        booking_contact_person.Show()
        booking_email.Show()

        booking_organisation.Text = booked_member7.Text
        'declaration of local variables which includes the connection string to database
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'declaration of local variables
        'SQL query to select data from the online dataase
        Dim sql As String = "SELECT * FROM bookings where agent ='" & organisation_name.Text & "'and cargo='" & heading.Text & "' and organisation='" & booking_organisation.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data from local variables 
        booking_cargo.DataBindings.Clear()
        booking_contact_person.DataBindings.Clear()
        booking_email.DataBindings.Clear()
        booking_mass.DataBindings.Clear()
        'filling of dataset with data obtained from database
        da.Fill(DataSet1, "db")
        booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        booking_contact_person.DataBindings.Add("text", DataSet1, "db.contact_person")
        booking_email.DataBindings.Add("text", DataSet1, "db.email")
        booking_mass.DataBindings.Add("text", DataSet1, "db.mass")

        'try catch block to catch user exceptions
        Try
            'connection string to online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to online database
                conn.Open()
                'SQL query to select data from online database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & booking_organisation.Text & "'", conn)
                'declaring of local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision made on dispalying of profile pic
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    booking_pro_pic.Image = Image.FromStream(ms)
                End If
                'closing of connection to online database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'message to display system exception if any encountered
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_details8_Click(sender As Object, e As EventArgs) Handles booking_details8.Click
        'this procedure is run when the 8th booking details button is clicked on
        'adjusting of graphical user interface to suit the feature being displayed
        booking_bak2.Show()
        booking_pro_pic.Show()
        organisation_name_label.Show()
        cargo_booking_label.Show()
        mass_label.Show()
        contact_person_label.Show()
        email_label.Show()
        booking_organisation.Show()
        booking_cargo.Show()
        booking_mass.Show()
        booking_contact_person.Show()
        booking_email.Show()
        'assigning of one text box to another
        booking_organisation.Text = booked_member8.Text
        'declaring of local variables
        Dim thisConnection As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
        Dim DataSet1 As New DataSet
        'declaring of local variables
        'SQL query to extract data from the online database
        Dim sql As String = "SELECT * FROM bookings where agent ='" & organisation_name.Text & "'and cargo='" & heading.Text & "' and organisation='" & booking_organisation.Text & "'"
        Dim da As New MySqlDataAdapter(sql, thisConnection)

        'clearing of data from variables
        booking_cargo.DataBindings.Clear()
        booking_contact_person.DataBindings.Clear()
        booking_email.DataBindings.Clear()
        booking_mass.DataBindings.Clear()
        'filling of data to dataset
        da.Fill(DataSet1, "db")
        booking_cargo.DataBindings.Add("text", DataSet1, "db.cargo")
        booking_contact_person.DataBindings.Add("text", DataSet1, "db.contact_person")
        booking_email.DataBindings.Add("text", DataSet1, "db.email")
        booking_mass.DataBindings.Add("text", DataSet1, "db.mass")

        'try catch block to catch system exceptions
        Try
            'connection string to the online database
            Using conn As New MySqlConnection("Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1")
                'establishing of connection to the online database
                conn.Open()
                'SQL query to get data from the database
                Dim command As New MySqlCommand("SELECT * FROM bookings where organisation ='" & booking_organisation.Text & "'", conn)
                'declaring of local variable
                Dim data As MySqlDataReader = command.ExecuteReader()
                'decision on displaying of profile pic 
                If data.HasRows = True Then
                    data.Read()
                    Dim bt As Byte() = DirectCast(data("profile_pic"), Byte())
                    Dim ms As New MemoryStream(bt)

                    booking_pro_pic.Image = Image.FromStream(ms)
                End If
                'closing of connection to database
                command.Dispose()
                data.Close()
                conn.Close()
            End Using
        Catch ex As Exception
            'displaying of system exception if any encountered
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub maximum_bookings_KeyPress(sender As Object, e As KeyPressEventArgs) Handles maximum_bookings.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub

    Private Sub price_per_tonne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price_per_tonne.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub

    Private Sub date_to_go_LostFocus(sender As Object, e As EventArgs) Handles date_to_go.LostFocus
        If date_to_go.Text = "" Then
            MessageBox.Show("please enter a date in the format yyyy-mm-dd !")
        End If
        Dim test As Date
        If Date.TryParseExact(date_to_go.Text.ToString(), "yyyy-mm-dd", _
                              System.Globalization.CultureInfo.CurrentCulture, _
                              Globalization.DateTimeStyles.None, test) Then

        Else
            MessageBox.Show("Please enter the date in the correct format yyyy-mm-dd !")
            'TODO: not ok
        End If
    End Sub

    Private Sub booking_print1_Click(sender As Object, e As EventArgs) Handles booking_print1.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(RichTextBox1.Text, RichTextBox1.Font, Brushes.Black, 100, 100)
    End Sub

    Private Sub booking_print2_Click(sender As Object, e As EventArgs) Handles booking_print2.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub booking_print3_Click(sender As Object, e As EventArgs) Handles booking_print3.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub booking_print4_Click(sender As Object, e As EventArgs) Handles booking_print4.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub booking_print5_Click(sender As Object, e As EventArgs) Handles booking_print5.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub booking_print6_Click(sender As Object, e As EventArgs) Handles booking_print6.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub booking_print7_Click(sender As Object, e As EventArgs) Handles booking_print7.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub booking_print8_Click(sender As Object, e As EventArgs) Handles booking_print8.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub
End Class