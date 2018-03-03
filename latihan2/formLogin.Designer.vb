<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txID = New System.Windows.Forms.TextBox()
        Me.txPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.PanelFormLogin = New System.Windows.Forms.Panel()
        Me.KaryawanTableAdapter1 = New latihan2.TheBreadShopDataSetTableAdapters.karyawanTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelFormLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PanelWindowBar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 117)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 87)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selamat Datang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(538, 30)
        Me.PanelWindowBar.TabIndex = 0
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(508, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 10
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'txID
        '
        Me.txID.Location = New System.Drawing.Point(70, 183)
        Me.txID.Name = "txID"
        Me.txID.Size = New System.Drawing.Size(398, 20)
        Me.txID.TabIndex = 0
        '
        'txPassword
        '
        Me.txPassword.Location = New System.Drawing.Point(70, 257)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.Size = New System.Drawing.Size(398, 20)
        Me.txPassword.TabIndex = 1
        Me.txPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 281)
        Me.Label4.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(468, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 281)
        Me.Label5.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(70, 362)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(398, 36)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnMasuk)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(70, 300)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(398, 62)
        Me.Panel4.TabIndex = 6
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnMasuk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMasuk.FlatAppearance.BorderSize = 0
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(0, 0)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(398, 62)
        Me.btnMasuk.TabIndex = 0
        Me.btnMasuk.Text = "Login"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'PanelFormLogin
        '
        Me.PanelFormLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFormLogin.Controls.Add(Me.Panel4)
        Me.PanelFormLogin.Controls.Add(Me.Panel3)
        Me.PanelFormLogin.Controls.Add(Me.Label5)
        Me.PanelFormLogin.Controls.Add(Me.Label4)
        Me.PanelFormLogin.Controls.Add(Me.txPassword)
        Me.PanelFormLogin.Controls.Add(Me.txID)
        Me.PanelFormLogin.Controls.Add(Me.Label3)
        Me.PanelFormLogin.Controls.Add(Me.Label2)
        Me.PanelFormLogin.Controls.Add(Me.Panel1)
        Me.PanelFormLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelFormLogin.Name = "PanelFormLogin"
        Me.PanelFormLogin.Size = New System.Drawing.Size(540, 400)
        Me.PanelFormLogin.TabIndex = 7
        '
        'KaryawanTableAdapter1
        '
        Me.KaryawanTableAdapter1.ClearBeforeFill = True
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 400)
        Me.Controls.Add(Me.PanelFormLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLogin"
        Me.Panel1.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelFormLogin.ResumeLayout(False)
        Me.PanelFormLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txID As TextBox
    Friend WithEvents txPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnMasuk As Button
    Friend WithEvents PanelFormLogin As Panel
    Friend WithEvents KaryawanTableAdapter1 As TheBreadShopDataSetTableAdapters.karyawanTableAdapter
    Friend WithEvents btnKeluar As Button
End Class
