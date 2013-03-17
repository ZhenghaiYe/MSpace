using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Controllers
{
    public class GlobalAsyncController : AsyncController
    {
        //
        // GET: /GlobalAsync/

        public ActionResult Index()
        {
            return View();
        }

        public void FamousWordAsync()
        {
            AsyncManager.OutstandingOperations.Increment();
           var task = Task.Factory.StartNew(() =>
            {
                // ...perform async operation here 
                AsyncManager.Parameters["info"] = "Result From Async Controller";
                NLog.LogManager.GetCurrentClassLogger().Debug("开始执行异步操作");
                AsyncManager.OutstandingOperations.Decrement();
                
            });
           task.Wait();
        }

        public ActionResult FamousWordCompleted()
        {
            NLog.LogManager.GetCurrentClassLogger().Debug("异步操作执行完毕");
            ViewBag.Info = AsyncManager.Parameters["info"].ToString();
            return PartialView();
        }

        public void ComponentAsync()
        {
            AsyncManager.OutstandingOperations.Increment();
            var task = Task.Factory.StartNew(() =>
            {
                // ...perform async operation here 
                AsyncManager.Parameters["components"] = "Result From Async Controller";
                NLog.LogManager.GetCurrentClassLogger().Debug("开始执行异步操作");
                AsyncManager.OutstandingOperations.Decrement();

            });
            task.Wait();
        }

        public ActionResult ComponentAsyncCompleted()
        {
            NLog.LogManager.GetCurrentClassLogger().Debug("异步操作执行完毕");
            ViewBag.Info = AsyncManager.Parameters["info"].ToString();
            return PartialView();
        }

    }
}
