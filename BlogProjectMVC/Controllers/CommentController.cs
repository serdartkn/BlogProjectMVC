using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProjectMVC.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager commentManager = new CommentManager();
        public PartialViewResult CommentList(int id)
        {
            var result = commentManager.GetAllByBlogId(id);
            return PartialView(result);
        }

        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }
    }
}