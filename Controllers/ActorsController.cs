using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        //public IActionResult Index()
        //{
        //    var data = _context.Actors.ToList();
        //    return View();
        //}

        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Actors.ToListAsync());
        //}

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
            
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {

                return View(actor);

            }
            

            _service.Add(actor);
            return RedirectToAction(nameof(Index));

        }
    }
}

