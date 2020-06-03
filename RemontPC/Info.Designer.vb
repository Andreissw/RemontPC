<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InfoGrid = New System.Windows.Forms.DataGridView()
        Me.BarLabel = New System.Windows.Forms.Label()
        Me.RemGrid = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.THTGrid = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.InfoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THTGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoGrid
        '
        Me.InfoGrid.AllowUserToAddRows = False
        Me.InfoGrid.AllowUserToDeleteRows = False
        Me.InfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InfoGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.InfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InfoGrid.EnableHeadersVisualStyles = False
        Me.InfoGrid.Location = New System.Drawing.Point(12, 50)
        Me.InfoGrid.Name = "InfoGrid"
        Me.InfoGrid.ReadOnly = True
        Me.InfoGrid.RowHeadersVisible = False
        Me.InfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InfoGrid.Size = New System.Drawing.Size(1257, 234)
        Me.InfoGrid.TabIndex = 0
        '
        'BarLabel
        '
        Me.BarLabel.AutoSize = True
        Me.BarLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BarLabel.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BarLabel.Location = New System.Drawing.Point(15, 706)
        Me.BarLabel.Name = "BarLabel"
        Me.BarLabel.Size = New System.Drawing.Size(56, 41)
        Me.BarLabel.TabIndex = 2
        Me.BarLabel.Text = "11"
        '
        'RemGrid
        '
        Me.RemGrid.AllowUserToAddRows = False
        Me.RemGrid.AllowUserToDeleteRows = False
        Me.RemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RemGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.RemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemGrid.EnableHeadersVisualStyles = False
        Me.RemGrid.Location = New System.Drawing.Point(12, 324)
        Me.RemGrid.Name = "RemGrid"
        Me.RemGrid.ReadOnly = True
        Me.RemGrid.RowHeadersVisible = False
        Me.RemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RemGrid.Size = New System.Drawing.Size(1257, 190)
        Me.RemGrid.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 290)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1257, 28)
        Me.TextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "История ремонта"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 701)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1257, 49)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(12, 16)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(1257, 28)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "Этапы сканирования"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Этапы сканирования"
        '
        'THTGrid
        '
        Me.THTGrid.AllowUserToAddRows = False
        Me.THTGrid.AllowUserToDeleteRows = False
        Me.THTGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.THTGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.THTGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.THTGrid.EnableHeadersVisualStyles = False
        Me.THTGrid.Location = New System.Drawing.Point(12, 557)
        Me.THTGrid.Name = "THTGrid"
        Me.THTGrid.ReadOnly = True
        Me.THTGrid.RowHeadersVisible = False
        Me.THTGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.THTGrid.Size = New System.Drawing.Size(1257, 138)
        Me.THTGrid.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 524)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1252, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Этап THT"
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 762)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.BarLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.THTGrid)
        Me.Controls.Add(Me.RemGrid)
        Me.Controls.Add(Me.InfoGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Информация"
        CType(Me.InfoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THTGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InfoGrid As DataGridView
    Friend WithEvents BarLabel As Label
    Friend WithEvents RemGrid As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents THTGrid As DataGridView
    Friend WithEvents Label3 As Label
End Class
