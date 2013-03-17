using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class StatisticsController : Controller
    {
        private ArticleCategoryRepository articleCategoryRepository = new ArticleCategoryRepository();
        private ArticleRepository articleRepository = new ArticleRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Article()
        {
            var categories = articleCategoryRepository.List();
            var articles = articleRepository.List(1);
            return PartialView();
        }

        public ActionResult Album()
        {
            return PartialView();
        }


    }
}
