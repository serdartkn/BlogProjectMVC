using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProjectMVC.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public PartialViewResult AboutAuthor()
        {
            return PartialView();   
        }

        public PartialViewResult AuthorPopularPost() 
        {
            return PartialView();
        }
    }
}