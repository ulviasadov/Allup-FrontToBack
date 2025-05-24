using Microsoft.AspNetCore.Mvc;

namespace Allup_FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
