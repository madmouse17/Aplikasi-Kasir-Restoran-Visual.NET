Public Class main_menu


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pesanan.TextBox2.Text = ""
        If CheckBox1.Checked = True Then
            pesanan.TextBox2.Text = pesanan.TextBox2.Text & CheckBox1.Text & vbCrLf
        End If
        If CheckBox2.Checked = True Then
            pesanan.TextBox2.Text = pesanan.TextBox2.Text & CheckBox2.Text & vbCrLf
        End If
        If CheckBox5.Checked = True Then
            pesanan.TextBox2.Text = pesanan.TextBox3.Text & CheckBox5.Text & vbCrLf
        End If
        If CheckBox6.Checked = True Then
            pesanan.TextBox2.Text = pesanan.TextBox2.Text & CheckBox6.Text & vbCrLf
        End If
        If CheckBox7.Checked = True Then
            pesanan.TextBox2.Text = pesanan.TextBox2.Text & CheckBox7.Text & vbCrLf
        End If
        If CheckBox8.Checked = True Then
            pesanan.TextBox2.Text = pesanan.TextBox2.Text & CheckBox8.Text & vbCrLf
        End If
        If CheckBox3.Checked = True Then
            pesanan.TextBox3.Text = pesanan.TextBox3.Text & CheckBox3.Text & vbCrLf
        End If
        If CheckBox4.Checked = True Then
            pesanan.TextBox3.Text = pesanan.TextBox3.Text & CheckBox4.Text & vbCrLf
        End If
        If CheckBox9.Checked = True Then
            pesanan.TextBox3.Text = pesanan.TextBox3.Text & CheckBox9.Text & vbCrLf
        End If
        If CheckBox10.Checked = True Then
            pesanan.TextBox3.Text = pesanan.TextBox3.Text & CheckBox10.Text & vbCrLf
        End If
        If TextBox1.Text = True Then
            pesanan.TextBox6.Text = pesanan.TextBox6.Text & TextBox1.Text & vbCrLf
        End If
        If TextBox3.Text = True Then
            pesanan.TextBox6.Text = pesanan.TextBox6.Text & TextBox3.Text & vbCrLf
        End If
        If TextBox5.Text = True Then
            pesanan.TextBox6.Text = pesanan.TextBox6.Text & TextBox5.Text & vbCrLf
        End If
        If TextBox7.Text = True Then
            pesanan.TextBox6.Text = pesanan.TextBox6.Text & TextBox7.Text & vbCrLf
        End If
        If TextBox9.Text = True Then
            pesanan.TextBox6.Text = pesanan.TextBox6.Text & TextBox9.Text & vbCrLf
        End If
        If TextBox11.Text = True Then
            pesanan.TextBox6.Text = pesanan.TextBox6.Text & TextBox11.Text & vbCrLf
        End If
        If TextBox14.Text = True Then
            pesanan.TextBox7.Text = pesanan.TextBox7.Text & TextBox14.Text & vbCrLf
        End If
        If TextBox16.Text = True Then
            pesanan.TextBox7.Text = pesanan.TextBox7.Text & TextBox16.Text & vbCrLf
        End If
        If TextBox18.Text = True Then
            pesanan.TextBox7.Text = pesanan.TextBox7.Text & TextBox18.Text & vbCrLf
        End If
        If TextBox20.Text = True Then
            pesanan.TextBox7.Text = pesanan.TextBox7.Text & TextBox20.Text & vbCrLf
        End If
        If TextBox2.Text = True Then
            pesanan.TextBox8.Text = pesanan.TextBox8.Text & TextBox2.Text & vbCrLf
        End If
        If TextBox4.Text = True Then
            pesanan.TextBox8.Text = pesanan.TextBox8.Text & TextBox4.Text & vbCrLf
        End If
        If TextBox6.Text = True Then
            pesanan.TextBox8.Text = pesanan.TextBox8.Text & TextBox6.Text & vbCrLf
        End If
        If TextBox8.Text = True Then
            pesanan.TextBox8.Text = pesanan.TextBox8.Text & TextBox8.Text & vbCrLf
        End If
        If TextBox10.Text = True Then
            pesanan.TextBox8.Text = pesanan.TextBox8.Text & TextBox10.Text & vbCrLf
        End If
        If TextBox12.Text = True Then
            pesanan.TextBox8.Text = pesanan.TextBox8.Text & TextBox12.Text & vbCrLf
        End If
        If TextBox15.Text = True Then
            pesanan.TextBox9.Text = pesanan.TextBox9.Text & TextBox15.Text & vbCrLf
        End If
        If TextBox19.Text = True Then
            pesanan.TextBox9.Text = pesanan.TextBox9.Text & TextBox19.Text & vbCrLf
        End If
        If TextBox17.Text = True Then
            pesanan.TextBox9.Text = pesanan.TextBox9.Text & TextBox17.Text & vbCrLf
        End If
        If TextBox21.Text = True Then
            pesanan.TextBox9.Text = pesanan.TextBox9.Text & TextBox21.Text & vbCrLf
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub main_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox14.Text = 0
        TextBox15.Text = 0
        TextBox16.Text = 0
        TextBox17.Text = 0
        TextBox18.Text = 0
        TextBox19.Text = 0
        TextBox20.Text = 0
        TextBox21.Text = 0
        pesanan.TextBox2.Text = ""
        pesanan.TextBox3.Text = ""
        pesanan.TextBox6.Text = ""
        pesanan.TextBox7.Text = ""
        pesanan.TextBox8.Text = ""
        pesanan.TextBox9.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim spageti As Integer
        spageti = CInt(TextBox1.Text)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim spageti As Integer
        Dim total As Integer
        spageti = CInt(TextBox1.Text)
        total = CInt(TextBox2.Text)
        total = spageti * 30000
        TextBox2.Text = total
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim steak As Integer
        steak = CInt(TextBox3.Text)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Dim steak As Integer
        Dim total1 As Integer
        steak = CInt(TextBox3.Text)
        total1 = CInt(TextBox4.Text)
        total1 = (steak * 20000)
        TextBox4.Text = total1
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim nasgor As Integer

        nasgor = CInt(TextBox5.Text)
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim nasgor As Integer
        Dim total2 As Integer
        nasgor = CInt(TextBox5.Text)
        total2 = CInt(TextBox6.Text)
        total2 = (nasgor * 15000)
        TextBox6.Text = total2
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Dim iga As Integer
        Dim total3 As Integer
        iga = CInt(TextBox7.Text)
        total3 = CInt(TextBox8.Text)
        total3 = (iga * 35000)
        TextBox8.Text = total3
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Dim iga As Integer

        iga = CInt(TextBox7.Text)
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        Dim sate As Integer
        Dim total4 As Integer
        sate = CInt(TextBox9.Text)
        total4 = CInt(TextBox10.Text)
        total4 = (sate * 25000)
        TextBox10.Text = total4
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Dim sate As Integer

        sate = CInt(TextBox9.Text)
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        Dim soto As Integer

        soto = CInt(TextBox11.Text)
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        Dim soto As Integer
        Dim total5 As Integer
        soto = CInt(TextBox11.Text)
        total5 = CInt(TextBox12.Text)
        total5 = (soto * 10000)
        TextBox12.Text = total5
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim total As Integer
        Dim total1 As Integer
        Dim total2 As Integer
        Dim total3 As Integer
        Dim total4 As Integer
        Dim total5 As Integer
        Dim total6 As Integer
        Dim total7 As Integer
        Dim total8 As Integer
        Dim total9 As Integer
        Dim jumlah As Integer
        total = CInt(TextBox2.Text)
        total1 = CInt(TextBox4.Text)
        total2 = CInt(TextBox6.Text)
        total3 = CInt(TextBox8.Text)
        total4 = CInt(TextBox10.Text)
        total5 = CInt(TextBox12.Text)
        total6 = CInt(TextBox15.Text)
        total7 = CInt(TextBox17.Text)
        total8 = CInt(TextBox19.Text)
        total9 = CInt(TextBox21.Text)
        jumlah = total + total1 + total2 + total3 + total4 + total5 + total6 + total7 + total8 + total9
        pesanan.TextBox4.Text = jumlah
        pesanan.Show()
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter
 
    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
        Dim taro As Integer
        Dim total6 As Integer
        taro = CInt(TextBox14.Text)
        total6 = CInt(TextBox15.Text)
        total6 = (taro * 15000)
        TextBox15.Text = total6
    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
        Dim taro As Integer
        taro = CInt(TextBox16.Text)
    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged
        Dim taro As Integer
        Dim total6 As Integer
        taro = CInt(TextBox16.Text)
        total6 = CInt(TextBox17.Text)
        total6 = (taro * 15000)
        TextBox17.Text = total6
    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        Dim taro As Integer
        Dim total6 As Integer
        taro = CInt(TextBox18.Text)
        total6 = CInt(TextBox19.Text)
        total6 = (taro * 15000)
        TextBox19.Text = total6
    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged
        Dim taro As Integer
        taro = CInt(TextBox20.Text)
    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged
        Dim taro As Integer
        Dim total6 As Integer
        taro = CInt(TextBox20.Text)
        total6 = CInt(TextBox21.Text)
        total6 = (taro * 15000)
        TextBox21.Text = total6
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        Dim taro As Integer
        taro = CInt(TextBox14.Text)
    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged
        Dim taro As Integer
        taro = CInt(TextBox18.Text)
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class