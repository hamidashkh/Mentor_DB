using Mentor_DB.DataAccesLayers;
using Mentor_DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_DB.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<HomePage> homePages=_context.homePages.ToList();
            return View(homePages);
        }
    }
}
