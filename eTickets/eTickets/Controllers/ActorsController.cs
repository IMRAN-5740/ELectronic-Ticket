using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ActorsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var actorsList = _context.Actors.ToList();
            return View(actorsList);
        }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _context.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
