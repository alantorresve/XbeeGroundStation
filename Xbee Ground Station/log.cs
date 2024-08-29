/*以純文字檔案紀錄Bug資訊*/

using System;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
namespace log
{
    public class Project_log
    {
        /// <summary>           
        /// 以text純文字檔紀錄LOG內容,以天為檔案,自訂存檔路徑,並且記錄時間 Record LOG content in plain text files, use days as files, customize the archive path, and record the time
        /// </summary>
        /// <param name="LOG">需要紀錄的字串</param>
        /// <param name="filePath">存檔路徑</param>
        public void Log_txet(string LOG , string filePath)
        {
            //今日日期
            DateTime Date = DateTime.Now;
            string TodyMillisecond = Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Tody = Date.ToString("yyyy-MM-dd");

            //如果此路徑沒有資料夾 If there is no folder for this path
            if (!Directory.Exists(filePath))
            {
                //新增資料夾
                Directory.CreateDirectory(filePath);
            }

            //把內容寫到目的檔案，若檔案存在則附加在原本內容之後(換行) Write the content to the target file, if the file exists, append it after the original content (line break)
            File.AppendAllText(filePath + Tody + ".txt", "\r\n" + TodyMillisecond + "：" + LOG);
        }

        /// <summary>
        /// 以text純文字檔紀錄LOG內容,以天為檔案,存檔在...\\LOG\\command_log\\下,並且記錄時間 Record the LOG content in plain text files, take the day as the file, archive it under ...\\LOG\\command_log\\, and record the time
        /// </summary>
        /// <param name="LOG">需要紀錄的字串 string to record</param>
        public void Command_log(string LOG)
        {
            Log_txet(LOG, "C:\\Users\\user\\Desktop\\Helmholtz cage project\\GranSystems_text_20201013\\GranSystems_text_20201013");
        }

        /// <summary>
        /// 以text純文字檔紀錄LOG內容,以天為檔案,存檔在"...\\LOG\\receive_log\\"下,並且記錄時間 Record the LOG content in plain text files, take the day as the file, archive it under "...\\LOG\\receive_log\\", and record the time
        /// </summary>
        /// <param name="LOG">需要紀錄的字串 string to record</param>
        public void Receive_log(string LOG)
        {
            Log_txet(LOG, "C:\\Users\\user\\Desktop\\Helmholtz cage project\\GranSystems_text_20201013\\GranSystems_text_20201013");
        }

        /// <summary>
        /// 以text純文字檔紀錄LOG內容,以天為檔案,存檔在"...\\LOG\\error_log\\"下,並且記錄時間 Record the LOG content in a plain text file, take the day as the file, archive it under "...\\LOG\\error_log\\", and record the time
        /// </summary>
        /// <param name="LOG">需要紀錄的字串 string to record</param>
        public void Error_log(string LOG)
        {
            Log_txet(LOG, "C:\\Users\\user\\Desktop\\Helmholtz cage project\\GranSystems_text_20201013\\GranSystems_text_20201013");
        }

        /// <summary>
        /// 將資料以Excel內容儲存,單行最新資料放置於第二行 Store the data as Excel content, and place the latest data in a single row in the second row
        /// </summary>
        /// <param name="strTitle">cell content</param>
        /// <param name="set_strHead">第一行項目</param>
        /// <param name="set_filePath">儲存路徑</param>
        public void ToExcel(string[] strTitle, string[] set_strHead,string set_filePath)//資料,項目,路徑
        {
            //int nMax = 9;
            //int nMin = 4;

            //int rowCount = nMax - nMin + 1;//總行數

            int columnCount = set_strHead.Length;//總列數



            //建立Excel物件

            Excel.Application excelApp = new Excel.Application();


            //設定Excel不可見

            excelApp.Visible = false;

            //新建工作簿

            //Excel.Workbook workBook = excelApp.Workbooks.Add(true);
            Excel.Workbook workBook = new Excel.Workbook();
            // 嘗試打開已經存在的workbook
            string filePath = System.IO.Directory.GetCurrentDirectory() + "/" + set_filePath;
            try
            {
                workBook = excelApp.Application.Workbooks.Open(filePath, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ex)    //若檔案不存在則加入新的workbook
            {
                workBook = excelApp.Workbooks.Add(Type.Missing);
            }

            //新建工作表

            Excel.Worksheet worksheet = workBook.ActiveSheet as Excel.Worksheet;





            //設定表頭

            string[] strHead = set_strHead;

            int[] columnWidth = new int[4] { 8, 16, 8, 10 };

            for (int i = 0; i < columnCount; i++)
            {

                //Excel.Range headRange = worksheet.Cells[2, i + 1] as Excel.Range;//獲取表頭單元格

                Excel.Range headRange = worksheet.Cells[1, i + 1] as Excel.Range;//獲取表頭單元格,不用標題則從1開始

                headRange.Value2 = strHead[i];//設定單元格文字

                headRange.Font.Name = "宋體";//設定字型

                headRange.Font.Size = 12;//字型大小

                headRange.Font.Bold = false;//加粗顯示

                headRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;//水平居中

                headRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;//垂直居中

                headRange.ColumnWidth = columnWidth[i];//設定列寬

                //  headRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;//設定邊框

                // headRange.Borders.Weight = Excel.XlBorderWeight.xlThin;//邊框常規粗細

            }



            //設定每列格式



            for (int i = 0; i < columnCount; i++)
            {
                //Excel.Range contentRange = worksheet.get_Range(worksheet.Cells[2, i + 1], worksheet.Cells[rowCount - 1 + 3, i + 1]);//不用標題則從第二行開始

                Excel.Range contentRange = worksheet.get_Range(worksheet.Cells[2, i + 1], Type.Missing); ;
                
                contentRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;//水平居中

                contentRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;//垂直居中

                //contentRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;//設定邊框

                // contentRange.Borders.Weight = Excel.XlBorderWeight.xlThin;//邊框常規粗細

                contentRange.WrapText = true;//自動換行

                contentRange.NumberFormatLocal = "@";//文字格式
                
                //插入
                contentRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
                if(i< strTitle.Length)
                {
                    contentRange.Cells[2, i + 1] = strTitle[i];
                }

            }




            try
            {
                // 儲存workbook
                workBook.SaveAs(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing
                    , Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing
                    , Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ex)
            {
                Error_log(ex.ToString());
            }
            //關閉workbook
            workBook.Close(false, Type.Missing, Type.Missing);

            //關閉Excel
            excelApp.Quit();

            //釋放Excel資源
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            workBook = null;
            workBook = null;
            workBook = null;
            excelApp = null;
            GC.Collect();

        }
    }



}



    