using FizzBuzz.Models;

namespace FizzBuzz.Data
{
    public interface IFizzBuzzRepo
    {
        Task<List<FizzBuzzClass>> GetAllFizzBuzzItemsAsync();
    }
}
