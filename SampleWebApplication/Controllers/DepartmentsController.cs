using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Data;
using SampleWebApplication.Models;
using System.Linq;

namespace SampleWebApplication.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }
    }
}
