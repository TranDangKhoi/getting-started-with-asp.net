using Microsoft.AspNetCore.Mvc;
using PracticalExam.Data;

namespace PracticalExam.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objEmployeeList = _db.Employees.ToList();
            return View(objEmployeeList);
        }
    }
}
