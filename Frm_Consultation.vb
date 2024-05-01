Imports System.Data.OleDb
Public Class Frm_Consultation
    Public Property NumPatn As String
    Public Property NomPatn As String
    Public Property PrenomPatn As String
    Public Property EtatSntPatn As String


    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\CabinetDB.mdb")
    Dim datapterPatn As New OleDbDataAdapter("SELECT * FROM T_Patient ORDER BY Num_Patn", conn)
    Dim DatapterMede As New OleDbDataAdapter("SELECT * FROM T_Medecin", conn)
    Dim dtsetPatn As New DataSet
    Dim dtsetMede As New DataSet
    Dim Reader As OleDbDataReader
    Dim datable As New DataTable

    Sub remplirTxt()
        datable.Rows.Add(Txt_NumConst.Text, Txt_NomMede.Text, Txt_NomPatn.Text, Txt_PrenomPatn.Text, Txt_EtatSnt.Text, Cmb_Type.Text, Txt_Prix.Text, Cmb_Maladie.Text, Date_Const.Value.ToString)
    End Sub


    Sub dataload()

        datable.Columns.Add("Consultation N°", Type.GetType("System.Int32"))
        datable.Columns.Add("Docteur", Type.GetType("System.String"))
        datable.Columns.Add("Nom de patient", Type.GetType("System.String"))
        datable.Columns.Add("Prénom", Type.GetType("System.String"))
        datable.Columns.Add("Etat santé de patient", Type.GetType("System.String"))
        datable.Columns.Add("Type de consultation", Type.GetType("System.String"))
        datable.Columns.Add("Prix de consultation", Type.GetType("System.Int32"))
        datable.Columns.Add("Détection des maladies", Type.GetType("System.String"))
        datable.Columns.Add("date de Consultation", Type.GetType("System.DateTime"))
        DataGridView1.DataSource = datable
        DataGridView1.AllowUserToAddRows = False

    End Sub

    Sub loadPatient()
        Txt_NumPtn.Text = NumPatn
        Txt_NomPatn.Text = NomPatn
        Txt_PrenomPatn.Text = PrenomPatn
        Txt_EtatSnt.Text = EtatSntPatn

    End Sub


    Sub Ajouter()
        dtsetPatn.Clear()
        datapterPatn.Fill(dtsetPatn, "T_Patient")
        Txt_NumPtn.DataBindings.Add("text", dtsetPatn, "T_Patient.Num_Patn")
        Txt_NomPatn.DataBindings.Add("text", dtsetPatn, "T_Patient.Nom_Patn")
        Txt_PrenomPatn.DataBindings.Add("text", dtsetPatn, "T_Patient.Prenom_Patn")
        Txt_EtatSnt.DataBindings.Add("text", dtsetPatn, "T_Patient.Etat_sante_ptn")
    End Sub

    Sub count()
        Dim Cadapter As New OleDbDataAdapter("SELECT T_Consultation.Num_Const FROM T_Consultation;", conn)
        Dim datable As New DataTable
        Cadapter.Fill(datable)
        Dim Nb As Integer = datable.Rows.Count
        Txt_NumConst.Text = Nb + 1
    End Sub
    Sub CmbMaladie()
        conn.Open()
        Cmb_Maladie.Items.Clear()
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM T_Pathologie"
        cmd.Connection = conn

        Reader = cmd.ExecuteReader

        While Reader.Read
            Cmb_Maladie.Items.Add(Reader.GetString(1))
        End While
        Reader.Close()
        conn.Close()
    End Sub


    Sub Dsc()
        conn.Open()
        Lst_Descr.Items.Clear()
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT T_Pathologie.Nom_Path, T_Pathologie.Description_Path
                           From T_Pathologie
                           WHERE (((T_Pathologie.Nom_Path)='" & Txt_Test.Text & "'));
