using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BonFromage.Models;

namespace BonFromage.Pages.MenuItems
{
    public class DetailsModel : PageModel
    {
        private readonly BonFromageContext _context;

        public DetailsModel(BonFromageContext context)
        {
            _context = context;
        }

        public MenuItem MenuItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MenuItem = await _context.MenuItem.FirstOrDefaultAsync(m => m.ID == id);

            if (MenuItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
