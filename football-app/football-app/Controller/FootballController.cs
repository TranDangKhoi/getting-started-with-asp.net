using Microsoft.AspNetCore.Mvc;

namespace football_app.Controllers;

public class FootballController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Matches(int id)
    {
        ViewData["id"] = id;
        return View();
    }
}
