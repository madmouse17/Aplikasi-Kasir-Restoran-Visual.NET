Imports System.Data.Odbc
Public Class pesanan
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
        Dim sql As String = "insert into tbpesan values('" & TextBox1.Text & "','" & Label1.Text & "','" & TextBox5.Text & "','" & TextBox2.Text & vbCrLf & "','" & TextBox6.Text & "','" & TextBox8.Text & "','" & TextBox3.Text & "','" & TextBox7.Text & "','" & TextBox9.Text & "','" & TextBox4.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from tbpesan order by id asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub
    Sub edit()
        koneksi()
        Dim update As String = "update tbpesan set no='" & Label1.Text & "',nama='" & TextBox5.Text & "',makan='" & TextBox2.Text & "',juma='" & TextBox6.Text & "',hama='" & TextBox8.Text & "',minum='" & TextBox3.Text & "',jumi='" & TextBox7.Text & "',hami='" & TextBox9.Text & "',total='" & TextBox4.Text & "' where id='" & TextBox1.Text & "'"
        cmd = New OdbcCommand(update, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Mengedit data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Mengedit data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        main_menu.Show()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub pesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        simpan()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        index = e.RowIndex

        Dim selectedrow As DataGridViewRow

        selectedrow = DataGridView1.Rows(index)

        TextBox1.Text = selectedrow.Cells(0).Value.ToString()
        Label1.Text = selectedrow.Cells(1).Value.ToString()
        TextBox5.Text = selectedrow.Cells(2).Value.ToString()
        TextBox2.Text = selectedrow.Cells(3).Value.ToString()
        TextBox6.Text = selectedrow.Cells(4).Value.ToString()
        TextBox8.Text = selectedrow.Cells(5).Value.ToString()
        TextBox3.Text = selectedrow.Cells(6).Value.ToString()
        TextBox7.Text = selectedrow.Cells(7).Value.ToString()
        TextBox9.Text = selectedrow.Cells(8).Value.ToString()
        TextBox4.Text = selectedrow.Cells(9).Value.ToString()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tampil()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        nota.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
       Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Pesan yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan id=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from tbpesan where id='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        edit()
        tampil()
    End Sub
End Class