using CRUDOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDOperation.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryBAL _categoryBAL;
        public CategoryController(ICategoryBAL categoryBAL)
        {
            _categoryBAL = categoryBAL;
            
        }

        public CategoryController()
        {
            
        }
        // GET: Category

        public ActionResult Index()
        {
            //CategoryBAl categoryBAl = new CategoryBAl();
            var categories= _categoryBAL.GetAllCategories();
            return View(categories);
        }
    }
}