<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_connect
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_connect))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.But_visib = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Txt_Nutili = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.But_Fermer = New System.Windows.Forms.Button()
        Me.But_conn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lab_LgGnrl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Location = New System.Drawing.Point(347, -6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 371)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.But_Fermer)
        Me.GroupBox1.Controls.Add(Me.But_conn)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 371)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Controls.Add(Me.But_visib)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Txt_Pass)
        Me.GroupBox4.Controls.Add(Me.Txt_Nutili)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(313, 65)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'But_visib
        '
        Me.But_visib.BackColor = System.Drawing.Color.White
        Me.But_visib.BackgroundImage = CType(resources.GetObject("But_visib.BackgroundImage"), System.Drawing.Image)
        Me.But_visib.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_visib.ForeColor = System.Drawing.Color.SteelBlue
        Me.But_visib.Location = New System.Drawing.Point(281, 40)
        Me.But_visib.Name = "But_visib"
        Me.But_visib.Size = New System.Drawing.Size(30, 21)
        Me.But_visib.TabIndex = 15
        Me.But_visib.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(55, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mot de pass"
        '
        'Txt_Pass
        '
        Me.Txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Pass.Location = New System.Drawing.Point(168, 40)
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pass.Size = New System.Drawing.Size(143, 20)
        Me.Txt_Pass.TabIndex = 13
        '
        'Txt_Nutili
        '
        Me.Txt_Nutili.Location = New System.Drawing.Point(168, 6)
        Me.Txt_Nutili.Name = "Txt_Nutili"
        Me.Txt_Nutili.Size = New System.Drawing.Size(143, 20)
        Me.Txt_Nutili.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nom d'utilisateur"
        '
        'But_Fermer
        '
        Me.But_Fermer.BackColor = System.Drawing.Color.White
        Me.But_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Fermer.ForeColor = System.Drawing.Color.SteelBlue
        Me.But_Fermer.Location = New System.Drawing.Point(184, 299)
        Me.But_Fermer.Name = "But_Fermer"
        Me.But_Fermer.Size = New System.Drawing.Size(146, 30)
        Me.But_Fermer.TabIndex = 9
        Me.But_Fermer.Text = "FERMER"
        Me.But_Fermer.UseVisualStyleBackColor = False
        '
        'But_conn
        '
        Me.But_conn.BackColor = System.Drawing.Color.Transparent
        Me.But_conn.BackgroundImage = CType(resources.GetObject("But_conn.BackgroundImage"), System.Drawing.Image)
        Me.But_conn.Location = New System.Drawing.Point(20, 299)
        Me.But_conn.Name = "But_conn"
        Me.But_conn.Size = New System.Drawing.Size(148, 30)
        Me.But_conn.TabIndex = 7
        Me.But_conn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(120, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBox3.Controls.Add(Me.Lab_LgGnrl)
        Me.GroupBox3.Location = New System.Drawing.Point(0, -1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 62)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Lab_LgGnrl
        '
        Me.Lab_LgGnrl.AutoSize = True
        Me.Lab_LgGnrl.Font = New System.Drawing.Font("Forte", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_LgGnrl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lab_LgGnrl.Location = New System.Drawing.Point(38, 16)
        Me.Lab_LgGnrl.Name = "Lab_LgGnrl"
        Me.Lab_LgGnrl.Size = New System.Drawing.Size(246, 35)
        Me.Lab_LgGnrl.TabIndex = 1
        Me.Lab_LgGnrl.Text = "Cabinet Médical"
        '
        'Frm_connect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 363)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_connect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_connect"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents But_visib As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Pass As TextBox
    Friend WithEvents Txt_Nutili As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents But_Fermer As Button
    Friend WithEvents But_conn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lab_LgGnrl As Label
End Class
