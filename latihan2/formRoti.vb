Imports System.ComponentModel

Public Class formRoti
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Sub ulangForm()
        txKodeRoti.Clear()
        txNamaRoti.Clear()
        txHarga.Clear()
        txDiskon.Clear()
        txStok.Clear()
        txKodeRoti.Enabled = True
        txKodeRoti.Focus()
    End Sub

    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        ulangForm()
        If MainMenu.editRoti Then
            txKodeRoti.Text = MainMenu.kodeRoti
            txKodeRoti.Enabled = False
            txNamaRoti.Focus()
        End If
    End Sub

    Private Sub formRoti_Load(sender As Object, e As EventArgs) Handles Me.Load
        ulangForm()
        If MainMenu.editRoti = False Then
            ulangForm()
        Else
            txKodeRoti.Text = MainMenu.kodeRoti
            txNamaRoti.Text = MainMenu.namaRoti
            txHarga.Text = Decimal.ToInt32(MainMenu.hargaRoti)
            txDiskon.Text = Decimal.ToInt32(MainMenu.diskonRoti)
            txStok.Text = Decimal.ToInt32(MainMenu.stokRoti)
            txKodeRoti.Enabled = False
            txNamaRoti.Focus()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txKodeRoti.Text = "" Or txNamaRoti.Text = "" Or txHarga.Text = "" Or txDiskon.Text = "" Or txStok.Text = "" Then
            MsgBox("Mohon Data Dilengkapi!")
        Else
            Try
                If MainMenu.editRoti = False Then
                    RotiTableAdapter.Insert(txKodeRoti.Text, txNamaRoti.Text, txHarga.Text, txDiskon.Text, txStok.Text)
                Else
                    RotiTableAdapter.edit(txNamaRoti.Text, txHarga.Text, txDiskon.Text, txStok.Text, txKodeRoti.Text)
                End If
                MainMenu.RotiTableAdapter.Fill(MainMenu.TheBreadShopDataSet.roti)
                Me.Close()
            Catch ex As Exception
                MsgBox("Kode Roti Sudah Ada!")
            End Try
        End If
    End Sub

    Private Sub formRoti_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainMenu.Show()
    End Sub

    Sub banHuruf(ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskon.KeyPress
        banHuruf(e)
    End Sub

    Private Sub txHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txHarga.KeyPress
        banHuruf(e)
    End Sub

    Private Sub txStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txStok.KeyPress
        banHuruf(e)
    End Sub
End Class