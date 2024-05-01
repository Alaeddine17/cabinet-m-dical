Imports System.Data.OleDb

Public Class Frm_Admin

    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\CabinetDB.mdb")
    Dim datapter As New OleDbDataAdapter("SELECT * FROM T_Medecin ORDER BY Num_medecin", conn)
    Dim dtset As New DataSet

    Sub loadcharge()
        Txt_NumM.Clear()
        Txt_Utili.Clear()
        Txt_TeleM.Clear()
        Txt_NumM.Clear()
        Txt_NomM.Clear()
        Txt_MotPass.Clear()
        Txt_EmailM.Clear()
        Txt_AdresseM.Clear()
        dtset.Clear()
        datapter.Fill(dtset, "T_Medecin")
        Txt_NumM.DataBindings.Add("text", dtset, "T_Medecin.Num_Medecin")
        Txt_NomM.DataBindings.Add("text", dtset, "T_Medecin.NomPrenom")
        Txt_TeleM.DataBindings.Add("text", dtset, "T_Medecin.Tel")
        Txt_AdresseM.DataBindings.Add("text", dtset, "T_medecin.Adresse")
        Txt_EmailM.DataBindings.Add("text", dtset, "T_Medecin.Email")
        Txt_Utili.DataBindings.Add("text", dtset, "T_Medecin.Utilisateur")
        Txt_MotPass.DataBindings.Add("text", dtset, "T_Medecin.MotDePass")
    End Sub

    Private Sub Frm_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcharge()

    End Sub



    Private Sub But_Suivant_Click(sender As Object, e As EventArgs) Handles But_Suivant.Click
        Me.BindingContext(dtset, "T_Medecin").Position += 1
    End Sub

    Private Sub But_retour_Click(sender As Object, e As EventArgs) Handles But_retour.Click
        Me.BindingContext(dtset, "T_Medecin").Position -= 1
    End Sub

    Private Sub But_Ajter_Click(sender As Object, e As EventArgs) Handles But_Ajter.Click

        Txt_NumM.ReadOnly = False
        Txt_NomM.ReadOnly = False
        Txt_TeleM.ReadOnly = False
        Txt_Utili.ReadOnly = False
        Txt_EmailM.ReadOnly = False
        Txt_AdresseM.ReadOnly = False
        Txt_MotPass.ReadOnly = False
        Txt_Utili.ReadOnly = False
        Txt_Utili.Clear()
        Txt_TeleM.Clear()
        Txt_NumM.Clear()
        Txt_NomM.Clear()
        Txt_MotPass.Clear()
        Txt_EmailM.Clear()
        Txt_AdresseM.Clear()
        But_Annuler2.Visible = True
        But_Enregter.Enabled = True
        Txt_NumM.Focus()
    End Sub

    Private Sub But_Modifier_Click(sender As Object, e As EventArgs) Handles But_Modifier.Click
        GroupeEdit.Visible = True
        Txt_NumM.ReadOnly = False
        Txt_NomM.ReadOnly = False
        Txt_TeleM.ReadOnly = False
        Txt_Utili.ReadOnly = False
        Txt_EmailM.ReadOnly = False
        Txt_AdresseM.ReadOnly = False
        Txt_MotPass.ReadOnly = False
        Txt_Utili.ReadOnly = False
    End Sub

    Private Sub But_AnnulerEdit_Click(sender As Object, e As EventArgs) Handles But_AnnulerEdit.Click
        GroupeEdit.Visible = False
        Txt_NumM.ReadOnly = True
        Txt_NomM.ReadOnly = True
        Txt_TeleM.ReadOnly = True
        Txt_Utili.ReadOnly = True
        Txt_EmailM.ReadOnly = True
        Txt_AdresseM.ReadOnly = True
        Txt_MotPass.ReadOnly = True
        Txt_Utili.ReadOnly = True
    End Sub

    Private Sub But_Editer_Click(sender As Object, e As EventArgs) Handles But_Editer.Click
        If (Txt_MotPass.Text <> Txt_Cnfrm.Text) Then
            MsgBox("Le mot de pass et confirmation ne correspondent pas", vbOKOnly + MsgBoxStyle.Exclamation, "attention")
            Return
        End If
        Dim id As Integer = Txt_NumM.Text
        Dim cmd As New OleDbCommand("UPDATE T_Medecin SET NomPrenom = '" & Txt_NomM.Text & "', Email = '" & Txt_EmailM.Text & "',Tel = " & Txt_TeleM.Text & " ,Adresse = '" & Txt_AdresseM.Text & "',Utilisateur = '" & Txt_Utili.Text & "',MotDePass = '" & Txt_MotPass.Text & "' WHERE Num_Medecin = " & id & "")
        cmd.Connection = conn

        conn.Open()
        cmd.ExecuteNonQuery()
        dtset.Clear()
        datapter.Fill(dtset)
        conn.Close()
        MsgBox("Admin est bien modifier", vbExclamation + vbOKOnly, "Remarque")
        But_AnnulerEdit_Click(Nothing, Nothing)
    End Sub

    Private Sub But_Enregter_Click(sender As Object, e As EventArgs) Handles But_Enregter.Click
        If (Txt_MotPass.Text <> Txt_Cnfrm.Text) Then
            MsgBox("Le mot de pass et confirmation ne correspondent pas", vbOKOnly + MsgBoxStyle.Exclamation, "attention")
            Txt_MotPass.Clear()
            Txt_Cnfrm.Clear()
            Return
        End If


        Dim cmd As New OleDbCommand
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO T_Medecin(Num_Medecin, NomPrenom, Email, Tel, Adresse, Utilisateur, MotDePass) VALUES ('" & Txt_NumM.Text & "','" & Txt_NomM.Text & "','" & Txt_EmailM.Text & "','" & Txt_TeleM.Text & "','" & Txt_AdresseM.Text & "','" & Trim(Txt_Utili.Text) & "','" & Trim(Txt_MotPass.Text) & "')"
            .Connection = conn
        End With

        conn.Open()
        cmd.ExecuteNonQuery()
        dtset.Clear()
        datapter.Fill(dtset, "T_Medecin")
        conn.Close()
        MsgBox("vous avez ajouter un nouvelle administrateur", vbInformation + vbOKOnly, "Remarque")

        But_AnnulerEdit_Click(Nothing, Nothing)
        But_Annuler2.Visible = False
    End Sub

    Private Sub But_Annuler2_Click(sender As Object, e As EventArgs) Handles But_Annuler2.Click
        Frm_Admin_Load(Nothing, Nothing)
    End Sub

    Private Sub But_Suppmer_Click(sender As Object, e As EventArgs) Handles But_Suppmer.Click
        If (MsgBox("voullez-vous vraiment supprimer cet administateur", vbInformation + vbYesNo, "attention") <> Windows.Forms.DialogResult.Yes) Then
            Return
        End If


        Dim id As Integer = Txt_NumM.Text
        Dim Cmd As New OleDbCommand("DELETE FROM T_Medecin WHERE Num_Medecin = " & id & "")
        Cmd.Connection = conn

        conn.Open()
        Cmd.ExecuteNonQuery()
        dtset.Clear()
        datapter.Fill(dtset)
        conn.Close()
        MsgBox("L'adminstateur est bien supprimer", MsgBoxStyle.Information + vbOKOnly, "Remarque")
    End Sub

End Class