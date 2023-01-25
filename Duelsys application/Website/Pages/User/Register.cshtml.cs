using DataAccess;
using DataAccess.ExceptionModels;
using DataAccess.UserManagement;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using DuelSysLogic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Website.Pages.User
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {


        private IUserRepository usersRepository { get { return new UserDAL(); } }
        private UsersManager usermanager { get { return new UsersManager(usersRepository); } }

        private IAssociationsRepository associationsRepository { get { return new AssociationsDAL(); } }
        private AssociationsManager associationsmanager { get { return new AssociationsManager(associationsRepository); } }


        public List<Association> Associations { get; private set; }

        [BindProperty]
        public Player newPlayer { get; set; }

        //UserCredentials fields
        [BindProperty]
        [Required(ErrorMessage = "Please fill in username")]
        [MaxLength(30)]
        [MinLength(2)]
        [RegularExpression(@"^[^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,30}$", ErrorMessage = $"Please make sure that you don't have any characters and username is longer than 2 characters")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please fill in password")]
        [MaxLength(30)]
        [MinLength(2)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[\W+]).{8,20}$", ErrorMessage = "Password should include one lowercase letter and one capital letter and one character and should be longer than 8 characters")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please fill the confirm password")]
        [Compare(nameof(Password), ErrorMessage = "Passords don't match")]
        public string ConfirmPassword { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please select association")]
        public int AssociationId { get; set; }

        internal UserCredentials newUserCrednetials { get { return new UserCredentials(Username, Password, DuelSysLogic.Enums.UserType.Player, AssociationId); } }


        //Error messages
        public string UsernameDuplication { get; set; }

        public string EmailDuplication { get; set; }

        public string PhoneNumberDuplication { get; set; }

        public string Message { get; set; }

        
        public string MaxDateTime { get { return DateTime.Now.ToString("yyyy-MM-dd"); } }

        public IActionResult OnGet()
        {
            try
            {
                Associations = associationsmanager.GetAllAssociations();
                return Page();
            }
            catch (Exception)
            {
                return Redirect($"../Error");
            }

        }

        public IActionResult OnPostRegister()
        {
            ModelState.Remove("newPlayer.UserCredentials");
            if (ModelState.IsValid)
            {
                try
                {
                    newPlayer.UserCredentials = newUserCrednetials;
                    usermanager.CreateUser(newPlayer);
                    return Redirect("/Authorization/Login?message= Please log in with your new account");
                }
                catch (UsernameDuplicationException ex)
                {
                    UsernameDuplication = ex.Message;
                }
                catch (PhoneNumberDuplicationException ex)
                {
                    PhoneNumberDuplication = ex.Message;
                }
                catch (EmailDuplicationException ex)
                {
                    EmailDuplication = ex.Message;
                }
                catch (UnableToConnectToHostException ex)
                {
                    Message = ex.Message;
                }
                catch (DALException ex)
                {
                    Message = ex.Message;
                }
                catch (Exception)
                {
                    Message = "Something went wrong";
                }
            }

            Associations = associationsmanager.GetAllAssociations();
            return Page();
        }
    }
}
