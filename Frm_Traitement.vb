Imports System.Data.OleDb
Public Class Frm_Traitement
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\CabinetDB.mdb")
    Dim datapter2 As New OleDbDataAdapter("SELECT * FROM T_Pathologie ORDER BY Code_Path", conn)
    Dim datapter3 As New OleDbDataAdapter("SELECT * FROM T_Medicament ORDER BY Code_Med", conn)
    Dim reader As OleDbDataReader


    Sub dataload()
        Dim datable2 As New DataTable
        datapter2.Fill(datable2)
        DataGridView2.DataSource = datable2

        Dim datable3 As New DataTable
        datapter3.Fill(datable3)
        DataGridView3.DataSource = datable3
    End Sub


    Private Sub Frm_Traitement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataload()

    End Sub


    Private Sub Txt_Medi_Rch_TextChanged(sender As Object, e As EventArgs) Handles Txt_Medi_Rch.TextChanged

        CType(DataGridView3.DataSource, DataTable).DefaultView.RowFilter = "Libelle_Med like '" + Txt_Medi_Rch.Text + "%'"

    End Sub

    Private Sub Txt_Path_Rch_TextChanged(sender As Object, e As EventArgs) Handles Txt_Path_Rch.TextChanged

        CType(DataGridView2.DataSource, DataTable).DefaultView.RowFilter = "Nom_Path like '" + Txt_Path_Rch.Text + "%'"


    End Sub

    Private Sub But_Insert_Path_Click(sender As Object, e As EventArgs) Handles But_Insert_trait.Click
        If (String.IsNullOrEmpty(Txt_CodeMed.Text) OrElse String.IsNullOrEmpty(Txt_Med_Insert.Text) OrElse String.IsNullOrEmpty(Txt_Path_Insert.Text) OrElse String.IsNullOrEmpty(Txt_CodePath.Text)) Then
            MsgBox("Voullez vous remplire les zone de text", vbExclamation + MsgBoxStyle.OkOnly, "Remarque")
            Return
        End If
        Dim cmd As New OleDbCommand
        cmd.CommandText = "INSERT INTO T_Traiter(Code_Path,Code_Med) VALUES('" & Txt_CodePath.Text & "','" & Txt_CodeMed.Text & "')"
        cmd.Connection = conn

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Traitment Bien fait", vbInformation + vbOKOnly, "Remarque")
        dataload()
        Rad_path.Checked = False
        Rad_med.Checked = False
        Txt_Path_Rch.Visible = False
        Txt_Medi_Rch.Visible = False
        Txt_CodeMed.Clear()
        Txt_CodePath.Clear()
        Txt_Med_Insert.Clear()
        Txt_Path_Insert.Clear()


    End Sub

    Private Sub But_fermer_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Rad_path_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_path.CheckedChanged
        Txt_Path_Rch.Visible = True
        Txt_Path_Rch.Select()
        Txt_Medi_Rch.Visible = False
        Txt_Path_Rch.Clear()
    End Sub

    Private Sub Rad_med_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_med.CheckedChanged
        Txt_Medi_Rch.Visible = True
        Txt_Medi_Rch.Select()
        Txt_Path_Rch.Visible = False
        Txt_Medi_Rch.Clear()

    End Sub

    Private Sub DataGridView3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentDoubleClick
        Txt_Med_Insert.Text = DataGridView3(1, DataGridView3.SelectedRows(0).Index).Value.ToString
        Txt_CodeMed.Text = DataGridView3(0, DataGridView3.SelectedRows(0).Index).Value.ToString


        Txt_CodeMed.Visible = True
        Txt_Med_Insert.Visible = True
        Lab_Code2.Visible = True
        Lab_Med.Visible = True
        But_Insert_trait.Enabled = True
        Txt_Medi_Rch.Visible = False
        Txt_Path_Rch.Visible = False
        Rad_med.Checked = False
        Txt_Medi_Rch.Visible = False
    End Sub

    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
        Txt_Path_Insert.Text = DataGridView2(1, DataGridView2.SelectedRows(0).Index).Value.ToString
        Txt_CodePath.Text = DataGridView2(0, DataGridView2.SelectedRows(0).Index).Value.ToString


        Txt_CodePath.Visible = True
        Txt_Path_Insert.Visible = True
        Lab_Code.Visible = True
        Lab_Path.Visible = True
        But_Insert_trait.Enabled = True
        Txt_Path_Rch.Visible = False
        Txt_Medi_Rch.Visible = False
        Rad_path.Checked = False
        Txt_Path_Rch.Visible = False
    End Sub

    Private Sub But_acc_Click(sender As Object, e As EventArgs) Handles But_acc.Click
        Me.Hide()

    End Sub
End Class