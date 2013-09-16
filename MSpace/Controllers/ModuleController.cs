using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Controllers
{
    /// <summary>
    /// Module ，通过修改 Module 的 model，实现目标平稳无损替换
    /// </summary>
    public class ModuleController : Controller
    {
        /// <summary>
        /// 左侧导航
        /// </summary>
        /// <returns></returns>
        public ActionResult LeftBanner()
        {
            return PartialView();
        }

        /// <summary>
        /// 面包屑导航
        /// </summary>
        /// <returns></returns>
        public ActionResult BreadCrumb()
        {
            return PartialView();
        }

        /// <summary>
        /// 信息展示
        /// </summary>
        /// <returns></returns>
        public ActionResult BlogRoll()
        {
            return PartialView();
        }
    }
}
