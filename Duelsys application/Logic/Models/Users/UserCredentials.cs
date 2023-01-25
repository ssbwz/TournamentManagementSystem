using DuelSysLogic.Enums;
using DuelSysLogic.Exceptions.Users;
using System.ComponentModel.DataAnnotations;

namespace DuelSysLogic.Models
{
    public class UserCredentials
    {
        private int playerId;

        public UserCredentials(int id, string username, string hashedPassword, string salt, UserType userType, int associationId)
        {
            this.Id = id;
            this.UserName = username;
            this.HashedPassword = hashedPassword;
            this.Salt = salt;
            this.UserType = userType;
            this.AssociationId = associationId;
        }

        public UserCredentials(int id, string username, string salt, UserType userType, string updatedPassword, int associationId)
        {
            this.Id = id;
            this.UserName = username;
            this.Salt = salt;
            this.HashedPassword = getHashedPassword(updatedPassword, Salt);
            this.UserType = userType;
            this.AssociationId = associationId;
        }

        public UserCredentials(string username, string newPassword, UserType userType, int associationId)
        {
            this.UserName = username;
            this.Salt = getNewSalt();
            this.HashedPassword = getHashedPassword(newPassword, Salt);
            this.UserType = userType;
            this.AssociationId = associationId;
        }

        public UserCredentials(int id, int playerId, string username, string hashedPassword, string salt, UserType userType, int associationId)
        {
            this.Id = id;
            this.PlayerId = playerId;
            this.UserName = username;
            this.HashedPassword = hashedPassword;
            this.Salt = salt;
            this.UserType = userType;
            this.AssociationId = associationId;
        }

        public int Id { get; private set; }

        public string UserName { get; private set; }

        public string HashedPassword { get; private set; }

        public string Salt { get; private set; }

        public UserType UserType { get; private set; }

        public int AssociationId { get; private set; }

        public int PlayerId
        {
            get
            {
                if (UserType != UserType.Player)
                {
                    throw new UserIsNotPlayerException("PlayerId is only for players");
                }
                return playerId;
            }
            private set { playerId = value; }
        }

        private string getNewSalt()
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[10];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        internal string getHashedPassword(string input, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring =
            new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
