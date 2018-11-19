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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSvnPath = New System.Windows.Forms.TextBox()
        Me.btnChooseFolder = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path svn folder"
        '
        'txtSvnPath
        '
        Me.txtSvnPath.Location = New System.Drawing.Point(123, 13)
        Me.txtSvnPath.Name = "txtSvnPath"
        Me.txtSvnPath.Size = New System.Drawing.Size(445, 22)
        Me.txtSvnPath.TabIndex = 1
        '
        'btnChooseFolder
        '
        Me.btnChooseFolder.Location = New System.Drawing.Point(575, 12)
        Me.btnChooseFolder.Name = "btnChooseFolder"
        Me.btnChooseFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseFolder.TabIndex = 2
        Me.btnChooseFolder.Text = "Choose Folder"
        Me.btnChooseFolder.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Click here to download SVN CLI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(6, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "* required"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Username"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(123, 90)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(445, 22)
        Me.txtSearch.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(575, 90)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "quangtd@minori.com.vn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Example: C:\SVN\SOURCE_CODE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(137, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Example: bp_minori_quangtd"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 197)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnChooseFolder)
        Me.Controls.Add(Me.txtSvnPath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Q Perfect Tool for SVN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSvnPath As TextBox
    Friend WithEvents btnChooseFolder As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
