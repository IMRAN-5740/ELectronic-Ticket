using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProducersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var producersList = _context.Producers.ToList();
            return View(producersList);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,Name,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            await _context.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }
    }
}
