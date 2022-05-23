using System.Web.Mvc;
using System;
namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {

        public ViewResult Index()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Date"];
            ViewBag.Title = TempData["Title"];
       
            return View();
        }

        public RedirectToRouteResult RedirectRoute()
        {
            TempData["Message"] = "Привет";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
        }
        public HttpStatusCodeResult StatusCode()
        {
            // Ошибка 404 - URL не может быть обслужен
            return new HttpStatusCodeResult(404, "Страница не найдена");
        }
    }
}