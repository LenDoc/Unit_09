using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }

        [Route("Test")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        [Route("Add/{user}/{id:int}", Name = "AddRoute")]
        public string Create(string user, int id)
        {
            return string.Format("Пользователь: {0}, Id: {1}", user, id);
        }
    }
}
