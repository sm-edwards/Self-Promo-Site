using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using self_promo_shawn.Data;

namespace self_promo_shawn.Pages.Admin.Experiences
{
    [Authorize] public class CreateModel : PageModel
    {
        private readonly self_promo_shawn.Data.SelfieDataContext _context;

        public CreateModel(self_promo_shawn.Data.SelfieDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Experience Experience { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Experiences == null || Experience == null)
            {
                return Page();
            }

            _context.Experiences.Add(Experience);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
