using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class SiteNewsController : Controller
    {
        private SiteNewsRepository siteNewsRepository = new SiteNewsRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(int id = 0)
        {
            var flag = siteNewsRepository.Delete(id);
            string msg = "删除成功";

            if (!flag) {
                msg = "删除失败";
            }
            return Json(new { flag = flag, msg = msg }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FlexiGrid()
        {
            var list = siteNewsRepository.List().ToList();
            var page = 1;
            var total = 100;
            var rows = Json(list).Data;
            return Json(new { page = page, total = total, rows = rows }, JsonRequestBehavior.AllowGet);
            //return Content(GetFlexiGridJson<SiteNews>(list, 1, 100));
        }

        /// <summary>
        /// 将list转换成FlexiGrid约定格式的Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="page">当前页数</param>
        /// <param name="total">总量</param>
        /// <returns></returns>
        public static string GetFlexiGridJson<T>(List<T> obj, int page, int total)
        {
            string json = "'page':{0},'total':{1},'rows':[{2}]";
            StringBuilder value = new StringBuilder();
            PropertyInfo[] propinfos = null;
            foreach (var i in obj)
            {
                StringBuilder input = new StringBuilder();
                if (propinfos == null)
                {
                    propinfos = i.GetType().GetProperties();
                }
                foreach (PropertyInfo j in propinfos)
                {
                    if (j.Name.ToLower() == "id")
                    {
                        input.AppendFormat("'{0}':'{1}','cell':[", j.Name, j.GetValue(i, null));
                    }
                    input.AppendFormat("'{0}',", j.GetValue(i, null));

                }
                input.Remove(input.Length - 1, 1);
                input.AppendFormat("]");
                value.AppendFormat("'{0}',", "{" + input.ToString() + "}");
            }
            value.Remove(value.Length - 1, 1);
            json = "[{" + string.Format(json, page, total, value) + "}]";
            return json;
        }

        public ActionResult List()
        {
            var list = siteNewsRepository.List();
            return Json(new { news = list }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(SiteNews model)
        {
            var flag = TryValidateModel(model);
            if (flag) {
                model.PublishDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                siteNewsRepository.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
