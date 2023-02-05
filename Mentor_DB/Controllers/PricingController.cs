using Mentor_DB.DataAccesLayers;
using Mentor_DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_DB.Controllers
{
    public class PricingController : Controller
    {
        private AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Pricing>  pricings= _context.Pricing.ToList();
            return View(pricings);
        }
    }
}
