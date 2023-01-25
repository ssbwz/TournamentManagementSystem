using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.Authorization
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
