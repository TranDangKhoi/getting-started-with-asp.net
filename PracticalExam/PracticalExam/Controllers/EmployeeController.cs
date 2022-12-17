using Microsoft.AspNetCore.Mvc;
using PracticalExam.Data;
using PracticalExam.Models;

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

        // GET
        public IActionResult Create()
        {
            return View();
        }
        // POSt
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
