<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Traitement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Traitement))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.But_acc = New System.Windows.Forms.Button()
        Me.But_Insert_trait = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Code_Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPathologieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CabinetDBDataSet = New GestCabinetMedical.CabinetDBDataSet()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Code_Med = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleMedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMedicamentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Grp_Traiter = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_CodeMed = New System.Windows.Forms.TextBox()
        Me.Lab_Code2 = New System.Windows.Forms.Label()
        Me.Lab_Med = New System.Windows.Forms.Label()
        Me.Txt_Med_Insert = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lab_Code = New System.Windows.Forms.Label()
        Me.Lab_Path = New System.Windows.Forms.Label()
        Me.Txt_CodePath = New System.Windows.Forms.TextBox()
        Me.Txt_Path_Insert = New System.Windows.Forms.TextBox()
        Me.Txt_Path_Rch = New System.Windows.Forms.TextBox()
        Me.Txt_Medi_Rch = New System.Windows.Forms.TextBox()
        Me.TTraiterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rad_med = New System.Windows.Forms.RadioButton()
        Me.Rad_path = New System.Windows.Forms.RadioButton()
        Me.T_TraiterTableAdapter = New GestCabinetMedical.CabinetDBDataSetTableAdapters.T_TraiterTableAdapter()
        Me.T_PathologieTableAdapter = New GestCabinetMedical.CabinetDBDataSetTableAdapters.T_PathologieTableAdapter()
        Me.T_MedicamentTableAdapter = New GestCabinetMedical.CabinetDBDataSetTableAdapters.T_MedicamentTableAdapter()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPathologieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMedicamentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_Traiter.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TTraiterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.But_acc)
        Me.GroupBox1.Location = New System.Drawing.Point(757, -9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 567)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        '
        'But_acc
        '
        Me.But_acc.BackgroundImage = CType(resources.GetObject("But_acc.BackgroundImage"), System.Drawing.Image)
        Me.But_acc.Location = New System.Drawing.Point(59, 24)
        Me.But_acc.Name = "But_acc"
        Me.But_acc.Size = New System.Drawing.Size(60, 60)
        Me.But_acc.TabIndex = 77
        Me.But_acc.UseVisualStyleBackColor = True
        '
        'But_Insert_trait
        '
        Me.But_Insert_trait.BackColor = System.Drawing.Color.DodgerBlue
        Me.But_Insert_trait.Enabled = False
        Me.But_Insert_trait.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Insert_trait.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_Insert_trait.Location = New System.Drawing.Point(254, 352)
        Me.But_Insert_trait.Name = "But_Insert_trait"
        Me.But_Insert_trait.Size = New System.Drawing.Size(261, 34)
        Me.But_Insert_trait.TabIndex = 123
        Me.But_Insert_trait.Text = "Affirmer le Traitement"
        Me.But_Insert_trait.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code_Path, Me.NomPathDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TPathologieBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Location = New System.Drawing.Point(-139, 178)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(520, 257)
        Me.DataGridView2.TabIndex = 112
        '
        'Code_Path
        '
        Me.Code_Path.DataPropertyName = "Code_Path"
        Me.Code_Path.HeaderText = "Code"
        Me.Code_Path.Name = "Code_Path"
        Me.Code_Path.ReadOnly = True
        '
        'NomPathDataGridViewTextBoxColumn
        '
        Me.NomPathDataGridViewTextBoxColumn.DataPropertyName = "Nom_Path"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.NomPathDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NomPathDataGridViewTextBoxColumn.HeaderText = "Pathologie"
        Me.NomPathDataGridViewTextBoxColumn.Name = "NomPathDataGridViewTextBoxColumn"
        Me.NomPathDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomPathDataGridViewTextBoxColumn.Width = 375
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
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code_Med, Me.LibelleMedDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.TMedicamentBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView3.Location = New System.Drawing.Point(-139, 177)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(528, 257)
        Me.DataGridView3.TabIndex = 113
        '
        'Code_Med
        '
        Me.Code_Med.DataPropertyName = "Code_Med"
        Me.Code_Med.HeaderText = "Code"
        Me.Code_Med.Name = "Code_Med"
        Me.Code_Med.ReadOnly = True
        '
        'LibelleMedDataGridViewTextBoxColumn
        '
        Me.LibelleMedDataGridViewTextBoxColumn.DataPropertyName = "Libelle_Med"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.LibelleMedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.LibelleMedDataGridViewTextBoxColumn.HeaderText = "Libelle Medicament"
        Me.LibelleMedDataGridViewTextBoxColumn.Name = "LibelleMedDataGridViewTextBoxColumn"
        Me.LibelleMedDataGridViewTextBoxColumn.ReadOnly = True
        Me.LibelleMedDataGridViewTextBoxColumn.Width = 390
        '
        'TMedicamentBindingSource
        '
        Me.TMedicamentBindingSource.DataMember = "T_Medicament"
        Me.TMedicamentBindingSource.DataSource = Me.CabinetDBDataSet
        '
        'Grp_Traiter
        '
        Me.Grp_Traiter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Grp_Traiter.Controls.Add(Me.But_Insert_trait)
        Me.Grp_Traiter.Controls.Add(Me.GroupBox4)
        Me.Grp_Traiter.Controls.Add(Me.GroupBox3)
        Me.Grp_Traiter.Location = New System.Drawing.Point(-37, 83)
        Me.Grp_Traiter.Name = "Grp_Traiter"
        Me.Grp_Traiter.Size = New System.Drawing.Size(796, 480)
        Me.Grp_Traiter.TabIndex = 98
        Me.Grp_Traiter.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView3)
        Me.GroupBox4.Controls.Add(Me.Txt_CodeMed)
        Me.GroupBox4.Controls.Add(Me.Lab_Code2)
        Me.GroupBox4.Controls.Add(Me.Lab_Med)
        Me.GroupBox4.Controls.Add(Me.Txt_Med_Insert)
        Me.GroupBox4.Location = New System.Drawing.Point(412, -6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(384, 352)
        Me.GroupBox4.TabIndex = 129
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Txt_CodeMed
        '
        Me.Txt_CodeMed.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_CodeMed.Enabled = False
        Me.Txt_CodeMed.Location = New System.Drawing.Point(120, 124)
        Me.Txt_CodeMed.Name = "Txt_CodeMed"
        Me.Txt_CodeMed.ReadOnly = True
        Me.Txt_CodeMed.Size = New System.Drawing.Size(34, 20)
        Me.Txt_CodeMed.TabIndex = 125
        Me.Txt_CodeMed.Visible = False
        '
        'Lab_Code2
        '
        Me.Lab_Code2.AutoSize = True
        Me.Lab_Code2.Font = New System.Drawing.Font("Century", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Code2.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Lab_Code2.Location = New System.Drawing.Point(6, 124)
        Me.Lab_Code2.Name = "Lab_Code2"
        Me.Lab_Code2.Size = New System.Drawing.Size(50, 20)
        Me.Lab_Code2.TabIndex = 126
        Me.Lab_Code2.Text = "Code"
        Me.Lab_Code2.Visible = False
        '
        'Lab_Med
        '
        Me.Lab_Med.AutoSize = True
        Me.Lab_Med.Font = New System.Drawing.Font("Century", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Med.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Lab_Med.Location = New System.Drawing.Point(6, 151)
        Me.Lab_Med.Name = "Lab_Med"
        Me.Lab_Med.Size = New System.Drawing.Size(110, 20)
        Me.Lab_Med.TabIndex = 127
        Me.Lab_Med.Text = "Medicament"
        Me.Lab_Med.Visible = False
        '
        'Txt_Med_Insert
        '
        Me.Txt_Med_Insert.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Med_Insert.Enabled = False
        Me.Txt_Med_Insert.Location = New System.Drawing.Point(120, 151)
        Me.Txt_Med_Insert.Name = "Txt_Med_Insert"
        Me.Txt_Med_Insert.ReadOnly = True
        Me.Txt_Med_Insert.Size = New System.Drawing.Size(237, 20)
        Me.Txt_Med_Insert.TabIndex = 124
        Me.Txt_Med_Insert.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lab_Code)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Controls.Add(Me.Lab_Path)
        Me.GroupBox3.Controls.Add(Me.Txt_CodePath)
        Me.GroupBox3.Controls.Add(Me.Txt_Path_Insert)
        Me.GroupBox3.Location = New System.Drawing.Point(34, -7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 353)
        Me.GroupBox3.TabIndex = 128
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Lab_Code
        '
        Me.Lab_Code.AutoSize = True
        Me.Lab_Code.Font = New System.Drawing.Font("Century", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Code.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Lab_Code.Location = New System.Drawing.Point(5, 123)
        Me.Lab_Code.Name = "Lab_Code"
        Me.Lab_Code.Size = New System.Drawing.Size(50, 20)
        Me.Lab_Code.TabIndex = 122
        Me.Lab_Code.Text = "Code"
        Me.Lab_Code.Visible = False
        '
        'Lab_Path
        '
        Me.Lab_Path.AutoSize = True
        Me.Lab_Path.Font = New System.Drawing.Font("Century", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Path.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Lab_Path.Location = New System.Drawing.Point(2, 150)
        Me.Lab_Path.Name = "Lab_Path"
        Me.Lab_Path.Size = New System.Drawing.Size(98, 20)
        Me.Lab_Path.TabIndex = 123
        Me.Lab_Path.Text = "Pathologie"
        Me.Lab_Path.Visible = False
        '
        'Txt_CodePath
        '
        Me.Txt_CodePath.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_CodePath.Enabled = False
        Me.Txt_CodePath.Location = New System.Drawing.Point(105, 125)
        Me.Txt_CodePath.Name = "Txt_CodePath"
        Me.Txt_CodePath.ReadOnly = True
        Me.Txt_CodePath.Size = New System.Drawing.Size(34, 20)
        Me.Txt_CodePath.TabIndex = 121
        Me.Txt_CodePath.Visible = False
        '
        'Txt_Path_Insert
        '
        Me.Txt_Path_Insert.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Path_Insert.Enabled = False
        Me.Txt_Path_Insert.Location = New System.Drawing.Point(105, 152)
        Me.Txt_Path_Insert.Name = "Txt_Path_Insert"
        Me.Txt_Path_Insert.ReadOnly = True
        Me.Txt_Path_Insert.Size = New System.Drawing.Size(252, 20)
        Me.Txt_Path_Insert.TabIndex = 120
        Me.Txt_Path_Insert.Visible = False
        '
        'Txt_Path_Rch
        '
        Me.Txt_Path_Rch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Path_Rch.Location = New System.Drawing.Point(41, 44)
        Me.Txt_Path_Rch.Name = "Txt_Path_Rch"
        Me.Txt_Path_Rch.Size = New System.Drawing.Size(177, 20)
        Me.Txt_Path_Rch.TabIndex = 121
        Me.Txt_Path_Rch.Visible = False
        '
        'Txt_Medi_Rch
        '
        Me.Txt_Medi_Rch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_Medi_Rch.Location = New System.Drawing.Point(481, 44)
        Me.Txt_Medi_Rch.Name = "Txt_Medi_Rch"
        Me.Txt_Medi_Rch.Size = New System.Drawing.Size(189, 20)
        Me.Txt_Medi_Rch.TabIndex = 121
        Me.Txt_Medi_Rch.Visible = False
        '
        'TTraiterBindingSource
        '
        Me.TTraiterBindingSource.DataMember = "T_Traiter"
        Me.TTraiterBindingSource.DataSource = Me.CabinetDBDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Rad_med)
        Me.GroupBox2.Controls.Add(Me.Txt_Medi_Rch)
        Me.GroupBox2.Controls.Add(Me.Txt_Path_Rch)
        Me.GroupBox2.Controls.Add(Me.Rad_path)
        Me.GroupBox2.Location = New System.Drawing.Point(-3, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(762, 75)
        Me.GroupBox2.TabIndex = 117
        Me.GroupBox2.TabStop = False
        '
        'Rad_med
        '
        Me.Rad_med.AutoSize = True
        Me.Rad_med.BackColor = System.Drawing.Color.Transparent
        Me.Rad_med.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_med.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Rad_med.Location = New System.Drawing.Point(481, 9)
        Me.Rad_med.Name = "Rad_med"
        Me.Rad_med.Size = New System.Drawing.Size(189, 24)
        Me.Rad_med.TabIndex = 125
        Me.Rad_med.TabStop = True
        Me.Rad_med.Text = "Trouver Médicament"
        Me.Rad_med.UseVisualStyleBackColor = False
        '
        'Rad_path
        '
        Me.Rad_path.AutoSize = True
        Me.Rad_path.BackColor = System.Drawing.Color.Transparent
        Me.Rad_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_path.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Rad_path.Location = New System.Drawing.Point(41, 9)
        Me.Rad_path.Name = "Rad_path"
        Me.Rad_path.Size = New System.Drawing.Size(177, 24)
        Me.Rad_path.TabIndex = 124
        Me.Rad_path.TabStop = True
        Me.Rad_path.Text = "Trouver Pathologie"
        Me.Rad_path.UseVisualStyleBackColor = False
        '
        'T_TraiterTableAdapter
        '
        Me.T_TraiterTableAdapter.ClearBeforeFill = True
        '
        'T_PathologieTableAdapter
        '
        Me.T_PathologieTableAdapter.ClearBeforeFill = True
        '
        'T_MedicamentTableAdapter
        '
        Me.T_MedicamentTableAdapter.ClearBeforeFill = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(-3, -27)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(762, 135)
        Me.GroupBox5.TabIndex = 118
        Me.GroupBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 54)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Forte", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Label2.Location = New System.Drawing.Point(282, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cabinet Médical"
        '
        'Frm_Traitement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 555)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Grp_Traiter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Traitement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Traitement"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPathologieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabinetDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMedicamentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_Traiter.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TTraiterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents But_acc As Button
    Friend WithEvents Grp_Traiter As GroupBox
    Friend WithEvents CabinetDBDataSet As CabinetDBDataSet
    Friend WithEvents TTraiterBindingSource As BindingSource
    Friend WithEvents T_TraiterTableAdapter As CabinetDBDataSetTableAdapters.T_TraiterTableAdapter
    Friend WithEvents TPathologieBindingSource As BindingSource
    Friend WithEvents T_PathologieTableAdapter As CabinetDBDataSetTableAdapters.T_PathologieTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TMedicamentBindingSource As BindingSource
    Friend WithEvents T_MedicamentTableAdapter As CabinetDBDataSetTableAdapters.T_MedicamentTableAdapter
    Friend WithEvents Txt_Path_Insert As TextBox
    Friend WithEvents Txt_Path_Rch As TextBox
    Friend WithEvents Txt_Medi_Rch As TextBox
    Friend WithEvents Txt_CodePath As TextBox
    Friend WithEvents Lab_Code As Label
    Friend WithEvents Lab_Path As Label
    Friend WithEvents Lab_Med As Label
    Friend WithEvents Lab_Code2 As Label
    Friend WithEvents Txt_CodeMed As TextBox
    Friend WithEvents Txt_Med_Insert As TextBox
    Friend WithEvents But_Insert_trait As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Rad_med As RadioButton
    Friend WithEvents Rad_path As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Code_Med As DataGridViewTextBoxColumn
    Friend WithEvents LibelleMedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Code_Path As DataGridViewTextBoxColumn
    Friend WithEvents NomPathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
