using OrderOverview.BusinessLayer;
using OrderOverview.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderOverview.WebApp.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: ProductCategory

        ProductCategoryManager categoryManager = new ProductCategoryManager();

        public ActionResult Index(bool? ConfirmToastr)
        {
            if (ConfirmToastr.HasValue && ConfirmToastr.Value)
            {
                ViewBag.ConfirmSubmitMessage = "Alert!"; 
            }

        var categories = categoryManager.GetProductCategory();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductCategory category)
        {
            categoryManager.Insert(category);
            return RedirectToAction("Index");
        }

        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }






    }
}