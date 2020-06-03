Public Class Rems
    Dim sql, name As String
    Dim startdateRem, endDateRem As DateTime
    Private Sub Rems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datiPi1.Value = Now
        datiPi2.Value = Now.AddDays(1)
        UserCombo.Text = Form1.UserName.Text
        name = Form1.UserName.Text
        names()
        zapros(name)
        Top(name)



    End Sub

  Sub zapros(cmd As String)
        startdateRem = datiPi1.Value
        endDateRem = datiPi2.Value
        sql = "Use FAS SELECT Barcode, RapairDate as Дата, Repairer as Ремонтник, M_Repair_Table.DefectCode as Дефект, Position as Позиция, ErrorCode as Ошибка, RepairCode as 'код ремонта'
                FROM [FAS].[dbo].[M_Repair_Table]
                  WHERE RapairDate   between  ('" & startdateRem.ToString("yyyy-MM-dd") & "') and ('" & endDateRem.ToString("yyyy-MM-dd") & "')
                      and Repairer ='" & cmd & "'
                    union
					  SELECT Barcode, RegDate, regby, DefectCode, Position, ErrorCode, RepairCode
                      FROM [PSIGMA.FLAT].[dbo].[TRC_Repair]
                       WHERE RegDate   between  ('" & startdateRem.ToString("yyyy-MM-dd") & "') and ('" & endDateRem.ToString("yyyy-MM-dd") & "')
                       and RegBy ='" & cmd & "'"
        LoadGridFromDB(GridRem, sql)
        Count.Text = GridRem.Rows.Count
    End Sub

    Sub names() ' Вывод линий
        sql = "Use FAS SELECT distinct(Repairer)   FROM [FAS].[dbo].[M_Repair_Table]  where Repairer != ''"
        LoadGridFromDB(GridName, sql)
        ComboBoxGrid(GridName, UserCombo, 0)

    End Sub


    Sub zaprosAll()
        startdateRem = datiPi1.Value
        endDateRem = datiPi2.Value
        sql = "Use FAS SELECT Barcode, RapairDate as Дата, Repairer as Ремонтник, M_Repair_Table.DefectCode as Дефект, Position as Позиция, ErrorCode as Ошибка, RepairCode as 'код ремонта'
                FROM [FAS].[dbo].[M_Repair_Table]
                  WHERE RapairDate   between  ('" & startdateRem.ToString("yyyy-MM-dd") & "') and ('" & endDateRem.ToString("yyyy-MM-dd") & "')  
                     union
					  SELECT Barcode, RegDate, regby, DefectCode, Position, ErrorCode, RepairCode
                      FROM [PSIGMA.FLAT].[dbo].[TRC_Repair]
                       WHERE RegDate   between  ('" & startdateRem.ToString("yyyy-MM-dd") & "') and ('" & endDateRem.ToString("yyyy-MM-dd") & "')
                       "
        LoadGridFromDB(GridRem, sql)
        Count.Text = GridRem.Rows.Count
    End Sub




    Private Sub BtOK_Click(sender As Object, e As EventArgs) Handles BtOK.Click
        Dim name As String
        name = UserCombo.Text
        If name = "Все" Then
            zaprosAll()
            TopAll()
        Else
            zapros(name)
            Top(name)
        End If

    End Sub


    Sub ComboBoxGrid(grid As DataGridView, cmd As ComboBox, numb As Integer) 'функция - перетаскивает информацию с грида в комбобокс, с помощью цикла
        For J = 0 To grid.Rows.Count - 2           'Выводим нужные данные, и убираем не нужные
            cmd.Items.Add(grid.Rows(J).Cells(numb).Value)
        Next

        cmd.Items.Add("Все")
    End Sub

    Sub Top(cmd As String)
        sql = "Use FAS SELECT distinct(position), count(position) as Количество FROM [FAS].[dbo].[M_Repair_Table] WHERE RapairDate  between  ('" & startdateRem.ToString("yyyy-MM-dd") & "') and ('" & endDateRem.ToString("yyyy-MM-dd") & "') and position != '' and Repairer = '" & cmd & "'
				  group by position
				  order by count(position) desc "
        LoadGridFromDB(GridPos, sql)
        visible()
    End Sub

    Sub TopAll()
        sql = "Use FAS SELECT distinct(position), count(position) as Количество FROM [FAS].[dbo].[M_Repair_Table] WHERE RapairDate  between  ('" & startdateRem.ToString("yyyy-MM-dd") & "') and ('" & endDateRem.ToString("yyyy-MM-dd") & "') and position != '' 
				  group by position
				  order by count(position) desc "
        LoadGridFromDB(GridPos, sql)
        visible()
    End Sub



    Sub ComboBoxGridPos(grid As DataGridView, cmd As ComboBox, numb As Integer) 'функция - перетаскивает информацию с грида в комбобокс, с помощью цикла
        For J = 0 To grid.Rows.Count - 2           'Выводим нужные данные, и убираем не нужные
            cmd.Items.Add(grid.Rows(J).Cells(numb).Value)
        Next
    End Sub

    Sub visible()
        GroupBox3.Visible = True
    End Sub
End Class