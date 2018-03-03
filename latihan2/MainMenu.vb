Public Class MainMenu
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public idKaryawan As String
    Public karyawan As String
    Public levelAdmin As Integer
    Public logOff As Boolean = False
    Public editRoti As Boolean
    Public kodeRoti As String
    Public namaRoti As String
    Public hargaRoti As Decimal
    Public diskonRoti As Integer
    Public stokRoti As Integer
    Public kodeKaryawan As String
    Public namaKaryawan As String
    Public shiftKaryawan As String
    Public levelKaryawan As Integer
    Public pasFoto As Byte()
    Public passwordKaryawan As String


    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        logOff = False
        Me.Close()
    End Sub

    Sub UlangForm()
        PanelWrapperDashboard.Visible = False
        PanelWrapperRoti.Visible = False
        PanelWrapperKaryawan.Visible = False
        PanelWrapperKasir.Visible = False
        PanelWrappernRiwayat.Visible = False
        btnDashboard.BackColor = Color.FromArgb(52, 73, 94)
        btnRoti.BackColor = Color.FromArgb(52, 73, 94)
        btnKaryawan.BackColor = Color.FromArgb(52, 73, 94)
        btnKasir.BackColor = Color.FromArgb(52, 73, 94)
        btnRiwayat.BackColor = Color.FromArgb(52, 73, 94)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
        btnRoti.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
        btnKasir.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
        btnRiwayat.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        UlangForm()
        PanelWrapperDashboard.Visible = True
        LblMenu.Text = "Dashboard"
        lblKeterangan.Text = ""
        btnDashboard.BackColor = Color.FromArgb(62, 87, 112)
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 87, 112)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
    End Sub

    Private Sub btnRoti_Click(sender As Object, e As EventArgs) Handles btnRoti.Click
        UlangForm()
        PanelWrapperRoti.Visible = True
        txCariRoti.Focus()
        LblMenu.Text = "Data Roti"
        lblKeterangan.Text = "Tekan F3 Untuk Mencari  |  Tekan F4 Untuk Menambah Data  |  Tekan F5 Untuk Mengedit Data  |  Tekan F6 Untuk Menghapus Data"
        btnRoti.BackColor = Color.FromArgb(62, 87, 112)
        btnRoti.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 87, 112)
        btnRoti.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        UlangForm()
        PanelWrapperKaryawan.Visible = True
        txCariKaryawan.Focus()
        LblMenu.Text = "Data Karyawan"
        lblKeterangan.Text = "Tekan F3 Untuk Mencari  |  Tekan F4 Untuk Menambah Data  |  Tekan F5 Untuk Mengedit Data  |  Tekan F6 Untuk Menghapus Data"
        btnKaryawan.BackColor = Color.FromArgb(62, 87, 112)
        btnKaryawan.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 87, 112)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        UlangForm()
        PanelWrapperKasir.Visible = True
        LblMenu.Text = "Kasir"
        lblKeterangan.Text = "Tekan Enter Untuk Menambah Data  |  Tekan F3 Untuk Menghapus Data  |  Tekan F4 Untuk Bayar  |  Tekan F5 Untuk Mengulang"
        btnKasir.BackColor = Color.FromArgb(62, 87, 112)
        btnKasir.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 87, 112)
        btnKasir.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
    End Sub

    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        UlangForm()
        PanelWrappernRiwayat.Visible = True
        LblMenu.Text = "Riwayat"
        lblKeterangan.Text = "Tekan F3 Untuk Mencari  |  Tekan F4 Untuk Menambah Data  |  Tekan F5 Untuk Mengedit Data  |  Tekan F6 Untuk Menghapus Data"
        btnRiwayat.BackColor = Color.FromArgb(62, 87, 112)
        btnRiwayat.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 87, 112)
        btnRiwayat.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 87, 112)
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'TheBreadShopDataSet.penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.TheBreadShopDataSet.penjualan)
        'TODO: This line of code loads data into the 'TheBreadShopDataSet.header_penjualan' table. You can move, or remove it, as needed.
        Me.Header_penjualanTableAdapter.Fill(Me.TheBreadShopDataSet.header_penjualan)
        'TODO: This line of code loads data into the 'TheBreadShopDataSet.riwayat' table. You can move, or remove it, as needed.
        Me.RiwayatTableAdapter.Fill(Me.TheBreadShopDataSet.riwayat)
        'TODO: This line of code loads data into the 'TheBreadShopDataSet.karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.TheBreadShopDataSet.karyawan)
        'TODO: This line of code loads data into the 'TheBreadShopDataSet.roti' table. You can move, or remove it, as needed.
        Me.RotiTableAdapter.Fill(Me.TheBreadShopDataSet.roti)
        'lblAdmin.Text = "    Admin : " + karyawan
        btnDashboard_Click(sender, e)
        Me.KeyPreview = True
        isiItemCBKodeRoti()

    End Sub

    Sub isiItemCBKodeRoti()
        CBKodeRoti.Items.Clear()
        Dim dt As New TheBreadShopDataSet.rotiDataTable
        dt = RotiTableAdapter.GetData()
        For i = 0 To dt.Count - 1
            CBKodeRoti.Items.Add(dt.Rows(i).Item(0))
        Next
        CBKodeRoti.AutoCompleteSource = AutoCompleteSource.ListItems
        CBKodeRoti.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub PanelWindowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelWindowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelWindowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseUp
        drag = False
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        logOff = True
        Me.Close()
        formLogin.Show()
    End Sub

    Private Sub btnTambahRoti_Click(sender As Object, e As EventArgs) Handles btnTambahRoti.Click
        editRoti = False
        formRoti.ShowDialog()
    End Sub

    Private Sub tabelDataRoti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataRoti.CellClick
        pilihSelRoti(e.RowIndex)
    End Sub

    Sub pilihSelRoti(ByVal e As String)
        If e >= 0 Then
            kodeRoti = tabelDataRoti.Rows(e).Cells(0).Value
            namaRoti = tabelDataRoti.Rows(e).Cells(1).Value
            hargaRoti = tabelDataRoti.Rows(e).Cells(2).Value
            diskonRoti = tabelDataRoti.Rows(e).Cells(3).Value
            stokRoti = tabelDataRoti.Rows(e).Cells(4).Value
        End If
    End Sub

    Private Sub btnEditRoti_Click(sender As Object, e As EventArgs) Handles btnEditRoti.Click
        If String.IsNullOrEmpty(kodeRoti) = False Then
            editRoti = True
            formRoti.ShowDialog()
        Else
            MsgBox("Mohon Pilih Data")
        End If
    End Sub

    Private Sub btnHapusRoti_Click(sender As Object, e As EventArgs) Handles btnHapusRoti.Click
        If String.IsNullOrEmpty(kodeRoti) = False Then
            If MsgBox("Apakah Anda Yakin Menghapus Data?", vbYesNo, "Konfirmasi") = vbYes Then
                RotiTableAdapter.hapus(kodeRoti)
                Me.RotiTableAdapter.Fill(Me.TheBreadShopDataSet.roti)
            End If
        Else
            MsgBox("Mohon Pilih Data!")
        End If
    End Sub

    Private Sub txCariRoti_TextChanged(sender As Object, e As EventArgs) Handles txCariRoti.TextChanged
        If txCariRoti.Text = "" Then
            Me.RotiTableAdapter.Fill(Me.TheBreadShopDataSet.roti)
        Else
            Dim cari As String = "%" + txCariRoti.Text + "%"
            RotiTableAdapter.FillByCari(TheBreadShopDataSet.roti, cari, cari)
        End If
    End Sub

    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If PanelWrapperRoti.Visible Then
            If e.KeyCode = Keys.F3 Then
                txCariRoti.Focus()
            ElseIf e.KeyCode = Keys.F4 Then
                btnTambahRoti_Click(sender, e)
            ElseIf e.KeyCode = Keys.F5 Then
                btnEditRoti_Click(sender, e)
            ElseIf e.KeyCode = Keys.F6 Then
                btnHapusRoti_Click(sender, e)
            End If
        ElseIf PanelWrapperKaryawan.Visible Then
            If e.KeyCode = Keys.F3 Then
                txCariKaryawan.Focus()
            ElseIf e.KeyCode = Keys.F4 Then
                'btnTambahkaryawan_Click(sender, e)
            ElseIf e.KeyCode = Keys.F5 Then
                'btnEditRoti_Click(sender, e)
            ElseIf e.KeyCode = Keys.F6 Then
                'btnHapusRoti_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles btnHapusKaryawan.Click

    End Sub

    Sub pilihSelKaryawan(ByVal e As String)
        If e >= 0 Then
            kodeKaryawan = tabelDataKaryawan.Rows(e).Cells(0).Value
            namaKaryawan = tabelDataKaryawan.Rows(e).Cells(1).Value
            shiftKaryawan = tabelDataKaryawan.Rows(e).Cells(2).Value
            levelKaryawan = tabelDataKaryawan.Rows(e).Cells(3).Value
            If IsDBNull(tabelDataKaryawan.Rows(e).Cells(4).Value) = False Then
                pasFoto = tabelDataKaryawan.Rows(e).Cells(4).Value
            End If
            passwordKaryawan = tabelDataKaryawan.Rows(e).Cells(5).Value
        End If
    End Sub

    Private Sub tabelDataKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataKaryawan.CellClick
        pilihSelKaryawan(e.RowIndex)
    End Sub

    Private Sub CBKodeRoti_TextChanged(sender As Object, e As EventArgs) Handles CBKodeRoti.TextChanged
        If CBKodeRoti.Text = "" Then
            isiItemCBKodeRoti()
            'Else
            '   Dim dt As New TheBreadShopDataSet.rotiDataTable
            '  dt = RotiTableAdapter.GetDataByKodeRoti("%" + CBKodeRoti.Text + "%")
            ' For i = 0 To dt.Count - 1
            'CBKodeRoti.Items.Clear()
            'CBKodeRoti.Items.Add(dt.Rows(i).Item(0))
            'Next
        End If
    End Sub
End Class
