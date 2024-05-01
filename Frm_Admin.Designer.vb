<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Admin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Admin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Grp_Trait = New System.Windows.Forms.GroupBox()
        Me.But_Annuler2 = New System.Windows.Forms.Button()
        Me.But_Modifier = New System.Windows.Forms.Button()
        Me.But_Ajter = New System.Windows.Forms.Button()
        Me.But_Suppmer = New System.Windows.Forms.Button()
        Me.But_Enregter = New System.Windows.Forms.Button()
        Me.But_Acc = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lab_LgGnrl = New System.Windows.Forms.Label()
        Me.Grp_Patn = New System.Windows.Forms.GroupBox()
        Me.Txt_Cnfrm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_MotPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Utili = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_AdresseM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_TeleM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_EmailM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_NomM = New System.Windows.Forms.TextBox()
        Me.Txt_NumM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupeEdit = New System.Windows.Forms.GroupBox()
        Me.But_AnnulerEdit = New System.Windows.Forms.Button()
        Me.But_Editer = New System.Windows.Forms.Button()
        Me.TMedecinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CabinetDBDataSet = New GestCabinetMedical.CabinetDBDataSet()
        Me.T_MedecinTableAdapter = New GestCabinetMedical.CabinetDBDataSetTableAdapters.T_MedecinTableAdapter()
        Me.But_Suivant = New System.Windows.Forms.Button()
        Me.But_retour = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_Trait.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_Patn.SuspendLayout()
        Me.GroupeEdit.SuspendLayout()
        CType(Me.TMedecinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Grp_Trait)
        Me.GroupBox1.Controls.Add(Me.But_Acc)
        Me.GroupBox1.Location = New System.Drawing.Point(800, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 580)
        Me.GroupBox1.TabIndex = 99
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
        Me.Grp_Trait.Location = New System.Drawing.Point(11, 141)
        Me.Grp_Trait.Name = "Grp_Trait"
        Me.Grp_Trait.Size = New System.Drawing.Size(147, 172)
        Me.Grp_Trait.TabIndex = 78
        Me.Grp_Trait.TabStop = False
        '
        'But_Annuler2
        '
        Me.But_Annuler2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Annuler2.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Annuler2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Annuler2.Location = New System.Drawing.Point(7, 10)
        Me.But_Annuler2.Name = "But_Annuler2"
        Me.But_Annuler2.Size = New System.Drawing.Size(135, 34)
        Me.But_Annuler2.TabIndex = 79
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Lab_LgGnrl)
        Me.GroupBox3.Location = New System.Drawing.Point(-2, -6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(804, 93)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 20)
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
        Me.Lab_LgGnrl.Location = New System.Drawing.Point(294, 34)
        Me.Lab_LgGnrl.Name = "Lab_LgGnrl"
        Me.Lab_LgGnrl.Size = New System.Drawing.Size(246, 35)
        Me.Lab_LgGnrl.TabIndex = 1
        Me.Lab_LgGnrl.Text = "Cabinet Médical"
        '
        'Grp_Patn
        '
        Me.Grp_Patn.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Grp_Patn.Controls.Add(Me.Txt_Cnfrm)
        Me.Grp_Patn.Controls.Add(Me.Label5)
        Me.Grp_Patn.Controls.Add(Me.Txt_MotPass)
        Me.Grp_Patn.Controls.Add(Me.Label7)
        Me.Grp_Patn.Controls.Add(Me.Txt_Utili)
        Me.Grp_Patn.Controls.Add(Me.Label8)
        Me.Grp_Patn.Controls.Add(Me.Txt_AdresseM)
        Me.Grp_Patn.Controls.Add(Me.Label4)
        Me.Grp_Patn.Controls.Add(Me.Txt_TeleM)
        Me.Grp_Patn.Controls.Add(Me.Label2)
        Me.Grp_Patn.Controls.Add(Me.Txt_EmailM)
        Me.Grp_Patn.Controls.Add(Me.Label6)
        Me.Grp_Patn.Controls.Add(Me.Txt_NomM)
        Me.Grp_Patn.Controls.Add(Me.Txt_NumM)
        Me.Grp_Patn.Controls.Add(Me.Label3)
        Me.Grp_Patn.Controls.Add(Me.Label1)
        Me.Grp_Patn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Patn.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Grp_Patn.Location = New System.Drawing.Point(-4, 132)
        Me.Grp_Patn.Name = "Grp_Patn"
        Me.Grp_Patn.Size = New System.Drawing.Size(806, 169)
        Me.Grp_Patn.TabIndex = 100
        Me.Grp_Patn.TabStop = False
        Me.Grp_Patn.Text = "Ajouter nouveau patient"
        '
        'Txt_Cnfrm
        '
        Me.Txt_Cnfrm.BackColor = System.Drawing.Color.White
        Me.Txt_Cnfrm.Location = New System.Drawing.Point(599, 124)
        Me.Txt_Cnfrm.Name = "Txt_Cnfrm"
        Me.Txt_Cnfrm.Size = New System.Drawing.Size(157, 22)
        Me.Txt_Cnfrm.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Honeydew
        Me.Label5.Location = New System.Drawing.Point(392, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 22)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "ConfirmerMotPass"
        '
        'Txt_MotPass
        '
        Me.Txt_MotPass.BackColor = System.Drawing.Color.White
        Me.Txt_MotPass.Location = New System.Drawing.Point(599, 91)
        Me.Txt_MotPass.Name = "Txt_MotPass"
        Me.Txt_MotPass.ReadOnly = True
        Me.Txt_MotPass.Size = New System.Drawing.Size(157, 22)
        Me.Txt_MotPass.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Honeydew
        Me.Label7.Location = New System.Drawing.Point(395, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 22)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Mot de Pass"
        '
        'Txt_Utili
        '
        Me.Txt_Utili.BackColor = System.Drawing.Color.White
        Me.Txt_Utili.Location = New System.Drawing.Point(599, 54)
        Me.Txt_Utili.Name = "Txt_Utili"
        Me.Txt_Utili.ReadOnly = True
        Me.Txt_Utili.Size = New System.Drawing.Size(157, 22)
        Me.Txt_Utili.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Honeydew
        Me.Label8.Location = New System.Drawing.Point(402, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 22)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Utilisateur"
        '
        'Txt_AdresseM
        '
        Me.Txt_AdresseM.BackColor = System.Drawing.Color.White
        Me.Txt_AdresseM.Location = New System.Drawing.Point(599, 18)
        Me.Txt_AdresseM.Name = "Txt_AdresseM"
        Me.Txt_AdresseM.ReadOnly = True
        Me.Txt_AdresseM.Size = New System.Drawing.Size(157, 22)
        Me.Txt_AdresseM.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Honeydew
        Me.Label4.Location = New System.Drawing.Point(402, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 22)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Adresse"
        '
        'Txt_TeleM
        '
        Me.Txt_TeleM.BackColor = System.Drawing.Color.White
        Me.Txt_TeleM.Location = New System.Drawing.Point(176, 119)
        Me.Txt_TeleM.Name = "Txt_TeleM"
        Me.Txt_TeleM.ReadOnly = True
        Me.Txt_TeleM.Size = New System.Drawing.Size(157, 22)
        Me.Txt_TeleM.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 22)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Telephone"
        '
        'Txt_EmailM
        '
        Me.Txt_EmailM.BackColor = System.Drawing.Color.White
        Me.Txt_EmailM.Location = New System.Drawing.Point(175, 86)
        Me.Txt_EmailM.Name = "Txt_EmailM"
        Me.Txt_EmailM.ReadOnly = True
        Me.Txt_EmailM.Size = New System.Drawing.Size(157, 22)
        Me.Txt_EmailM.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 22)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Email"
        '
        'Txt_NomM
        '
        Me.Txt_NomM.BackColor = System.Drawing.Color.White
        Me.Txt_NomM.Location = New System.Drawing.Point(175, 54)
        Me.Txt_NomM.Name = "Txt_NomM"
        Me.Txt_NomM.ReadOnly = True
        Me.Txt_NomM.Size = New System.Drawing.Size(157, 22)
        Me.Txt_NomM.TabIndex = 90
        '
        'Txt_NumM
        '
        Me.Txt_NumM.BackColor = System.Drawing.Color.White
        Me.Txt_NumM.Location = New System.Drawing.Point(175, 19)
        Me.Txt_NumM.Name = "Txt_NumM"
        Me.Txt_NumM.ReadOnly = True
        Me.Txt_NumM.Size = New System.Drawing.Size(43, 22)
        Me.Txt_NumM.TabIndex = 89
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Honeydew
        Me.Label3.Location = New System.Drawing.Point(8, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 22)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Nom et prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 22)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "N°"
        '
        'GroupeEdit
        '
        Me.GroupeEdit.BackColor = System.Drawing.Color.Transparent
        Me.GroupeEdit.Controls.Add(Me.But_AnnulerEdit)
        Me.GroupeEdit.Controls.Add(Me.But_Editer)
        Me.GroupeEdit.Location = New System.Drawing.Point(225, 292)
        Me.GroupeEdit.Name = "GroupeEdit"
        Me.GroupeEdit.Size = New System.Drawing.Size(289, 45)
        Me.GroupeEdit.TabIndex = 101
        Me.GroupeEdit.TabStop = False
        Me.GroupeEdit.Visible = False
        '
        'But_AnnulerEdit
        '
        Me.But_AnnulerEdit.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_AnnulerEdit.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_AnnulerEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_AnnulerEdit.Location = New System.Drawing.Point(145, 9)
        Me.But_AnnulerEdit.Name = "But_AnnulerEdit"
        Me.But_AnnulerEdit.Size = New System.Drawing.Size(138, 34)
        Me.But_AnnulerEdit.TabIndex = 4
        Me.But_AnnulerEdit.Text = "Annuler"
        Me.But_AnnulerEdit.UseVisualStyleBackColor = False
        '
        'But_Editer
        '
        Me.But_Editer.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_Editer.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Editer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Editer.Location = New System.Drawing.Point(5, 9)
        Me.But_Editer.Name = "But_Editer"
        Me.But_Editer.Size = New System.Drawing.Size(140, 34)
        Me.But_Editer.TabIndex = 3
        Me.But_Editer.Text = "Editer"
        Me.But_Editer.UseVisualStyleBackColor = False
        '
        'TMedecinBindingSource
        '
        Me.TMedecinBindingSource.DataMember = "T_Medecin"
        Me.TMedecinBindingSource.DataSource = Me.CabinetDBDataSet
        '
        'CabinetDBDataSet
        '
        Me.CabinetDBDataSet.DataSetName = "CabinetDBDataSet"
        Me.CabinetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_MedecinTableAdapter
        '
        Me.T_MedecinTableAdapter.ClearBeforeFill = True
        '
        'But_Suivant
        '
        Me.But_Suivant.BackColor = System.Drawing.Color.Fuchsia
        Me.But_Suivant.BackgroundImage = CType(resources.GetObject("But_Suivant.BackgroundImage"), System.Drawing.Image)
        Me.But_Suivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Suivant.Location = New System.Drawing.Point(418, 341)
        Me.But_Suivant.Name = "But_Suivant"
        Me.But_Suivant.Size = New System.Drawing.Size(44, 37)
        Me.But_Suivant.TabIndex = 106
        Me.But_Suivant.UseVisualStyleBackColor = False
        '
        'But_retour
        '
        Me.But_retour.BackColor = System.Drawing.Color.Fuchsia
        Me.But_retour.BackgroundImage = CType(resources.GetObject("But_retour.BackgroundImage"), System.Drawing.Image)
        Me.But_retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_retour.Location = New System.Drawing.Point(267, 341)
        Me.But_retour.Name = "But_retour"
        Me.But_retour.Size = New System.Drawing.Size(44, 37)
        Me.But_retour.TabIndex = 107
        Me.But_retour.UseVisualStyleBackColor = False
        '
        'Frm_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(967, 502)
        Me.Controls.Add(Me.But_Suivant)
        Me.Controls.Add(Me.But_retour)
        Me.Controls.Add(Me.Grp_Patn)
        Me.Controls.Add(Me.GroupeEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.Name = "Frm_Admin"
        Me.Text = "Frm_Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.Grp_Trait.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_Patn.ResumeLayout(False)
        Me.Grp_Patn.PerformLayout()
        Me.GroupeEdit.ResumeLayout(False)
        CType(Me.TMedecinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents But_Acc As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lab_LgGnrl As Label
    Friend WithEvents Grp_Patn As GroupBox
    Friend WithEvents Txt_EmailM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_NomM As TextBox
    Friend WithEvents Txt_NumM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupeEdit As GroupBox
    Friend WithEvents But_AnnulerEdit As Button
    Friend WithEvents But_Editer As Button
    Friend WithEvents CabinetDBDataSet As CabinetDBDataSet
    Friend WithEvents TMedecinBindingSource As BindingSource
    Friend WithEvents T_MedecinTableAdapter As CabinetDBDataSetTableAdapters.T_MedecinTableAdapter
    Friend WithEvents Txt_TeleM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_AdresseM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Cnfrm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_MotPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Utili As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents But_Suivant As Button
    Friend WithEvents But_retour As Button
    Friend WithEvents Grp_Trait As GroupBox
    Friend WithEvents But_Modifier As Button
    Friend WithEvents But_Ajter As Button
    Friend WithEvents But_Suppmer As Button
    Friend WithEvents But_Enregter As Button
    Friend WithEvents But_Annuler2 As Button
End Class
