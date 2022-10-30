using FizzBuzz.Models;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzz.Data
{
    public class FizzBuzzRepo : IFizzBuzzRepo
    {
        private readonly MyDbContext _context;
        public FizzBuzzRepo(MyDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<FizzBuzzClass>> GetAllFizzBuzzItemsAsync()
        {
            return await _context.FizzBuzzTable.ToListAsync();
        }
    }
}
