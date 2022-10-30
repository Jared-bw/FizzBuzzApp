using FizzBuzz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace FizzBuzz.Data
{
    public class MyDbContext : DbContext 
    {
        public DbSet<FizzBuzzClass> FizzBuzzTable { get; set; } = default!;
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
            Database.Migrate();
            if (FizzBuzzTable!.FirstOrDefault() is null)
            {
                var entries = from num in Enumerable.Range(1, 100) select new FizzBuzzClass(num);
                FizzBuzzTable!.AddRange(entries);
                SaveChanges();
            }
            
        }
    }
}
