using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager _categoryManager = new CategoryManager();

        public ActionResult Index()
        {
            var categoryValues = _categoryManager.GetAll();
            return View(categoryValues);
        }

        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryValues = _categoryManager.GetAll();
            return PartialView(categoryValues);
        }
    }
}