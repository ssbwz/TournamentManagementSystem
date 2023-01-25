using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DuelSysLogic.Models;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using DuelSysLogic.Enums;
using DataAccess.UserManagement;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using DataAccess.ExceptionModels;

namespace Website.Pages.Authorization
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private IUserRepository repository { get { return new UserDAL(); } }

        private UsersManager usersManager { get { return new UsersManager(repository); } }


        public UserCredentials UserCredentials { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please fill the username")]
        public string UsernameField { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please fill the password")]
        public string PasswordField { get; set; }

        internal bool DALExcptionHappened { get; private set; }

        internal string MessageTitle { get; private set; }

        internal string MessageDescription { get; private set; }

        internal string passedMessage { get; private set; }


        public void OnGet(string message)
        {
            this.passedMessage = message;
        }

        public IActionResult OnPostLogin() 
        {
            try
            {

                if (ModelState.IsValid)
                {
                    try
                    {
                        var gottenCredentionals = usersManager.GetUserCredentials(UsernameField);
                        if (gottenCredentionals == null)
                        {
                            MessageTitle = "Check Credentionals";
                            MessageDescription = "Please check the password and the username.";
                            return Page();
                        }

                        if (usersManager.GetAccess(gottenCredentionals, UsernameField, PasswordField))
                        {
                            if (UserType.Player == gottenCredentionals.UserType)
                            {
                                List<Claim> claims = new List<Claim>();

                                claims.Add(new Claim("username", gottenCredentionals.UserName));
                                claims.Add(new Claim("id", $"{gottenCredentionals.Id}"));
                                claims.Add(new Claim("playerId", $"{gottenCredentionals.PlayerId}"));
                                claims.Add(new Claim(ClaimTypes.Role, $"{gottenCredentionals.UserType}"));
                                claims.Add(new Claim("associationId", $"{gottenCredentionals.AssociationId}"));

                                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                                return Redirect("/Index");
                            }
                            MessageTitle = "Access denied";
                            MessageDescription = "You can't log in if you don't have a player account";
                            return Page();
                        }

                        MessageTitle = "Check Credentionals";
                        MessageDescription = "Please check the password and the username.";
                        return Page();
                    }
                    catch (DALException ex)
                    {
                        DALExcptionHappened = true;
                        MessageTitle = "Connection";
                        MessageDescription = $"{ex.Message}, try again please.";
                    }
                    catch (UnableToConnectToHostException ex)
                    {
                        DALExcptionHappened = true;
                        MessageTitle = "Connection";
                        MessageDescription = $"{ex.Message}, try again please.";
                    }
                }
                return Page();
            }
            catch (Exception) 
            {
                return Redirect("/Error?code={0}");
            }
        }
    }
}
