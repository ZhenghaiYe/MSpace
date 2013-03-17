using System.Web.Mvc;

namespace MSpace.Areas.M
{
    public class MAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "M";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "M_default",
                "M/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
