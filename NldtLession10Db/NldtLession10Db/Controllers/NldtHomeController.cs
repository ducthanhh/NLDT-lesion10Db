using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NldtLession10Db.Controllers
{
    public class NldtHomeController : Controller
    {
        public ActionResult NldtIndex()
        {
            // kiem tra du lieu trong session
            if (Session["NldtAccount"]!=null)
            {
                var NldtAccount = Session["NldtAccount"] as ;
                ViewBag.FullName = NldtAccount.NldtFullName;
            }
            return View();
        }

        public ActionResult NldtAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NldtContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}