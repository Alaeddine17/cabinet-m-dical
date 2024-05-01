
Imports System.Data.OleDb
Public Class Frm_connect
    Dim Fois As Integer = 0
    Dim Conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " & Application.StartupPath & "/CabinetDB.mdb")

    Private Sub But_visib_Click(sender As Object, e As EventArgs) Handles But_visib.Click
        If (Txt_Pass.PasswordChar = "*") Then
            Txt_Pass.PasswordChar = ""
        Else
            Txt_Pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub But_Fermer_Click(sender As Object, e As EventArgs) Handles But_Fermer.Click
        End
    End Sub
    Private Sub Frm_connect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Nutili.Select()
    End Sub

    Private Sub But_conn_Click(sender As Object, e As EventArgs) Handles But_conn.Click
        Dim Utl As String = Txt_Nutili.Text
        Dim Pass As String = Txt_Pass.Text

        Dim CmdC As New OleDbCommand("SELECT * FROM T_Medecin WHERE Utilisateur = '" & Utl & "' AND MotDePass = '" & Pass & "'", Conn)
        Conn.Open()
        Dim reader = CmdC.ExecuteReader

        If (reader.Read = False) Then
            MsgBox("Le Nom d'utilisateur ou le mot de pass est incorrect", MessageBoxIcon.Error, "attention")
            Fois += 1
        Else
            Me.Hide()
            MDIAccueil.Show()
        End If
        If (Fois > 2) Then
            End
        End If

        Conn.Close()
    End Sub
End Class