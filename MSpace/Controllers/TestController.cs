using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elmah;
using MSpace.Filters.Exception;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace MSpace.Controllers
{
    [MSpaceHandleError]
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
           //return RedirectToAction("Create", new { Id = "操作成功" });
            ViewBag.HHH = CLib.CSecurity.MD5Helper.GetMD5("changweihua@outlook.com");
            return View();
        }

        public ActionResult Create(string Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        public ActionResult Ex()
        {
            try
            {
                int num = Convert.ToInt32("Irving");
            }
            catch (Exception e)
            {
                ErrorSignal.FromCurrentContext().Raise(e);
            }

            return View();
        }

        public ActionResult Ex2()
        {

            int num = Convert.ToInt32("Changweihua");

            return View();
        }



        public ActionResult JsRender()
        {
            return View();
        }

        public ActionResult DownLoad()
        {
            
            return View();
        }

        public ActionResult DownLoadExcel()
        {
            HttpContext.Response.ContentType = "application/x-excel";
            int rowIndex = 0;
            string filename = HttpUtility.UrlEncode("Product_Development_Time_Report.xls");//文件名进行url编码，防止乱码
            HttpContext.Response.AddHeader("Content-Disposition", "attachment;filename=" + filename);
            HSSFWorkbook workbook = new HSSFWorkbook();
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "NPOI Team";
            workbook.DocumentSummaryInformation = dsi;
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "NPOI SDK Example";
            workbook.SummaryInformation = si;
            ISheet sheet = workbook.CreateSheet("Product DevelopmentTime Report");

            //设置报表的主标题信息
            IRow rowTitle = sheet.CreateRow(rowIndex);
            rowTitle.HeightInPoints = 20;

            ICell cellTitle = rowTitle.CreateCell(0);
            //set the title of the sheet
            cellTitle.SetCellValue("Product Development Time Report");
            ICellStyle styleTitle = workbook.CreateCellStyle();
            styleTitle.Alignment = HorizontalAlignment.CENTER;
            //create a font style
            IFont font = workbook.CreateFont();
            font.Boldweight = (short)FontBoldWeight.BOLD;//加粗
            font.FontHeightInPoints = 14;
            styleTitle.SetFont(font);
            cellTitle.CellStyle = styleTitle;
            rowIndex++;


            //merged cells on single row
            //ATTENTION: don't use Region class, which is obsolete
            sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, 2));


            //设置报表副标题
            IRow rowSubTitle = sheet.CreateRow(rowIndex);
            rowSubTitle.HeightInPoints = 18;
            ICell cellSubTitle = rowSubTitle.CreateCell(0);
            //set the title of the sheet
            cellSubTitle.SetCellValue("Period:25/02/2012-26/03/2012"); //区间页面传值
            ICellStyle styleSubTitle = workbook.CreateCellStyle();
            styleSubTitle.Alignment = HorizontalAlignment.CENTER;
            //create a font style
            IFont fontSubTitle = workbook.CreateFont();
            fontSubTitle.Boldweight = (short)FontBoldWeight.BOLD;//加粗
            fontSubTitle.FontHeightInPoints = 12;
            styleSubTitle.SetFont(fontSubTitle);
            cellSubTitle.CellStyle = styleSubTitle;
            sheet.AddMergedRegion(new CellRangeAddress(1, 1, 0, 2));
            rowIndex++;

            IRow rowSubTitle2 = sheet.CreateRow(rowIndex);
            rowSubTitle2.HeightInPoints = 18;
            ICell cellSubTitle2 = rowSubTitle2.CreateCell(0);
            //set the title of the sheet
            cellSubTitle2.SetCellValue("Time360");                     //区间页面传值
            ICellStyle styleSubTitle2 = workbook.CreateCellStyle();
            styleSubTitle2.Alignment = HorizontalAlignment.CENTER;
            //create a font style
            IFont fontSubTitle1 = workbook.CreateFont();
            fontSubTitle1.Boldweight = (short)FontBoldWeight.BOLD;//加粗
            fontSubTitle1.FontHeightInPoints = 12;
            styleSubTitle2.SetFont(fontSubTitle1);
            cellSubTitle2.CellStyle = styleSubTitle2;
            sheet.AddMergedRegion(new CellRangeAddress(2, 2, 0, 2));
            rowIndex++;


            ICellStyle StyleCell = workbook.CreateCellStyle();//创建单元格的样式
            IFont FontCell = workbook.CreateFont();//创建字体样式
            FontCell.Boldweight = (short)FontBoldWeight.BOLD;//加粗
            FontCell.FontHeightInPoints = 12;
            FontCell.FontName = "Arial";

            StyleCell.SetFont(FontCell);
            StyleCell.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER;//横样式
            StyleCell.VerticalAlignment = VerticalAlignment.CENTER;//垂直样式
            StyleCell.BorderBottom = BorderStyle.THIN;
            StyleCell.BorderTop = BorderStyle.THIN;

            IRow rowHeaderTitle = sheet.CreateRow(rowIndex);
            string[] HeadcolumnsStr = new string[] { "Activeity Code ", "This Peroid(Manhours)", "To-Date(Manhours)" };
            for (int i = 0; i < HeadcolumnsStr.Length; i++)
            {
                ICell celltemp = rowHeaderTitle.CreateCell(i);

                celltemp.SetCellValue(HeadcolumnsStr[i]);

                celltemp.CellStyle = StyleCell;

            }
            rowIndex++;

            #region 数据
            StyleCell = workbook.CreateCellStyle();//创建单元格的样式
            FontCell = workbook.CreateFont();//创建字体样式
            FontCell.Boldweight = (short)FontBoldWeight.NORMAL;//普通
            FontCell.FontHeightInPoints = 12;

            FontCell.FontName = "Arial";

            StyleCell.SetFont(FontCell);
            StyleCell.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT;//横样式
            StyleCell.VerticalAlignment = VerticalAlignment.CENTER;//垂直样式
            StyleCell.BorderBottom = BorderStyle.THIN;
            StyleCell.BorderTop = BorderStyle.THIN;
            DataTable sourceTable_TestRecord = new DataTable();


            for (int i = 0; i < sourceTable_TestRecord.Rows.Count; i++)
            {
                IRow rowData = sheet.CreateRow(rowIndex);
                for (int j = 0; j < HeadcolumnsStr.Length; j++)
                {
                    ICell cellValue = rowData.CreateCell(j);


                    cellValue.SetCellValue(sourceTable_TestRecord.Rows[i][j].ToString());
                    cellValue.CellStyle = StyleCell;
                }
                rowIndex++;
            }

            #endregion

            #region 统计

            StyleCell = workbook.CreateCellStyle();//创建单元格的样式
            FontCell = workbook.CreateFont();//创建字体样式
            FontCell.Boldweight = (short)FontBoldWeight.BOLD;//加粗
            FontCell.Color = NPOI.HSSF.Util.HSSFColor.RED.index;
            FontCell.FontHeightInPoints = 12;
            FontCell.FontName = "Arial";

            StyleCell.SetFont(FontCell);
            StyleCell.Alignment = NPOI.SS.UserModel.HorizontalAlignment.RIGHT;//横样式
            StyleCell.VerticalAlignment = VerticalAlignment.CENTER;//垂直样式

            IRow rowTotal = sheet.CreateRow(rowIndex);
            ICell cellTotalName0 = rowTotal.CreateCell(0);
            cellTotalName0.SetCellValue("Total Hours");
            cellTotalName0.CellStyle = StyleCell;


            StyleCell = workbook.CreateCellStyle();//创建单元格的样式
            FontCell = workbook.CreateFont();//创建字体样式
            FontCell.Boldweight = (short)FontBoldWeight.BOLD;//加粗
            FontCell.Color = NPOI.HSSF.Util.HSSFColor.RED.COLOR_NORMAL;
            FontCell.FontHeightInPoints = 12;
            FontCell.FontName = "Arial";

            StyleCell.SetFont(FontCell);
            StyleCell.Alignment = NPOI.SS.UserModel.HorizontalAlignment.RIGHT;//横样式
            StyleCell.VerticalAlignment = VerticalAlignment.CENTER;//垂直样式

            ICell cellTotalName1 = rowTotal.CreateCell(1);
            cellTotalName1.SetCellValue("200");
            cellTotalName1.CellStyle = StyleCell;

            #endregion


            #region 设置列宽
            sheet.SetColumnWidth(0, 12000);
            sheet.SetColumnWidth(1, 12000);
            sheet.SetColumnWidth(2, 12000);
            #endregion


            workbook.Write(HttpContext.Response.OutputStream);
            return null;
        }

        public ActionResult TestJS()
        {
            return View();
        }


        public ActionResult ThirdParty()
        {
            return View();
        }

        public ActionResult DownLoad0()
        {
            /* 
            微软为Response对象提供了一个新的方法TransmitFile来解决使用Response.BinaryWrite 
            下载超过400mb的文件时导致Aspnet_wp.exe进程回收而无法成功下载的问题。 
            代码如下： 
            */
            //Response.ContentType = "application/x-zip-compressed";
            Response.AddHeader("Content-Disposition", "attachment;filename=Paper.pdf");
            string filename = Server.MapPath("~/Pdf/Paper.pdf");
            //Response.TransmitFile(filename);
            return File(filename, "application/pdf");
        }


        /// <summary>
        /// TransmitFile实现下载
        /// </summary>
        /// <returns></returns>
        public ActionResult DownLoad1()
        {
            /* 
            微软为Response对象提供了一个新的方法TransmitFile来解决使用Response.BinaryWrite 
            下载超过400mb的文件时导致Aspnet_wp.exe进程回收而无法成功下载的问题。 
            代码如下： 
            */
            

            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", "attachment;filename=Paper.pdf");
            string filename = Server.MapPath("~/Pdf/Paper.pdf");
            Response.TransmitFile(filename);
            return null;
        }

        /// <summary>
        /// WriteFile实现下载
        /// </summary>
        /// <returns></returns>
        public ActionResult DownLoad2()
        {
            string fileName = "Paper.pdf";//客户端保存的文件名 
            string filePath = Server.MapPath("~/Pdf/Paper.pdf");//路径



            FileInfo fileInfo = new FileInfo(filePath);
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
            Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            Response.AddHeader("Content-Transfer-Encoding", "binary");
            Response.ContentType = "application/octet-stream";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
            Response.WriteFile(fileInfo.FullName);
            Response.Flush();
            Response.End();

            return null;
        }

        /// <summary>
        /// WriteFile分块下载
        /// </summary>
        /// <returns></returns>
        public ActionResult DownLoad3()
        {
            string fileName = "Paper.pdf";//客户端保存的文件名 
            string filePath = Server.MapPath("~/Pdf/Paper.pdf");//路径

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

            if (fileInfo.Exists == true)
            {
                const long ChunkSize = 102400;//100K 每次读取文件，只读取100K，这样可以缓解服务器的压力 
                byte[] buffer = new byte[ChunkSize];

                Response.Clear();
                System.IO.FileStream iStream = System.IO.File.OpenRead(filePath);
                long dataLengthToRead = iStream.Length;//获取下载的文件总大小 
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName));
                while (dataLengthToRead > 0 && Response.IsClientConnected)
                {
                    int lengthRead = iStream.Read(buffer, 0, Convert.ToInt32(ChunkSize));//读取的大小 
                    Response.OutputStream.Write(buffer, 0, lengthRead);
                    Response.Flush();
                    dataLengthToRead = dataLengthToRead - lengthRead;
                }
                Response.Close();
            }

            return null;
        }

        /// <summary>
        /// 流方式下载
        /// </summary>
        /// <returns></returns>
        public ActionResult DownLoad4()
        {
            //string fileName = "download4.pdf";//客户端保存的文件名 
            //string filePath = Server.MapPath("~/Pdf/Paper.pdf");//路径

            ////以字符流的形式下载文件 
            //FileStream fs = new FileStream(filePath, FileMode.Open);
            //byte[] bytes = new byte[(int)fs.Length];
            //fs.Read(bytes, 0, bytes.Length);
            //fs.Close();
            //Response.ContentType = "application/pdf";
            ////通知浏览器下载文件而不是打开 
            //Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
            //Response.BinaryWrite(bytes);
            //Response.Flush();
            //Response.End();

            MemoryStream ms = new MemoryStream();
            IWorkbook workbook = new HSSFWorkbook();//创建Workbook对象

            ISheet sheet = workbook.CreateSheet("Sheet1");//创建工作表

            IRow row = sheet.CreateRow(0);//在工作表中添加一行

            ICell cell = row.CreateCell(0);//在行中添加一列

            cell.SetCellValue("test");//设置列的内容

            workbook.Write(ms);
            byte[] bytes = new byte[(int)ms.Length];
            ms.Read(bytes, 0, bytes.Length);
            ms.Close();
            //Response.ContentType = "application/x-excel";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode("Test.xls", System.Text.Encoding.UTF8));
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();

            return null;
        }


        public void DownloadFile(System.Web.UI.Page WebForm, String FileNameWhenUserDownload, String FileBody)
        {

            WebForm.Response.ClearHeaders();
            WebForm.Response.Clear();
            WebForm.Response.Expires = 0;
            WebForm.Response.Buffer = true;
            WebForm.Response.AddHeader("Accept-Language", "zh-tw");
            //'文件名称
            WebForm.Response.AddHeader("content-disposition", "attachment; filename='" + System.Web.HttpUtility.UrlEncode(FileNameWhenUserDownload, System.Text.Encoding.UTF8) + "'");
            WebForm.Response.ContentType = "Application/octet-stream";
            //'文件内容
            WebForm.Response.Write(FileBody);//-----------
            WebForm.Response.End();
        }


        //上面这段代码是下载一个动态产生的文本文件，若这个文件已经存在于服务器端的实体路径，则可以通过下面的函数：

        public void DownloadFileByFilePath(System.Web.UI.Page WebForm, String FileNameWhenUserDownload, String FilePath)
        {
            WebForm.Response.ClearHeaders();
            WebForm.Response.Clear();
            WebForm.Response.Expires = 0;
            WebForm.Response.Buffer = true;
            WebForm.Response.AddHeader("Accept-Language", "zh-tw");
            //文件名称
            WebForm.Response.AddHeader("content-disposition", "attachment; filename='" + System.Web.HttpUtility.UrlEncode(FileNameWhenUserDownload, System.Text.Encoding.UTF8) + "'");
            WebForm.Response.ContentType = "Application/octet-stream";
            //文件内容
            WebForm.Response.Write(System.IO.File.ReadAllBytes(FilePath));//---------
            WebForm.Response.End();


        }
    }
}
