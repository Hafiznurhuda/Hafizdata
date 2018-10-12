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
        Me.components = New System.ComponentModel.Container()
        Me.btsend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tbidnum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbunit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbac = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbdes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbphone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbins = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbtrabs = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.LVReq = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DdToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btsend
        '
        Me.btsend.Location = New System.Drawing.Point(130, 310)
        Me.btsend.Name = "btsend"
        Me.btsend.Size = New System.Drawing.Size(84, 29)
        Me.btsend.TabIndex = 0
        Me.btsend.Text = "Send Request"
        Me.btsend.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name of Rquestor"
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(130, 51)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(136, 20)
        Me.tbname.TabIndex = 2
        '
        'tbidnum
        '
        Me.tbidnum.Location = New System.Drawing.Point(130, 86)
        Me.tbidnum.Name = "tbidnum"
        Me.tbidnum.Size = New System.Drawing.Size(136, 20)
        Me.tbidnum.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Number"
        '
        'tbunit
        '
        Me.tbunit.Location = New System.Drawing.Point(130, 121)
        Me.tbunit.Name = "tbunit"
        Me.tbunit.Size = New System.Drawing.Size(136, 20)
        Me.tbunit.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unit"
        '
        'tbac
        '
        Me.tbac.Location = New System.Drawing.Point(447, 86)
        Me.tbac.Name = "tbac"
        Me.tbac.Size = New System.Drawing.Size(136, 20)
        Me.tbac.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "A/C Reg"
        '
        'tbdes
        '
        Me.tbdes.Location = New System.Drawing.Point(447, 51)
        Me.tbdes.Name = "tbdes"
        Me.tbdes.Size = New System.Drawing.Size(136, 20)
        Me.tbdes.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "To unit/Destination"
        '
        'tbphone
        '
        Me.tbphone.Location = New System.Drawing.Point(447, 153)
        Me.tbphone.Name = "tbphone"
        Me.tbphone.Size = New System.Drawing.Size(136, 20)
        Me.tbphone.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ext. Phone/HP"
        '
        'tbins
        '
        Me.tbins.Location = New System.Drawing.Point(130, 201)
        Me.tbins.Multiline = True
        Me.tbins.Name = "tbins"
        Me.tbins.Size = New System.Drawing.Size(432, 103)
        Me.tbins.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Instruction"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Date of Issue"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(343, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Transportation"
        '
        'cbtrabs
        '
        Me.cbtrabs.FormattingEnabled = True
        Me.cbtrabs.Items.AddRange(New Object() {"Pick Up", "Box", "Blind Van", "Truck", "BTT", "Forklift", "Other"})
        Me.cbtrabs.Location = New System.Drawing.Point(447, 121)
        Me.cbtrabs.Name = "cbtrabs"
        Me.cbtrabs.Size = New System.Drawing.Size(136, 21)
        Me.cbtrabs.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(130, 157)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(29, 12)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(55, 20)
        Me.tbid.TabIndex = 19
        '
        'LVReq
        '
        Me.LVReq.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LVReq.Location = New System.Drawing.Point(12, 367)
        Me.LVReq.Name = "LVReq"
        Me.LVReq.Size = New System.Drawing.Size(550, 181)
        Me.LVReq.TabIndex = 20
        Me.LVReq.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DdToolStripMenuItem, Me.DdToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 48)
        '
        'DdToolStripMenuItem
        '
        Me.DdToolStripMenuItem.Name = "DdToolStripMenuItem"
        Me.DdToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DdToolStripMenuItem.Text = "Edit"
        '
        'DdToolStripMenuItem1
        '
        Me.DdToolStripMenuItem1.Name = "DdToolStripMenuItem1"
        Me.DdToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DdToolStripMenuItem1.Text = "Hapus"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 29)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 560)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LVReq)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cbtrabs)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbins)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbphone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbdes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbunit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbidnum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btsend)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btsend As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents tbidnum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbunit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbac As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbdes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbphone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbins As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbtrabs As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents LVReq As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DdToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
