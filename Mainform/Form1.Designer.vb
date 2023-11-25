<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Panel1 = New Panel()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.SeaShell
        Label1.Font = New Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(189, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 55)
        Label1.TabIndex = 0
        Label1.Text = "Login Form"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.jsitlogo_withoutbg
        PictureBox1.Location = New Point(472, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(190, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SeaShell
        Label2.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(74, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 27)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SeaShell
        Label3.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(79, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 27)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(211, 204)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(450, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(211, 251)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(450, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(315, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 57)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaShell
        Panel1.Controls.Add(LinkLabel2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 456)
        Panel1.TabIndex = 7
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(362, 392)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(54, 15)
        LinkLabel2.TabIndex = 9
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Register?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(343, 364)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(100, 15)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "JSIT Login Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
