using System;
using System.Web;
using System.Web.Mvc;
using ControllersAndActions.Infrastructure;
namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message =
                "Привет из контроллера DerivedController метода действия Index";
            return View("MyView");
        }
        public ActionResult ActionMethod()
        {
            // Получить доступ к разнообразным свойствам из объектов контекста
            string userName = User.Identity.Name;
            string serverName = Server.MachineName;
            string clientIP = Request.UserHostAddress;
            DateTime dateStamp = HttpContext.Timestamp;

            // Извлечь отправленные данные из Request.Form 
            string oldProductName = Request.Form["OldName"];
            string newProductName = Request.Form["NewName"];

            // ...

            return View();
        }
        public ActionResult WeatherForecast()
        {
            string city = (string)RouteData.Values["city"];
            DateTime forDate = DateTime.Parse(Request.Form["forDate"]);

            // реализовать прогноз погоды

            return View();
        }
        public ActionResult WeatherForecast(string city, DateTime forDate)
        {
            // реализовать прогноз погоды
            return View();
        }
        public ActionResult WeatherForecast(DateTime forDate, string city = "КИЇВ",
    int page = 1)
        {
            // реализовать прогноз погоды
            return View();
        }

        //public void ProduceOutput()
        //{
        //    if (Server.MachineName == "ProfessorWeb")
        //        Response.Redirect("/Basic/Index");
        //    else
        //        Response.Write("Контроллер: Derived, Метод действия: ProduceOutput");
        //}
        public ActionResult ProduceOutput()
        {
            return Redirect("/Basic/Index");
        }
        //public ActionResult ProduceOutput()
        //{
        //    if (Server.MachineName == "MyMachineName")
        //        return new CustomRedirectResult { Url = "/Basic/Index" };
        //    else
        //    {
        //        Response.Write("Контроллер: Derived, Метод действия: ProduceOutput");
        //        return null;
        //    }
        //}

    }
}