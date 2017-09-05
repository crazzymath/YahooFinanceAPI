Imports YahooFinanceAPI
Imports System.Globalization
Imports Excel = Microsoft.Office.Interop.Excel

Public Class YahooDataForm
    Private Sub AskButton_Click(sender As Object, e As EventArgs) Handles AskButton.Click

        ProgressBar.Visible = True
        ProgressBar.Minimum = 1
        ProgressBar.Maximum = TextBoxRICs.Lines.Length
        ProgressBar.Value = 1
        ProgressBar.Step = 1

        Dim tablaSalida As New DataTable

        tablaSalida.Columns.Add("RIC")
        tablaSalida.Columns.Add("AdjustedClose", System.Type.GetType("System.Double"))


        Dim DataDate As Date

        DataDate = DateTimePicker.Value

        'First get a valid token from Yahoo Finance
        While (Token.Cookie = "" OrElse Token.Crumb = "")
            Token.Refresh()
        End While



        'And now, we do something...

        For Each ric As String In TextBoxRICs.Lines

            ric = Replace(ric, vbTab, "")
            ric = Replace(ric, vbLf, "")
            ric = Replace(ric, vbCrLf, "")

            If ric <> "" Then

                Dim hps As List(Of HistoryPrice)
                Dim px_Close As Double
                Try
                    hps = Historical.Get(Trim(ric), DataDate.AddMonths(-1), DataDate)
                    If hps.LongCount > 0 Then
                        px_Close = hps.Last.AdjClose
                    Else
                        px_Close = -1
                    End If
                Catch ex As Exception
                    px_Close = -1
                End Try

                Dim fila As DataRow = tablaSalida.NewRow
                fila("RIC") = ric
                fila("AdjustedClose") = Convert.ToDouble(px_Close, CultureInfo.CurrentCulture)
                tablaSalida.Rows.Add(fila)

                Debug.Write(vbLf & ric & vbTab & px_Close & " ")

                ProgressBar.PerformStep()
            Else
                ProgressBar.PerformStep()
            End If
        Next ric

        SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        SaveFileDialog.FileName = "Close Prices - " + DataDate.ToString("yyyyMMdd") + ".xlsx"

        If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            ExportExcel2007(tablaSalida, SaveFileDialog.FileName)
        End If

        ProgressBar.Visible = False
        ProgressBar.Value = 1



    End Sub

    Public Sub ExportExcel2007(ByVal Table As DataTable, ByVal Location As String)
        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i, j As Integer

        Try
            xlApp = New Excel.Application
            'xlApp.DecimalSeparator = ","
            'xlApp.ThousandsSeparator = ""
            xlApp.UseSystemSeparators = True
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = CType(xlWorkBook.Sheets.Add(), Excel.Worksheet)
            xlWorkSheet.Name = "MarketData"
            For i = 0 To Table.Rows.Count - 1
                For j = 0 To Table.Columns.Count - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = Table.Rows(i).Item(j)
                Next
                Application.DoEvents()
            Next
            xlWorkSheet.SaveAs(Location, Excel.XlFileFormat.xlOpenXMLWorkbook)
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub SVTYahooDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxRICs.Lines = My.Settings.ListaRICs.Split(vbLf)
    End Sub

    Private Sub SVTYahooDataForm_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        My.Settings.ListaRICs = TextBoxRICs.Text
    End Sub

End Class
