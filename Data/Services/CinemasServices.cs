using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class CinemasServices : ICinemasServices
    {
        private readonly AppDbContext _context;

        public CinemasServices(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Cinema cinema)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cinema>> GetAll()
        {
            var result = await _context.Cinemas.ToListAsync();
            return result;
        }
        public Cinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Cinema newCinema)
        {
            throw new NotImplementedException();
        }
    }
}
