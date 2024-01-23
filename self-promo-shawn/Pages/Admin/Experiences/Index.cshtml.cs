using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using self_promo_shawn.Data;

namespace self_promo_shawn.Pages.Admin.Experiences
{
    [Authorize] public class IndexModel : PageModel
    {
        private readonly self_promo_shawn.Data.SelfieDataContext _context;

        public IndexModel(self_promo_shawn.Data.SelfieDataContext context)
        {
            _context = context;
        }

        public IList<Experience> Experience { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Experiences != null)
            {
                Experience = await _context.Experiences.OrderByDescending(e => e.StartDate).ToListAsync();
            }
        }
    }
}
