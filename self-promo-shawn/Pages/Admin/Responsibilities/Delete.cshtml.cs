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
    [Authorize] public class DeleteModel : PageModel
    {
        private readonly self_promo_shawn.Data.SelfieDataContext _context;

        public DeleteModel(self_promo_shawn.Data.SelfieDataContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Responsibility Responsibility { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Responsibilities == null)
            {
                return NotFound();
            }

            var responsibility = await _context.Responsibilities.Include(r => r.Experience).FirstOrDefaultAsync(m => m.ResponsibilityId == id);

            if (responsibility == null)
            {
                return NotFound();
            }
            else 
            {
                Responsibility = responsibility;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Responsibilities == null)
            {
                return NotFound();
            }
            var responsibility = await _context.Responsibilities.FindAsync(id);

            if (responsibility != null)
            {
                Responsibility = responsibility;
                _context.Responsibilities.Remove(Responsibility);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
