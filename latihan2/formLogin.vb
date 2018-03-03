Public Class formLogin
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If txID.Text IsNot "" And txPassword.Text IsNot "" Then
            Dim dt As New TheBreadShopDataSet.karyawanDataTable
            dt = KaryawanTableAdapter1.GetDataByLogin(txID.Text, txPassword.Text)
            If dt.Count = 0 Then
                MsgBox("Login Gagal")
            Else
                Me.Hide()
                MainMenu.idKaryawan = dt.Rows(0).Item(0)
                MainMenu.karyawan = dt.Rows(0).Item(1)
                MainMenu.levelAdmin = dt.Rows(0).Item(5)
                MainMenu.ShowDialog()
                If MainMenu.logOff = False Then
                    Me.Close()
                Else
                    txID.Clear()
                    txPassword.Clear()
                    txID.Focus()
                End If
            End If
        Else
            MsgBox("Mohon Dilengkapi")
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
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
End Class