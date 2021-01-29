<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Ychastok_TB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RFID_Lb = New System.Windows.Forms.Label()
        Me.RFID_TB = New System.Windows.Forms.TextBox()
        Me.Log_in = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Display = New System.Windows.Forms.GroupBox()
        Me.DecsriptionText = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PosLB = New System.Windows.Forms.Label()
        Me.NoOk = New System.Windows.Forms.Button()
        Me.FalseFaultBT = New System.Windows.Forms.Button()
        Me.RepairBT = New System.Windows.Forms.Button()
        Me.PositionList = New System.Windows.Forms.ListBox()
        Me.GenerateCodeCB = New System.Windows.Forms.ComboBox()
        Me.RepairCodeCB = New System.Windows.Forms.ComboBox()
        Me.DefectCodeCB = New System.Windows.Forms.ComboBox()
        Me.ErrorCB = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PositionCB = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PCName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AppNames = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.LOTLabel = New System.Windows.Forms.Label()
        Me.LOT = New System.Windows.Forms.Label()
        Me.Model = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Serial_TB = New System.Windows.Forms.TextBox()
        Me.GridLine = New System.Windows.Forms.DataGridView()
        Me.DescpLB = New System.Windows.Forms.Label()
        Me.LabelChecking = New System.Windows.Forms.Label()
        Me.PosGrid = New System.Windows.Forms.DataGridView()
        Me.ErrorGrid = New System.Windows.Forms.DataGridView()
        Me.DefectCodeGrid = New System.Windows.Forms.DataGridView()
        Me.RepCode = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BTRep = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me._PSIGMA_FLATDataSet = New RemontPC._PSIGMA_FLATDataSet()
        Me.TRCRepairPositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRC_RepairPositionTableAdapter = New RemontPC._PSIGMA_FLATDataSetTableAdapters.TRC_RepairPositionTableAdapter()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Log_in.SuspendLayout()
        Me.Display.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefectCodeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._PSIGMA_FLATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRCRepairPositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ychastok_TB
        '
        Me.Ychastok_TB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Ychastok_TB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ychastok_TB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ychastok_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Ychastok_TB.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Ychastok_TB.FormattingEnabled = True
        Me.Ychastok_TB.Location = New System.Drawing.Point(12, 46)
        Me.Ychastok_TB.Name = "Ychastok_TB"
        Me.Ychastok_TB.Size = New System.Drawing.Size(261, 37)
        Me.Ychastok_TB.TabIndex = 1
        Me.Ychastok_TB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Участок ремонта"
        '
        'RFID_Lb
        '
        Me.RFID_Lb.AutoSize = True
        Me.RFID_Lb.Enabled = False
        Me.RFID_Lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RFID_Lb.Location = New System.Drawing.Point(6, 86)
        Me.RFID_Lb.Name = "RFID_Lb"
        Me.RFID_Lb.Size = New System.Drawing.Size(172, 29)
        Me.RFID_Lb.TabIndex = 1
        Me.RFID_Lb.Text = "Введите RFID"
        '
        'RFID_TB
        '
        Me.RFID_TB.Enabled = False
        Me.RFID_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.RFID_TB.Location = New System.Drawing.Point(13, 120)
        Me.RFID_TB.Name = "RFID_TB"
        Me.RFID_TB.Size = New System.Drawing.Size(261, 35)
        Me.RFID_TB.TabIndex = 2
        Me.RFID_TB.TabStop = False
        '
        'Log_in
        '
        Me.Log_in.Controls.Add(Me.Ychastok_TB)
        Me.Log_in.Controls.Add(Me.Button2)
        Me.Log_in.Controls.Add(Me.RFID_TB)
        Me.Log_in.Controls.Add(Me.Label1)
        Me.Log_in.Controls.Add(Me.RFID_Lb)
        Me.Log_in.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Log_in.Location = New System.Drawing.Point(6, 26)
        Me.Log_in.Name = "Log_in"
        Me.Log_in.Size = New System.Drawing.Size(286, 198)
        Me.Log_in.TabIndex = 3
        Me.Log_in.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 38)
        Me.Button2.TabIndex = 7
        Me.Button2.TabStop = False
        Me.Button2.Text = "Выход"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.Color.Silver
        Me.Display.Controls.Add(Me.DecsriptionText)
        Me.Display.Controls.Add(Me.Button3)
        Me.Display.Controls.Add(Me.Button1)
        Me.Display.Controls.Add(Me.PosLB)
        Me.Display.Controls.Add(Me.NoOk)
        Me.Display.Controls.Add(Me.FalseFaultBT)
        Me.Display.Controls.Add(Me.RepairBT)
        Me.Display.Controls.Add(Me.PositionList)
        Me.Display.Controls.Add(Me.GenerateCodeCB)
        Me.Display.Controls.Add(Me.RepairCodeCB)
        Me.Display.Controls.Add(Me.DefectCodeCB)
        Me.Display.Controls.Add(Me.ErrorCB)
        Me.Display.Controls.Add(Me.Label12)
        Me.Display.Controls.Add(Me.PositionCB)
        Me.Display.Controls.Add(Me.Label11)
        Me.Display.Controls.Add(Me.Label6)
        Me.Display.Controls.Add(Me.Label10)
        Me.Display.Controls.Add(Me.Label9)
        Me.Display.Controls.Add(Me.Label4)
        Me.Display.Enabled = False
        Me.Display.Location = New System.Drawing.Point(298, 230)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(710, 312)
        Me.Display.TabIndex = 4
        Me.Display.TabStop = False
        '
        'DecsriptionText
        '
        Me.DecsriptionText.Location = New System.Drawing.Point(445, 182)
        Me.DecsriptionText.Multiline = True
        Me.DecsriptionText.Name = "DecsriptionText"
        Me.DecsriptionText.Size = New System.Drawing.Size(221, 81)
        Me.DecsriptionText.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Image = Global.RemontPC.My.Resources.Resources.Plus1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(666, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 45)
        Me.Button3.TabIndex = 7
        Me.Button3.TabStop = False
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Image = Global.RemontPC.My.Resources.Resources.icons8_minus_38
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(667, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 45)
        Me.Button1.TabIndex = 7
        Me.Button1.TabStop = False
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PosLB
        '
        Me.PosLB.AutoSize = True
        Me.PosLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PosLB.Location = New System.Drawing.Point(317, 16)
        Me.PosLB.Name = "PosLB"
        Me.PosLB.Size = New System.Drawing.Size(87, 16)
        Me.PosLB.TabIndex = 6
        Me.PosLB.Text = "Description"
        Me.PosLB.Visible = False
        '
        'NoOk
        '
        Me.NoOk.BackColor = System.Drawing.Color.Red
        Me.NoOk.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.NoOk.FlatAppearance.BorderSize = 2
        Me.NoOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NoOk.Location = New System.Drawing.Point(522, 268)
        Me.NoOk.Name = "NoOk"
        Me.NoOk.Size = New System.Drawing.Size(180, 36)
        Me.NoOk.TabIndex = 4
        Me.NoOk.TabStop = False
        Me.NoOk.Text = "UNIT IS NOT OK"
        Me.NoOk.UseVisualStyleBackColor = False
        '
        'FalseFaultBT
        '
        Me.FalseFaultBT.BackColor = System.Drawing.Color.GreenYellow
        Me.FalseFaultBT.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FalseFaultBT.FlatAppearance.BorderSize = 2
        Me.FalseFaultBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FalseFaultBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FalseFaultBT.Location = New System.Drawing.Point(249, 268)
        Me.FalseFaultBT.Name = "FalseFaultBT"
        Me.FalseFaultBT.Size = New System.Drawing.Size(267, 36)
        Me.FalseFaultBT.TabIndex = 4
        Me.FalseFaultBT.TabStop = False
        Me.FalseFaultBT.Text = " FALSEFAULT"
        Me.FalseFaultBT.UseVisualStyleBackColor = False
        '
        'RepairBT
        '
        Me.RepairBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RepairBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RepairBT.FlatAppearance.BorderSize = 2
        Me.RepairBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RepairBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RepairBT.Location = New System.Drawing.Point(9, 268)
        Me.RepairBT.Name = "RepairBT"
        Me.RepairBT.Size = New System.Drawing.Size(236, 36)
        Me.RepairBT.TabIndex = 4
        Me.RepairBT.TabStop = False
        Me.RepairBT.Text = "REPAIRED"
        Me.RepairBT.UseVisualStyleBackColor = False
        '
        'PositionList
        '
        Me.PositionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.PositionList.FormattingEnabled = True
        Me.PositionList.ItemHeight = 18
        Me.PositionList.Location = New System.Drawing.Point(445, 80)
        Me.PositionList.Name = "PositionList"
        Me.PositionList.Size = New System.Drawing.Size(221, 94)
        Me.PositionList.TabIndex = 6
        '
        'GenerateCodeCB
        '
        Me.GenerateCodeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GenerateCodeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenerateCodeCB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateCodeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GenerateCodeCB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GenerateCodeCB.FormattingEnabled = True
        Me.GenerateCodeCB.Items.AddRange(New Object() {"01", "09"})
        Me.GenerateCodeCB.Location = New System.Drawing.Point(149, 186)
        Me.GenerateCodeCB.MaxLength = 7
        Me.GenerateCodeCB.Name = "GenerateCodeCB"
        Me.GenerateCodeCB.Size = New System.Drawing.Size(129, 26)
        Me.GenerateCodeCB.TabIndex = 4
        '
        'RepairCodeCB
        '
        Me.RepairCodeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RepairCodeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.RepairCodeCB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RepairCodeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RepairCodeCB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RepairCodeCB.FormattingEnabled = True
        Me.RepairCodeCB.Location = New System.Drawing.Point(149, 141)
        Me.RepairCodeCB.MaxLength = 7
        Me.RepairCodeCB.Name = "RepairCodeCB"
        Me.RepairCodeCB.Size = New System.Drawing.Size(129, 26)
        Me.RepairCodeCB.TabIndex = 3
        '
        'DefectCodeCB
        '
        Me.DefectCodeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DefectCodeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DefectCodeCB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DefectCodeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DefectCodeCB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.DefectCodeCB.FormattingEnabled = True
        Me.DefectCodeCB.Location = New System.Drawing.Point(149, 97)
        Me.DefectCodeCB.MaxLength = 7
        Me.DefectCodeCB.Name = "DefectCodeCB"
        Me.DefectCodeCB.Size = New System.Drawing.Size(129, 26)
        Me.DefectCodeCB.TabIndex = 2
        '
        'ErrorCB
        '
        Me.ErrorCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ErrorCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ErrorCB.BackColor = System.Drawing.Color.White
        Me.ErrorCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ErrorCB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ErrorCB.FormattingEnabled = True
        Me.ErrorCB.Location = New System.Drawing.Point(149, 51)
        Me.ErrorCB.MaxLength = 7
        Me.ErrorCB.Name = "ErrorCB"
        Me.ErrorCB.Size = New System.Drawing.Size(129, 26)
        Me.ErrorCB.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(15, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Generator Code:"
        '
        'PositionCB
        '
        Me.PositionCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PositionCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PositionCB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PositionCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PositionCB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.PositionCB.FormattingEnabled = True
        Me.PositionCB.Location = New System.Drawing.Point(445, 48)
        Me.PositionCB.MaxLength = 7
        Me.PositionCB.Name = "PositionCB"
        Me.PositionCB.Size = New System.Drawing.Size(221, 26)
        Me.PositionCB.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(15, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Repair Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(345, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(15, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Defect Code:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(15, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Error Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(317, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Repair Position"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(968, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 31)
        Me.Button4.TabIndex = 4
        Me.Button4.TabStop = False
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PCName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.AppNames)
        Me.GroupBox2.Controls.Add(Me.UserName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ModelLabel)
        Me.GroupBox2.Controls.Add(Me.LOTLabel)
        Me.GroupBox2.Controls.Add(Me.LOT)
        Me.GroupBox2.Controls.Add(Me.Model)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(298, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(710, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'PCName
        '
        Me.PCName.AutoSize = True
        Me.PCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.PCName.Location = New System.Drawing.Point(101, 68)
        Me.PCName.Name = "PCName"
        Me.PCName.Size = New System.Drawing.Size(182, 25)
        Me.PCName.TabIndex = 0
        Me.PCName.Text = "WSG150170dddd"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 0
        '
        'AppNames
        '
        Me.AppNames.AutoSize = True
        Me.AppNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.AppNames.Location = New System.Drawing.Point(246, 15)
        Me.AppNames.Name = "AppNames"
        Me.AppNames.Size = New System.Drawing.Size(75, 25)
        Me.AppNames.TabIndex = 0
        Me.AppNames.Text = "Repair"
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.UserName.Location = New System.Drawing.Point(167, 40)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(124, 25)
        Me.UserName.TabIndex = 0
        Me.UserName.Text = "Volodin A.A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Название приложения: "
        '
        'ModelLabel
        '
        Me.ModelLabel.AutoSize = True
        Me.ModelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.ModelLabel.Location = New System.Drawing.Point(93, 93)
        Me.ModelLabel.Name = "ModelLabel"
        Me.ModelLabel.Size = New System.Drawing.Size(95, 25)
        Me.ModelLabel.TabIndex = 0
        Me.ModelLabel.Text = "Модель:"
        Me.ModelLabel.Visible = False
        '
        'LOTLabel
        '
        Me.LOTLabel.AutoSize = True
        Me.LOTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.LOTLabel.Location = New System.Drawing.Point(66, 119)
        Me.LOTLabel.Name = "LOTLabel"
        Me.LOTLabel.Size = New System.Drawing.Size(62, 25)
        Me.LOTLabel.TabIndex = 0
        Me.LOTLabel.Text = "ЛОТ:"
        Me.LOTLabel.Visible = False
        '
        'LOT
        '
        Me.LOT.AutoSize = True
        Me.LOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.LOT.Location = New System.Drawing.Point(6, 119)
        Me.LOT.Name = "LOT"
        Me.LOT.Size = New System.Drawing.Size(62, 25)
        Me.LOT.TabIndex = 0
        Me.LOT.Text = "ЛОТ:"
        Me.LOT.Visible = False
        '
        'Model
        '
        Me.Model.AutoSize = True
        Me.Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Model.Location = New System.Drawing.Point(5, 93)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(95, 25)
        Me.Model.TabIndex = 0
        Me.Model.Text = "Модель:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label7.Location = New System.Drawing.Point(6, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Станция:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Пользователь :"
        '
        'Serial_TB
        '
        Me.Serial_TB.Enabled = False
        Me.Serial_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Serial_TB.Location = New System.Drawing.Point(298, 193)
        Me.Serial_TB.Name = "Serial_TB"
        Me.Serial_TB.Size = New System.Drawing.Size(666, 31)
        Me.Serial_TB.TabIndex = 3
        Me.Serial_TB.TabStop = False
        '
        'GridLine
        '
        Me.GridLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridLine.Location = New System.Drawing.Point(1635, 171)
        Me.GridLine.Name = "GridLine"
        Me.GridLine.Size = New System.Drawing.Size(32, 30)
        Me.GridLine.TabIndex = 5
        Me.GridLine.Visible = False
        '
        'DescpLB
        '
        Me.DescpLB.AutoSize = True
        Me.DescpLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.DescpLB.Location = New System.Drawing.Point(12, 9)
        Me.DescpLB.Name = "DescpLB"
        Me.DescpLB.Size = New System.Drawing.Size(135, 29)
        Me.DescpLB.TabIndex = 6
        Me.DescpLB.Text = "Description"
        Me.DescpLB.Visible = False
        '
        'LabelChecking
        '
        Me.LabelChecking.AutoSize = True
        Me.LabelChecking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelChecking.Location = New System.Drawing.Point(295, 12)
        Me.LabelChecking.Name = "LabelChecking"
        Me.LabelChecking.Size = New System.Drawing.Size(115, 24)
        Me.LabelChecking.TabIndex = 6
        Me.LabelChecking.Text = "Description"
        Me.LabelChecking.Visible = False
        '
        'PosGrid
        '
        Me.PosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PosGrid.Location = New System.Drawing.Point(1635, 230)
        Me.PosGrid.Name = "PosGrid"
        Me.PosGrid.Size = New System.Drawing.Size(32, 30)
        Me.PosGrid.TabIndex = 5
        Me.PosGrid.Visible = False
        '
        'ErrorGrid
        '
        Me.ErrorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ErrorGrid.Location = New System.Drawing.Point(1635, 275)
        Me.ErrorGrid.Name = "ErrorGrid"
        Me.ErrorGrid.Size = New System.Drawing.Size(32, 30)
        Me.ErrorGrid.TabIndex = 5
        Me.ErrorGrid.Visible = False
        '
        'DefectCodeGrid
        '
        Me.DefectCodeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DefectCodeGrid.Location = New System.Drawing.Point(1635, 311)
        Me.DefectCodeGrid.Name = "DefectCodeGrid"
        Me.DefectCodeGrid.Size = New System.Drawing.Size(32, 30)
        Me.DefectCodeGrid.TabIndex = 5
        Me.DefectCodeGrid.Visible = False
        '
        'RepCode
        '
        Me.RepCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RepCode.Location = New System.Drawing.Point(1635, 347)
        Me.RepCode.Name = "RepCode"
        Me.RepCode.Size = New System.Drawing.Size(32, 30)
        Me.RepCode.TabIndex = 5
        Me.RepCode.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.Location = New System.Drawing.Point(-23, 581)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 10, 3, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1904, 73)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "____________________________________________________"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(-1, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 73)
        Me.Label14.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(711, 653)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 37)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Label8"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BTRep
        '
        Me.BTRep.FlatAppearance.BorderSize = 0
        Me.BTRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTRep.Image = Global.RemontPC.My.Resources.Resources._40_1_
        Me.BTRep.Location = New System.Drawing.Point(240, 292)
        Me.BTRep.Name = "BTRep"
        Me.BTRep.Size = New System.Drawing.Size(57, 73)
        Me.BTRep.TabIndex = 20
        Me.BTRep.TabStop = False
        Me.BTRep.UseVisualStyleBackColor = True
        Me.BTRep.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.RemontPC.My.Resources.Resources.icons8_questions_50
        Me.Button5.Location = New System.Drawing.Point(240, 237)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 58)
        Me.Button5.TabIndex = 8
        Me.Button5.TabStop = False
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        '_PSIGMA_FLATDataSet
        '
        Me._PSIGMA_FLATDataSet.DataSetName = "_PSIGMA_FLATDataSet"
        Me._PSIGMA_FLATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRCRepairPositionBindingSource
        '
        Me.TRCRepairPositionBindingSource.DataMember = "TRC_RepairPosition"
        Me.TRCRepairPositionBindingSource.DataSource = Me._PSIGMA_FLATDataSet
        '
        'TRC_RepairPositionTableAdapter
        '
        Me.TRC_RepairPositionTableAdapter.ClearBeforeFill = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, -4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "_v_last"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1179, 741)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BTRep)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LabelChecking)
        Me.Controls.Add(Me.DescpLB)
        Me.Controls.Add(Me.RepCode)
        Me.Controls.Add(Me.DefectCodeGrid)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ErrorGrid)
        Me.Controls.Add(Me.PosGrid)
        Me.Controls.Add(Me.GridLine)
        Me.Controls.Add(Me.Serial_TB)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.Log_in)
        Me.Controls.Add(Me.Label13)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Настройка"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Log_in.ResumeLayout(False)
        Me.Log_in.PerformLayout()
        Me.Display.ResumeLayout(False)
        Me.Display.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefectCodeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._PSIGMA_FLATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRCRepairPositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ychastok_TB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RFID_Lb As Label
    Friend WithEvents RFID_TB As TextBox
    Friend WithEvents Log_in As GroupBox
    Friend WithEvents Display As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UserName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Serial_TB As TextBox
    Friend WithEvents PCName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GridLine As DataGridView
    Friend WithEvents AppNames As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DescpLB As Label
    Friend WithEvents PositionCB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PositionList As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents FalseFaultBT As Button
    Friend WithEvents RepairBT As Button
    Friend WithEvents ModelLabel As Label
    Friend WithEvents Model As Label
    Friend WithEvents LOTLabel As Label
    Friend WithEvents LOT As Label
    Friend WithEvents LabelChecking As Label
    Friend WithEvents PosGrid As DataGridView
    Friend WithEvents PosLB As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GenerateCodeCB As ComboBox
    Friend WithEvents RepairCodeCB As ComboBox
    Friend WithEvents DefectCodeCB As ComboBox
    Friend WithEvents ErrorCB As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorGrid As DataGridView
    Friend WithEvents DefectCodeGrid As DataGridView
    Friend WithEvents RepCode As DataGridView
    Friend WithEvents DecsriptionText As TextBox
    Friend WithEvents NoOk As Button
    Private WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BTRep As Button
    Friend WithEvents _PSIGMA_FLATDataSet As _PSIGMA_FLATDataSet
    Friend WithEvents TRCRepairPositionBindingSource As BindingSource
    Friend WithEvents TRC_RepairPositionTableAdapter As _PSIGMA_FLATDataSetTableAdapters.TRC_RepairPositionTableAdapter
    Friend WithEvents Label15 As Label
End Class
