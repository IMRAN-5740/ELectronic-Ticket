using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CinemasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cinemasList = _context.Cinemas.ToList();
            return View(cinemasList);
        }
    }
}
