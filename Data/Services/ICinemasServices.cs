using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface ICinemasServices
    {
        Task<IEnumerable<Cinema>> GetAll();
        Cinema GetById (int id);
        void Add(Cinema cinema);
        void Update(int id,Cinema newCinema);
        void Delete(int id);
    }
}
