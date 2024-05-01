Imports System.Data.OleDb
Imports System.Data

Public Class Frm_Patient
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\CabinetDB.mdb")
    Dim datapter As New OleDbDataAdapter("SELECT * FROM T_patient ORDER BY Num_Patn", conn)
    Dim datable As New DataTable

    Sub dataload()
        Dim datable As New DataTable
        datapter.Fill(datable)
        DataGridView1.DataSource = datable
    End Sub


    Private Sub But_Modifier_Click(sender As Object, e As EventArgs) Handles But_Modifier.Click
        But_Const.Visible = True
        Grp_Patn.Text = "Patient"
        If (DataGridView1.SelectedRows.Count = 0) Then
            MsgBox("Voullez vous selectionner le patient doit Modifie", vbExclamation + MsgBoxStyle.OkOnly, "Remarque")
            Return
        End If

        Txt_NumPtn.Text = DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_NomPatn.Text = DataGridView1(1, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_PrenomPatn.Text = DataGridView1(2, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_Age.Text = DataGridView1(3, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_Sexe.Text = DataGridView1(4, DataGridView1.SelectedRows(0).Index).Value.ToString
        Cmb_Etat.Text = DataGridView1(5, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_Tel.Text = DataGridView1(6, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_Email.Text = DataGridView1(7, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_CIN.Text = DataGridView1(8, DataGridView1.SelectedRows(0).Index).Value.ToString

        If (String.IsNullOrEmpty(Txt_NumPtn.Text)) Then
            MsgBox("Voullez vous selectionner le patient doit Modifie", vbExclamation + MsgBoxStyle.OkOnly, "Remarque")
            Return
        End If

        GroupeEdit.Visible = True
        Grp_recherche.Visible = False
        Grp_Patn.Visible = True
        Grp_Trait.Visible = False
        DataGridView1.Enabled = False

        Txt_NomPatn.ReadOnly = False
        Txt_Age.ReadOnly = False
        Txt_CIN.ReadOnly = False
        Txt_Email.ReadOnly = False
        Txt_PrenomPatn.ReadOnly = False
        Txt_Sexe.ReadOnly = False
        Txt_Tel.ReadOnly = False
        Txt_NumPtn.Enabled = False


    End Sub

    Private Sub But_Rechercher_Click(sender As Object, e As EventArgs)
        Grp_recherche.Visible = True
        Grp_Patn.Visible = False
        If (GroupeEdit.Visible = True) Then
            GroupeEdit.Visible = False
        End If
    End Sub

    Private Sub But_Ajter_Click(sender As Object, e As EventArgs) Handles But_Ajter.Click
        Grp_Patn.Text = "Ajouter nouveau patient"

        If (Grp_recherche.Visible = True) Then
            Grp_recherche.Visible = False
        End If
        If (Grp_Patn.Visible = False) Then
            Grp_Patn.Visible = True
        End If
        If (GroupeEdit.Visible = True) Then
            GroupeEdit.Visible = False
        End If

        If (Grp_Trait.Visible = False) Then
            Grp_Trait.Visible = True
        End If

        But_Modifier.Enabled = False
        But_Suppmer.Enabled = False
        DataGridView1.ReadOnly = True
        Txt_NumPtn.Clear()
        Txt_NomPatn.Clear()
        Txt_PrenomPatn.Clear()
        Txt_Age.Clear()
        Txt_Email.Clear()
        Txt_Sexe.Clear()
        Txt_Tel.Clear()
        Txt_CIN.Clear()
        Cmb_Etat.Text = ""

        But_Annuler2.Visible = True
        But_Enregter.Enabled = True

        Txt_NomPatn.ReadOnly = False
        Txt_Age.ReadOnly = False
        Txt_CIN.ReadOnly = False
        Txt_Email.ReadOnly = False
        Txt_PrenomPatn.ReadOnly = False
        Txt_Sexe.ReadOnly = False
        Txt_Tel.ReadOnly = False
        Txt_NumPtn.ReadOnly = False
        Txt_NumPtn.Enabled = True
        Txt_NumPtn.Focus()

    End Sub

    Private Sub Frm_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataload()
        But_Rechercher_Click(Nothing, Nothing)
        But_Annuler2.Visible = False
        But_Enregter.Enabled = False
        Txt_NumPtn.Enabled = False
        But_Modifier.Enabled = True

        But_Suppmer.Enabled = True
        Txt_Rch.Clear()
        DataGridView1.Enabled = True
    End Sub



    Private Sub But_AnnulerEdit_Click(sender As Object, e As EventArgs) Handles But_AnnulerEdit.Click
        Frm_Patient_Load(Nothing, Nothing)
        Grp_Trait.Visible = True
        DataGridView1.Enabled = True
    End Sub

    Private Sub But_Enregter_Click(sender As Object, e As EventArgs) Handles But_Enregter.Click
        If (String.IsNullOrEmpty(Txt_NumPtn.Text) OrElse String.IsNullOrEmpty(Txt_NomPatn.Text) OrElse String.IsNullOrEmpty(Txt_PrenomPatn.Text) OrElse String.IsNullOrEmpty(Txt_Age.Text) OrElse String.IsNullOrEmpty(Txt_Sexe.Text) OrElse String.IsNullOrEmpty(Txt_Email.Text) OrElse String.IsNullOrEmpty(Txt_Tel.Text) OrElse String.IsNullOrEmpty(Txt_CIN.Text)) Then
            MsgBox("Vollez vous Remplire Toute les informations !", vbInformation + vbOKOnly, "remarque")
        End If

        Dim cmd As New OleDbCommand

        With cmd
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO T_patient(Num_Patn,Nom_Patn,Prenom_Patn,Age_Patn,Sexe_Patn,Etat_sante_ptn,Tel_Patn,Email_Patn,CIN_Patn) VALUES ('" & Txt_NumPtn.Text & "','" & Txt_NomPatn.Text & "','" & Txt_PrenomPatn.Text & "'," & Txt_Age.Text & ",'" & Txt_Sexe.Text & "','" & Cmb_Etat.Text & "'," & Txt_Tel.Text & ",'" & Txt_Email.Text & "','" & Txt_CIN.Text & "')"
            .Connection = conn
        End With
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("le patient est Bien Enregistrer", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Remarque")
        But_Annuler2.Visible = False
        But_Ajter.Visible = True

        Frm_Patient_Load(Nothing, Nothing)
    End Sub

    Private Sub But_Annuler2_Click(sender As Object, e As EventArgs) Handles But_Annuler2.Click
        Frm_Patient_Load(Nothing, Nothing)
    End Sub

    Private Sub Rad_ID_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_ID.CheckedChanged
        Lab_rech.Text = "Entrer le Numéro de patient :"
        Txt_Rch.Select()
        Txt_Rch.ReadOnly = False
    End Sub

    Private Sub Rad_N_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_N.CheckedChanged
        Lab_rech.Text = "Entrer le Nom de patient :"
        Txt_Rch.Focus()
        Txt_Rch.ReadOnly = False
    End Sub

    Private Sub Rad_P_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_P.CheckedChanged
        Lab_rech.Text = "Entrer le Prénom de patient :"
        Txt_Rch.Focus()
        Txt_Rch.ReadOnly = False
    End Sub

    Private Sub Txt_Rch_TextChanged(sender As Object, e As EventArgs) Handles Txt_Rch.TextChanged
        If Rad_ID.Checked Then
            CType(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Num_Patn like '" + Txt_Rch.Text + "%'"
        ElseIf Rad_N.Checked Then
            CType(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Nom_Patn like '" + Txt_Rch.Text + "%'"
        ElseIf Rad_P.Checked Then
            CType(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Prenom_Patn like '" & Txt_Rch.Text & "%'"
        Else
            CType(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Etat_sante_Ptn like '" & Txt_Rch.Text & "%'"
        End If
    End Sub

    Private Sub But_Editer_Click(sender As Object, e As EventArgs) Handles But_Editer.Click
        Dim id As String = DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString

        If (DataGridView1.SelectedRows.Count = 0) Then
            MsgBox("veuillez selectionner le patient doit Modifier", MsgBoxStyle.Information + vbOKOnly, "attention")
            Return
        End If


        Dim Cmd As New OleDbCommand
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "UPDATE T_patient SET Num_Patn = '" & Txt_NumPtn.Text & "', Nom_Patn = '" & Txt_NomPatn.Text & "',Prenom_Patn = '" & Txt_PrenomPatn.Text & "', Age_Patn = " & Txt_Age.Text & ", Sexe_Patn = '" & Txt_Sexe.Text & "', Etat_sante_ptn = '" & Cmb_Etat.Text & "',Tel_Patn = " & Txt_Tel.Text & ", Email_Patn = '" & Txt_Email.Text & "', CIN_Patn = '" & Txt_CIN.Text & "' WHERE Num_Patn = '" & id & "'"
        Cmd.Connection = conn

        conn.Open()
        Cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Le Patient est bien modifier", vbInformation + vbOKOnly, "Remarque")


        But_AnnulerEdit_Click(Nothing, Nothing)

    End Sub

    Private Sub But_fermer_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub But_Suppmer_Click(sender As Object, e As EventArgs) Handles But_Suppmer.Click

        Dim id As String = DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString

        If (DataGridView1.SelectedRows.Count = 0) Then
            MsgBox("selectionnez dabord le Patient que vous voullez supprimer", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Return
        End If

        If (MsgBox("voullez vouz vraiment supprimer cet Patient?", MsgBoxStyle.YesNo, "remarque") <> Windows.Forms.DialogResult.Yes) Then
            Return
        End If

        Dim cmd As New OleDbCommand("DELETE FROM T_Patient WHERE Num_patn ='" & id & "'", conn)


        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        dataload()
        MsgBox("le patient est bient Supprimer", MsgBoxStyle.Information + vbOKOnly, "Remarque")





    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        'But_Enregter.Enabled = False
        But_Modifier_Click(Nothing, Nothing)
    End Sub

    Private Sub But_Supp2_Click(sender As Object, e As EventArgs) Handles But_Supp2.Click
        But_Suppmer_Click(Nothing, Nothing)

    End Sub
    Private Sub Rad_Etat_CheckedChanged_1(sender As Object, e As EventArgs) Handles Rad_Etat.CheckedChanged
        Lab_rech.Text = "Entrer l'L'état de santé de patient :"
        Txt_Rch.Focus()
        Txt_Rch.ReadOnly = False
    End Sub

    Private Sub But_Const_Click(sender As Object, e As EventArgs) Handles But_Const.Click
        Dim Cnst As New Frm_Consultation

        Cnst.NumPatn = Txt_NumPtn.Text
        Cnst.NomPatn = Txt_NomPatn.Text
        Cnst.PrenomPatn = Txt_PrenomPatn.Text
        Cnst.EtatSntPatn = Cmb_Etat.Text
        Cnst.Show()

        Frm_Patient_Load(Nothing, Nothing)
        But_Const.Visible = False

    End Sub

    Private Sub But_Acc_Click(sender As Object, e As EventArgs) Handles But_Acc.Click
        Me.Hide()

    End Sub
End Class