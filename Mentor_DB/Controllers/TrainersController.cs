using Mentor_DB.DataAccesLayers;
using Mentor_DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_DB.Controllers
{
    public class TrainersController : Controller
    {
        private AppDbContext _context;
        public TrainersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Trainers> trainers=_context.Trainers.ToList();
            return View(trainers);
        }
    }
}
