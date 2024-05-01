<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Consultation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consultation))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.But_Pat = New System.Windows.Forms.Button()
        Me.Grp_Ord = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.But_Ord = New System.Windows.Forms.Button()
        Me.Grp_Trait = New System.Windows.Forms.GroupBox()
        Me.But_Enregter = New System.Windows.Forms.Button()
        Me.But_Ajter = New System.Windows.Forms.Button()
        Me.But_acc = New System.Windows.Forms.Button()
        Me.Grp_Patn = New System.Windows.Forms.GroupBox()
        Me.But_retour = New System.Windows.Forms.Button()
        Me.But_Suivant = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_NomMede = New System.Windows.Forms.TextBox()
        Me.Txt_NumMede = New System.Windows.Forms.TextBox()
        Me.Txt_EtatSnt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_NumConst = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_NumPtn = New System.Windows.Forms.TextBox()
        Me.Txt_PrenomPatn = New System.Windows.Forms.TextBox()
        Me.Txt_NomPatn = New System.Windows.Forms.TextBox()
        Me.Cmb_Type = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Date_Const = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Prix = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Cmb_Maladie = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Test = New System.Windows.Forms.TextBox()
        Me.Lst_Descr = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_Ord.SuspendLayout()
        Me.Grp_Trait.SuspendLayout()
        Me.Grp_Patn.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(1, -14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(751, 99)
        Me.GroupBox5.TabIndex = 122
        Me.GroupBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 54)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Forte", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Label2.Location = New System.Drawing.Point(285, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cabinet Médical"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.But_Pat)
        Me.GroupBox1.Controls.Add(Me.Grp_Ord)
        Me.GroupBox1.Controls.Add(Me.Grp_Trait)
        Me.GroupBox1.Controls.Add(Me.But_acc)
        Me.GroupBox1.Location = New System.Drawing.Point(748, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 649)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        '
        'But_Pat
        '
        Me.But_Pat.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_Pat.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Pat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Pat.Location = New System.Drawing.Point(18, 250)
        Me.But_Pat.Name = "But_Pat"
        Me.But_Pat.Size = New System.Drawing.Size(135, 34)
        Me.But_Pat.TabIndex = 125
        Me.But_Pat.Text = "Patient"
        Me.But_Pat.UseVisualStyleBackColor = False
        Me.But_Pat.Visible = False
        '
        'Grp_Ord
        '
        Me.Grp_Ord.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Ord.Controls.Add(Me.Button1)
        Me.Grp_Ord.Controls.Add(Me.But_Ord)
        Me.Grp_Ord.Location = New System.Drawing.Point(17, 282)
        Me.Grp_Ord.Name = "Grp_Ord"
        Me.Grp_Ord.Size = New System.Drawing.Size(139, 85)
        Me.Grp_Ord.TabIndex = 80
        Me.Grp_Ord.TabStop = False
        Me.Grp_Ord.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Century", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 34)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "Imprimer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'But_Ord
        '
        Me.But_Ord.BackColor = System.Drawing.Color.LightSeaGreen
        Me.But_Ord.Font = New System.Drawing.Font("Century", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Ord.ForeColor = System.Drawing.Color.White
        Me.But_Ord.Location = New System.Drawing.Point(2, 9)
        Me.But_Ord.Name = "But_Ord"
        Me.But_Ord.Size = New System.Drawing.Size(135, 34)
        Me.But_Ord.TabIndex = 124
        Me.But_Ord.Text = "Ordonnance"
        Me.But_Ord.UseVisualStyleBackColor = False
        '
        'Grp_Trait
        '
        Me.Grp_Trait.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Trait.Controls.Add(Me.But_Enregter)
        Me.Grp_Trait.Controls.Add(Me.But_Ajter)
        Me.Grp_Trait.Location = New System.Drawing.Point(17, 161)
        Me.Grp_Trait.Name = "Grp_Trait"
        Me.Grp_Trait.Size = New System.Drawing.Size(139, 89)
        Me.Grp_Trait.TabIndex = 79
        Me.Grp_Trait.TabStop = False
        '
        'But_Enregter
        '
        Me.But_Enregter.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_Enregter.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Enregter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Enregter.Location = New System.Drawing.Point(2, 49)
        Me.But_Enregter.Name = "But_Enregter"
        Me.But_Enregter.Size = New System.Drawing.Size(135, 34)
        Me.But_Enregter.TabIndex = 2
        Me.But_Enregter.Text = "Enregistrer"
        Me.But_Enregter.UseVisualStyleBackColor = False
        '
        'But_Ajter
        '
        Me.But_Ajter.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Ajter.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Ajter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Ajter.Location = New System.Drawing.Point(2, 10)
        Me.But_Ajter.Name = "But_Ajter"
        Me.But_Ajter.Size = New System.Drawing.Size(135, 34)
        Me.But_Ajter.TabIndex = 0
        Me.But_Ajter.Text = "Nouveau"
        Me.But_Ajter.UseVisualStyleBackColor = False
        '
        'But_acc
        '
        Me.But_acc.BackgroundImage = CType(resources.GetObject("But_acc.BackgroundImage"), System.Drawing.Image)
        Me.But_acc.Location = New System.Drawing.Point(53, 24)
        Me.But_acc.Name = "But_acc"
        Me.But_acc.Size = New System.Drawing.Size(60, 60)
        Me.But_acc.TabIndex = 77
        Me.But_acc.UseVisualStyleBackColor = True
        '
        'Grp_Patn
        '
        Me.Grp_Patn.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Grp_Patn.Controls.Add(Me.But_retour)
        Me.Grp_Patn.Controls.Add(Me.But_Suivant)
        Me.Grp_Patn.Controls.Add(Me.GroupBox4)
        Me.Grp_Patn.Controls.Add(Me.Txt_EtatSnt)
        Me.Grp_Patn.Controls.Add(Me.Label9)
        Me.Grp_Patn.Controls.Add(Me.Label15)
        Me.Grp_Patn.Controls.Add(Me.Txt_NumConst)
        Me.Grp_Patn.Controls.Add(Me.Label3)
        Me.Grp_Patn.Controls.Add(Me.Label1)
        Me.Grp_Patn.Controls.Add(Me.Label10)
        Me.Grp_Patn.Controls.Add(Me.Txt_NumPtn)
        Me.Grp_Patn.Controls.Add(Me.Txt_PrenomPatn)
        Me.Grp_Patn.Controls.Add(Me.Txt_NomPatn)
        Me.Grp_Patn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Patn.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Grp_Patn.Location = New System.Drawing.Point(0, 83)
        Me.Grp_Patn.Name = "Grp_Patn"
        Me.Grp_Patn.Size = New System.Drawing.Size(752, 275)
        Me.Grp_Patn.TabIndex = 123
        Me.Grp_Patn.TabStop = False
        Me.Grp_Patn.Text = resources.GetString("Grp_Patn.Text")
        '
        'But_retour
        '
        Me.But_retour.BackColor = System.Drawing.Color.Fuchsia
        Me.But_retour.BackgroundImage = CType(resources.GetObject("But_retour.BackgroundImage"), System.Drawing.Image)
        Me.But_retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_retour.Location = New System.Drawing.Point(178, 230)
        Me.But_retour.Name = "But_retour"
        Me.But_retour.Size = New System.Drawing.Size(44, 37)
        Me.But_retour.TabIndex = 118
        Me.But_retour.UseVisualStyleBackColor = False
        Me.But_retour.Visible = False
        '
        'But_Suivant
        '
        Me.But_Suivant.BackColor = System.Drawing.Color.Fuchsia
        Me.But_Suivant.BackgroundImage = CType(resources.GetObject("But_Suivant.BackgroundImage"), System.Drawing.Image)
        Me.But_Suivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Suivant.Location = New System.Drawing.Point(279, 230)
        Me.But_Suivant.Name = "But_Suivant"
        Me.But_Suivant.Size = New System.Drawing.Size(44, 37)
        Me.But_Suivant.TabIndex = 117
        Me.But_Suivant.UseVisualStyleBackColor = False
        Me.But_Suivant.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Txt_NomMede)
        Me.GroupBox4.Controls.Add(Me.Txt_NumMede)
        Me.GroupBox4.Location = New System.Drawing.Point(452, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(312, 63)
        Me.GroupBox4.TabIndex = 120
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "                                                                                 " &
    "                                                                            "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(5, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 22)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "N° Medecin"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(5, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 22)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Docteur"
        '
        'Txt_NomMede
        '
        Me.Txt_NomMede.BackColor = System.Drawing.Color.White
        Me.Txt_NomMede.Enabled = False
        Me.Txt_NomMede.Location = New System.Drawing.Point(141, 36)
        Me.Txt_NomMede.Name = "Txt_NomMede"
        Me.Txt_NomMede.Size = New System.Drawing.Size(149, 22)
        Me.Txt_NomMede.TabIndex = 99
        '
        'Txt_NumMede
        '
        Me.Txt_NumMede.BackColor = System.Drawing.Color.White
        Me.Txt_NumMede.Enabled = False
        Me.Txt_NumMede.Location = New System.Drawing.Point(141, 6)
        Me.Txt_NumMede.Name = "Txt_NumMede"
        Me.Txt_NumMede.Size = New System.Drawing.Size(43, 22)
        Me.Txt_NumMede.TabIndex = 101
        '
        'Txt_EtatSnt
        '
        Me.Txt_EtatSnt.BackColor = System.Drawing.Color.White
        Me.Txt_EtatSnt.Enabled = False
        Me.Txt_EtatSnt.Location = New System.Drawing.Point(269, 192)
        Me.Txt_EtatSnt.Name = "Txt_EtatSnt"
        Me.Txt_EtatSnt.Size = New System.Drawing.Size(157, 22)
        Me.Txt_EtatSnt.TabIndex = 116
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 22)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "état de santé du patient"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(11, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(174, 22)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "N° Consultation"
        '
        'Txt_NumConst
        '
        Me.Txt_NumConst.BackColor = System.Drawing.Color.White
        Me.Txt_NumConst.Enabled = False
        Me.Txt_NumConst.Location = New System.Drawing.Point(269, 16)
        Me.Txt_NumConst.Name = "Txt_NumConst"
        Me.Txt_NumConst.Size = New System.Drawing.Size(43, 22)
        Me.Txt_NumConst.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Honeydew
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 22)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Nom de patient"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 22)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Prénom de patient"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 22)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "N° Patient"
        '
        'Txt_NumPtn
        '
        Me.Txt_NumPtn.BackColor = System.Drawing.Color.White
        Me.Txt_NumPtn.Enabled = False
        Me.Txt_NumPtn.Location = New System.Drawing.Point(269, 63)
        Me.Txt_NumPtn.Name = "Txt_NumPtn"
        Me.Txt_NumPtn.Size = New System.Drawing.Size(43, 22)
        Me.Txt_NumPtn.TabIndex = 89
        '
        'Txt_PrenomPatn
        '
        Me.Txt_PrenomPatn.BackColor = System.Drawing.Color.White
        Me.Txt_PrenomPatn.Enabled = False
        Me.Txt_PrenomPatn.Location = New System.Drawing.Point(269, 148)
        Me.Txt_PrenomPatn.Name = "Txt_PrenomPatn"
        Me.Txt_PrenomPatn.Size = New System.Drawing.Size(157, 22)
        Me.Txt_PrenomPatn.TabIndex = 91
        '
        'Txt_NomPatn
        '
        Me.Txt_NomPatn.BackColor = System.Drawing.Color.White
        Me.Txt_NomPatn.Enabled = False
        Me.Txt_NomPatn.Location = New System.Drawing.Point(269, 109)
        Me.Txt_NomPatn.Name = "Txt_NomPatn"
        Me.Txt_NomPatn.Size = New System.Drawing.Size(157, 22)
        Me.Txt_NomPatn.TabIndex = 90
        '
        'Cmb_Type
        '
        Me.Cmb_Type.FormattingEnabled = True
        Me.Cmb_Type.Items.AddRange(New Object() {"Visite", "Consultation", "Controle", "Traitement"})
        Me.Cmb_Type.Location = New System.Drawing.Point(264, 24)
        Me.Cmb_Type.Name = "Cmb_Type"
        Me.Cmb_Type.Size = New System.Drawing.Size(162, 21)
        Me.Cmb_Type.TabIndex = 108
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(445, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 21)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "MAD"
        '
        'Date_Const
        '
        Me.Date_Const.Location = New System.Drawing.Point(264, 101)
        Me.Date_Const.Name = "Date_Const"
        Me.Date_Const.Size = New System.Drawing.Size(238, 20)
        Me.Date_Const.TabIndex = 106
        '
        'Txt_Prix
        '
        Me.Txt_Prix.BackColor = System.Drawing.Color.White
        Me.Txt_Prix.Location = New System.Drawing.Point(264, 65)
        Me.Txt_Prix.Name = "Txt_Prix"
        Me.Txt_Prix.ReadOnly = True
        Me.Txt_Prix.Size = New System.Drawing.Size(162, 20)
        Me.Txt_Prix.TabIndex = 105
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(6, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(216, 22)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Prix de Consultation"
        '
        'Cmb_Maladie
        '
        Me.Cmb_Maladie.FormattingEnabled = True
        Me.Cmb_Maladie.Location = New System.Drawing.Point(264, 137)
        Me.Cmb_Maladie.Name = "Cmb_Maladie"
        Me.Cmb_Maladie.Size = New System.Drawing.Size(238, 21)
        Me.Cmb_Maladie.TabIndex = 115
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(5, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(240, 22)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "Détection des maladies"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 22)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Date de Consultation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 22)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Type de Consultation"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.Txt_Test)
        Me.GroupBox2.Controls.Add(Me.Lst_Descr)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Cmb_Type)
        Me.GroupBox2.Controls.Add(Me.Cmb_Maladie)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Txt_Prix)
        Me.GroupBox2.Controls.Add(Me.Date_Const)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 356)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(752, 281)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = resources.GetString("GroupBox2.Text")
        '
        'Txt_Test
        '
        Me.Txt_Test.BackColor = System.Drawing.Color.White
        Me.Txt_Test.Enabled = False
        Me.Txt_Test.Location = New System.Drawing.Point(775, 151)
        Me.Txt_Test.Name = "Txt_Test"
        Me.Txt_Test.Size = New System.Drawing.Size(10, 20)
        Me.Txt_Test.TabIndex = 121
        '
        'Lst_Descr
        '
        Me.Lst_Descr.BackColor = System.Drawing.Color.MintCream
        Me.Lst_Descr.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_Descr.ForeColor = System.Drawing.Color.Black
        Me.Lst_Descr.FormattingEnabled = True
        Me.Lst_Descr.ItemHeight = 16
        Me.Lst_Descr.Location = New System.Drawing.Point(264, 173)
        Me.Lst_Descr.Name = "Lst_Descr"
        Me.Lst_Descr.Size = New System.Drawing.Size(238, 52)
        Me.Lst_Descr.TabIndex = 140
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(5, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 22)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Description"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 643)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(993, 41)
        Me.DataGridView1.TabIndex = 125
        '
        'Frm_Consultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 607)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Grp_Patn)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Consultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultation"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Grp_Ord.ResumeLayout(False)
        Me.Grp_Trait.ResumeLayout(False)
        Me.Grp_Patn.ResumeLayout(False)
        Me.Grp_Patn.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents But_acc As Button
    Friend WithEvents Grp_Patn As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_PrenomPatn As TextBox
    Friend WithEvents Txt_NomPatn As TextBox
    Friend WithEvents Txt_NumPtn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Cmb_Maladie As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_Prix As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Txt_NumConst As TextBox
    Friend WithEvents Txt_NumMede As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Txt_NomMede As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Date_Const As DateTimePicker
    Friend WithEvents Cmb_Type As ComboBox
    Friend WithEvents Txt_EtatSnt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents But_Suivant As Button
    Friend WithEvents But_retour As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Grp_Trait As GroupBox
    Friend WithEvents But_Ajter As Button
    Friend WithEvents But_Enregter As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents But_Ord As Button
    Friend WithEvents Grp_Ord As GroupBox
    Friend WithEvents Lst_Descr As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Test As TextBox
    Friend WithEvents But_Pat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
