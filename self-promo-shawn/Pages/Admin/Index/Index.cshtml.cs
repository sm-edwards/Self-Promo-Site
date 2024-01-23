using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace self_promo_shawn.Pages.Admin.Index
{
    [Authorize] public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
