<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.organisation_name = New System.Windows.Forms.TextBox()
        Me.country = New System.Windows.Forms.TextBox()
        Me.language = New System.Windows.Forms.TextBox()
        Me.currency = New System.Windows.Forms.TextBox()
        Me.purpose = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(144, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Logistics Transport Settings"
        '
        'organisation_name
        '
        Me.organisation_name.BackColor = System.Drawing.Color.LightGray
        Me.organisation_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.organisation_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.organisation_name.ForeColor = System.Drawing.Color.DimGray
        Me.organisation_name.Location = New System.Drawing.Point(127, 119)
        Me.organisation_name.Name = "organisation_name"
        Me.organisation_name.Size = New System.Drawing.Size(190, 24)
        Me.organisation_name.TabIndex = 15
        Me.organisation_name.Text = "Organisation Name"
        '
        'country
        '
        Me.country.BackColor = System.Drawing.Color.LightGray
        Me.country.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.country.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.country.ForeColor = System.Drawing.Color.DimGray
        Me.country.Location = New System.Drawing.Point(127, 160)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(134, 24)
        Me.country.TabIndex = 16
        Me.country.Text = "Country"
        '
        'language
        '
        Me.language.BackColor = System.Drawing.Color.LightGray
        Me.language.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.language.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.language.ForeColor = System.Drawing.Color.DimGray
        Me.language.Location = New System.Drawing.Point(127, 204)
        Me.language.Name = "language"
        Me.language.Size = New System.Drawing.Size(134, 24)
        Me.language.TabIndex = 17
        Me.language.Text = "Language"
        '
        'currency
        '
        Me.currency.BackColor = System.Drawing.Color.LightGray
        Me.currency.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.currency.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currency.ForeColor = System.Drawing.Color.DimGray
        Me.currency.Location = New System.Drawing.Point(127, 251)
        Me.currency.Name = "currency"
        Me.currency.Size = New System.Drawing.Size(134, 24)
        Me.currency.TabIndex = 18
        Me.currency.Text = "Currency"
        '
        'purpose
        '
        Me.purpose.BackColor = System.Drawing.Color.LightGray
        Me.purpose.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.purpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purpose.ForeColor = System.Drawing.Color.DimGray
        Me.purpose.Location = New System.Drawing.Point(127, 296)
        Me.purpose.Name = "purpose"
        Me.purpose.Size = New System.Drawing.Size(134, 24)
        Me.purpose.TabIndex = 19
        Me.purpose.Text = "Purpose"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.LightGray
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.DimGray
        Me.username.Location = New System.Drawing.Point(393, 119)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(134, 24)
        Me.username.TabIndex = 20
        Me.username.Text = "Username"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.LightGray
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.DimGray
        Me.password.Location = New System.Drawing.Point(393, 160)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(134, 24)
        Me.password.TabIndex = 21
        Me.password.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(407, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 99)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(127, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 28)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Update Settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(367, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "*Please ensure details are correct these"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(367, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "cannot be changed"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(627, 413)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.purpose)
        Me.Controls.Add(Me.currency)
        Me.Controls.Add(Me.language)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.organisation_name)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents organisation_name As System.Windows.Forms.TextBox
    Friend WithEvents country As System.Windows.Forms.TextBox
    Friend WithEvents language As System.Windows.Forms.TextBox
    Friend WithEvents currency As System.Windows.Forms.TextBox
    Friend WithEvents purpose As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
