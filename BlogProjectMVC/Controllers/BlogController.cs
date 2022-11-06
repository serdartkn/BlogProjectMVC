using Business.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProjectMVC.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager();
        
        public ActionResult Index()
        {
            return View();
        } 

        public PartialViewResult BlogList(int page = 1)
        {
            var blogList = blogManager.GetAll().ToPagedList(page,6);
            return PartialView(blogList);
        }

        public PartialViewResult FeaturedPosts()
        {
            var postTitle1 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage1 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogImage).FirstOrDefault();
            var postDate1 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogDate).FirstOrDefault();
            ViewBag.postTitle1 = postTitle1;
            ViewBag.postImage1 = postImage1;
            ViewBag.postDate1 = postDate1;

            var postTitle2 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage2 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogImage).FirstOrDefault();
            var postDate2 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogDate).FirstOrDefault();
            ViewBag.postTitle2 = postTitle2;
            ViewBag.postImage2 = postImage2;
            ViewBag.postDate2 = postDate2;

            var postTitle3 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage3 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogImage).FirstOrDefault();
            var postDate3 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogDate).FirstOrDefault();
            ViewBag.postTitle3 = postTitle3;
            ViewBag.postImage3 = postImage3;
            ViewBag.postDate3 = postDate3;

            var postTitle4 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 6).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage4 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 6).Select(y => y.BlogImage).FirstOrDefault();
            var postDate4 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 6).Select(y => y.BlogDate).FirstOrDefault();
            ViewBag.postTitle4 = postTitle4;
            ViewBag.postImage4 = postImage4;
            ViewBag.postDate4 = postDate4;

            //Ortadaki Post
            var postTitle5 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage5 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogImage).FirstOrDefault();
            var postDate5 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogDate).FirstOrDefault();
            var postCategoryName5 = blogManager.GetAll().OrderByDescending(b => b.BlogId).Where(x => x.CategoryId == 4).Select(y => y.Category.CategoryName).FirstOrDefault();
            ViewBag.postTitle5 = postTitle5;
            ViewBag.postImage5 = postImage5;
            ViewBag.postDate5 = postDate5;
            ViewBag.postCategoryName5 = postCategoryName5;

            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts() 
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public ActionResult BlogDetails() 
        {
            return View();
        }

        public PartialViewResult BlogCover(int id) 
        {
            var result = blogManager.GetBlogById(id);
            return PartialView(result);
        }

        public PartialViewResult BlogReadAll(int id) 
        {
            var result = blogManager.GetBlogById(id);
            return PartialView(result);
        }
    }
}