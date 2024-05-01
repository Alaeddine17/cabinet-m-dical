Imports System.Data.OleDb

Public Class Frm_medicament
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\CabinetDB.mdb")
    Dim datapter As New OleDbDataAdapter("SELECT * FROM T_Medicament ORDER BY Code_Med", conn)
    Dim dtset As New DataSet
    Sub Dataload()

        Dim datable As New DataTable
        datapter.Fill(datable)
        DataGridView1.DataSource = datable

    End Sub


    Private Sub Frm_medicaments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dataload()

        datapter.Fill(dtset, "T_Medicament")
        Txt_Code.DataBindings.Add("text", dtset, "T_Medicament.Code_Med")
        Txt_Libelle.DataBindings.Add("text", dtset, "T_Medicament.Libelle_Med")

    End Sub

    Private Sub But_Modifier_Click(sender As Object, e As EventArgs) Handles But_Modifier.Click
        GroupeEdit.Visible = True
        Txt_Code.ReadOnly = False
        Txt_Libelle.ReadOnly = False
    End Sub
    Private Sub But_Ajter_Click(sender As Object, e As EventArgs) Handles But_Ajter.Click
        DataGridView1.Enabled = False
        Txt_Code.ReadOnly = False
        Txt_Libelle.ReadOnly = False
        Txt_Code.Clear()
        Txt_Libelle.Clear()
        But_Enregter.Enabled = True
        Txt_Code.Focus()
    End Sub

    Private Sub But_Enregter_Click(sender As Object, e As EventArgs) Handles But_Enregter.Click

        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO T_Medicament (Code_Med,Libelle_Med) Values ('" & Txt_Code.Text & "','" & Txt_Libelle.Text & "')"
        cmd.Connection = conn

        conn.Open()
        cmd.ExecuteNonQuery()
        dtset.Clear()
        datapter.Fill(dtset, "T_Medicament")
        conn.Close()
        Dataload()
        MsgBox("Le nouvelle Médicament est bien Enregistrer", vbInformation + vbOKOnly, "Remarque")
        But_AnnulerEdit_Click(Nothing, Nothing)


        DataGridView1.Enabled = True
        Txt_Code.ReadOnly = True
        Txt_Libelle.ReadOnly = True
        But_Enregter.Enabled = False
    End Sub

    Private Sub But_Suppmer_Click(sender As Object, e As EventArgs) Handles But_Suppmer.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MsgBox("selectionnez dabord le Patient que vous voullez supprimer", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Return
        End If

        If (MsgBox("voullez vouz vraiment supprimer cet Médicament?", MsgBoxStyle.YesNo, "remarque") <> Windows.Forms.DialogResult.Yes) Then
            Return
        End If
        Dim id As String = Txt_Code.Text
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM T_Medicament WHERE Code_Med = '" & id & "'"
        cmd.Connection = conn
        conn.Open()
        dtset.Clear()
        datapter.Fill(dtset, "T_Medicament")
        cmd.ExecuteNonQuery()
        conn.Close()
        Dataload()
        MsgBox("C'est médicament est bien supprimer", vbInformation + vbOKOnly, "Remarque")


    End Sub

    Private Sub But_fermer_Click(sender As Object, e As EventArgs) 
        End
    End Sub


    Private Sub But_AnnulerEdit_Click(sender As Object, e As EventArgs) Handles But_AnnulerEdit.Click
        GroupeEdit.Visible = False
        Txt_Code.ReadOnly = True
        Txt_Libelle.ReadOnly = True
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Txt_Code.Text = DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_Libelle.Text = DataGridView1(1, DataGridView1.SelectedRows(0).Index).Value.ToString
    End Sub
    Private Sub But_Suivant_Click(sender As Object, e As EventArgs) Handles But_Suivant.Click
        Me.BindingContext(dtset, "T_Medicament").Position += 1
    End Sub

    Private Sub But_retour_Click(sender As Object, e As EventArgs) Handles But_retour.Click
        Me.BindingContext(dtset, "T_Medicament").Position -= 1
    End Sub

    Private Sub But_Editer_Click(sender As Object, e As EventArgs) Handles But_Editer.Click
        Dim id As String = Txt_Code.Text
        Dim cmd As New OleDbCommand("UPDATE T_Medicament SET Libelle_Med = '" & Txt_Libelle.Text & "' WHERE Code_Med = '" & id & "'", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        dtset.Clear()
        datapter.Fill(dtset, "T_Medicament")
        conn.Close()
        Dataload()
        MsgBox("Le Médicament est bien modifier", vbExclamation + vbOKOnly, "Remarque")
        But_AnnulerEdit_Click(Nothing, Nothing)
    End Sub

    Private Sub But_acc_Click(sender As Object, e As EventArgs) Handles But_acc.Click
        Me.Hide()

    End Sub
End Class