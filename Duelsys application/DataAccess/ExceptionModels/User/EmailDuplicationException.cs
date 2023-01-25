

namespace DataAccess.ExceptionModels
{
    public class EmailDuplicationException : Exception
    {
        public EmailDuplicationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
