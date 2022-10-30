using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FizzBuzz.Models
{
    public class FizzBuzzClass
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Text { get; set; }

        public FizzBuzzClass(int id)
        {
            Id = id;
            Text = GetFizzBuzzText(id);
        }


        // TODO: add unit tests, test for non divisible, divisble by 3, 5, and 15
        public static string GetFizzBuzzText(int x)
        {
            StringBuilder sb = new(4);
            if (x % 3 == 0) sb.Append("Fizz");
            if (x % 5 == 0) sb.Append("Buzz");
            return sb.Length == 0 ? x.ToString() : sb.ToString();
        }
    }
}
