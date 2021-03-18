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
    public class IndexModel : PageModel
    {
        private readonly BonFromageContext _context;

        public IndexModel(BonFromageContext context)
        {
            _context = context;
        }

        public IList<MenuItem> MenuItem { get;set; }

        public async Task OnGetAsync()
        {
            MenuItem = await _context.MenuItem.ToListAsync();
        }
    }
}
