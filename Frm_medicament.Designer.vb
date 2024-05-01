<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_medicament
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_medicament))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gp = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lab_LgGnrl = New System.Windows.Forms.Label()
        Me.Grp = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodeMedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleMedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMedicamentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CabinetDBDataSet = New GestCabinetMedical.CabinetDBDataSet()
        Me.But_Suivant = New System.Windows.Forms.Button()
        Me.Txt_Code = New System.Windows.Forms.TextBox()
        Me.But_retour = New System.Windows.Forms.Button()
        Me.Txt_Libelle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupeEdit = New System.Windows.Forms.GroupBox()
        Me.But_AnnulerEdit = New System.Windows.Forms.Button()
        Me.But_Editer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Grp_Trait = New System.Windows.Forms.GroupBox()
        Me.But_Modifier = New System.Windows.Forms.Button()
        Me.But_Ajter = New System.Windows.Forms.Button()
        Me.But_Suppmer = New System.Windows.Forms.Button()
        Me.But_Enregter = New System.Windows.Forms.Button()
        Me.But_acc = New System.Windows.Forms.Button()
        Me.T_MedicamentTableAdapter = New GestCabinetMedical.CabinetDBDataSetTableAdapters.T_MedicamentTableAdapter()
        Me.Gp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMedicamentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupeEdit.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_Trait.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gp
        '
        Me.Gp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Gp.Controls.Add(Me.PictureBox1)
        Me.Gp.Controls.Add(Me.Lab_LgGnrl)
        Me.Gp.Location = New System.Drawing.Point(-1, -7)
        Me.Gp.Name = "Gp"
        Me.Gp.Size = New System.Drawing.Size(502, 92)
        Me.Gp.TabIndex = 99
        Me.Gp.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 19)
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
        Me.Lab_LgGnrl.Location = New System.Drawing.Point(168, 38)
        Me.Lab_LgGnrl.Name = "Lab_LgGnrl"
        Me.Lab_LgGnrl.Size = New System.Drawing.Size(246, 35)
        Me.Lab_LgGnrl.TabIndex = 2
        Me.Lab_LgGnrl.Text = "Cabinet Médical"
        '
        'Grp
        '
        Me.Grp.BackColor = System.Drawing.Color.MintCream
        Me.Grp.BackgroundImage = CType(resources.GetObject("Grp.BackgroundImage"), System.Drawing.Image)
        Me.Grp.Controls.Add(Me.DataGridView1)
        Me.Grp.Controls.Add(Me.But_Suivant)
        Me.Grp.Controls.Add(Me.Txt_Code)
        Me.Grp.Controls.Add(Me.But_retour)
        Me.Grp.Controls.Add(Me.Txt_Libelle)
        Me.Grp.Controls.Add(Me.Label1)
        Me.Grp.Controls.Add(Me.Label3)
        Me.Grp.Controls.Add(Me.GroupeEdit)
        Me.Grp.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Grp.Location = New System.Drawing.Point(-1, 75)
        Me.Grp.Name = "Grp"
        Me.Grp.Size = New System.Drawing.Size(502, 339)
        Me.Grp.TabIndex = 98
        Me.Grp.TabStop = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeMedDataGridViewTextBoxColumn, Me.LibelleMedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TMedicamentBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(43, 173)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(398, 166)
        Me.DataGridView1.TabIndex = 110
        '
        'CodeMedDataGridViewTextBoxColumn
        '
        Me.CodeMedDataGridViewTextBoxColumn.DataPropertyName = "Code_Med"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.CodeMedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CodeMedDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeMedDataGridViewTextBoxColumn.Name = "CodeMedDataGridViewTextBoxColumn"
        Me.CodeMedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibelleMedDataGridViewTextBoxColumn
        '
        Me.LibelleMedDataGridViewTextBoxColumn.DataPropertyName = "Libelle_Med"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.LibelleMedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.LibelleMedDataGridViewTextBoxColumn.HeaderText = "Médicament"
        Me.LibelleMedDataGridViewTextBoxColumn.Name = "LibelleMedDataGridViewTextBoxColumn"
        Me.LibelleMedDataGridViewTextBoxColumn.ReadOnly = True
        Me.LibelleMedDataGridViewTextBoxColumn.Width = 260
        '
        'TMedicamentBindingSource
        '
        Me.TMedicamentBindingSource.DataMember = "T_Medicament"
        Me.TMedicamentBindingSource.DataSource = Me.CabinetDBDataSet
        '
        'CabinetDBDataSet
        '
        Me.CabinetDBDataSet.DataSetName = "CabinetDBDataSet"
        Me.CabinetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'But_Suivant
        '
        Me.But_Suivant.BackColor = System.Drawing.Color.Fuchsia
        Me.But_Suivant.BackgroundImage = CType(resources.GetObject("But_Suivant.BackgroundImage"), System.Drawing.Image)
        Me.But_Suivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Suivant.Location = New System.Drawing.Point(383, 53)
        Me.But_Suivant.Name = "But_Suivant"
        Me.But_Suivant.Size = New System.Drawing.Size(44, 37)
        Me.But_Suivant.TabIndex = 104
        Me.But_Suivant.UseVisualStyleBackColor = False
        '
        'Txt_Code
        '
        Me.Txt_Code.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Code.ForeColor = System.Drawing.Color.Teal
        Me.Txt_Code.Location = New System.Drawing.Point(202, 33)
        Me.Txt_Code.Name = "Txt_Code"
        Me.Txt_Code.ReadOnly = True
        Me.Txt_Code.Size = New System.Drawing.Size(41, 23)
        Me.Txt_Code.TabIndex = 106
        '
        'But_retour
        '
        Me.But_retour.BackColor = System.Drawing.Color.Fuchsia
        Me.But_retour.BackgroundImage = CType(resources.GetObject("But_retour.BackgroundImage"), System.Drawing.Image)
        Me.But_retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_retour.Location = New System.Drawing.Point(43, 53)
        Me.But_retour.Name = "But_retour"
        Me.But_retour.Size = New System.Drawing.Size(44, 37)
        Me.But_retour.TabIndex = 105
        Me.But_retour.UseVisualStyleBackColor = False
        '
        'Txt_Libelle
        '
        Me.Txt_Libelle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Libelle.ForeColor = System.Drawing.Color.Teal
        Me.Txt_Libelle.Location = New System.Drawing.Point(202, 67)
        Me.Txt_Libelle.Name = "Txt_Libelle"
        Me.Txt_Libelle.ReadOnly = True
        Me.Txt_Libelle.Size = New System.Drawing.Size(143, 23)
        Me.Txt_Libelle.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(115, 33)
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
        Me.Label3.ForeColor = System.Drawing.Color.Honeydew
        Me.Label3.Location = New System.Drawing.Point(115, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Libelle"
        '
        'GroupeEdit
        '
        Me.GroupeEdit.BackColor = System.Drawing.Color.Transparent
        Me.GroupeEdit.Controls.Add(Me.But_AnnulerEdit)
        Me.GroupeEdit.Controls.Add(Me.But_Editer)
        Me.GroupeEdit.Location = New System.Drawing.Point(107, 91)
        Me.GroupeEdit.Name = "GroupeEdit"
        Me.GroupeEdit.Size = New System.Drawing.Size(279, 52)
        Me.GroupeEdit.TabIndex = 95
        Me.GroupeEdit.TabStop = False
        Me.GroupeEdit.Visible = False
        '
        'But_AnnulerEdit
        '
        Me.But_AnnulerEdit.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_AnnulerEdit.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_AnnulerEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_AnnulerEdit.Location = New System.Drawing.Point(139, 12)
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
        Me.But_Editer.Location = New System.Drawing.Point(3, 11)
        Me.But_Editer.Name = "But_Editer"
        Me.But_Editer.Size = New System.Drawing.Size(135, 34)
        Me.But_Editer.TabIndex = 3
        Me.But_Editer.Text = "Editer"
        Me.But_Editer.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Grp_Trait)
        Me.GroupBox1.Controls.Add(Me.But_acc)
        Me.GroupBox1.Location = New System.Drawing.Point(500, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 424)
        Me.GroupBox1.TabIndex = 97
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
        'But_acc
        '
        Me.But_acc.BackgroundImage = CType(resources.GetObject("But_acc.BackgroundImage"), System.Drawing.Image)
        Me.But_acc.Location = New System.Drawing.Point(63, 26)
        Me.But_acc.Name = "But_acc"
        Me.But_acc.Size = New System.Drawing.Size(60, 60)
        Me.But_acc.TabIndex = 77
        Me.But_acc.UseVisualStyleBackColor = True
        '
        'T_MedicamentTableAdapter
        '
        Me.T_MedicamentTableAdapter.ClearBeforeFill = True
        '
        'Frm_medicament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 413)
        Me.Controls.Add(Me.Gp)
        Me.Controls.Add(Me.Grp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_medicament"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicament"
        Me.Gp.ResumeLayout(False)
        Me.Gp.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp.ResumeLayout(False)
        Me.Grp.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMedicamentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupeEdit.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Grp_Trait.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gp As GroupBox
    Friend WithEvents Lab_LgGnrl As Label
    Friend WithEvents Grp As GroupBox
    Friend WithEvents But_Suivant As Button
    Friend WithEvents Txt_Code As TextBox
    Friend WithEvents But_retour As Button
    Friend WithEvents Txt_Libelle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupeEdit As GroupBox
    Friend WithEvents But_AnnulerEdit As Button
    Friend WithEvents But_Editer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Grp_Trait As GroupBox
    Friend WithEvents But_Modifier As Button
    Friend WithEvents But_Ajter As Button
    Friend WithEvents But_Suppmer As Button
    Friend WithEvents But_Enregter As Button
    Friend WithEvents But_acc As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CabinetDBDataSet As CabinetDBDataSet
    Friend WithEvents TMedicamentBindingSource As BindingSource
    Friend WithEvents T_MedicamentTableAdapter As CabinetDBDataSetTableAdapters.T_MedicamentTableAdapter
    Friend WithEvents CodeMedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibelleMedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