"
        cmd.Connection = conn

        Reader = cmd.ExecuteReader

        While Reader.Read

            Lst_Descr.Items.Add(Reader.GetString(1))

        End While
        Reader.Close()
        conn.Close()
    End Sub


    Sub loadMede()
        dtsetMede.Clear()
        DatapterMede.Fill(dtsetMede, "T_Medecin")
        Txt_NumMede.DataBindings.Add("text", dtsetMede, "T_Medecin.Num_Medecin")
        Txt_NomMede.DataBindings.Add("text", dtsetMede, "T_Medecin.NomPrenom")
    End Sub



    Private Sub Frm_Consultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPatient()
        loadMede()
        CmbMaladie()
        count()
        dataload()
    End Sub

    Private Sub But_fermer_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Cmb_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Type.SelectedIndexChanged
        If (Cmb_Type.Text = "Visite") Then
            Txt_Prix.Text = 200
        ElseIf (Cmb_Type.Text = "Controle") Then
            Txt_Prix.Text = 300
        ElseIf (Cmb_Type.Text = "Traitement") Then
            Txt_Prix.Text = 250
        Else
            Txt_Prix.Text = 400
        End If
    End Sub

    Private Sub But_retour_Click(sender As Object, e As EventArgs) Handles But_retour.Click
        Me.BindingContext(dtsetPatn, "T_Patient").Position -= 1
    End Sub

    Private Sub But_Suivant_Click(sender As Object, e As EventArgs) Handles But_Suivant.Click
        Me.BindingContext(dtsetPatn, "T_Patient").Position += 1
    End Sub

    Private Sub But_Enregter_Click(sender As Object, e As EventArgs) Handles But_Enregter.Click

        If (String.IsNullOrEmpty(Txt_NomPatn.Text) OrElse String.IsNullOrEmpty(Txt_NumPtn.Text) OrElse String.IsNullOrEmpty(Txt_Prix.Text) OrElse String.IsNullOrEmpty(Cmb_Maladie.Text)) Then
            MsgBox("Voullez vous remplire les zone de text", vbExclamation + MsgBoxStyle.OkOnly, "Remarque")
            Return
        End If

        Dim Cmd As New OleDbCommand
        Cmd.CommandText = "INSERT INTO T_Consultation(Num_Const,Num_Medecin,Num_Patn,Date_Const,Type_Const,Prix_Const,Maladie_Const) VALUES (" & Txt_NumConst.Text & "," & Txt_NumMede.Text & ",'" & Txt_NumPtn.Text & "',# " & Date_Const.Value.ToString() & " #,'" & Cmb_Type.Text & "'," & Txt_Prix.Text & ",'" & Cmb_Maladie.Text & "')"
        Cmd.Connection = conn

        conn.Open()
        Cmd.ExecuteNonQuery()
        conn.Close()
        remplirTxt()
        MsgBox("Success", vbOKOnly, "Remarque")
        But_Ajter.Enabled = False
        Grp_Ord.Visible = True
        But_acc.Enabled = False
        But_Enregter.Enabled = False
    End Sub

    Private Sub But_Ajter_Click(sender As Object, e As EventArgs) Handles But_Ajter.Click
        Txt_NumConst.Clear()
        Cmb_Type.Text = ""
        Txt_Prix.Clear()
        Cmb_Maladie.Text = ""
        But_Ajter.Enabled = False
        Ajouter()
        But_Suivant.Visible = True
        But_retour.Visible = True
        But_Pat.Visible = True
        count()
    End Sub

    Private Sub But_Const_Click(sender As Object, e As EventArgs) Handles But_Ord.Click
        Dim Ord As New Frm_Ordonnance

        Ord.NumPatn = Txt_NumPtn.Text
        Ord.NomPatn = Txt_NomPatn.Text
        Ord.EtatSntPatn = Txt_EtatSnt.Text
        Ord.Result = Cmb_Maladie.Text
        Ord.PrenomPatn = Txt_PrenomPatn.Text

        Ord.Show()
    End Sub

    Private Sub Cmb_Maladie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Maladie.SelectedIndexChanged
        Txt_Test.Text = Cmb_Maladie.SelectedItem
        Dsc()
    End Sub

    Private Sub But_acc_Click(sender As Object, e As EventArgs) Handles But_acc.Click
        Me.Hide()

    End Sub

    Private Sub But_Pat_Click(sender As Object, e As EventArgs) Handles But_Pat.Click
        Me.Hide()
        Frm_Patient.Show()
        But_Pat.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim datable2 As New DataTable
        datable2.Columns.Add("Consultation N°", Type.GetType("System.Int32"))
        datable2.Columns.Add("Docteur", Type.GetType("System.String"))
        datable2.Columns.Add("Nom de patient", Type.GetType("System.String"))
        datable2.Columns.Add("Prénom de patient", Type.GetType("System.String"))
        datable2.Columns.Add("Etat santé de patient", Type.GetType("System.String"))
        datable2.Columns.Add("Type de consultation", Type.GetType("System.String"))
        datable2.Columns.Add("Prix de consultation", Type.GetType("System.Int32"))
        datable2.Columns.Add("Détection des maladies", Type.GetType("System.String"))
        datable2.Columns.Add("date de Consultation", Type.GetType("System.DateTime"))

        For Each row As DataGridViewRow In DataGridView1.Rows
            datable2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
        Next
        FrmRepportConst.Show()
        Dim report As New CrystalReportConst
        report.SetDataSource(datable2)
        FrmRepportConst.CrystalReportViewer1.ReportSource = report

    End Sub
End Class