using Microsoft.AspNetCore.Mvc;

namespace WellsBookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
