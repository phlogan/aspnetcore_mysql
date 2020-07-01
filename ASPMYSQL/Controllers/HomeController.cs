using Microsoft.AspNetCore.Mvc;

namespace ASPMYSQL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}