using DueetAPI.Models;

namespace DueetAPI.Repository
{
    public interface IDueetRepository
    {
        Task<IEnumerable<Fruit>> FindAll();
    }
}
