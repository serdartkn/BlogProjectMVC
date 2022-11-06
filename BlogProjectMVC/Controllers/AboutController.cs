using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProjectMVC.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        AboutManager aboutManager = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Footer() 
        {
            var result = aboutManager.GetAll();
            return PartialView(result);
        }

        public PartialViewResult MeetTheTeam() 
        {
            return PartialView();
        }
    }
}