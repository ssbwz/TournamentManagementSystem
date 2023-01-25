
namespace DataAccess.ExceptionModels
{
    public class PhoneNumberDuplicationException : Exception
    {
        public PhoneNumberDuplicationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
