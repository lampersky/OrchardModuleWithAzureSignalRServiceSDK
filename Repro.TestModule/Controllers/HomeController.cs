using Microsoft.AspNetCore.Mvc;

namespace Module1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
