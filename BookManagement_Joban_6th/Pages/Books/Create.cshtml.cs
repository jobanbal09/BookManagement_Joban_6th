using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookManagement_Joban_6th.BussinessModel;
using BookManagement_Joban_6th.Data;

namespace BookManagement_Joban_6th.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookManagement_Joban_6th.Data.ApplicationDbContext _context;

        public CreateModel(BookManagement_Joban_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorID"] = new SelectList(_context.Authors, "ID", "Name");
        ViewData["PriceID"] = new SelectList(_context.Prices, "ID", "Rate");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
