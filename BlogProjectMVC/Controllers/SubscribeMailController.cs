using Business.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProjectMVC.Controllers
{
    public class SubscribeMailController : Controller
    {
        // GET: Subscribe

        SubscribeMailManager _subscribeMailManager = new SubscribeMailManager();

        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail subscribeMail)
        {
            _subscribeMailManager.AddMail(subscribeMail);
            return PartialView();
        }
    }
}