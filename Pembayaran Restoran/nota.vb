Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms
Public Class nota
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=resto"
        con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String = "insert into tbpesan values('" & pesanan.TextBox1.Text & "','" & pesanan.Label1.Text & "','" & pesanan.TextBox5.Text & "','" & pesanan.TextBox2.Text & "','" & pesanan.TextBox6.Text & "','" & pesanan.TextBox8.Text & "','" & pesanan.TextBox3.Text & "','" & pesanan.TextBox7.Text & "','" & pesanan.TextBox9.Text & "','" & pesanan.TextBox4.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Private Sub nota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim id As New ReportParameter("id", pesanan.TextBox1.Text)
        Me.ReportViewer1.LocalReport.SetParameters(id)
        Dim nama As New ReportParameter("nama", pesanan.TextBox5.Text)
        Me.ReportViewer1.LocalReport.SetParameters(nama)
        Dim meja As New ReportParameter("meja", pesanan.Label1.Text)
        Me.ReportViewer1.LocalReport.SetParameters(meja)
        Dim makan As New ReportParameter("makan", pesanan.TextBox2.Text)
        Me.ReportViewer1.LocalReport.SetParameters(makan)
        Dim minum As New ReportParameter("minum", pesanan.TextBox3.Text)
        Me.ReportViewer1.LocalReport.SetParameters(minum)
        Dim total As New ReportParameter("total", pesanan.TextBox4.Text)
        Me.ReportViewer1.LocalReport.SetParameters(total)
        Dim juma As New ReportParameter("juma", pesanan.TextBox6.Text)
        Me.ReportViewer1.LocalReport.SetParameters(juma)
        Dim hama As New ReportParameter("hama", pesanan.TextBox8.Text)
        Me.ReportViewer1.LocalReport.SetParameters(hama)
        Dim jumi As New ReportParameter("jumi", pesanan.TextBox7.Text)
        Me.ReportViewer1.LocalReport.SetParameters(jumi)
        Dim hami As New ReportParameter("hami", pesanan.TextBox9.Text)
        Me.ReportViewer1.LocalReport.SetParameters(hami)
        Me.ReportViewer1.RefreshReport()

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Function sql() As Object
        Throw New NotImplementedException
    End Function


End Class