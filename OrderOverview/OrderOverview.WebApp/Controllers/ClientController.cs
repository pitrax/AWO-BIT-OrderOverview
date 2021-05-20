using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderOverview.WebApp.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult List()
        {
            return View();
        }
    }
}