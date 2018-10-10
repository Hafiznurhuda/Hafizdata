<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBnama = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tbpermintaan = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBkeperluan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbbidang = New System.Windows.Forms.ComboBox()
        Me.LV1 = New System.Windows.Forms.ListView()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btedit = New System.Windows.Forms.Button()
        Me.Btupdate = New System.Windows.Forms.Button()
        Me.Btapus = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.Tbbentuk = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Pengajuan Dana"
        '
        'TBnama
        '
        Me.TBnama.Location = New System.Drawing.Point(108, 42)
        Me.TBnama.Name = "TBnama"
        Me.TBnama.Size = New System.Drawing.Size(179, 20)
        Me.TBnama.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(108, 155)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BtSave
        '
        Me.BtSave.Location = New System.Drawing.Point(108, 317)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(75, 23)
        Me.BtSave.TabIndex = 3
        Me.BtSave.Text = "Add"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Pelaksana"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jml Permintaan"
        '
        'Tbpermintaan
        '
        Me.Tbpermintaan.Location = New System.Drawing.Point(108, 114)
        Me.Tbpermintaan.Name = "Tbpermintaan"
        Me.Tbpermintaan.Size = New System.Drawing.Size(179, 20)
        Me.Tbpermintaan.TabIndex = 5
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(108, 178)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(108, 201)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Keperluan"
        '
        'TBkeperluan
        '
        Me.TBkeperluan.Location = New System.Drawing.Point(108, 234)
        Me.TBkeperluan.Multiline = True
        Me.TBkeperluan.Name = "TBkeperluan"
        Me.TBkeperluan.Size = New System.Drawing.Size(179, 77)
        Me.TBkeperluan.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Bidang"
        '
        'Cbbidang
        '
        Me.Cbbidang.FormattingEnabled = True
        Me.Cbbidang.Items.AddRange(New Object() {"ICT", "Akademik", "Keuangan", "Marketing"})
        Me.Cbbidang.Location = New System.Drawing.Point(108, 76)
        Me.Cbbidang.Name = "Cbbidang"
        Me.Cbbidang.Size = New System.Drawing.Size(179, 21)
        Me.Cbbidang.TabIndex = 12
        '
        'LV1
        '
        Me.LV1.Location = New System.Drawing.Point(374, 34)
        Me.LV1.Name = "LV1"
        Me.LV1.Size = New System.Drawing.Size(267, 294)
        Me.LV1.TabIndex = 13
        Me.LV1.UseCompatibleStateImageBehavior = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(655, 361)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 350
        Me.LineShape1.X2 = 349
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 357
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bentuk dana"
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(374, 334)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 23)
        Me.btedit.TabIndex = 16
        Me.btedit.Text = "Edit"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'Btupdate
        '
        Me.Btupdate.Location = New System.Drawing.Point(189, 317)
        Me.Btupdate.Name = "Btupdate"
        Me.Btupdate.Size = New System.Drawing.Size(75, 23)
        Me.Btupdate.TabIndex = 17
        Me.Btupdate.Text = "Update"
        Me.Btupdate.UseVisualStyleBackColor = True
        '
        'Btapus
        '
        Me.Btapus.Location = New System.Drawing.Point(566, 334)
        Me.Btapus.Name = "Btapus"
        Me.Btapus.Size = New System.Drawing.Size(75, 23)
        Me.Btapus.TabIndex = 18
        Me.Btapus.Text = "Hapus"
        Me.Btapus.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(422, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2018, 10, 7, 0, 0, 0, 0)
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(36, 380)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(54, 20)
        Me.tbid.TabIndex = 20
        '
        'Tbbentuk
        '
        Me.Tbbentuk.Location = New System.Drawing.Point(284, 380)
        Me.Tbbentuk.Name = "Tbbentuk"
        Me.Tbbentuk.Size = New System.Drawing.Size(54, 20)
        Me.Tbbentuk.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Tunai"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cek bank"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(128, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Giro"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 361)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tbbentuk)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Btapus)
        Me.Controls.Add(Me.Btupdate)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LV1)
        Me.Controls.Add(Me.Cbbidang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBkeperluan)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tbpermintaan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TBnama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBnama As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents BtSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tbpermintaan As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBkeperluan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cbbidang As System.Windows.Forms.ComboBox
    Friend WithEvents LV1 As System.Windows.Forms.ListView
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents Btupdate As System.Windows.Forms.Button
    Friend WithEvents Btapus As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents Tbbentuk As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
