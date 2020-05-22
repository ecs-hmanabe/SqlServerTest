<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSELECT = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxBirthday = New System.Windows.Forms.TextBox()
        Me.LabelStudentID = New System.Windows.Forms.Label()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.LabelBirthday = New System.Windows.Forms.Label()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.TextBoxGender = New System.Windows.Forms.TextBox()
        Me.ButtonINSERT = New System.Windows.Forms.Button()
        Me.ButtonUPDATE = New System.Windows.Forms.Button()
        Me.ButtonDELETE = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(13, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 19)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'ButtonSELECT
        '
        Me.ButtonSELECT.Location = New System.Drawing.Point(12, 91)
        Me.ButtonSELECT.Name = "ButtonSELECT"
        Me.ButtonSELECT.Size = New System.Drawing.Size(171, 23)
        Me.ButtonSELECT.TabIndex = 4
        Me.ButtonSELECT.Text = "SELECT"
        Me.ButtonSELECT.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(776, 301)
        Me.DataGridView1.TabIndex = 5
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Location = New System.Drawing.Point(334, 6)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxStudentID.TabIndex = 6
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(334, 31)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxFirstName.TabIndex = 7
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(334, 56)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxLastName.TabIndex = 8
        '
        'TextBoxBirthday
        '
        Me.TextBoxBirthday.Location = New System.Drawing.Point(334, 81)
        Me.TextBoxBirthday.Name = "TextBoxBirthday"
        Me.TextBoxBirthday.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxBirthday.TabIndex = 9
        '
        'LabelStudentID
        '
        Me.LabelStudentID.AutoSize = True
        Me.LabelStudentID.Location = New System.Drawing.Point(258, 9)
        Me.LabelStudentID.Name = "LabelStudentID"
        Me.LabelStudentID.Size = New System.Drawing.Size(55, 12)
        Me.LabelStudentID.TabIndex = 10
        Me.LabelStudentID.Text = "StudentID"
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(255, 34)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(58, 12)
        Me.LabelFirstName.TabIndex = 11
        Me.LabelFirstName.Text = "FirstName"
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Location = New System.Drawing.Point(253, 59)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(56, 12)
        Me.LabelLastName.TabIndex = 12
        Me.LabelLastName.Text = "LastName"
        '
        'LabelBirthday
        '
        Me.LabelBirthday.AutoSize = True
        Me.LabelBirthday.Location = New System.Drawing.Point(253, 84)
        Me.LabelBirthday.Name = "LabelBirthday"
        Me.LabelBirthday.Size = New System.Drawing.Size(48, 12)
        Me.LabelBirthday.TabIndex = 13
        Me.LabelBirthday.Text = "Birthday"
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Location = New System.Drawing.Point(255, 109)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(41, 12)
        Me.LabelGender.TabIndex = 14
        Me.LabelGender.Text = "Gender"
        '
        'TextBoxGender
        '
        Me.TextBoxGender.Location = New System.Drawing.Point(334, 106)
        Me.TextBoxGender.Name = "TextBoxGender"
        Me.TextBoxGender.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxGender.TabIndex = 15
        '
        'ButtonINSERT
        '
        Me.ButtonINSERT.Location = New System.Drawing.Point(440, 54)
        Me.ButtonINSERT.Name = "ButtonINSERT"
        Me.ButtonINSERT.Size = New System.Drawing.Size(75, 23)
        Me.ButtonINSERT.TabIndex = 16
        Me.ButtonINSERT.Text = "登録"
        Me.ButtonINSERT.UseVisualStyleBackColor = True
        '
        'ButtonUPDATE
        '
        Me.ButtonUPDATE.Location = New System.Drawing.Point(440, 79)
        Me.ButtonUPDATE.Name = "ButtonUPDATE"
        Me.ButtonUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUPDATE.TabIndex = 17
        Me.ButtonUPDATE.Text = "更新"
        Me.ButtonUPDATE.UseVisualStyleBackColor = True
        '
        'ButtonDELETE
        '
        Me.ButtonDELETE.Location = New System.Drawing.Point(440, 104)
        Me.ButtonDELETE.Name = "ButtonDELETE"
        Me.ButtonDELETE.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDELETE.TabIndex = 18
        Me.ButtonDELETE.Text = "削除"
        Me.ButtonDELETE.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(674, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "遷移"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LabelStudentID)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.LabelBirthday)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.TextBoxStudentID)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.TextBoxBirthday)
        Me.Controls.Add(Me.TextBoxGender)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonINSERT)
        Me.Controls.Add(Me.ButtonUPDATE)
        Me.Controls.Add(Me.ButtonDELETE)
        Me.Controls.Add(Me.ButtonSELECT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSELECT As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxBirthday As TextBox
    Friend WithEvents LabelStudentID As Label
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents LabelLastName As Label
    Friend WithEvents LabelBirthday As Label
    Friend WithEvents LabelGender As Label
    Friend WithEvents TextBoxGender As TextBox
    Friend WithEvents ButtonINSERT As Button
    Friend WithEvents ButtonUPDATE As Button
    Friend WithEvents ButtonDELETE As Button
    Friend WithEvents Button3 As Button
End Class
