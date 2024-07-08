using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Data;
using SampleWebApplication.Models;
using System.Linq;

namespace SampleWebApplication.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Companies
        public IActionResult Index()
        {
            var companies = _context.Companies.ToList();
            return View(companies);
        }
    }
}
