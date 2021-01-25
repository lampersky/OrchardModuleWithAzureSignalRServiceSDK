using Microsoft.AspNetCore.Mvc;

namespace SimpleMvc.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
