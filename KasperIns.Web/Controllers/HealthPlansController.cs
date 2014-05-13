using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KasperIns.Web.Controllers
{
    public class HealthPlansController : Controller
    {
        // GET: HealthPlans
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndividualPlans()
        {
            return View();
        }

        public ActionResult Individuals()
        {
            return View();
        }

        public ActionResult Medicare()
        {
            return View();
        }

        public ActionResult Groups()
        {
            return View();
        }

        public ActionResult Dental()
        {
            return View();
        }

        public ActionResult Life()
        {
            return View();
        }
    }
}