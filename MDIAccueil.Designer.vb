<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIAccueil))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lab_Globale = New System.Windows.Forms.Label()
        Me.But_Md = New System.Windows.Forms.Button()
        Me.But_vnts = New System.Windows.Forms.Button()
        Me.But_Commander = New System.Windows.Forms.Button()
        Me.But_Fam = New System.Windows.Forms.Button()
        Me.But_Frnss = New System.Windows.Forms.Button()
        Me.But_clients = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lab_date = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.But_Apropos = New System.Windows.Forms.Button()
        Me.But_Admin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Patient = New System.Windows.Forms.ToolStripMenuItem()
        Me.Medicament = New System.Windows.Forms.ToolStripMenuItem()
        Me.pathologie = New System.Windows.Forms.ToolStripMenuItem()
        Me.traitemnet = New System.Windows.Forms.ToolStripMenuItem()
        Me.consultation = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 666)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1370, 30)
        Me.StatusStrip.TabIndex = 9
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(0, 25)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Century", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(311, 25)
        Me.ToolStripStatusLabel1.Text = "Gestion de cabinet médical "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Century", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Teal
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(158, 25)
        Me.ToolStripStatusLabel2.Text = "Version :  1.0.0"
        '
        'Lab_Globale
        '
        Me.Lab_Globale.AutoSize = True
        Me.Lab_Globale.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Lab_Globale.Font = New System.Drawing.Font("Century", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Globale.ForeColor = System.Drawing.Color.White
        Me.Lab_Globale.Location = New System.Drawing.Point(870, 3)
        Me.Lab_Globale.Name = "Lab_Globale"
        Me.Lab_Globale.Size = New System.Drawing.Size(496, 25)
        Me.Lab_Globale.TabIndex = 11
        Me.Lab_Globale.Text = "Gestion de Cabinet médical  - Version : 1.0.0"
        '
        'But_Md
        '
        Me.But_Md.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Md.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Md.ForeColor = System.Drawing.Color.White
        Me.But_Md.Location = New System.Drawing.Point(393, 356)
        Me.But_Md.Name = "But_Md"
        Me.But_Md.Size = New System.Drawing.Size(171, 55)
        Me.But_Md.TabIndex = 20
        Me.But_Md.Text = "Traitement"
        Me.But_Md.UseVisualStyleBackColor = False
        '
        'But_vnts
        '
        Me.But_vnts.BackColor = System.Drawing.Color.White
        Me.But_vnts.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_vnts.ForeColor = System.Drawing.Color.Teal
        Me.But_vnts.Location = New System.Drawing.Point(573, 299)
        Me.But_vnts.Name = "But_vnts"
        Me.But_vnts.Size = New System.Drawing.Size(171, 55)
        Me.But_vnts.TabIndex = 14
        Me.But_vnts.Text = "Consultation"
        Me.But_vnts.UseVisualStyleBackColor = False
        '
        'But_Commander
        '
        Me.But_Commander.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Commander.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Commander.ForeColor = System.Drawing.Color.White
        Me.But_Commander.Location = New System.Drawing.Point(754, 299)
        Me.But_Commander.Name = "But_Commander"
        Me.But_Commander.Size = New System.Drawing.Size(171, 55)
        Me.But_Commander.TabIndex = 16
        Me.But_Commander.Text = "Médicaments"
        Me.But_Commander.UseVisualStyleBackColor = False
        '
        'But_Fam
        '
        Me.But_Fam.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Fam.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Fam.ForeColor = System.Drawing.Color.White
        Me.But_Fam.Location = New System.Drawing.Point(393, 299)
        Me.But_Fam.Name = "But_Fam"
        Me.But_Fam.Size = New System.Drawing.Size(171, 55)
        Me.But_Fam.TabIndex = 21
        Me.But_Fam.Text = "Patient"
        Me.But_Fam.UseVisualStyleBackColor = False
        '
        'But_Frnss
        '
        Me.But_Frnss.BackColor = System.Drawing.Color.MediumTurquoise
        Me.But_Frnss.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Frnss.ForeColor = System.Drawing.Color.White
        Me.But_Frnss.Location = New System.Drawing.Point(753, 357)
        Me.But_Frnss.Name = "But_Frnss"
        Me.But_Frnss.Size = New System.Drawing.Size(171, 55)
        Me.But_Frnss.TabIndex = 19
        Me.But_Frnss.Text = "Pathologie"
        Me.But_Frnss.UseVisualStyleBackColor = False
        '
        'But_clients
        '
        Me.But_clients.BackColor = System.Drawing.Color.White
        Me.But_clients.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_clients.ForeColor = System.Drawing.Color.Teal
        Me.But_clients.Location = New System.Drawing.Point(572, 357)
        Me.But_clients.Name = "But_clients"
        Me.But_clients.Size = New System.Drawing.Size(171, 55)
        Me.But_clients.TabIndex = 23
        Me.But_clients.Text = "Ordonnance"
        Me.But_clients.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Lab_date)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1382, 113)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Lab_date
        '
        Me.Lab_date.AutoSize = True
        Me.Lab_date.BackColor = System.Drawing.Color.Transparent
        Me.Lab_date.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_date.ForeColor = System.Drawing.Color.Teal
        Me.Lab_date.Location = New System.Drawing.Point(79, 36)
        Me.Lab_date.Name = "Lab_date"
        Me.Lab_date.Size = New System.Drawing.Size(174, 44)
        Me.Lab_date.TabIndex = 32
        Me.Lab_date.Text = "22:22:22"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Forte", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(485, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(381, 52)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Cabinet Médical"
        '
        'But_Apropos
        '
        Me.But_Apropos.BackColor = System.Drawing.Color.White
        Me.But_Apropos.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Apropos.ForeColor = System.Drawing.Color.Teal
        Me.But_Apropos.Location = New System.Drawing.Point(934, 299)
        Me.But_Apropos.Name = "But_Apropos"
        Me.But_Apropos.Size = New System.Drawing.Size(171, 55)
        Me.But_Apropos.TabIndex = 28
        Me.But_Apropos.Text = "À Propos-Nous"
        Me.But_Apropos.UseVisualStyleBackColor = False
        '
        'But_Admin
        '
        Me.But_Admin.BackColor = System.Drawing.Color.White
        Me.But_Admin.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Admin.ForeColor = System.Drawing.Color.Teal
        Me.But_Admin.Location = New System.Drawing.Point(933, 357)
        Me.But_Admin.Name = "But_Admin"
        Me.But_Admin.Size = New System.Drawing.Size(171, 55)
        Me.But_Admin.TabIndex = 29
        Me.But_Admin.Text = "Adiministrateur"
        Me.But_Admin.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolStripMenuItem1, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1370, 31)
        Me.MenuStrip.TabIndex = 128
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.BackgroundImage = CType(resources.GetObject("FileMenu.BackgroundImage"), System.Drawing.Image)
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem})
        Me.FileMenu.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic)
        Me.FileMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(85, 27)
        Me.FileMenu.Text = "&Fichier"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(235, 28)
        Me.PrintToolStripMenuItem.Text = "&Imprimer"
        '
        'EditMenu
        '
        Me.EditMenu.BackgroundImage = CType(resources.GetObject("EditMenu.BackgroundImage"), System.Drawing.Image)
        Me.EditMenu.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic)
        Me.EditMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(88, 27)
        Me.EditMenu.Text = "&Edition"
        '
        'ViewMenu
        '
        Me.ViewMenu.BackgroundImage = CType(resources.GetObject("ViewMenu.BackgroundImage"), System.Drawing.Image)
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic)
        Me.ViewMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(105, 27)
        Me.ViewMenu.Text = "&Affichage"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.ToolBarToolStripMenuItem.Text = "&Barre d'outils"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.StatusBarToolStripMenuItem.Text = "&Barre d'état"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(77, 27)
        Me.ToolStripMenuItem1.Text = "&Outils"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(150, 28)
        Me.ToolStripMenuItem2.Text = "&Options"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.BackgroundImage = CType(resources.GetObject("ToolsMenu.BackgroundImage"), System.Drawing.Image)
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic)
        Me.ToolsMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(77, 27)
        Me.ToolsMenu.Text = "&Outils"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(150, 28)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.BackColor = System.Drawing.Color.White
        Me.WindowsMenu.BackgroundImage = CType(resources.GetObject("WindowsMenu.BackgroundImage"), System.Drawing.Image)
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Patient, Me.Medicament, Me.pathologie, Me.traitemnet, Me.consultation, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic)
        Me.WindowsMenu.ForeColor = System.Drawing.Color.White
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(101, 27)
        Me.WindowsMenu.Text = "F&enêtres"
        '
        'Patient
        '
        Me.Patient.Name = "Patient"
        Me.Patient.Size = New System.Drawing.Size(196, 28)
        Me.Patient.Text = "&Patients"
        '
        'Medicament
        '
        Me.Medicament.Name = "Medicament"
        Me.Medicament.Size = New System.Drawing.Size(196, 28)
        Me.Medicament.Text = "&Médicament"
        '
        'pathologie
        '
        Me.pathologie.Name = "pathologie"
        Me.pathologie.Size = New System.Drawing.Size(196, 28)
        Me.pathologie.Text = "Pathologie"
        '
        'traitemnet
        '
        Me.traitemnet.Name = "traitemnet"
        Me.traitemnet.Size = New System.Drawing.Size(196, 28)
        Me.traitemnet.Text = "&Traitement"
        '
        'consultation
        '
        Me.consultation.Name = "consultation"
        Me.consultation.Size = New System.Drawing.Size(196, 28)
        Me.consultation.Text = "&Consultation"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(196, 28)
        Me.CloseAllToolStripMenuItem.Text = "&Fermer tout"
        '
        'HelpMenu
        '
        Me.HelpMenu.BackgroundImage = CType(resources.GetObject("HelpMenu.BackgroundImage"), System.Drawing.Image)
        Me.HelpMenu.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpMenu.ForeColor = System.Drawing.Color.White
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(82, 27)
        Me.HelpMenu.Text = "&Admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1157, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'MDIParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1370, 696)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.But_Apropos)
        Me.Controls.Add(Me.But_Admin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.But_Fam)
        Me.Controls.Add(Me.But_Md)
        Me.Controls.Add(Me.But_vnts)
        Me.Controls.Add(Me.But_clients)
        Me.Controls.Add(Me.Lab_Globale)
        Me.Controls.Add(Me.But_Commander)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.But_Frnss)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent"
        Me.Text = "Accueil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Lab_Globale As Label
    Friend WithEvents But_Fam As Button
    Friend WithEvents But_Md As Button
    Friend WithEvents But_vnts As Button
    Friend WithEvents But_Commander As Button
    Friend WithEvents But_Frnss As Button
    Friend WithEvents But_clients As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents But_Apropos As Button
    Friend WithEvents But_Admin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label18 As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolsMenu As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsMenu As ToolStripMenuItem
    Friend WithEvents Patient As ToolStripMenuItem
    Friend WithEvents Medicament As ToolStripMenuItem
    Friend WithEvents pathologie As ToolStripMenuItem
    Friend WithEvents traitemnet As ToolStripMenuItem
    Friend WithEvents consultation As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenu As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lab_date As Label
End Class
