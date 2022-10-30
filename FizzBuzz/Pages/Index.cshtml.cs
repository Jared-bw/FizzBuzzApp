using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FizzBuzz.Data;
using FizzBuzz.Models;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IFizzBuzzRepo _repo;

        public IndexModel(IFizzBuzzRepo repo)
        {
            _repo = repo;
        }

        public IList<FizzBuzzClass> FizzBuzzClassList { get;set; } = default!;

        public async Task OnGetAsync()
        {
            FizzBuzzClassList = await _repo.GetAllFizzBuzzItemsAsync();
        }
    }
}
