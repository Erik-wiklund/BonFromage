using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BonFromage.Models;
using Microsoft.AspNetCore.Authorization;

namespace BonFromage.Pages.MenuItems
{
    [Authorize]
public class AccountController : Controller
{
    // public ActionResult Login()
    // {
    // }

    // public ActionResult Logout()
    // {
    // }
}
    public class CreateModel : PageModel
    {
        private readonly BonFromageContext _context;

        public CreateModel(BonFromageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MenuItem MenuItem { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MenuItem.Add(MenuItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
