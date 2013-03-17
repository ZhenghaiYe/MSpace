using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class ComponentController : Controller
    {

        private ComponentRepository componentRepository = new ComponentRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjaxIndex()
        {
            var list = componentRepository.List();
            return Json(new { components = list }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var flag = componentRepository.Delete(id);
            string message = "删除成功";
            if (!flag)
            {
                message = "删除失败";
            }
            return Json(new { success = flag , msg = message});
        }

        /// <summary>
        /// 预览组件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Preview(int id)
        {
            var model = componentRepository.Find(id);
            return PartialView(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Component model)
        {
            var flag = TryUpdateModel<Component>(model, new string[] { "Name", "Content" });

            model.IsEnable = false;
            model.Order = -1;
            model.Content = HttpUtility.HtmlEncode(model.Content);

            if (ModelState.IsValid)
            {
                componentRepository.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}
