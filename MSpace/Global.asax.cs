using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MSpace
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "DefaultRoute", // 路由名称
                "{controller}/{action}/{id}", // 带有参数的 URL
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // 参数默认值
                new[] { "MSpace.Controllers" }// Namespaces 引入默认的命名空间
            );

            //routes.MapRoute(
            //   "RelatedArticletRoute", // 路由名称
            //   "{controller}/{action}/{tag}", // 带有参数的 URL
            //   new { controller = "Article", action = "RelatedArticle", id = UrlParameter.Optional }, // 参数默认值
            //   new[] { "MSpace.Controllers" }// Namespaces 引入默认的命名空间
            //);

            routes.MapRoute(
                "AdminRoute", // 路由名称
                "Admin/{controller}/{action}/{id}", // 带有参数的 URL
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // 参数默认值
                new[] { "MSpace.Areas.Admin.Controllers" }// Namespaces 引入默认的命名空间
            );

            routes.MapRoute(
                "MRoute", // 路由名称
                "M/{controller}/{action}/{id}", // 带有参数的 URL
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // 参数默认值
                new[] { "MSpace.Areas.M.Controllers" }// Namespaces 引入默认的命名空间
            );


            routes.MapRoute(
                "AlbumRoute", // 路由名称
                "Admin/{controller}/{action}/{albumId}/{pageIndex}", // 带有参数的 URL
                new { controller = "Gallary", action = "Index", albumId = 1, pageIndex = UrlParameter.Optional }, // 参数默认值
                new[] { "MSpace.Areas.Admin.Controllers" }// Namespaces 引入默认的命名空间
            );

            //routes.MapRoute(
            //    "AlbumDownloadRoute", // 路由名称
            //    "Admin/{controller}/{action}/{albumId}.{ext}", // 带有参数的 URL
            //    new { controller = "Gallary", action = "Index", albumId = 1, ext = "zip" }, // 参数默认值
            //    new[] { "MSpace.Areas.Admin.Controllers" }// Namespaces 引入默认的命名空间
            //);

            routes.MapRoute(
                "SectionRoute", // 路由名称
                "Admin/{controller}/{action}/{id}", // 带有参数的 URL
                new { controller = "Home", action = "Index", id = 2 }, // 参数默认值
                new[] { "MSpace.Areas.Admin.Controllers" }// Namespaces 引入默认的命名空间
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
           
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}