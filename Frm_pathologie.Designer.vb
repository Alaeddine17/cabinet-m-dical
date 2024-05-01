<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_pathologie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_pathologie))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gp = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lab_LgGnrl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Grp_Trait = New System.Windows.Forms.GroupBox()
        Me.But_Modifier = New System.Windows.Forms.Button()
        Me.But_Ajter = New System.Windows.Forms.Button()
        Me.But_Suppmer = New System.Windows.Forms.Button()
        Me.But_Enregter = New System.Windows.Forms.Button()
        Me.But_fermer = New System.Windows.Forms.Button()
        Me.But_acc = New System.Windows.Forms.Button()
        Me.Grp = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionPathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPathologieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CabinetDBDataSet = New GestCabinetMedical.CabinetDBDataSet()
        Me.Txt_DescPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.But_Suivant = New System.Windows.Forms.Button()
        Me.Txt_Code = New System.Windows.Forms.TextBox()
        Me.GroupeEdit = New System.Windows.Forms.GroupBox()
        Me.But_AnnulerEdit = New System.Windows.Forms.Button()
        Me.But_Editer = New System.Windows.Forms.Button()
        Me.But_retour = New System.Windows.Forms.Button()
        Me.Txt_Path = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_PathologieTableAdapter = New GestCabinetMedical.CabinetDBDataSetTableAdapters.T_PathologieTableAdapter()
        Me.Gp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_Trait.SuspendLayout()
        Me.Grp.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPathologieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupeEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gp
        '
        Me.Gp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Gp.Controls.Add(Me.PictureBox1)
        Me.Gp.Controls.Add(Me.Lab_LgGnrl)
        Me.Gp.Location = New System.Drawing.Point(-16, -6)
        Me.Gp.Name = "Gp"
        Me.Gp.Size = New System.Drawing.Size(659, 92)
        Me.Gp.TabIndex = 102
        Me.Gp.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 19)
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
        Me.Lab_LgGnrl.Location = New System.Drawing.Point(223, 34)
        Me.Lab_LgGnrl.Name = "Lab_LgGnrl"
        Me.Lab_LgGnrl.Size = New System.Drawing.Size(246, 35)
        Me.Lab_LgGnrl.TabIndex = 2
        Me.Lab_LgGnrl.Text = "Cabinet Médical"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Grp_Trait)
        Me.GroupBox1.Controls.Add(Me.But_fermer)
        Me.GroupBox1.Controls.Add(Me.But_acc)
        Me.GroupBox1.Location = New System.Drawing.Point(642, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 533)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'Grp_Trait
        '
        Me.Grp_Trait.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Trait.Controls.Add(Me.But_Modifier)
        Me.Grp_Trait.Controls.Add(Me.But_Ajter)
        Me.Grp_Trait.Controls.Add(Me.But_Suppmer)
        Me.Grp_Trait.Controls.Add(Me.But_Enregter)
        Me.Grp_Trait.Location = New System.Drawing.Point(16, 143)
        Me.Grp_Trait.Name = "Grp_Trait"
        Me.Grp_Trait.Size = New System.Drawing.Size(147, 172)
        Me.Grp_Trait.TabIndex = 57
        Me.Grp_Trait.TabStop = False
        '
        'But_Modifier
        '
        Me.But_Modifier.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Modifier.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Modifier.Location = New System.Drawing.Point(7, 92)
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
        Me.But_Suppmer.Location = New System.Drawing.Point(6, 132)
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
        Me.But_Enregter.Location = New System.Drawing.Point(6, 51)
        Me.But_Enregter.Name = "But_Enregter"
        Me.But_Enregter.Size = New System.Drawing.Size(135, 34)
        Me.But_Enregter.TabIndex = 2
        Me.But_Enregter.Text = "Enregistrer"
        Me.But_Enregter.UseVisualStyleBackColor = False
        '
        'But_fermer
        '
        Me.But_fermer.BackgroundImage = CType(resources.GetObject("But_fermer.BackgroundImage"), System.Drawing.Image)
        Me.But_fermer.Location = New System.Drawing.Point(90, 21)
        Me.But_fermer.Name = "But_fermer"
        Me.But_fermer.Size = New System.Drawing.Size(60, 60)
        Me.But_fermer.TabIndex = 78
        Me.But_fermer.UseVisualStyleBackColor = True
        '
        'But_acc
        '
        Me.But_acc.BackgroundImage = CType(resources.GetObject("But_acc.BackgroundImage"), System.Drawing.Image)
        Me.But_acc.Location = New System.Drawing.Point(24, 21)
        Me.But_acc.Name = "But_acc"
        Me.But_acc.Size = New System.Drawing.Size(60, 60)
        Me.But_acc.TabIndex = 77
        Me.But_acc.UseVisualStyleBackColor = True
        '
        'Grp
        '
        Me.Grp.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Grp.BackgroundImage = CType(resources.GetObject("Grp.BackgroundImage"), System.Drawing.Image)
        Me.Grp.Controls.Add(Me.DataGridView1)
        Me.Grp.Controls.Add(Me.Txt_DescPath)
        Me.Grp.Controls.Add(Me.Label2)
        Me.Grp.Controls.Add(Me.But_Suivant)
        Me.Grp.Controls.Add(Me.Txt_Code)
        Me.Grp.Controls.Add(Me.GroupeEdit)
        Me.Grp.Controls.Add(Me.But_retour)
        Me.Grp.Controls.Add(Me.Txt_Path)
        Me.Grp.Controls.Add(Me.Label1)
        Me.Grp.Controls.Add(Me.Label3)
        Me.Grp.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Grp.Location = New System.Drawing.Point(-10, 77)
        Me.Grp.Name = "Grp"
        Me.Grp.Size = New System.Drawing.Size(653, 453)
        Me.Grp.TabIndex = 100
        Me.Grp.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodePathDataGridViewTextBoxColumn, Me.NomPathDataGridViewTextBoxColumn, Me.DescriptionPathDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TPathologieBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 275)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(603, 187)
        Me.DataGridView1.TabIndex = 104
        '
        'CodePathDataGridViewTextBoxColumn
        '
        Me.CodePathDataGridViewTextBoxColumn.DataPropertyName = "Code_Path"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.CodePathDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CodePathDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodePathDataGridViewTextBoxColumn.Name = "CodePathDataGridViewTextBoxColumn"
        Me.CodePathDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomPathDataGridViewTextBoxColumn
        '
        Me.NomPathDataGridViewTextBoxColumn.DataPropertyName = "Nom_Path"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.NomPathDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NomPathDataGridViewTextBoxColumn.HeaderText = "Pathologie"
        Me.NomPathDataGridViewTextBoxColumn.Name = "NomPathDataGridViewTextBoxColumn"
        Me.NomPathDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomPathDataGridViewTextBoxColumn.Width = 180
        '
        'DescriptionPathDataGridViewTextBoxColumn
        '
        Me.DescriptionPathDataGridViewTextBoxColumn.DataPropertyName = "Description_Path"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DescriptionPathDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DescriptionPathDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionPathDataGridViewTextBoxColumn.Name = "DescriptionPathDataGridViewTextBoxColumn"
        Me.DescriptionPathDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionPathDataGridViewTextBoxColumn.Width = 280
        '
        'TPathologieBindingSource
        '
        Me.TPathologieBindingSource.DataMember = "T_Pathologie"
        Me.TPathologieBindingSource.DataSource = Me.CabinetDBDataSet
        '
        'CabinetDBDataSet
        '
        Me.CabinetDBDataSet.DataSetName = "CabinetDBDataSet"
        Me.CabinetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Txt_DescPath
        '
        Me.Txt_DescPath.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_DescPath.ForeColor = System.Drawing.Color.Teal
        Me.Txt_DescPath.Location = New System.Drawing.Point(289, 130)
        Me.Txt_DescPath.Multiline = True
        Me.Txt_DescPath.Name = "Txt_DescPath"
        Me.Txt_DescPath.ReadOnly = True
        Me.Txt_DescPath.Size = New System.Drawing.Size(168, 58)
        Me.Txt_DescPath.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(151, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 22)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Description"
        '
        'But_Suivant
        '
        Me.But_Suivant.BackColor = System.Drawing.Color.Fuchsia
        Me.But_Suivant.BackgroundImage = CType(resources.GetObject("But_Suivant.BackgroundImage"), System.Drawing.Image)
        Me.But_Suivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Suivant.Location = New System.Drawing.Point(475, 88)
        Me.But_Suivant.Name = "But_Suivant"
        Me.But_Suivant.Size = New System.Drawing.Size(44, 37)
        Me.But_Suivant.TabIndex = 104
        Me.But_Suivant.UseVisualStyleBackColor = False
        '
        'Txt_Code
        '
        Me.Txt_Code.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Code.ForeColor = System.Drawing.Color.Teal
        Me.Txt_Code.Location = New System.Drawing.Point(289, 55)
        Me.Txt_Code.Name = "Txt_Code"
        Me.Txt_Code.ReadOnly = True
        Me.Txt_Code.Size = New System.Drawing.Size(41, 23)
        Me.Txt_Code.TabIndex = 106
        '
        'GroupeEdit
        '
        Me.GroupeEdit.BackColor = System.Drawing.Color.Transparent
        Me.GroupeEdit.Controls.Add(Me.But_AnnulerEdit)
        Me.GroupeEdit.Controls.Add(Me.But_Editer)
        Me.GroupeEdit.Location = New System.Drawing.Point(207, 192)
        Me.GroupeEdit.Name = "GroupeEdit"
        Me.GroupeEdit.Size = New System.Drawing.Size(279, 52)
        Me.GroupeEdit.TabIndex = 103
        Me.GroupeEdit.TabStop = False
        Me.GroupeEdit.Visible = False
        '
        'But_AnnulerEdit
        '
        Me.But_AnnulerEdit.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_AnnulerEdit.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_AnnulerEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_AnnulerEdit.Location = New System.Drawing.Point(144, 13)
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
        Me.But_Editer.Location = New System.Drawing.Point(4, 13)
        Me.But_Editer.Name = "But_Editer"
        Me.But_Editer.Size = New System.Drawing.Size(135, 34)
        Me.But_Editer.TabIndex = 3
        Me.But_Editer.Text = "Editer"
        Me.But_Editer.UseVisualStyleBackColor = False
        '
        'But_retour
        '
        Me.But_retour.BackColor = System.Drawing.Color.Fuchsia
        Me.But_retour.BackgroundImage = CType(resources.GetObject("But_retour.BackgroundImage"), System.Drawing.Image)
        Me.But_retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_retour.Location = New System.Drawing.Point(100, 88)
        Me.But_retour.Name = "But_retour"
        Me.But_retour.Size = New System.Drawing.Size(44, 37)
        Me.But_retour.TabIndex = 105
        Me.But_retour.UseVisualStyleBackColor = False
        '
        'Txt_Path
        '
        Me.Txt_Path.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Path.ForeColor = System.Drawing.Color.Teal
        Me.Txt_Path.Location = New System.Drawing.Point(289, 92)
        Me.Txt_Path.Name = "Txt_Path"
        Me.Txt_Path.ReadOnly = True
        Me.Txt_Path.Size = New System.Drawing.Size(168, 23)
        Me.Txt_Path.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(155, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(150, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Pathologie"
        '
        'T_PathologieTableAdapter
        '
        Me.T_PathologieTableAdapter.ClearBeforeFill = True
        '
        'Frm_pathologie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 527)
        Me.Controls.Add(Me.Gp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grp)
        Me.Name = "Frm_pathologie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pathaologie"
        Me.Gp.ResumeLayout(False)
        Me.Gp.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Grp_Trait.ResumeLayout(False)
        Me.Grp.ResumeLayout(False)
        Me.Grp.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPathologieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupeEdit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gp As GroupBox
    Friend WithEvents Lab_LgGnrl As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Grp_Trait As GroupBox
    Friend WithEvents But_Modifier As Button
    Friend WithEvents But_Ajter As Button
    Friend WithEvents But_Suppmer As Button
    Friend WithEvents But_Enregter As Button
    Friend WithEvents But_fermer As Button
    Friend WithEvents But_acc As Button
    Friend WithEvents Grp As GroupBox
    Friend WithEvents Txt_DescPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents But_Suivant As Button
    Friend WithEvents Txt_Code As TextBox
    Friend WithEvents But_retour As Button
    Friend WithEvents Txt_Path As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupeEdit As GroupBox
    Friend WithEvents But_AnnulerEdit As Button
    Friend WithEvents But_Editer As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CabinetDBDataSet As CabinetDBDataSet
    Friend WithEvents TPathologieBindingSource As BindingSource
    Friend WithEvents T_PathologieTableAdapter As CabinetDBDataSetTableAdapters.T_PathologieTableAdapter
    Friend WithEvents CodePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomPathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionPathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
