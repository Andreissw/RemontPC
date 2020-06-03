Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System


Public Class Form1
    Dim SQL, RFID_X, AppName As String
    Dim Check As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserName.Text = ""
        Lines() 'Получает список линий в комбобокс
        errorcodeList()
        DefectCode()
        repairCode()
        PCName.Text = GetPCName() ' Получает имя компьютера
        LoadChecking()
        'RFID_TB.Text = "1"

    End Sub
    Dim stationid, statname As String
    Sub LoadChecking() ' Проверяет базу с приложением, станциями и линиями

        SQL = " Use FAS SELECT TOP (1) line.name FROM [FAS].[dbo].[M_AppListForPC] left join dbo.M_LineID as line on M_AppListForPC.LineID = line.ID  where StationName = '" & PCName.Text & "'  and appname = '" & AppNames.Text & "'"
        statname = SelectString(SQL)


        If SelectString(SQL) = Nothing Then
            Check = False
            DescpLB.Text = "Настройте станцию, выберите место ремонта"
            DescpLB.Visible = True
            DescpLB.ForeColor = Color.Red
            Ychastok_TB.Select()
        Else
            Check = True
            Ychastok_TB.Text = statname
            Ychastok_TB.Enabled = False
            RFID_TB.Enabled = True
            RFID_TB.Select()
        End If
    End Sub

    Sub nameidstat()
        SQL = " Use FAS SELECT TOP (1) StationID  FROM [FAS].[dbo].[M_AppListForPC] left join dbo.M_LineID as line on M_AppListForPC.LineID = line.ID  where StationName = '" & PCName.Text & "'  and appname = '" & AppNames.Text & "'"
        stationid = SelectString(SQL)
    End Sub

    Private Sub RFID_TB_KeyPress(sender As Object, e As KeyEventArgs) Handles RFID_TB.KeyDown 'ЛОГИН определение станции в базе 

        If e.KeyCode = Keys.Enter And Check = False Then 'Если станция не зарегистрирована
            RFID()
            RFID_TB.Clear()

        ElseIf e.KeyCode = Keys.Enter And Check = True Then 'Если станция зарегистрирована
            rfid2()
            RFID_TB.Clear()

        End If


    End Sub

    Dim modelid As String
    Sub ОпределениеМодели()
        Try
            SQL = "SELECT [id] FROM [QA].[dbo].[ModelTable] where ModelName = '" & ModelLabel.Text & "'"
            modelid = SelectString(SQL)
        Catch ex As Exception
            modelid = "None"
        End Try

    End Sub


    Dim indef As String
    Private Sub Serial_TB_KeyPress(sender As Object, e As KeyEventArgs) Handles Serial_TB.KeyDown 'Программа определение номера 

        If e.KeyCode = Keys.Enter Then
            checkdissLog()

            If Serial_TB.Text.Length < 5 Then ' не принимает меньше 5 символов
                Serial_TB.Clear()
                Exit Sub
            End If

            If Serial_TB.Text.Length = 21 Then 'определние номера СADEN и С.П.
                IndefenitModel()
                ОпределениеМодели()  'Определние ID модели


                ErrorCB.Focus()

            ElseIf Serial_TB.Text.Length = 16 Then
                indef = "1"
                'CheckBarcode()
                LOTLabel.Text = "Неизвестно"
                ModelLabel.Text = "Неизвестно"
                models = ModelLabel.Text
                ModelLabel.Visible = True 'Делает надпись модель видимой
                LOT.Visible = True 'Делает надпись ЛОТ видимой
                LOTLabel.Visible = True
                Button5.Visible = True
                OkBar() ' Функция настройки дисплея
                posit2()
                LabelChecking.Visible = False
                ErrorCB.Focus()
            ElseIf Serial_TB.Text.Length = 9 Or Serial_TB.Text.Length = 11 Then 'Плата с баркодом в 9-11 символов
                indef = "1"
                'CheckBarcode()
                LOTLabel.Text = "Неизвестно"
                ModelLabel.Text = "Неизвестно"
                models = ModelLabel.Text
                ModelLabel.Visible = True 'Делает надпись модель видимой
                LOT.Visible = True 'Делает надпись ЛОТ видимой
                LOTLabel.Visible = True
                Button5.Visible = True
                OkBar() ' Функция настройки дисплея
                posit2()
                LabelChecking.Visible = False
                ErrorCB.Focus()
            Else
                'CheckBarcode()
                contractmodel() ' Если barcode не приемника 
                ErrorCB.Focus()
            End If
            ErrorCB.Text = Errorcode
        End If
    End Sub
    Private Sub PositionCB_KeyDown(sender As Object, e As KeyEventArgs) Handles PositionCB.KeyDown 'добавление поз. номера в листбокс
        check3 = True

        If e.KeyCode = Keys.Enter And PositionCB.Text.Length > 0 Then ' Работает по событию
            CheckPosition() 'проверка позици в базе

            For i = 0 To PositionList.Items.Count - 1 ' Проверка позиции, на дубликат
                PositionList.SelectedIndex = i
                If PositionCB.Text = PositionList.Text Then
                    check3 = False
                    Exit For
                End If
            Next

            If check3 = True Then
                If Check2 = True Then
                    PositionList.Items.Insert(0, PositionCB.Text)
                    PosLB.Text = "Добавлена позиция '" & PositionCB.Text & "'"
                    PosLB.Visible = True
                    PosLB.ForeColor = Color.Green
                    PositionCB.Text = ""
                    PositionList.SelectedIndex = 0
                Else
                    PosLB.Text = "Позиция '" & PositionCB.Text & "' не найдена в базе"
                    PosLB.Visible = True
                    PosLB.ForeColor = Color.Red
                    PositionCB.Text = ""
                    Try
                        PositionList.SelectedIndex = 0
                    Catch ex As Exception

                    End Try
                End If
            Else
                PosLB.Text = "Позиция '" & PositionCB.Text & "' есть в списке"
                PosLB.Visible = True
                PosLB.ForeColor = Color.Red
                PositionCB.Text = ""
                PositionList.SelectedIndex = 0
            End If
        End If
    End Sub

    Sub AddStation() ' Добавление имени компьютера в базу
        AddCheckStation()

        If Check = False Then

            SQL = "insert into [FAS].[dbo].[M_Stations]  (StationName, CreateDate) values ('" & PCName.Text & "',CURRENT_TIMESTAMP)" ' Добавляет в базу имя компьютера
            SelectString(SQL)
            'MsgBox("Добавлен")
            Check = True

        End If

    End Sub
    Dim idapp, STID, idline As String
    Sub addAppST() 'Добавление в базу приложения, станции и место ремонта 

        AppName = AppNames.Text
        If Check = True Then
            SQL = "SELECT TOP (1) [ID_App] FROM [FAS].[dbo].[M_Applications]  where appname = '" & AppName & "'"
            idapp = SelectString(SQL)
            SQL = "SELECT TOP (1) [StationID]  FROM [FAS].[dbo].[M_Stations]  where StationName = '" & PCName.Text & "'"
            STID = SelectString(SQL)
            SQL = "SELECT TOP (1000) [ID]  FROM [FAS].[dbo].[M_LineID]  where [Name] = '" & Ychastok_TB.Text & "'"
            idline = SelectString(SQL)
            SQL = "  Insert into [FAS].[dbo].[M_AppListForPC]  (idapp,appname,LineID,StationID,StationName,AppCreateDate) Values
                     ('" & idapp & "','" & AppName & "', '" & idline & "'  , '" & STID & "','" & PCName.Text & "',CURRENT_TIMESTAMP)"
            SelectString(SQL)
        End If
    End Sub


    Sub AddCheckStation() 'Проверка станции в базе станций 
        SQL = "SELECT TOP (1)      [StationID]      FROM [FAS].[dbo].[M_Stations]  where StationName = '" & PCName.Text & "'"
        stationid = SelectString(SQL)
        If SelectString(SQL) = Nothing Then
            Check = False
        Else
            Check = True

        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles Ychastok_TB.SelectedValueChanged
        RFID_TB.Enabled = True
        RFID_Lb.Enabled = True
        RFID_TB.Select()
    End Sub

    Sub Lines() ' Вывод линий
        SQL = "SELECT TOP (1000) [Name] FROM [FAS].[dbo].[M_LineID]  where TypeID = 5"
        LoadGridFromDB(GridLine, SQL)
        ComboBoxGrid(GridLine, Ychastok_TB, 0)

    End Sub

    Sub errorcodeList()
        SQL = "SELECT TOP (1000) concat(Category,code) FROM [FAS].[dbo].[M_ErrorCode]"
        LoadGridFromDB(ErrorGrid, SQL)
        ComboBoxGrid(ErrorGrid, ErrorCB, 0)
    End Sub

    Sub DefectCode()
        SQL = "SELECT  [DefectCodeName]  FROM [PSIGMA.FLAT].[dbo].[TRC_DefectCode] where DefectCodeName != ''"
        LoadGridFromDB(DefectCodeGrid, SQL)
        ComboBoxGrid(DefectCodeGrid, DefectCodeCB, 0)
    End Sub

    Sub repairCode()
        SQL = "SELECT TOP (10000)   [RepairCodeName] FROM [PSIGMA.FLAT].[dbo].[TRC_RepairCode]"
        LoadGridFromDB(RepCode, SQL)
        ComboBoxGrid(RepCode, RepairCodeCB, 0)
    End Sub

    Sub RFID()
        SQL = "use FAS Select RFID FROM [FAS].[dbo].[M_Users] where RFID = '" & RFID_TB.Text & "'" ' Проверяет RFID
        RFID_X = SelectString(SQL)

        If RFID_X = Nothing Then
            Exit Sub
        End If

        If RFID_X = RFID_TB.Text Then
            Check = True
        Else
            Check = False
            RFID_TB.Clear()
            DescpLB.Text = "Неверный логин"
            DescpLB.Visible = True
            DescpLB.ForeColor = Color.Red
        End If

        If Check = True Then 'ЕСЛИ TRUE то ищет имя в базе 
            SQL = "use FAS Select UserName FROM [FAS].[dbo].[M_Users] where RFID = '" & RFID_TB.Text & "'"
            RFID_X = SelectString(SQL)
            UserName.Text = RFID_X
            RFID_TB.Enabled = False
            RFID_TB.Clear()
            AddStation()
            addAppST() 'Добавление в базу станции
            DescpLB.Visible = False
            Serial_TB.Enabled = True
            nameidstat()
            Ychastok_TB.Enabled = False
            Serial_TB.Focus()
            BTRep.Visible = True

        End If
    End Sub

    Sub rfid2()
        SQL = "use FAS Select RFID FROM [FAS].[dbo].[M_Users] where RFID = '" & RFID_TB.Text & "'" ' Проверяет RFID
        RFID_X = SelectString(SQL)
        If RFID_X = Nothing Then
            Exit Sub
        End If
        If RFID_X = RFID_TB.Text Then
            Check = True
        Else
            RFID_TB.Clear()
            DescpLB.Text = "Неверный логин"
            DescpLB.Visible = True
            DescpLB.ForeColor = Color.Red
            Check = False

        End If

        If Check = True Then 'ЕСЛИ TRUE то ищет имя в базе 
            SQL = "use FAS Select UserName FROM [FAS].[dbo].[M_Users] where RFID = '" & RFID_TB.Text & "'"
            RFID_X = SelectString(SQL)
            UserName.Text = RFID_X
            RFID_TB.Enabled = False
            RFID_TB.Clear()
            DescpLB.Visible = False
            nameidstat()
            Serial_TB.Enabled = True
            Serial_TB.Focus()
            BTRep.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click ' КНОПКА ОТМЕНЫ
        clear()

    End Sub

    Sub clear() 'функция отчистки дисплея
        Display.Enabled = False
        PosLB.Visible = False
        PosLB.Text = ""
        PositionCB.Items.Clear()
        PositionCB.Text = ""
        PositionList.Items.Clear()
        DecsriptionText.Clear()
        Serial_TB.Clear()
        ModelLabel.Visible = False
        LOT.Visible = False
        LOTLabel.Visible = False
        Serial_TB.Enabled = True
        Serial_TB.Focus()
        ErrorCB.Text = ""
        DefectCodeCB.Text = ""
        RepairCodeCB.Text = ""
        GenerateCodeCB.Text = ""
        ErrorCB.BackColor = Color.White
        DefectCodeCB.BackColor = Color.White
        RepairCodeCB.BackColor = Color.White
        DefectCodeCB.BackColor = Color.White
        Button5.Visible = False
    End Sub

    Public models As String
    Sub contractmodel()
        indef = "1"
        CheckBarcode()
        If Check = True Then
            LOTLabel.Text = "Неизвестно"
            ModelLabel.Text = "Неизвестно"
            models = ModelLabel.Text
            ModelLabel.Visible = True 'Делает надпись модель видимой
            LOT.Visible = True 'Делает надпись ЛОТ видимой
            LOTLabel.Visible = True
            Button5.Visible = True
            OkBar() ' Функция настройки дисплея
            posit2()
            LabelChecking.Visible = False
        ElseIf Check = False Then
            Labeltext() ' Функция, пишет что номер не определен
        End If
    End Sub

    Sub IndefenitModel()   'Определяет модель CADEN
        indef = "2"
        CheckBarcode()
        If Check = True Then
            LOTLabel.Text = Microsoft.VisualBasic.Strings.Right(Serial_TB.Text, 3) 'Достает с номера ЛОТ
            ModelLabel.Text = Serial_TB.Text.Substring(7, 6) 'Достает с номера название модели
            models = ModelLabel.Text
            ModelLabel.Visible = True 'Делает надпись модель видимой
            LOT.Visible = True 'Делает надпись ЛОТ видимой
            LOTLabel.Visible = True
            Button5.Visible = True
            OkBar() ' Функция настройки дисплея
            posit()
            If PositionCB.Items.Count = 0 Then
                posit2()
            End If
            LabelChecking.Visible = False
        ElseIf Check = False Then
            Labeltext() ' Функция, пишет что номер не определен
        End If
    End Sub

    Sub posit() 'Определение позиций Добавление позиций относительно МОДЕЛИ
        SQL = "SELECT distinct(positionName)  FROM [PSIGMA.FLAT].[dbo].[TRC_RepairPosition]  where ModelName = '" & ModelLabel.Text & "' "
        LoadGridFromDB(PosGrid, SQL)
        ComboBoxGrid(PosGrid, PositionCB, 0)
    End Sub

    Sub posit2()
        LoadCombo(PositionCB, "SELECT  distinct(positionName)  FROM [PSIGMA.FLAT].[dbo].[TRC_RepairPosition]")
        'SQL = "SELECT  distinct(positionName)  FROM [PSIGMA.FLAT].[dbo].[TRC_RepairPosition]"
        'LoadGridFromDB(PosGrid, SQL)
        ''ComboBoxGrid(PosGrid, PositionCB, 0)
    End Sub



    Sub ComboBoxGrid(grid As DataGridView, cmd As ComboBox, numb As Integer) 'функция - перетаскивает информацию с грида в комбобокс, с помощью цикла
        'For J = 0 To grid.Rows.Count - 2           'Выводим нужные данные, и убираем не нужные
        '    cmd.Items.Add(grid.Rows(J).Cells(numb).Value)
        'Next

    End Sub

    Dim check3 As Boolean = True

    Dim Check2 As Boolean = False
    Sub CheckPosition()
        If indef = "2" Then
            SQL = "SELECT TOP (1000) [ID]      ,[ModelName]      ,[PositionName]  FROM [PSIGMA.FLAT].[dbo].[TRC_RepairPosition]  where PositionName = '" & PositionCB.Text & "' and modelname =  '" & ModelLabel.Text & "'"
            If SelectString(SQL) = Nothing Then
                Check2 = False
            Else
                Check2 = True
            End If
        ElseIf indef = "1" Then
            SQL = "SELECT TOP (1000) [ID]      ,[ModelName]      ,[PositionName]  FROM [PSIGMA.FLAT].[dbo].[TRC_RepairPosition]  where PositionName = '" & PositionCB.Text & "'"
            If SelectString(SQL) = Nothing Then
                Check2 = False
            Else
                Check2 = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If PositionList.SelectedIndex Then
            Try
                PositionList.Items.RemoveAt(PositionList.SelectedIndex())
                PositionList.SelectedIndex = 0
            Catch ex As Exception

            End Try
        Else
            Try
                PositionList.Items.RemoveAt(0)
                PosLB.Text = ""
                PositionList.SelectedIndex = 0
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub ErrorCB_Leave(sender As Object, e As EventArgs) Handles ErrorCB.Leave 'убирается фокус функция срабатывает  ERRORCOMBOBOX

        leavecombo(ErrorCB)
        'DefectCodeCB.Select()
    End Sub

    Private Sub DefectCodeCB_Leave(sender As Object, e As EventArgs) Handles DefectCodeCB.Leave, DefectCodeCB.SelectedIndexChanged 'убирается фокус функция срабатывает  DEFECTCOMBOBOX
        leavecombo(DefectCodeCB)
        'RepairCodeCB.Select()
        'ErrorCB.Select(0, 0)
    End Sub

    Private Sub RepairCodeCB_Leave(sender As Object, e As EventArgs) Handles RepairCodeCB.Leave, RepairCodeCB.SelectedIndexChanged 'убирается фокус функция срабатывает  REPAIRCOMBOBOX
        leavecombo(RepairCodeCB)
        'GenerateCodeCB.Select()
        'DefectCodeCB.Select(0, 0)
    End Sub

    Private Sub GenerateCodeCB_Leave(sender As Object, e As EventArgs) Handles GenerateCodeCB.Leave, GenerateCodeCB.SelectedIndexChanged
        leavecombo(GenerateCodeCB)
        'RepairCodeCB.Select(0, 0)
        'GenerateCodeCB.Select(0, 0)
    End Sub
    Private Sub ErrorCB_KeyDown(sender As Object, e As KeyEventArgs) Handles ErrorCB.KeyDown
        If e.KeyCode = Keys.Enter Then
            DefectCodeCB.Select()
        End If
    End Sub
    Private Sub DefectCodeCB_KeyDown(sender As Object, e As KeyEventArgs) Handles DefectCodeCB.KeyDown
        If e.KeyCode = Keys.Enter Then
            RepairCodeCB.Select()
            ErrorCB.Select(0, 0)
        End If
    End Sub
    Private Sub RepairCodeCB_KeyDown(sender As Object, e As KeyEventArgs) Handles RepairCodeCB.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenerateCodeCB.Select()
            DefectCodeCB.Select(0, 0)
        End If
    End Sub

    Private Sub GenerateCodeCB_KeyDown(sender As Object, e As KeyEventArgs) Handles GenerateCodeCB.KeyDown
        If e.KeyCode = Keys.Enter Then
            PositionCB.Select()
            GenerateCodeCB.Select()
            'GenerateCodeCB.Select(0, 0)
        End If
    End Sub

    Sub leavecombo(combo As ComboBox)

        'Dim checking As Boolean = False
        'If combo.Text = "" Then
        '    combo.BackColor = Color.White
        'Else

        '    For i = 0 To combo.Items.Count - 1
        '        If combo.Items.Item(i) = combo.Text Then
        '            checking = True
        '            Exit For
        '        End If
        '    Next

        '    If checking = False Then
        '        combo.Text = ""
        '        combo.BackColor = Color.LightCoral
        '    Else
        '        checking = True
        '        combo.BackColor = Color.MediumSeaGreen
        '    End If
        'End If
    End Sub



    Sub OkBar() 'функция настройки дисплея
        Serial_TB.Enabled = False
        Display.Enabled = True
        Display.BackColor = Color.Ivory

    End Sub



    Sub Labeltext() 'Функция вывода ошибки
        LabelChecking.Text = "Номер не определен: '" & Serial_TB.Text & "'"
        LabelChecking.Visible = True
        LabelChecking.ForeColor = Color.Red
        Serial_TB.Clear()
    End Sub

    Private Sub NoOk_Click(sender As Object, e As EventArgs) Handles NoOk.Click 'КНОПКА СПСАНИЕ БРАКА
        StageOne()

    End Sub

    Private Sub FalseFaultBT_Click(sender As Object, e As EventArgs) Handles FalseFaultBT.Click ' КНОПКА ложный отказ
        ОпределениеМодели()
        SQL = " Use fas insert into [FAS].[dbo].[M_Repair_Table] (Barcode,RapairDate,Repairer, [Repair location],Repair_Station_ID,Position,RepairCode,DefectCode,GeneratorCode,[Description],isUnitOK,Modelid)
	                VALUES
	                ('" & Serial_TB.Text & "',CURRENT_TIMESTAMP,'" & UserName.Text & "','" & Ychastok_TB.Text & "','" & stationid & "','','Y','3','','" & DecsriptionText.Text & "',1, '" & modelid & "')"
        SelectString(SQL)
        clear()
    End Sub

    Sub checktextbox() 'устанавливает фокус на текстбоксы которые пустые 
        If DefectCodeCB.Text = "" Then
            DefectCodeCB.Select()
            Exit Sub
        End If
        If RepairCodeCB.Text = "" Then
            RepairCodeCB.Select()
            Exit Sub
        End If
    End Sub

    Sub checktextboxRep() 'устанавливает фокус на текстбоксы которые пустые 

        If DefectCodeCB.Text = "" Then
            DefectCodeCB.Select()
            Exit Sub
        End If
        If RepairCodeCB.Text = "" Then
            RepairCodeCB.Select()
            Exit Sub
        End If
        If GenerateCodeCB.Text = "" Then
            GenerateCodeCB.Select()
            Exit Sub
        End If
        If PositionList.Items.Count = 0 Then
            PositionCB.Select()
            Exit Sub
        End If
    End Sub

    Private Sub RepairBT_Click(sender As Object, e As EventArgs) Handles RepairBT.Click 'Кнопка ремонта
        If DefectCodeCB.Text = "" Or RepairCodeCB.Text = "" Or GenerateCodeCB.Text = "" Or PositionList.Items.Count = 0 Then
            checktextboxRep()
        Else
            For i = 0 To PositionList.Items.Count - 1
                SQL = " Use fas insert into [FAS].[dbo].[M_Repair_Table] (Barcode,RapairDate,Repairer, [Repair location],Repair_Station_ID,Position,RepairCode,DefectCode,GeneratorCode,[Description],isUnitOK,[ErrorCode],Modelid)
	                VALUES
	                ('" & Serial_TB.Text & "',CURRENT_TIMESTAMP,'" & UserName.Text & "','" & Ychastok_TB.Text & "','" & stationid & "','" & PositionList.Items.Item(i) & "','" & RepairCodeCB.Text & "','" & DefectCodeCB.Text & "','" & GenerateCodeCB.Text & "','" & DecsriptionText.Text & "',1,'" & ErrorCB.Text & "','" & modelid & "' )"
                SelectString(SQL)

            Next
            clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
        RFID_TB.Enabled = True
        Serial_TB.Enabled = False
        UserName.Text = ""
        BTRep.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        check3 = True

        CheckPosition() 'проверка позици в базе

            For i = 0 To PositionList.Items.Count - 1 ' Проверка позиции, на дубликат
                PositionList.SelectedIndex = i
                If PositionCB.Text = PositionList.Text Then
                    check3 = False
                    Exit For
                End If
            Next

            If check3 = True Then
                If Check2 = True Then
                    PositionList.Items.Insert(0, PositionCB.Text)
                    PosLB.Text = "Добавлена позиция '" & PositionCB.Text & "'"
                    PosLB.Visible = True
                    PosLB.ForeColor = Color.Green
                    PositionCB.Text = ""
                    PositionList.SelectedIndex = 0
                Else
                    PosLB.Text = "Позиция '" & PositionCB.Text & "' не найдена в базе"
                    PosLB.Visible = True
                    PosLB.ForeColor = Color.Red
                    PositionCB.Text = ""
                    Try
                        PositionList.SelectedIndex = 0
                    Catch ex As Exception

                    End Try
                End If
            Else
                PosLB.Text = "Позиция '" & PositionCB.Text & "' есть в списке"
                PosLB.Visible = True
                PosLB.ForeColor = Color.Red
                PositionCB.Text = ""
                PositionList.SelectedIndex = 0
            End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Info.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Date.Now
    End Sub

    Private Sub BTRep_Click(sender As Object, e As EventArgs) Handles BTRep.Click
        Rems.Show()
    End Sub





    Sub StageOne() 'функция списание брака 
        If DefectCodeCB.Text = "" Or RepairCodeCB.Text = "" Then
            checktextbox()
        Else
            SQL = " Use fas insert into [FAS].[dbo].[M_Repair_Table] (Barcode,RapairDate,Repairer, [Repair location],Repair_Station_ID,Position,RepairCode,DefectCode,GeneratorCode,[Description],isUnitOK,[ErrorCode],Modelid)
	                VALUES
	                ('" & Serial_TB.Text & "',CURRENT_TIMESTAMP,'" & UserName.Text & "','" & Ychastok_TB.Text & "','" & stationid & "','','" & RepairCodeCB.Text & "','" & DefectCodeCB.Text & "','" & GenerateCodeCB.Text & "','" & DecsriptionText.Text & "',0,'" & ErrorCB.Text & "','" & modelid & "')"
            SelectString(SQL)

            clear()
        End If

    End Sub



    Dim DateReg, DateRem As String
    Sub CheckBarcode() 'Проверка номера в Таблице UNIT и таблицы ремонта
        SQL = "Use [PSIGMA.FLAT]  SELECT RegDate  FROM [PSIGMA.FLAT].[dbo].[TRC_Unit]  where Barcode = '" & Serial_TB.Text & "'"
        DateReg = SelectString(SQL)
        If DateReg = Nothing Then
            Check = False
        Else
            Check = True
        End If

    End Sub
    Dim Errorcode As String
    Sub checkdissLog() 'проверяет наличие номера в таблице  оказов
        SQL = "Use fas SELECT TOP (1) concat(er.Category ,er.Code )  FROM [FAS].[dbo].[M_Disassembly]  left join [PSIGMA.FLAT].dbo.TRC_Unit as 
                id on M_Disassembly.PCBID = id.id
                left join M_ErrorCode as er on M_Disassembly.ErrorCodeID = er.ID
                where barcode = '" & Serial_TB.Text & "'"
        If SelectString(SQL) = "" Then
            SQL = "use SMDCOMPONETS SELECT concat(err.Category ,err.Code )   FROM [SMDCOMPONETS].[dbo].[LazerBase] as LB left join FAS.dbo.Ct_OperLog as 
                    logs on LB.IDLaser = logs.PCBID
                 left join fas.dbo.FAS_ErrorCode as err on logs.ErrorCodeID = err.ErrorCodeID    where  Content = '" & Serial_TB.Text & "'   
                        and err.ErrorCodeID is not null
                  order by StepDate desc "
        End If

        Errorcode = SelectString(SQL)
    End Sub
End Class

