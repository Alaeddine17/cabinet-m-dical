<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Patient
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Patient))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Grp_recherche = New System.Windows.Forms.GroupBox()
        Me.Rad_Etat = New System.Windows.Forms.RadioButton()
        Me.Lab_rech = New System.Windows.Forms.Label()
        Me.Txt_Rch = New System.Windows.Forms.TextBox()
        Me.Rad_P = New System.Windows.Forms.RadioButton()
        Me.Rad_N = New System.Windows.Forms.RadioButton()
        Me.Rad_ID = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Grp_Trait = New System.Windows.Forms.GroupBox()
        Me.But_Annuler2 = New System.Windows.Forms.Button()
        Me.But_Modifier = New System.Windows.Forms.Button()
        Me.But_Ajter = New System.Windows.Forms.Button()
        Me.But_Suppmer = New System.Windows.Forms.Button()
        Me.But_Enregter = New System.Windows.Forms.Button()
        Me.But_Acc = New System.Windows.Forms.Button()
        Me.But_Const = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lab_LgGnrl = New System.Windows.Forms.Label()
        Me.Grp_Patn = New System.Windows.Forms.GroupBox()
        Me.Cmb_Etat = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_CIN = New System.Windows.Forms.TextBox()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Txt_Tel = New System.Windows.Forms.TextBox()
        Me.Txt_Sexe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Age = New System.Windows.Forms.TextBox()
        Me.Txt_PrenomPatn = New System.Windows.Forms.TextBox()
        Me.Txt_NomPatn = New System.Windows.Forms.TextBox()
        Me.Txt_NumPtn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupeEdit = New System.Windows.Forms.GroupBox()
        Me.But_Supp2 = New System.Windows.Forms.Button()
        Me.But_AnnulerEdit = New System.Windows.Forms.Button()
        Me.But_Editer = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumPatnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPatnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomPatnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgePatnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexePatnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatsanteptnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelPatnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailPatnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CINPatnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CabinetDBDataSet = New GestCabinetMedical.CabinetDBDataSet()
        Me.T_PatientTableAdapter = New GestCabinetMedical.CabinetDBDataSetTableAdapters.T_PatientTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Grp_recherche.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_Trait.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_Patn.SuspendLayout()
        Me.GroupeEdit.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grp_recherche
        '
        Me.Grp_recherche.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Grp_recherche.Controls.Add(Me.Rad_Etat)
        Me.Grp_recherche.Controls.Add(Me.Lab_rech)
        Me.Grp_recherche.Controls.Add(Me.Txt_Rch)
        Me.Grp_recherche.Controls.Add(Me.Rad_P)
        Me.Grp_recherche.Controls.Add(Me.Rad_N)
        Me.Grp_recherche.Controls.Add(Me.Rad_ID)
        Me.Grp_recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_recherche.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Grp_recherche.Location = New System.Drawing.Point(112, 97)
        Me.Grp_recherche.Name = "Grp_recherche"
        Me.Grp_recherche.Size = New System.Drawing.Size(631, 116)
        Me.Grp_recherche.TabIndex = 98
        Me.Grp_recherche.TabStop = False
        Me.Grp_recherche.Text = "Recherche :                                                                      " &
    "                                                                     "
        Me.Grp_recherche.Visible = False
        '
        'Rad_Etat
        '
        Me.Rad_Etat.AutoSize = True
        Me.Rad_Etat.BackColor = System.Drawing.Color.Transparent
        Me.Rad_Etat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_Etat.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Rad_Etat.Location = New System.Drawing.Point(442, 19)
        Me.Rad_Etat.Name = "Rad_Etat"
        Me.Rad_Etat.Size = New System.Drawing.Size(180, 24)
        Me.Rad_Etat.TabIndex = 81
        Me.Rad_Etat.TabStop = True
        Me.Rad_Etat.Text = "Par L'état de santé"
        Me.Rad_Etat.UseVisualStyleBackColor = False
        '
        'Lab_rech
        '
        Me.Lab_rech.AutoSize = True
        Me.Lab_rech.BackColor = System.Drawing.Color.Transparent
        Me.Lab_rech.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_rech.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Lab_rech.Location = New System.Drawing.Point(110, 73)
        Me.Lab_rech.Name = "Lab_rech"
        Me.Lab_rech.Size = New System.Drawing.Size(185, 21)
        Me.Lab_rech.TabIndex = 80
        Me.Lab_rech.Text = "Entrer le Prenom : "
        '
        'Txt_Rch
        '
        Me.Txt_Rch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Rch.Location = New System.Drawing.Point(461, 73)
        Me.Txt_Rch.Name = "Txt_Rch"
        Me.Txt_Rch.ReadOnly = True
        Me.Txt_Rch.Size = New System.Drawing.Size(146, 22)
        Me.Txt_Rch.TabIndex = 61
        '
        'Rad_P
        '
        Me.Rad_P.AutoSize = True
        Me.Rad_P.BackColor = System.Drawing.Color.Transparent
        Me.Rad_P.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_P.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Rad_P.Location = New System.Drawing.Point(294, 20)
        Me.Rad_P.Name = "Rad_P"
        Me.Rad_P.Size = New System.Drawing.Size(120, 24)
        Me.Rad_P.TabIndex = 2
        Me.Rad_P.TabStop = True
        Me.Rad_P.Text = "Par Prenom"
        Me.Rad_P.UseVisualStyleBackColor = False
        '
        'Rad_N
        '
        Me.Rad_N.AutoSize = True
        Me.Rad_N.BackColor = System.Drawing.Color.Transparent
        Me.Rad_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_N.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Rad_N.Location = New System.Drawing.Point(162, 20)
        Me.Rad_N.Name = "Rad_N"
        Me.Rad_N.Size = New System.Drawing.Size(95, 24)
        Me.Rad_N.TabIndex = 1
        Me.Rad_N.TabStop = True
        Me.Rad_N.Text = "Par Nom"
        Me.Rad_N.UseVisualStyleBackColor = False
        '
        'Rad_ID
        '
        Me.Rad_ID.AutoSize = True
        Me.Rad_ID.BackColor = System.Drawing.Color.Transparent
        Me.Rad_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_ID.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Rad_ID.Location = New System.Drawing.Point(8, 20)
        Me.Rad_ID.Name = "Rad_ID"
        Me.Rad_ID.Size = New System.Drawing.Size(121, 24)
        Me.Rad_ID.TabIndex = 0
        Me.Rad_ID.TabStop = True
        Me.Rad_ID.Text = "Par Numéro"
        Me.Rad_ID.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Grp_Trait)
        Me.GroupBox1.Controls.Add(Me.But_Acc)
        Me.GroupBox1.Location = New System.Drawing.Point(821, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 580)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        '
        'Grp_Trait
        '
        Me.Grp_Trait.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Trait.Controls.Add(Me.But_Annuler2)
        Me.Grp_Trait.Controls.Add(Me.But_Modifier)
        Me.Grp_Trait.Controls.Add(Me.But_Ajter)
        Me.Grp_Trait.Controls.Add(Me.But_Suppmer)
        Me.Grp_Trait.Controls.Add(Me.But_Enregter)
        Me.Grp_Trait.Location = New System.Drawing.Point(8, 140)
        Me.Grp_Trait.Name = "Grp_Trait"
        Me.Grp_Trait.Size = New System.Drawing.Size(147, 175)
        Me.Grp_Trait.TabIndex = 57
        Me.Grp_Trait.TabStop = False
        '
        'But_Annuler2
        '
        Me.But_Annuler2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Annuler2.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Annuler2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Annuler2.Location = New System.Drawing.Point(6, 9)
        Me.But_Annuler2.Name = "But_Annuler2"
        Me.But_Annuler2.Size = New System.Drawing.Size(135, 34)
        Me.But_Annuler2.TabIndex = 5
        Me.But_Annuler2.Text = "Annuler"
        Me.But_Annuler2.UseVisualStyleBackColor = False
        Me.But_Annuler2.Visible = False
        '
        'But_Modifier
        '
        Me.But_Modifier.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Modifier.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Modifier.Location = New System.Drawing.Point(7, 93)
        Me.But_Modifier.Name = "But_Modifier"
        Me.But_Modifier.Size = New System.Drawing.Size(135, 34)
        Me.But_Modifier.TabIndex = 28
        Me.But_Modifier.Text = "Modifier"
        Me.But_Modifier.UseVisualStyleBackColor = False
        '
        'But_Ajter
        '
        Me.But_Ajter.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Ajter.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Ajter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Ajter.Location = New System.Drawing.Point(6, 10)
        Me.But_Ajter.Name = "But_Ajter"
        Me.But_Ajter.Size = New System.Drawing.Size(135, 34)
        Me.But_Ajter.TabIndex = 0
        Me.But_Ajter.Text = "Ajouter"
        Me.But_Ajter.UseVisualStyleBackColor = False
        '
        'But_Suppmer
        '
        Me.But_Suppmer.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_Suppmer.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Suppmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Suppmer.Location = New System.Drawing.Point(6, 133)
        Me.But_Suppmer.Name = "But_Suppmer"
        Me.But_Suppmer.Size = New System.Drawing.Size(135, 34)
        Me.But_Suppmer.TabIndex = 3
        Me.But_Suppmer.Text = "Supprimer"
        Me.But_Suppmer.UseVisualStyleBackColor = False
        '
        'But_Enregter
        '
        Me.But_Enregter.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_Enregter.Enabled = False
        Me.But_Enregter.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Enregter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Enregter.Location = New System.Drawing.Point(6, 50)
        Me.But_Enregter.Name = "But_Enregter"
        Me.But_Enregter.Size = New System.Drawing.Size(135, 34)
        Me.But_Enregter.TabIndex = 2
        Me.But_Enregter.Text = "Enregistrer"
        Me.But_Enregter.UseVisualStyleBackColor = False
        '
        'But_Acc
        '
        Me.But_Acc.BackgroundImage = CType(resources.GetObject("But_Acc.BackgroundImage"), System.Drawing.Image)
        Me.But_Acc.Location = New System.Drawing.Point(49, 27)
        Me.But_Acc.Name = "But_Acc"
        Me.But_Acc.Size = New System.Drawing.Size(60, 60)
        Me.But_Acc.TabIndex = 77
        Me.But_Acc.UseVisualStyleBackColor = True
        '
        'But_Const
        '
        Me.But_Const.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Const.Font = New System.Drawing.Font("Century", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Const.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Const.Location = New System.Drawing.Point(73, 13)
        Me.But_Const.Name = "But_Const"
        Me.But_Const.Size = New System.Drawing.Size(134, 34)
        Me.But_Const.TabIndex = 99
        Me.But_Const.Text = "Consulter"
        Me.But_Const.UseVisualStyleBackColor = False
        Me.But_Const.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Lab_LgGnrl)
        Me.GroupBox3.Location = New System.Drawing.Point(-1, -7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(985, 98)
        Me.GroupBox3.TabIndex = 96
        Me.GroupBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 54)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Lab_LgGnrl
        '
        Me.Lab_LgGnrl.AutoSize = True
        Me.Lab_LgGnrl.Font = New System.Drawing.Font("Forte", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_LgGnrl.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Lab_LgGnrl.Location = New System.Drawing.Point(291, 34)
        Me.Lab_LgGnrl.Name = "Lab_LgGnrl"
        Me.Lab_LgGnrl.Size = New System.Drawing.Size(246, 35)
        Me.Lab_LgGnrl.TabIndex = 1
        Me.Lab_LgGnrl.Text = "Cabinet Médical"
        '
        'Grp_Patn
        '
        Me.Grp_Patn.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Grp_Patn.Controls.Add(Me.Cmb_Etat)
        Me.Grp_Patn.Controls.Add(Me.Label9)
        Me.Grp_Patn.Controls.Add(Me.Label8)
        Me.Grp_Patn.Controls.Add(Me.Txt_CIN)
        Me.Grp_Patn.Controls.Add(Me.Txt_Email)
        Me.Grp_Patn.Controls.Add(Me.Txt_Tel)
        Me.Grp_Patn.Controls.Add(Me.Txt_Sexe)
        Me.Grp_Patn.Controls.Add(Me.Label5)
        Me.Grp_Patn.Controls.Add(Me.Label6)
        Me.Grp_Patn.Controls.Add(Me.Label7)
        Me.Grp_Patn.Controls.Add(Me.Txt_Age)
        Me.Grp_Patn.Controls.Add(Me.Txt_PrenomPatn)
        Me.Grp_Patn.Controls.Add(Me.Txt_NomPatn)
        Me.Grp_Patn.Controls.Add(Me.Txt_NumPtn)
        Me.Grp_Patn.Controls.Add(Me.Label4)
        Me.Grp_Patn.Controls.Add(Me.Label3)
        Me.Grp_Patn.Controls.Add(Me.Label2)
        Me.Grp_Patn.Controls.Add(Me.Label1)
        Me.Grp_Patn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Patn.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Grp_Patn.Location = New System.Drawing.Point(73, 49)
        Me.Grp_Patn.Name = "Grp_Patn"
        Me.Grp_Patn.Size = New System.Drawing.Size(751, 189)
        Me.Grp_Patn.TabIndex = 94
        Me.Grp_Patn.TabStop = False
        Me.Grp_Patn.Text = "Ajouter nouveau patient"
        '
        'Cmb_Etat
        '
        Me.Cmb_Etat.FormattingEnabled = True
        Me.Cmb_Etat.Items.AddRange(New Object() {"Diabètique", "Obèsitè", "Asthmatique", "Intact"})
        Me.Cmb_Etat.Location = New System.Drawing.Point(534, 153)
        Me.Cmb_Etat.Name = "Cmb_Etat"
        Me.Cmb_Etat.Size = New System.Drawing.Size(157, 24)
        Me.Cmb_Etat.TabIndex = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Honeydew
        Me.Label9.Location = New System.Drawing.Point(266, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 22)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "état de santé du patient"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Honeydew
        Me.Label8.Location = New System.Drawing.Point(383, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 22)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "CIN"
        '
        'Txt_CIN
        '
        Me.Txt_CIN.BackColor = System.Drawing.Color.White
        Me.Txt_CIN.Location = New System.Drawing.Point(534, 120)
        Me.Txt_CIN.Name = "Txt_CIN"
        Me.Txt_CIN.ReadOnly = True
        Me.Txt_CIN.Size = New System.Drawing.Size(157, 22)
        Me.Txt_CIN.TabIndex = 99
        '
        'Txt_Email
        '
        Me.Txt_Email.BackColor = System.Drawing.Color.White
        Me.Txt_Email.Location = New System.Drawing.Point(534, 89)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.ReadOnly = True
        Me.Txt_Email.Size = New System.Drawing.Size(157, 22)
        Me.Txt_Email.TabIndex = 98
        '
        'Txt_Tel
        '
        Me.Txt_Tel.BackColor = System.Drawing.Color.White
        Me.Txt_Tel.Location = New System.Drawing.Point(534, 56)
        Me.Txt_Tel.Name = "Txt_Tel"
        Me.Txt_Tel.ReadOnly = True
        Me.Txt_Tel.Size = New System.Drawing.Size(157, 22)
        Me.Txt_Tel.TabIndex = 97
        '
        'Txt_Sexe
        '
        Me.Txt_Sexe.BackColor = System.Drawing.Color.White
        Me.Txt_Sexe.Location = New System.Drawing.Point(534, 21)
        Me.Txt_Sexe.Name = "Txt_Sexe"
        Me.Txt_Sexe.ReadOnly = True
        Me.Txt_Sexe.Size = New System.Drawing.Size(157, 22)
        Me.Txt_Sexe.TabIndex = 96
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Honeydew
        Me.Label5.Location = New System.Drawing.Point(383, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 22)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Telephone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(383, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 22)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(383, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 22)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Sexe"
        '
        'Txt_Age
        '
        Me.Txt_Age.BackColor = System.Drawing.Color.White
        Me.Txt_Age.Location = New System.Drawing.Point(162, 120)
        Me.Txt_Age.Name = "Txt_Age"
        Me.Txt_Age.ReadOnly = True
        Me.Txt_Age.Size = New System.Drawing.Size(157, 22)
        Me.Txt_Age.TabIndex = 92
        '
        'Txt_PrenomPatn
        '
        Me.Txt_PrenomPatn.BackColor = System.Drawing.Color.White
        Me.Txt_PrenomPatn.Location = New System.Drawing.Point(162, 87)
        Me.Txt_PrenomPatn.Name = "Txt_PrenomPatn"
        Me.Txt_PrenomPatn.ReadOnly = True
        Me.Txt_PrenomPatn.Size = New System.Drawing.Size(157, 22)
        Me.Txt_PrenomPatn.TabIndex = 91
        '
        'Txt_NomPatn
        '
        Me.Txt_NomPatn.BackColor = System.Drawing.Color.White
        Me.Txt_NomPatn.Location = New System.Drawing.Point(162, 52)
        Me.Txt_NomPatn.Name = "Txt_NomPatn"
        Me.Txt_NomPatn.ReadOnly = True
        Me.Txt_NomPatn.Size = New System.Drawing.Size(157, 22)
        Me.Txt_NomPatn.TabIndex = 90
        '
        'Txt_NumPtn
        '
        Me.Txt_NumPtn.BackColor = System.Drawing.Color.White
        Me.Txt_NumPtn.Location = New System.Drawing.Point(162, 20)
        Me.Txt_NumPtn.Name = "Txt_NumPtn"
        Me.Txt_NumPtn.ReadOnly = True
        Me.Txt_NumPtn.Size = New System.Drawing.Size(43, 22)
        Me.Txt_NumPtn.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Honeydew
        Me.Label4.Location = New System.Drawing.Point(11, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 22)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Honeydew
        Me.Label3.Location = New System.Drawing.Point(11, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 22)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 22)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 22)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "N°"
        '
        'GroupeEdit
        '
        Me.GroupeEdit.BackColor = System.Drawing.Color.Transparent
        Me.GroupeEdit.Controls.Add(Me.But_Supp2)
        Me.GroupeEdit.Controls.Add(Me.But_AnnulerEdit)
        Me.GroupeEdit.Controls.Add(Me.But_Editer)
        Me.GroupeEdit.Location = New System.Drawing.Point(218, 229)
        Me.GroupeEdit.Name = "GroupeEdit"
        Me.GroupeEdit.Size = New System.Drawing.Size(413, 44)
        Me.GroupeEdit.TabIndex = 95
        Me.GroupeEdit.TabStop = False
        Me.GroupeEdit.Visible = False
        '
        'But_Supp2
        '
        Me.But_Supp2.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_Supp2.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Supp2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Supp2.Location = New System.Drawing.Point(140, 7)
        Me.But_Supp2.Name = "But_Supp2"
        Me.But_Supp2.Size = New System.Drawing.Size(135, 34)
        Me.But_Supp2.TabIndex = 5
        Me.But_Supp2.Text = "Supprimer"
        Me.But_Supp2.UseVisualStyleBackColor = False
        '
        'But_AnnulerEdit
        '
        Me.But_AnnulerEdit.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_AnnulerEdit.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_AnnulerEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_AnnulerEdit.Location = New System.Drawing.Point(277, 7)
        Me.But_AnnulerEdit.Name = "But_AnnulerEdit"
        Me.But_AnnulerEdit.Size = New System.Drawing.Size(135, 34)
        Me.But_AnnulerEdit.TabIndex = 4
        Me.But_AnnulerEdit.Text = "Annuler"
        Me.But_AnnulerEdit.UseVisualStyleBackColor = False
        '
        'But_Editer
        '
        Me.But_Editer.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_Editer.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Editer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Editer.Location = New System.Drawing.Point(3, 7)
        Me.But_Editer.Name = "But_Editer"
        Me.But_Editer.Size = New System.Drawing.Size(135, 34)
        Me.But_Editer.TabIndex = 3
        Me.But_Editer.Text = "Editer"
        Me.But_Editer.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumPatnDataGridViewTextBoxColumn, Me.NomPatnDataGridViewTextBoxColumn, Me.PrenomPatnDataGridViewTextBoxColumn, Me.AgePatnDataGridViewTextBoxColumn, Me.SexePatnDataGridViewTextBoxColumn, Me.EtatsanteptnDataGridViewTextBoxColumn, Me.TelPatnDataGridViewTextBoxColumn, Me.EmailPatnDataGridViewTextBoxColumn, Me.CINPatnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TPatientBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(-41, 400)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1031, 277)
        Me.DataGridView1.TabIndex = 99
        '
        'NumPatnDataGridViewTextBoxColumn
        '
        Me.NumPatnDataGridViewTextBoxColumn.DataPropertyName = "Num_Patn"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.NumPatnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NumPatnDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.NumPatnDataGridViewTextBoxColumn.Name = "NumPatnDataGridViewTextBoxColumn"
        Me.NumPatnDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumPatnDataGridViewTextBoxColumn.Width = 60
        '
        'NomPatnDataGridViewTextBoxColumn
        '
        Me.NomPatnDataGridViewTextBoxColumn.DataPropertyName = "Nom_Patn"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.NomPatnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NomPatnDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomPatnDataGridViewTextBoxColumn.Name = "NomPatnDataGridViewTextBoxColumn"
        Me.NomPatnDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrenomPatnDataGridViewTextBoxColumn
        '
        Me.PrenomPatnDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Patn"
        Me.PrenomPatnDataGridViewTextBoxColumn.HeaderText = "Prenom"
        Me.PrenomPatnDataGridViewTextBoxColumn.Name = "PrenomPatnDataGridViewTextBoxColumn"
        Me.PrenomPatnDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrenomPatnDataGridViewTextBoxColumn.Width = 120
        '
        'AgePatnDataGridViewTextBoxColumn
        '
        Me.AgePatnDataGridViewTextBoxColumn.DataPropertyName = "Age_Patn"
        Me.AgePatnDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgePatnDataGridViewTextBoxColumn.Name = "AgePatnDataGridViewTextBoxColumn"
        Me.AgePatnDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgePatnDataGridViewTextBoxColumn.Width = 55
        '
        'SexePatnDataGridViewTextBoxColumn
        '
        Me.SexePatnDataGridViewTextBoxColumn.DataPropertyName = "Sexe_Patn"
        Me.SexePatnDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.SexePatnDataGridViewTextBoxColumn.Name = "SexePatnDataGridViewTextBoxColumn"
        Me.SexePatnDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexePatnDataGridViewTextBoxColumn.Width = 80
        '
        'EtatsanteptnDataGridViewTextBoxColumn
        '
        Me.EtatsanteptnDataGridViewTextBoxColumn.DataPropertyName = "Etat_sante_ptn"
        Me.EtatsanteptnDataGridViewTextBoxColumn.HeaderText = "Etat Santé"
        Me.EtatsanteptnDataGridViewTextBoxColumn.Name = "EtatsanteptnDataGridViewTextBoxColumn"
        Me.EtatsanteptnDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtatsanteptnDataGridViewTextBoxColumn.Width = 140
        '
        'TelPatnDataGridViewTextBoxColumn
        '
        Me.TelPatnDataGridViewTextBoxColumn.DataPropertyName = "Tel_Patn"
        Me.TelPatnDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelPatnDataGridViewTextBoxColumn.Name = "TelPatnDataGridViewTextBoxColumn"
        Me.TelPatnDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailPatnDataGridViewTextBoxColumn
        '
        Me.EmailPatnDataGridViewTextBoxColumn.DataPropertyName = "Email_Patn"
        Me.EmailPatnDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailPatnDataGridViewTextBoxColumn.Name = "EmailPatnDataGridViewTextBoxColumn"
        Me.EmailPatnDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailPatnDataGridViewTextBoxColumn.Width = 233
        '
        'CINPatnDataGridViewTextBoxColumn
        '
        Me.CINPatnDataGridViewTextBoxColumn.DataPropertyName = "CIN_Patn"
        Me.CINPatnDataGridViewTextBoxColumn.HeaderText = "CIN"
        Me.CINPatnDataGridViewTextBoxColumn.Name = "CINPatnDataGridViewTextBoxColumn"
        Me.CINPatnDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TPatientBindingSource
        '
        Me.TPatientBindingSource.DataMember = "T_Patient"
        Me.TPatientBindingSource.DataSource = Me.CabinetDBDataSet
        '
        'CabinetDBDataSet
        '
        Me.CabinetDBDataSet.DataSetName = "CabinetDBDataSet"
        Me.CabinetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_PatientTableAdapter
        '
        Me.T_PatientTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.But_Const)
        Me.GroupBox2.Controls.Add(Me.Grp_Patn)
        Me.GroupBox2.Controls.Add(Me.GroupeEdit)
        Me.GroupBox2.Controls.Add(Me.Grp_recherche)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(824, 316)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        '
        'Frm_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 673)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Frm_Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient"
        Me.Grp_recherche.ResumeLayout(False)
        Me.Grp_recherche.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Grp_Trait.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_Patn.ResumeLayout(False)
        Me.Grp_Patn.PerformLayout()
        Me.GroupeEdit.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grp_recherche As GroupBox
    Friend WithEvents Lab_rech As Label
    Friend WithEvents Txt_Rch As TextBox
    Friend WithEvents Rad_P As RadioButton
    Friend WithEvents Rad_N As RadioButton
    Friend WithEvents Rad_ID As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Grp_Trait As GroupBox
    Friend WithEvents But_Annuler2 As Button
    Friend WithEvents But_Modifier As Button
    Friend WithEvents But_Ajter As Button
    Friend WithEvents But_Suppmer As Button
    Friend WithEvents But_Enregter As Button
    Friend WithEvents But_Acc As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lab_LgGnrl As Label
    Friend WithEvents Grp_Patn As GroupBox
    Friend WithEvents Cmb_Etat As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_CIN As TextBox
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Txt_Tel As TextBox
    Friend WithEvents Txt_Sexe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Age As TextBox
    Friend WithEvents Txt_PrenomPatn As TextBox
    Friend WithEvents Txt_NomPatn As TextBox
    Friend WithEvents Txt_NumPtn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupeEdit As GroupBox
    Friend WithEvents But_AnnulerEdit As Button
    Friend WithEvents But_Editer As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CabinetDBDataSet As CabinetDBDataSet
    Friend WithEvents TPatientBindingSource As BindingSource
    Friend WithEvents T_PatientTableAdapter As CabinetDBDataSetTableAdapters.T_PatientTableAdapter
    Friend WithEvents But_Supp2 As Button
    Friend WithEvents NumPatnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomPatnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrenomPatnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgePatnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexePatnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtatsanteptnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelPatnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailPatnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CINPatnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Rad_Etat As RadioButton
    Friend WithEvents But_Const As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
