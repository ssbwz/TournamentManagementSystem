
namespace DataAccess.ExceptionModels
{
    public class UsernameDuplicationException : Exception
    {
        public UsernameDuplicationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
