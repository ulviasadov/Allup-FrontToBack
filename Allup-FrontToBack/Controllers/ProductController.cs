using Microsoft.AspNetCore.Mvc;

namespace Allup_FrontToBack.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
