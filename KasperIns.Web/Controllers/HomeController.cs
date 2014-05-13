using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KasperIns.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CompanyInfo()
        {
            return View();
        }

        public ActionResult AgentBio()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }
                            //        <li>@Html.ActionLink("Company Info", "CompanyInfo", "Home")</li>
                            //<li>@Html.ActionLink("Agent Bio", "AgentBio", "Home")</li>
                            //<li>@Html.ActionLink("Services", "Services", "Home")</li>
    }
}