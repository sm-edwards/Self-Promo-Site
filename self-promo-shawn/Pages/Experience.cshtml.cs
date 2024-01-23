using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using self_promo_shawn.Data;

namespace self_promo_shawn.Pages;

public class ExperienceModel : PageModel
{
    public ICollection<Experience> ProfessionalExperiences { get; set; } = default!;
    public ICollection<Experience> Activities { get; set; } = default!;
    private readonly SelfieDataContext _context;
    private readonly ILogger<ExperienceModel> _logger;

    public ExperienceModel(SelfieDataContext context, ILogger<ExperienceModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task OnGetAsync()
    {
        this.ProfessionalExperiences = await _context.Experiences
            .Include(e => e.Responsibilities)
            .Where(e => e.IsProfessional == true)
            .ToListAsync();
        this.Activities = await _context.Experiences
            .Include(e => e.Responsibilities)
            .Where(e => e.IsProfessional == false)
            .ToListAsync();
    }
}

