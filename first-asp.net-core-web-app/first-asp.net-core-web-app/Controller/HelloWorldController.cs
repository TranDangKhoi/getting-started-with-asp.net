using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // With the current pattern : pattern: "{controller=Home}/{action=Index}/{id?}");. You can passed in parameters in two ways

    // 1. Using ? and &
    // GET: /HelloWorld/Welcome?name=Rick&numtimes=4
    public string Welcome(string name, int numTimes = 1)
    {
        // Interpolated String: ($"{value}")
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
    // 2. Using slug, ? and & if there is more params
    // GET: /HelloWorld/Welcome2/{id}?name=name
    public string Welcome2(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}