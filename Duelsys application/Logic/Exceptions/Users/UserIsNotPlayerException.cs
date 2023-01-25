
namespace DuelSysLogic.Exceptions.Users
{
    public class UserIsNotPlayerException : Exception
    {
        public UserIsNotPlayerException(string? message) : base(message)
        {
        }
    }
}
