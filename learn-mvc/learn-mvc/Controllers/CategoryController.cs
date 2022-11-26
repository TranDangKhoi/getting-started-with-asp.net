using Microsoft.AspNetCore.Mvc;

namespace learn_mvc.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
