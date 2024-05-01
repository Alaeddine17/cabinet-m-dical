Imports System.Data.OleDb
Public Class Frm_pathologie
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\CabinetDB.mdb")
    Dim datapter As New OleDbDataAdapter("SELECT * FROM T_Pathologie ORDER BY Code_Path", conn)
    Dim dtset As New DataSet

    Sub Dataload()
        Dim datable As New DataTable
        datapter.Fill(datable)
        DataGridView1.DataSource = datable
    End Sub
    Private Sub Frm_pathaologie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dataload()
        dtset.Clear()
        datapter.Fill(dtset, "T_Pathologie")
        Txt_Code.DataBindings.Add("text", dtset, "T_Pathologie.Code_Path")
        Txt_Path.DataBindings.Add("text", dtset, "T_Pathologie.Nom_Path")
        Txt_DescPath.DataBindings.Add("text", dtset, "T_Pathologie.Description_Path")
    End Sub

    Private Sub But_Enregter_Click(sender As Object, e As EventArgs) Handles But_Enregter.Click

        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO T_Pathologie (Code_Path,Nom_Path,Description_Path) Values ('" & Txt_Code.Text & "','" & Txt_Path.Text & "','" & Txt_DescPath.Text & "')"
        cmd.Connection = conn

        conn.Open()
        cmd.ExecuteNonQuery()
        dtset.Clear()
        datapter.Fill(dtset, "T_Pathologie")
        conn.Close()

        MsgBox("Le nouvelle Médicament est bien Enregistrer", vbInformation + vbOKOnly, "Remarque")
        But_AnnulerEdit_Click(Nothing, Nothing)

        Dataload()

        Txt_Code.ReadOnly = True
        Txt_Path.ReadOnly = True
        But_Enregter.Enabled = False
    End Sub

    Private Sub But_AnnulerEdit_Click(sender As Object, e As EventArgs) Handles But_AnnulerEdit.Click
        GroupeEdit.Visible = False
        Txt_Code.ReadOnly = True
        Txt_Path.ReadOnly = True
        Txt_DescPath.ReadOnly = True

    End Sub

    Private Sub But_Ajter_Click(sender As Object, e As EventArgs) Handles But_Ajter.Click
        Txt_Code.ReadOnly = False
        Txt_Path.ReadOnly = False
        Txt_DescPath.ReadOnly = False
        Txt_DescPath.Clear()
        Txt_Code.Clear()
        Txt_Path.Clear()
        But_Enregter.Enabled = True
        Txt_Code.Focus()
    End Sub

    Private Sub But_Suivant_Click(sender As Object, e As EventArgs) Handles But_Suivant.Click
        Me.BindingContext(dtset, "T_Pathologie").Position += 1
    End Sub

    Private Sub But_retour_Click(sender As Object, e As EventArgs) Handles But_retour.Click
        Me.BindingContext(dtset, "T_Pathologie").Position -= 1
    End Sub

    Private Sub But_fermer_Click(sender As Object, e As EventArgs) Handles But_fermer.Click
        End
    End Sub

    Private Sub But_Modifier_Click(sender As Object, e As EventArgs) Handles But_Modifier.Click
        GroupeEdit.Visible = True
        Txt_Code.ReadOnly = False
        Txt_Path.ReadOnly = False
        Txt_DescPath.ReadOnly = False
    End Sub

    Private Sub But_Editer_Click(sender As Object, e As EventArgs) Handles But_Editer.Click
        Dim id As String = Txt_Code.Text
        Dim cmd As New OleDbCommand("UPDATE T_Pathologie SET Nom_Path = '" & Txt_Path.Text & "',Description_Path = '" & Txt_DescPath.Text & "' WHERE Code_Path = '" & id & "'", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        dtset.Clear()
        datapter.Fill(dtset, "T_Pathologie")
        conn.Close()
        Dataload()
        MsgBox("Le Maladie est bien modifier", vbExclamation + vbOKOnly, "Remarque")
        But_AnnulerEdit_Click(Nothing, Nothing)
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Txt_Code.Text = DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_Path.Text = DataGridView1(1, DataGridView1.SelectedRows(0).Index).Value.ToString
        Txt_DescPath.Text = DataGridView1(2, DataGridView1.SelectedRows(0).Index).Value.ToString
    End Sub

    Private Sub But_Suppmer_Click(sender As Object, e As EventArgs) Handles But_Suppmer.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MsgBox("selectionnez dabord le Patient que vous voullez supprimer", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Return
        End If

        If (MsgBox("voullez vous vraiment supprimer c'est pathologie?", vbInformation + vbYesNo, "attention") <> Windows.Forms.DialogResult.Yes) Then
            Return
        End If
        Dim id As String = DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString
        Dim cmd As New OleDbCommand

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM T_Pathologie WHERE Code_Path = '" & id & "'"
        cmd.Connection = conn


        conn.Open()
        cmd.ExecuteNonQuery()
        dtset.Clear()
        datapter.Fill(dtset, "T_Pathologie")
        conn.Close()

        Dataload()
        MsgBox("C'est pathologie est bien supprimer", vbInformation + vbOKOnly, "Remarque")

    End Sub

    Private Sub But_acc_Click(sender As Object, e As EventArgs) Handles But_acc.Click
        Me.Hide()

    End Sub
End Class