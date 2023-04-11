using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersServices _service;
        public ProducersController(IProducersServices service)
        {
            _service = service;
        }
        public async Task <IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
