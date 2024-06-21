<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionform
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
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        btnStartStopwatch = New Button()
        lblStopwatch = New Label()
        btnSubmit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(247, 41)
        txtName.Name = "txtName"
        txtName.Size = New Size(188, 23)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(247, 105)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(188, 23)
        txtEmail.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(247, 161)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(188, 23)
        txtPhone.TabIndex = 5
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(247, 214)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(188, 23)
        txtGithubLink.TabIndex = 7
        ' 
        ' btnStartStopwatch
        ' 
        btnStartStopwatch.Location = New Point(115, 264)
        btnStartStopwatch.Name = "btnStartStopwatch"
        btnStartStopwatch.Size = New Size(167, 26)
        btnStartStopwatch.TabIndex = 8
        btnStartStopwatch.Text = "TOGGLE STOPWATCH"
        btnStartStopwatch.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(344, 270)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(49, 15)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(115, 309)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(320, 39)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(115, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 12
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(115, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 13
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(115, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 14
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(115, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 15)
        Label4.TabIndex = 15
        Label4.Text = "Github Link for Task2"
        ' 
        ' CreateSubmissionForm
        ' 
        AccessibleName = ""
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatch)
        Controls.Add(btnStartStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnStartStopwatch As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
