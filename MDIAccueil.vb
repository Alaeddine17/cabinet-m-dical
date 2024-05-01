Imports System.Windows.Forms

Public Class MDIAccueil

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        Frm_Patient.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: ajoutez le code ici pour ouvrir le fichier.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilisez My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData pour extraire les informations du Presse-papiers.
    End Sub



    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Frm_medicament.Show()
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Frm_pathologie.Show()
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Frm_Traitement.Show()
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Frm_Consultation.Show()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub HelpMenu_Click(sender As Object, e As EventArgs)
        Dim Msg As String = InputBox("Mot de pass Admin")
        If (Msg = "Admin123") Then
            Frm_Admin.Show()
        Else
            MsgBox("", vbExclamation + vbOKCancel, "attention")
        End If
    End Sub

    Private Sub But_Fam_Click(sender As Object, e As EventArgs) Handles But_Fam.Click
        Frm_Patient.Show()
    End Sub

    Private Sub But_Md_Click(sender As Object, e As EventArgs) Handles But_Md.Click
        Frm_Traitement.Show()
    End Sub

    Private Sub But_vnts_Click(sender As Object, e As EventArgs) Handles But_vnts.Click
        Frm_Consultation.Show()
    End Sub

    Private Sub But_clients_Click(sender As Object, e As EventArgs) Handles But_clients.Click
        Frm_Ordonnance.Show()
    End Sub

    Private Sub But_Commander_Click(sender As Object, e As EventArgs) Handles But_Commander.Click
        Frm_medicament.Show()
    End Sub

    Private Sub But_Frnss_Click(sender As Object, e As EventArgs) Handles But_Frnss.Click
        Frm_pathologie.Show()
    End Sub

    Private Sub Apropos_Click(sender As Object, e As EventArgs) Handles But_Apropos.Click
        FrmApropos.Show()
    End Sub

    Private Sub But_Admin_Click(sender As Object, e As EventArgs) Handles But_Admin.Click
        Dim Msg As String = InputBox("Mot de pass Admin")
        If (Msg = "Admin123") Then
            Frm_Admin.Show()
        Else
            MsgBox("", vbExclamation + vbOKCancel, "attention")
        End If
    End Sub

    Private Sub MDIParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lab_date.Text = Date.Now.ToString("hh:mm:ss")

    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Patient.Click
        Frm_Patient.Show()
    End Sub

    Private Sub Medicament_Click(sender As Object, e As EventArgs) Handles Medicament.Click
        Frm_medicament.Show()
    End Sub

    Private Sub pathologie_Click(sender As Object, e As EventArgs) Handles pathologie.Click
        Frm_pathologie.Show()
    End Sub

    Private Sub traitemnet_Click(sender As Object, e As EventArgs) Handles traitemnet.Click
        Frm_Traitement.Show()
    End Sub

    Private Sub consultation_Click(sender As Object, e As EventArgs) Handles consultation.Click
        Frm_Consultation.Show()
    End Sub
End Class
