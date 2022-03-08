using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager _blogManager = new BlogManager();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AuthorAbout(int id)
        {
            var authorDetail = _blogManager.GetBlogById(id);
            return PartialView(authorDetail);
        }
            
        public PartialViewResult AuthorPopulerPost(int id)
        {
            var blogAuthorId = _blogManager.GetAll().Where(x => x.BlogId == id).Select( y => y.AuthorId).FirstOrDefault();
            var authorBlogs = _blogManager.GetBlogById(blogAuthorId);
            return PartialView(authorBlogs);
        }
    }
}