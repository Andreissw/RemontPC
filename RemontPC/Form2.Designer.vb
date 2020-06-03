<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rems
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridRem = New System.Windows.Forms.DataGridView()
        Me.UserCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Count = New System.Windows.Forms.Label()
        Me.GridName = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtOK = New System.Windows.Forms.Button()
        Me.datiPi2 = New System.Windows.Forms.DateTimePicker()
        Me.datiPi1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridPos = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridRem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridRem)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 465)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GridRem
        '
        Me.GridRem.AllowUserToAddRows = False
        Me.GridRem.AllowUserToDeleteRows = False
        Me.GridRem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridRem.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.GridRem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridRem.EnableHeadersVisualStyles = False
        Me.GridRem.Location = New System.Drawing.Point(6, 19)
        Me.GridRem.Name = "GridRem"
        Me.GridRem.ReadOnly = True
        Me.GridRem.RowHeadersVisible = False
        Me.GridRem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridRem.Size = New System.Drawing.Size(750, 440)
        Me.GridRem.TabIndex = 4
        '
        'UserCombo
        '
        Me.UserCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.UserCombo.FormattingEnabled = True
        Me.UserCombo.Location = New System.Drawing.Point(8, 175)
        Me.UserCombo.Name = "UserCombo"
        Me.UserCombo.Size = New System.Drawing.Size(195, 26)
        Me.UserCombo.TabIndex = 2
        Me.UserCombo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Выбор ремонтника"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Отремонтированных плат"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Count.Location = New System.Drawing.Point(213, 34)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(39, 20)
        Me.Count.TabIndex = 3
        Me.Count.Text = "100"
        '
        'GridName
        '
        Me.GridName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GridName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.GridName.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridName.Location = New System.Drawing.Point(1032, 26)
        Me.GridName.Name = "GridName"
        Me.GridName.Size = New System.Drawing.Size(74, 68)
        Me.GridName.TabIndex = 0
        Me.GridName.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BtOK)
        Me.GroupBox2.Controls.Add(Me.datiPi2)
        Me.GroupBox2.Controls.Add(Me.datiPi1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(193, 141)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'BtOK
        '
        Me.BtOK.BackColor = System.Drawing.Color.LightSalmon
        Me.BtOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtOK.Location = New System.Drawing.Point(46, 104)
        Me.BtOK.Name = "BtOK"
        Me.BtOK.Size = New System.Drawing.Size(141, 31)
        Me.BtOK.TabIndex = 4
        Me.BtOK.Text = "Сформировать"
        Me.BtOK.UseVisualStyleBackColor = False
        '
        'datiPi2
        '
        Me.datiPi2.CustomFormat = "dd.MM.yyyy"
        Me.datiPi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.datiPi2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datiPi2.Location = New System.Drawing.Point(46, 69)
        Me.datiPi2.Name = "datiPi2"
        Me.datiPi2.Size = New System.Drawing.Size(139, 29)
        Me.datiPi2.TabIndex = 3
        Me.datiPi2.Value = New Date(2019, 7, 12, 0, 0, 0, 0)
        '
        'datiPi1
        '
        Me.datiPi1.CustomFormat = "dd.MM.yyyy"
        Me.datiPi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.datiPi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datiPi1.Location = New System.Drawing.Point(46, 34)
        Me.datiPi1.Name = "datiPi1"
        Me.datiPi1.Size = New System.Drawing.Size(139, 29)
        Me.datiPi1.TabIndex = 3
        Me.datiPi1.Value = New Date(2019, 7, 12, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "До"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "От"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Выберите период"
        '
        'GridPos
        '
        Me.GridPos.AllowUserToAddRows = False
        Me.GridPos.AllowUserToDeleteRows = False
        Me.GridPos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridPos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.GridPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPos.EnableHeadersVisualStyles = False
        Me.GridPos.Location = New System.Drawing.Point(7, 60)
        Me.GridPos.Name = "GridPos"
        Me.GridPos.ReadOnly = True
        Me.GridPos.RowHeadersVisible = False
        Me.GridPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPos.Size = New System.Drawing.Size(187, 194)
        Me.GridPos.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Топ ремонта позиций"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridPos)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 266)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 262)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(5, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 26)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "*Данные по позициям " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "формируются с 11.07.19"
        '
        'Rems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1145, 559)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GridName)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserCombo)
        Me.Controls.Add(Me.GroupBox1)
        Me.name = "Rems"
        Me.Text = "Отчет по ремонту"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridRem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UserCombo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Count As Label
    Friend WithEvents GridName As DataGridView
    Friend WithEvents GridRem As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtOK As Button
    Friend WithEvents datiPi2 As DateTimePicker
    Friend WithEvents datiPi1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GridPos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
End Class
