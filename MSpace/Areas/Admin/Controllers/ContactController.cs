using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class ContactController : AdminBaseController
    {
        private ContactGroupRepository contactGroupRepository = new ContactGroupRepository();
        private ContactRepository contactRepository = new ContactRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var list = contactGroupRepository.List().OrderBy(_ => _.GroupName).ToList();

            ViewBag.Groups = new SelectList(list, "Id", "GroupName");

            return View();
        }

        public ActionResult List()
        {
            var list = from c in contactRepository.List() select new { c.FullName, c.Id, c.ImagePath };

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ListSummary()
        {
            var list = contactRepository.List();

            return PartialView(list);
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            var a = TryValidateModel(contact);
            NLog.LogManager.GetCurrentClassLogger().Debug("是否通过====" + a);
            //for (int i = 0; i < ModelState.Count; i++)
            //{
            //    NLog.LogManager.GetCurrentClassLogger().Debug(ModelState.Keys.ElementAt(i) + ":" + ModelState.Values.ElementAt(0).Errors[0].ErrorMessage);
            //}
            if (ModelState.IsValid)
            {
                contact.FullName = contact.LastName + contact.FirstName;
                var flag = contactRepository.Add(contact);

                return View("Index");
            }
            var list = contactGroupRepository.List().OrderBy(_ => _.GroupName).ToList();
            ViewBag.Groups = new SelectList(list, "Id", "GroupName");
            return View(contact);
        }

    }
}
