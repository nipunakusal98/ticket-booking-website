using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IProducersServices
    {
        Task<IEnumerable<Producer>> GetAll();
        Producer GetById(int id);
        void Add(Producer producer);
        void Update(int id, Producer newProducer);
        void Delete(int id);
    }
}
