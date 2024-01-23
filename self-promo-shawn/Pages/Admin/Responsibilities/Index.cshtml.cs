using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using self_promo_shawn.Data;

namespace self_promo_shawn.Pages.Admin.Responsibilities
{
    [Authorize] public class IndexModel : PageModel
    {
        private readonly self_promo_shawn.Data.SelfieDataContext _context;

        public IndexModel(self_promo_shawn.Data.SelfieDataContext context)
        {
            _context = context;
        }

        public IList<Responsibility> Responsibility { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Responsibilities != null)
            {
                Responsibility = await _context.Responsibilities
                .Include(r => r.Experience).OrderBy(r => r.SequenceNumber).ToListAsync();
            }
        }
    }
}
