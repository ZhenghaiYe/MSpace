using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class DataController : AdminBaseController
    {
        private ArticleCategoryRepository articleCategoryRepository = new ArticleCategoryRepository();
        private ArticleRepository articleRepository = new ArticleRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BackupFile()
        {
            return PartialView();
        }

        public ActionResult Backup()
        {
            return PartialView();
        }

        public ActionResult Export()
        {
            return PartialView();
        }

    }
}
