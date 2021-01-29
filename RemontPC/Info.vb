Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System

Public Class Info
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Запрос()
            THT()
            TesterSMT()
            AOI()
        Catch ex As Exception

        End Try
    End Sub


    Sub TesterSMT()
        Dim bar As String = Form1.Serial_TB.Text
        Dim sql As String
        sql = "SELECT[TRID]
      ,[PASS]
      ,[FAIL]
      ,[DateReg] 'дата сканирования'      
      ,[ErrorCodeID]
      ,[Description]
     
  FROM [FAS].[dbo].[Tester_Caden]

  where trid = '" & bar & "'"
        LoadGridFromDB(DataGridView1, sql)


    End Sub


    Sub AOI()
        Dim sql As String
        Dim bar As String = Form1.Serial_TB.Text
        sql = "   use SMDCOMPONETS SELECT inspectionDate 'Дата AOI', User_INSPect 'Ремонтник', InspectResult 'Результат АОИ', UserInspectionResult'Результат проверки',CIRNAME 'Позиция'
  FROM [SMDCOMPONETS].[dbo].[AOIresult]
  where PCBnumber = '" & bar & "'
  order by inspectionDate desc "
        LoadGridFromDB(DataGridView2, sql)


    End Sub

    Sub THT()
        Dim bar As String = Form1.Serial_TB.Text
        Dim sql As String
        sql = "SELECT [CreateDate] as 'Дата' ,[Barcode]   ,[TestResultsDetial] as 'Код Ошибки'
      ,[IsPass]      ,[CreateBy]       FROM [PSIGMA.FLAT].[dbo].[TRC_CommonTest]  where barcode = '" & bar & "'"
        LoadGridFromDB(THTGrid, sql)


    End Sub


    Private Sub Запрос()
        Dim bar As String = Form1.Serial_TB.Text
        Dim sql As String
        BarLabel.Text = bar
        sql = " use [PSIGMA.FLAT] SELECT TOP (1000) trc_unitstate.UnitStateCode as ШАГ	 ,format(TRC_UnitLog.StateCodeDate,'dd.MM.yyyy HH:mm') As ДАТА      ,TRC_dtProductionArea.name AS Линия
      	        FROM [PSIGMA.FLAT].[dbo].[TRC_UnitLog]
  left join trc_unitstate on trc_unitlog.StateCodeID = trc_unitstate.ID
  left join TRC_dtProductionArea on TRC_UnitLog.ProductionAreaID = TRC_dtProductionArea.id
  left join trc_unit on trc_unitlog.UnitID = trc_unit.ID
  where barcode = '" & bar & "'"
        LoadGridFromDB(InfoGrid, sql)

        sql = "Use [PSIGMA.FLAT] SELECT concat(CONVERT(varchar,RegDate,104),' ',CONVERT(varchar,RegDate,108)) as 'Дата Ремонта'	,RegBy as Реонтник,IsUnitOk as 'Результа Ремонта'
			  ,LOT as 'ЛОТ:'
             ,SourceArea AS 'Участок ремонта'
	        
             ,ErrorCode as 'Код отказа'
	        ,Position as 'Позиция'
	        ,RepairCode as 'Код ремонта'
	        ,DefectCode as 'Код дефекта'
	         ,GeneratorCode as 'Код виновника'
                  FROM [PSIGMA.FLAT].[dbo].[TRC_Repair]
                  where barcode = '" & bar & "' 
                 				  union
				  SELECT TOP (1000)          concat(CONVERT(varchar,RapairDate,104),' ',CONVERT(varchar,RapairDate,108)) as 'Дата Ремонта'  
				    ,[Repairer] as 'Ремонтник'
					 , [isUnitOK] as 'Результат ремонта'
					 , right(barcode,3) as Лот
					 , [Repair location] as 'Место ремонта'
					 , [ErrorCode] as 'Код ошибки'
					 , [Position] as 'Позиция'
					 , [RepairCode] as 'Код ремонта'
					 , DefectCode as 'Код дефекта'
					 , GeneratorCode as 'код виновника'
                     FROM [FAS].[dbo].[M_Repair_Table]
                         where barcode = '" & bar & "' "
        LoadGridFromDB(RemGrid, sql)
    End Sub
End Class