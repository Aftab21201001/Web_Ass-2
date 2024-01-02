using Microsoft.AspNetCore.Mvc;

namespace PAKWEAR.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
