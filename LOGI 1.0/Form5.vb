'importing of libraries to be used
Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Form5
    'declaration of global variable for connection string
    Dim connectionString As String = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'closing of the form initiated by clicking a 'x' shaped picture box 
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'code to minimise the form
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declaration of local variables to be used 
        Dim pin_id As String
        Dim pin As String
        Dim verification_label As String
        Dim flag As Boolean = False

        'initilisation of variables declared above
        pin_id = TextBox1.Text
        pin = TextBox2.Text & TextBox3.Text & TextBox4.Text & TextBox5.Text
        verification_label = Label6.Text


        'checking if a product key is entered in the text boxes provided using a decision
        If (String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text)) Then

            'displaying of message to end user if the product key is missing
            MessageBox.Show("productkey is  missing")
            Exit Sub
        End If

        'comparing the product key with values in the database
        flag = CheckUser(pin_id, pin)
        If flag = True Then

            'displaying of message if the product key exists
            MessageBox.Show("Key successfuly verified!!")

            'creation of a confirmation file for system registration
            System.IO.File.Create("D:\LOGI\verified.txt")

            'closing of current form and displaying of next form
            Me.Hide()
            Form2.Show()
        Else

            'message to be displayed if an incorrect product key is entered
            MessageBox.Show("Key is incorrect")
        End If
    End Sub
    Private Function CheckUser(ByVal u As String, ByVal p As String) As Boolean
        'local variables declaration within a function

        Dim flag As Boolean = False
        Dim cnn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader

        'connecting to the database and retreiving data for comparison

        cnn.ConnectionString = "Persist Security Info=False;server=db4free.net;port=3306;username=gonzo1;password=a1b2c3d4e5;database=logisys1"
        cmd.CommandText = "select * from product_keys where id='" + u.Trim() + "' and p_keys='" + p.Trim() + "'"
        cmd.Connection = cnn
        cnn.Open()
        reader = cmd.ExecuteReader()

        'checking if values containing user input were retreived 

        If (reader.HasRows) Then
            flag = True

        End If

        'closing of connection to database
        cnn.Close()

        'returning the value  from the function
        Return flag
    End Function


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only!", "LOGIsys")
            e.Handled = True
        End If
    End Sub
End Class