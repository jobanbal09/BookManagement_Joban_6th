using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookManagement_Joban_6th.BussinessModel;
using BookManagement_Joban_6th.Data;

namespace BookManagement_Joban_6th.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookManagement_Joban_6th.Data.ApplicationDbContext _context;

        public IndexModel(BookManagement_Joban_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Price).ToListAsync();
        }
    }
}
