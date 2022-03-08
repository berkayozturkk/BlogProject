using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Footer()
        {
            var aboutManager = _aboutManager.GetAll();
            return PartialView(aboutManager);
        }

        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
    }
}