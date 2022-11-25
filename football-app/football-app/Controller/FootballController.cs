using Microsoft.AspNetCore.Mvc;

namespace football_app.Controllers;

public class FootballController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Matches()
    {
        return View();
    }
}
