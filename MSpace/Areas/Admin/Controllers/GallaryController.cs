using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ionic.Zip;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class GallaryController : AdminBaseController
    {
        //
        // GET: /Admin/Album/

        private AlbumRepository albumRepository = new AlbumRepository();
        private AlbumImageRepository albumImageRepository = new AlbumImageRepository();

        public ActionResult Index()
        {
            var list = albumRepository.List();
            return View(list);
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Album album)
        {
            var flag = TryValidateModel(album);
            if (ModelState.IsValid)
            {
                albumRepository.Add(album);
                var list = albumRepository.List();
                return Redirect("Index");
            }
            return View(album);
        }

        public ActionResult Album(int id)
        {
            var model = albumRepository.Find(id);
            return View(model);
        }

        public ActionResult AlbumPage(int albumId = 1, int pageIndex = 1)
        {
            ViewBag.PageIndex = pageIndex;
            var list = albumImageRepository.List(albumId);
            return PartialView(list);
        }

        public ActionResult Upload(int id = 1)
        {
            //var list = albumRepository.List();
            //ViewBag.Albums = new SelectList(list, "Id", "Name");

            var model = albumRepository.Find(id);
            return View(model);
        }

        //public ActionResult Download(int albumId, string ext)
        //{
        //    string fileName = albumId + ".pdf";//客户端保存的文件名 
        //    string filePath = Server.MapPath("~/Pdf/Paper.pdf");//路径

        //    System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

        //    if (fileInfo.Exists == true)
        //    {
        //        const long ChunkSize = 102400;//100K 每次读取文件，只读取100K，这样可以缓解服务器的压力 
        //        byte[] buffer = new byte[ChunkSize];

        //        Response.Clear();
        //        System.IO.FileStream iStream = System.IO.File.OpenRead(filePath);
        //        long dataLengthToRead = iStream.Length;//获取下载的文件总大小 
        //        Response.ContentType = "application/octet-stream";
        //        Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName));
        //        while (dataLengthToRead > 0 && Response.IsClientConnected)
        //        {
        //            int lengthRead = iStream.Read(buffer, 0, Convert.ToInt32(ChunkSize));//读取的大小 
        //            Response.OutputStream.Write(buffer, 0, lengthRead);
        //            Response.Flush();
        //            dataLengthToRead = dataLengthToRead - lengthRead;
        //        }
        //        Response.Close();
        //    }

        //    return null;
        //}

        [HttpPost]
        public ActionResult Upload(int id, HttpPostedFileBase Filedata)
        {
            int albumId = id;// = Convert.ToInt32(Request.QueryString["AlbumId"]);
            var model = albumRepository.Find(id);
            try
            {
                Image image = Image.FromStream(Filedata.InputStream);
                DirectoryInfo di = Directory.CreateDirectory(HttpContext.Server.MapPath("~") + "Album\\" + model.Name + "\\");
                string fName =  Path.GetFileName(Filedata.FileName);
                string newName = fName.Substring(0, fName.LastIndexOf('.')) + "-" + DateTime.Now.ToString("yyyyMMddhhmmss") + fName.Substring(fName.LastIndexOf('.'));
                string spath = Path.Combine(di.FullName, newName);
                NLog.LogManager.GetCurrentClassLogger().Debug(spath);
                image.Save(spath);

                albumImageRepository.Add(new AlbumImage { AlbumId = albumId, NewName=newName,  OriginName = Filedata.FileName, Url = string.Format("{0}{1}/{2}", BaseUrl, "Album/" + model.Name, newName) });

                return Json(new { id = "0", mess = "成功上传所有图片" });
            }
            catch (Exception ex)
            {
                NLog.LogManager.GetCurrentClassLogger().Debug(ex.Message);
                return Json(new { id = "1", mess = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult MultiUpload(HttpPostedFileBase[] Filedatas)
        {
            try
            {
                foreach (HttpPostedFileBase Filedata in Filedatas)
                {
                    Image image = Image.FromStream(Filedata.InputStream);
                    string ipath = Path.Combine("Images", Path.GetFileName(Filedata.FileName));
                    string spath = Path.Combine(HttpContext.Server.MapPath("~"), ipath);
                    image.Save(spath);
                    albumImageRepository.Add(new AlbumImage { AlbumId = 1, OriginName = Filedata.FileName, Url = string.Format("{0}{1}/{2}", BaseUrl, "Images", Filedata.FileName) });
                }

                return Json(new { id = "0", mess = "成功上传所有图片" });
            }
            catch (Exception ex)
            {
                return Json(new { id = "1", mess = ex.Message });
            }
        }


        [HttpPost]
        public void tryCrop(string img, int x, int y, int w, int h)
        {
            Image image = Image.FromFile(Path.Combine(HttpContext.Server.MapPath("~"), "Images", img));
            Crop(image, w, h, x, y).Save(Path.Combine(HttpContext.Server.MapPath("~"), "Images", "v" + img));
            Response.Redirect(string.Format("{0}{1}/{2}", BaseUrl, "Images", "v" + img));
        }

        public string BaseUrl
        {
            get
            {
                return Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + '/';
            }
        }

        [NonAction]
        public static Image Crop(Image image, int width, int height, int x, int y)
        {
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            bmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphic = Graphics.FromImage(bmp))
            {
                graphic.SmoothingMode = SmoothingMode.AntiAlias;
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.DrawImage(image, new Rectangle(0, 0, width, height), x, y, width, height, GraphicsUnit.Pixel);
            }

            return bmp;
         }


        public ActionResult Download(int id)
        {
            //string fileName = id + ".pdf";//客户端保存的文件名 
            //string filePath = Server.MapPath("~/Pdf/Paper.pdf");//路径

            //System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

            //if (fileInfo.Exists == true)
            //{
            //    const long ChunkSize = 102400;//100K 每次读取文件，只读取100K，这样可以缓解服务器的压力 
            //    byte[] buffer = new byte[ChunkSize];

            //    Response.Clear();
            //    System.IO.FileStream iStream = System.IO.File.OpenRead(filePath);
            //    long dataLengthToRead = iStream.Length;//获取下载的文件总大小 
            //    Response.ContentType = "application/octet-stream";
            //    Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName));
            //    while (dataLengthToRead > 0 && Response.IsClientConnected)
            //    {
            //        int lengthRead = iStream.Read(buffer, 0, Convert.ToInt32(ChunkSize));//读取的大小 
            //        Response.OutputStream.Write(buffer, 0, lengthRead);
            //        Response.Flush();
            //        dataLengthToRead = dataLengthToRead - lengthRead;
            //    }
            //    Response.Close();
            //}


            Response.Clear();
            var model = albumRepository.Find(id);
            string filename = model.Name+DateTime.Now.ToString("yyyy-MM-dd") + ".zip";
            Response.ContentType = "application/zip";
            Response.AddHeader("content-disposition", "filename=" + filename);

            //很多属性转移到构造函数中设置
            using (ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
            {
                zip.AddDirectory(Server.MapPath("~/Album/"+model.Name));
                zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
                zip.Save(Response.OutputStream);

                
            }



            return null;
        }
        public ActionResult WaterFall()
        {
            return View();
        }

    }
}
