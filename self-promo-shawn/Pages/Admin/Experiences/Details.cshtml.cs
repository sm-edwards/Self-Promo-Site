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
    [Authorize] public class DetailsModel : PageModel
    {
        private readonly self_promo_shawn.Data.SelfieDataContext _context;

        public DetailsModel(self_promo_shawn.Data.SelfieDataContext context)
        {
            _context = context;
        }

      public Experience Experience { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Experiences == null)
            {
                return NotFound();
            }

            var experience = await _context.Experiences.FirstOrDefaultAsync(m => m.ExperienceId == id);
            if (experience == null)
            {
                return NotFound();
            }
            else 
            {
                Experience = experience;
            }
            return Page();
        }
    }
}
