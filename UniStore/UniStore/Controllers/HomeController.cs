using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniStore.Controllers
{
    using UniStore.Handlers;
    public class HomeController : Controller
    {
        private readonly ICategoryHandler categoryHandler;
     
        public HomeController(ICategoryHandler categoryHandler)
        {
            this.categoryHandler = categoryHandler;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}