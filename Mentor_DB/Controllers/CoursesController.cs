using Mentor_DB.DataAccesLayers;
using Mentor_DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_DB.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Courses>courses= _context.Courses.ToList();
            return View(courses);
        }
    }
}
