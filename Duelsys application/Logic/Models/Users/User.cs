using DuelSys_Logic.Enums;
using DuelSysLogic.Models;
using System.ComponentModel.DataAnnotations;

namespace DuelSys_Logic.Models
{
    public class User
    {
        
        public User(string firstName, string lastName, Gender gender, string birthDate, string phoneNumber, string email, UserCredentials credentials)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.BirthDate = birthDate;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.UserCredentials = credentials;
        }
        public User() { }
        [MaxLength(30)]
        [Required(ErrorMessage ="Please fill in the first name")]
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,30}$", ErrorMessage = "Please enter vaild first name")]
        public string FirstName { get; set; }

        [MaxLength(30)]
        [Required(ErrorMessage = "Please fill in the last name")]
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,30}$", ErrorMessage = "Please enter vaild last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please choose a gender")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Please fill in the date of birth")]
        public string BirthDate { get; set; }

        
        [MaxLength(15)]
        [Required(ErrorMessage = "Please fill in the phone number")]
        [RegularExpression(@"^\d{10,15}$", ErrorMessage = "Please enter vaild phone number")]
        public string PhoneNumber { get; set; }

        
        [MaxLength(256)]
        [Required(ErrorMessage = "Please fill in the email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Please enter vaild email")]
        public string Email { get; set; }

        public UserCredentials UserCredentials { get; set; }
    }
}
