using DuelSys_Logic.Models;
using DuelSysLogic.Enums;
using DuelSysLogic.Models;

namespace DuelSysLogic.Interfaces
{
    public interface IUserRepository
    {
        public void CreateUser(User newUser);

        public void DeleteUser(User selectedUser);

        public bool CheckDuplicationBSN(string bSN, int associationId);

        public List<Staff> GetEightStaffEachTime(int group, int associationId,UserType userType);

        public UserCredentials GetUserCredentials(string username);

        public void UpdateUser(User oldUser,User updatedUser);
    }
}
