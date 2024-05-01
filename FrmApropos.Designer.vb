<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApropos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApropos))
        Me.But_OK = New System.Windows.Forms.Button()
        Me.Lab_gn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'But_OK
        '
        Me.But_OK.BackColor = System.Drawing.Color.LightSeaGreen
        Me.But_OK.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_OK.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_OK.Location = New System.Drawing.Point(219, 202)
        Me.But_OK.Name = "But_OK"
        Me.But_OK.Size = New System.Drawing.Size(119, 52)
        Me.But_OK.TabIndex = 6
        Me.But_OK.Text = "OK"
        Me.But_OK.UseVisualStyleBackColor = False
        '
        'Lab_gn
        '
        Me.Lab_gn.AutoSize = True
        Me.Lab_gn.BackColor = System.Drawing.Color.Transparent
        Me.Lab_gn.Font = New System.Drawing.Font("Century", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_gn.ForeColor = System.Drawing.Color.White
        Me.Lab_gn.Location = New System.Drawing.Point(5, 138)
        Me.Lab_gn.Name = "Lab_gn"
        Me.Lab_gn.Size = New System.Drawing.Size(542, 23)
        Me.Lab_gn.TabIndex = 5
        Me.Lab_gn.Text = "Réalisé Par << Alae Eddine Elharrak - Naila serhir>>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Proje Fin d'étude En developpement Informatique 2022"
        '
        'FrmApropos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 371)
        Me.Controls.Add(Me.But_OK)
        Me.Controls.Add(Me.Lab_gn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmApropos"
        Me.Text = "À Propos-Nous"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents But_OK As Button
    Friend WithEvents Lab_gn As Label
    Friend WithEvents Label1 As Label
End Class
