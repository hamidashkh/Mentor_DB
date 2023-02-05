using Mentor_DB.DataAccesLayers;
using Mentor_DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_DB.Controllers
{
    public class EventsController : Controller
    {
        private AppDbContext _context;
        public EventsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Events>events=_context.Events.ToList();
            return View(events);
        }
    }
}
