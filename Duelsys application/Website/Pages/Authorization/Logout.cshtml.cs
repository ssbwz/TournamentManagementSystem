using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.Authorization
{
    [Authorize]
    public class LogoutModel : PageModel
    {

        public async Task<IActionResult> OnGetAsync()
        {
            await HttpContext.SignOutAsync(
             CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("../Index");
        }
    }
}
