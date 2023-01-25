using DuelSys_Logic.Enums;
using DuelSys_Logic.Models;
using DuelSysLogic.Enums.Sport;
using System.ComponentModel.DataAnnotations;

namespace DuelSysLogic.Models
{
    public class Player : User
    {
        public Player(SportType sportPreference, string firstName, string lastName, Gender gender, string birthDate, string phoneNumber, string email, UserCredentials credentials) : base(firstName, lastName, gender, birthDate, phoneNumber, email, credentials)
        {
            this.SportPreference = sportPreference;
        }

        public Player() { }
        [Required(ErrorMessage = "Please select sport preference")]
        public SportType SportPreference  { get;  set; }
    }
}
