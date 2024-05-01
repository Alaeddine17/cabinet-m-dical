Imports System.Data.OleDb


Public Class Frm_Ordonnance
    Public Property NumPatn As String
    Public Property NomPatn As String
    Public Property PrenomPatn As String
    Public Property EtatSntPatn As String
    Public Property Result As String



    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\CabinetDB.mdb")
    Dim datapterPatn As New OleDbDataAdapter("SELECT * FROM T_Patient", conn)
    Dim DatapterMede As New OleDbDataAdapter("SELECT * FROM T_Medecin", conn)
    Dim dtsetPatn As New DataSet
    Dim dtsetMede As New DataSet
    Dim Reader As OleDbDataReader
    Dim datable As New DataTable

    Sub remplirTxt()
        datable.Rows.Add(Txt_NumOrd.Text, Txt_NomMede.Text, Txt_NomPatn.Text, TxtMed1.Text, TxtMed2.Text, TxtMed3.Text, TxtMed4.Text, ComboBox1.Text, ComboBox2.Text, ComboBox3.Text, ComboBox4.Text, Txt_PrenomPatn.Text)
    End Sub


    Sub dataload()


        datable.Columns.Add("Ordonnance N°", Type.GetType("System.Int32"))
        datable.Columns.Add("Docteur", Type.GetType("System.String"))
        datable.Columns.Add("Nom de patient", Type.GetType("System.String"))
        datable.Columns.Add("Médicament 1", Type.GetType("System.String"))
        datable.Columns.Add("Médicament 2", Type.GetType("System.String"))
        datable.Columns.Add("Médicament 3", Type.GetType("System.String"))
        datable.Columns.Add("Médicament 4", Type.GetType("System.String"))
        datable.Columns.Add("Unité par jour 1", Type.GetType("System.String"))
        datable.Columns.Add("Unité par jour 2", Type.GetType("System.String"))
        datable.Columns.Add("Unité par jour 3", Type.GetType("System.String"))
        datable.Columns.Add("Unité par jour 4", Type.GetType("System.String"))
        datable.Columns.Add("Prénom de Patient", Type.GetType("System.String"))
        DataGridView1.DataSource = datable
        DataGridView1.AllowUserToAddRows = False

    End Sub

    Sub count()
        Dim Cadapter As New OleDbDataAdapter("SELECT T_Ordonnance.Num_Ord FROM T_Ordonnance;", conn)
        Dim datable As New DataTable
        Cadapter.Fill(datable)
        Dim Nb As Integer = datable.Rows.Count
        Txt_NumOrd.Text = Nb + 1
    End Sub
    Sub loadPatient()
        Txt_NumPtn.Text = NumPatn
        Txt_NomPatn.Text = NomPatn
        Txt_EtatSnt.Text = EtatSntPatn
        txt_PrenomPatn.Text = PrenomPatn

    End Sub
    Sub loadMede()
        dtsetMede.Clear()
        DatapterMede.Fill(dtsetMede, "T_Medecin")
        Txt_NumMede.DataBindings.Add("text", dtsetMede, "T_Medecin.Num_Medecin")
        Txt_NomMede.DataBindings.Add("text", dtsetMede, "T_Medecin.NomPrenom")
    End Sub


    Sub Traitment()
        conn.Open()
        Lst_Med.Items.Clear()
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT T_Pathologie.Nom_Path, T_Medicament.Libelle_Med, T_Pathologie.Description_Path
                           FROM T_Pathologie INNER JOIN (T_Medicament INNER JOIN T_Traiter ON T_Medicament.Code_Med = T_Traiter.Code_Med) ON T_Pathologie.Code_Path = T_Traiter.Code_Path
                           WHERE (((T_Pathologie.Nom_Path)='" & Txt_Resultat.Text & "'));"
        cmd.Connection = conn

        Reader = cmd.ExecuteReader

        While Reader.Read

            Lst_Med.Items.Add(Reader.GetString(1))
        End While
        Reader.Close()
        conn.Close()

    End Sub


    Sub Maladie()
        conn.Open()
        Lst_Result.Items.Clear()
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT T_Consultation.Num_Patn, T_Consultation.Maladie_Const
                           FROM T_Consultation
                           WHERE (((T_Consultation.Num_Patn)= '" & Txt_NumPtn.Text & "' ));"
        cmd.Connection = conn

        Reader = cmd.ExecuteReader

        While Reader.Read

            Lst_Result.Items.Add(Reader.GetString(1))

        End While
        Reader.Close()
        conn.Close()

    End Sub

    Sub Ajouter()
        dtsetPatn.Clear()
        datapterPatn.Fill(dtsetPatn, "T_Patient")
        Txt_NumPtn.DataBindings.Add("text", dtsetPatn, "T_Patient.Num_Patn")
        Txt_NomPatn.DataBindings.Add("text", dtsetPatn, "T_Patient.Nom_Patn")
        Txt_EtatSnt.DataBindings.Add("text", dtsetPatn, "T_Patient.Etat_sante_ptn")
    End Sub

    Private Sub Frm_Ordonnance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPatient()
        loadMede()
        Maladie()
        count()
        dataload()
    End Sub

    Private Sub Lst_Result_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Result.SelectedIndexChanged
        TxtMed1.Clear()
        TxtMed2.Clear()
        TxtMed3.Clear()
        TxtMed4.Clear()
        TxtMed1.Enabled = False
        TxtMed2.Enabled = False
        TxtMed3.Enabled = False
        TxtMed4.Enabled = False
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        ComboBox4.Visible = False
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""


        Txt_Resultat.Text = Lst_Result.SelectedItem
        Traitment()

    End Sub

    Private Sub But_fermer_Click(sender As Object, e As EventArgs) 
        End

    End Sub

    Private Sub But_Enregter_Click(sender As Object, e As EventArgs) Handles But_Enregter.Click
        If (String.IsNullOrEmpty(Txt_NomPatn.Text) OrElse String.IsNullOrEmpty(Txt_NumPtn.Text) OrElse String.IsNullOrEmpty(Txt_EtatSnt.Text) OrElse String.IsNullOrEmpty(TxtMed1.Text)) Then
            MsgBox("Selectionner le patient dabord", vbExclamation + MsgBoxStyle.OkOnly, "Remarque")

            Me.Hide()
            Frm_Patient.Show()
            Return

        End If

        Dim Cmd As New OleDbCommand
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "INSERT INTO T_Ordonnance (Num_Ord, Date_Ord, Num_Patn, Num_Medecin) VALUES (" & Txt_NumOrd.Text & ",# " & Date_Const.Value.ToString & " #, '" & Txt_NumPtn.Text & "', " & Txt_NumMede.Text & ")"
        Cmd.Connection = conn

        conn.Open()
        Cmd.ExecuteNonQuery()
        conn.Close()
        remplirTxt()
        MsgBox("L'ordonnance est bien enregistrer", vbInformation + vbOKOnly, "remarque")
        But_Enregter.Enabled = False
        But_Imprimer.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButAd4.Click
        If Lst_Med.Items.Count < 1 Then
            Return
        Else
            TxtMed1.Text = Lst_Med.Items(0)
        End If

        ComboBox1.Visible = True
        TxtMed1.ReadOnly = False
    End Sub

    Private Sub ButAd3_Click(sender As Object, e As EventArgs) Handles ButAd3.Click
        If Lst_Med.Items.Count < 2 Then
            Return
        Else
            TxtMed2.Text = Lst_Med.Items(1)
        End If
        TxtMed2.ReadOnly = False
        ComboBox2.Visible = True
    End Sub

    Private Sub ButAd2_Click(sender As Object, e As EventArgs) Handles ButAd2.Click
        If Lst_Med.Items.Count <= 2 Then
            Return
        Else TxtMed3.Text = Lst_Med.Items(2)
        End If
        TxtMed3.ReadOnly = False
        ComboBox3.Visible = True
    End Sub

    Private Sub ButAd1_Click(sender As Object, e As EventArgs) Handles ButAd1.Click
        If Lst_Med.Items.Count <= 3 Then
            Return
        Else
            TxtMed4.Text = Lst_Med.Items(4)
        End If
        ComboBox4.Visible = True
        TxtMed4.ReadOnly = False
    End Sub

    Private Sub But_acc_Click(sender As Object, e As EventArgs) Handles But_acc.Click
        Me.Hide()

    End Sub

    Private Sub But_Pat_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Frm_Patient.Show()
    End Sub

    Private Sub But_Ajter_Click(sender As Object, e As EventArgs)

        Txt_NumOrd.Clear()
        TxtMed1.Clear()
        TxtMed2.Clear()
        TxtMed3.Clear()
        TxtMed4.Clear()
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        ComboBox4.Visible = False
    End Sub

    Private Sub But_Impimer_Click(sender As Object, e As EventArgs) Handles But_Imprimer.Click
        Dim datable2 As New DataTable
        datable2.Columns.Add("Ordonnance N°", Type.GetType("System.Int32"))
        datable2.Columns.Add("Docteur", Type.GetType("System.String"))
        datable2.Columns.Add("Nom de patient", Type.GetType("System.String"))
        datable2.Columns.Add("Médicament 1", Type.GetType("System.String"))
        datable2.Columns.Add("Médicament 2", Type.GetType("System.String"))
        datable2.Columns.Add("Médicament 3", Type.GetType("System.String"))
        datable2.Columns.Add("Médicament 4", Type.GetType("System.String"))
        datable2.Columns.Add("Unité par jour 1", Type.GetType("System.String"))
        datable2.Columns.Add("Unité par jour 2", Type.GetType("System.String"))
        datable2.Columns.Add("Unité par jour 3", Type.GetType("System.String"))
        datable2.Columns.Add("Unité par jour 4", Type.GetType("System.String"))
        datable2.Columns.Add("Prénom de patient", Type.GetType("System.String"))
        For Each row As DataGridViewRow In DataGridView1.Rows
            datable2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).Value)
        Next
        FrmRepportOrd.Show()
        Dim report As New CrystalReportOrd
        report.SetDataSource(datable2)
        FrmRepportOrd.CrystalReportViewer1.ReportSource = report
    End Sub
End Class