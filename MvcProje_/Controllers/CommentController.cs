using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_.Controllers
{
    public class CommentController : Controller
    {
        CommentManager _commentManager = new CommentManager();
  
        public PartialViewResult CommentList(int id)
        {
            var commentList = _commentManager.CommentByBlog(id);
            return PartialView(commentList);
        }

        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult LeaveComment(Comment comment)
        {
            _commentManager.CommentAdd(comment);
            return PartialView();
        }


    }
}