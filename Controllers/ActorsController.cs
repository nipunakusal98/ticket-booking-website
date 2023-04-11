using eTickets.Data;
using eTickets.Data.Services;
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
    }
}

