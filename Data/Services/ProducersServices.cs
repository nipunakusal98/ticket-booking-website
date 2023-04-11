using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ProducersServices : IProducersServices
    {
        private readonly AppDbContext _context;
        public ProducersServices(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Producer producer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producer>> GetAll()
        {
            var result = await _context.Producers.ToListAsync();
            return result;
        }

        public Producer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Producer newProducer)
        {
            throw new NotImplementedException();
        }
    }
}
