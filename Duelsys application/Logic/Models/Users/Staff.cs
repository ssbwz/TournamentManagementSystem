using DuelSys_Logic.Enums;
using DuelSys_Logic.Models;

namespace DuelSysLogic.Models
{
    public class Staff: User
    {

        public Staff(string BSN, string firstName, string lastName, Gender gender, string birthDate, string phoneNumber, string email, UserCredentials credentials) : base(firstName, lastName, gender, birthDate, phoneNumber, email, credentials)
        {
            this.BSN = BSN;
        }
        public Staff() { }
        public string BSN { get; private set; }
    }
}
