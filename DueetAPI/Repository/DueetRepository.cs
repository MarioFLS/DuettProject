using DueetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DueetAPI.Repository
{
    public class DueetRepository : IDueetRepository
    {
        private readonly DueetContext _context;

        public DueetRepository(DueetContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Fruit>> FindAll()
        {
            return await _context.Fruit.ToListAsync();
        }
    }
}
