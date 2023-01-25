using DuelSys_Logic.Models;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Models;
using DuelSysLogic.Enums;

namespace DuelSysLogic.Managers
{
    public class UsersManager
    {
        private IUserRepository repository;

        public UsersManager(IUserRepository repository) 
        {
            this.repository = repository;
        }

        public bool GetAccess(UserCredentials userCredentials,string usernameField, string passwordField) 
        {
            if (userCredentials.UserName.ToLower() == usernameField.ToLower() 
                && userCredentials.HashedPassword ==  userCredentials.getHashedPassword(passwordField, userCredentials.Salt))
            {
                return true;
            }
            return false;


        }

        ///<summary> Check if BSN is already used <paramref name="description"/>
        ///<para>Return true when there are duplication and false for not</para>
        ///</summary>
        public bool CheckDuplicationBSN(string bSN, int associationId)
        {
            return repository.CheckDuplicationBSN(bSN,associationId);
        }

        public UserCredentials GetUserCredentials(string username) 
        {
           return repository.GetUserCredentials(username);
        }

        public List<Staff> GetEightEmployeesEachTime(int pageNumber, int associationId)
        {
            return repository.GetEightStaffEachTime(pageNumber, associationId,UserType.Employee);
        }

        public List<Staff> GetEightAdminsEachTime(int pageNumber, int associationId)
        {
           return  repository.GetEightStaffEachTime(pageNumber, associationId, UserType.Admin);
        }

        public void CreateUser(User newUser) 
        {
            repository.CreateUser(newUser);
        }

        public void UpdateUser(User oldUser, User newUser) 
        {
             repository.UpdateUser(oldUser, newUser);
        }

        public void DeleteUser(User selectedUser) 
        {
            repository.DeleteUser(selectedUser);
        }
    }
}
