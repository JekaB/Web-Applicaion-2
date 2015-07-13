using System.Web.Mvc;

namespace Web_Applicaion_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int firstVal = 10;
            int secondVal = 5;
            int reuslt = firstVal / secondVal;

            ViewBag.Message = "Отладка прилодения ASP.NET MVC!";

            return View(reuslt);
        }
    }
}