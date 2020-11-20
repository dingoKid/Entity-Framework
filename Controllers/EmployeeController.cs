using Microsoft.AspNetCore.Mvc;
using ShadEntityFrameworkApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ShadEntityFrameworkApp
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}