using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Filters.Action;
using MSpace.Filters.Authorization;

namespace MSpace.Areas.Admin.Controllers
{
    [SimpleAuthorize]
    public class AdminBaseController : Controller
    {

    }
}
