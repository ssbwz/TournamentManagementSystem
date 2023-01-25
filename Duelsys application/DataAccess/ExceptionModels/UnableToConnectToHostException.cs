
namespace DataAccess.ExceptionModels
{
    public class UnableToConnectToHostException : Exception
    {
        public UnableToConnectToHostException(string? message) : base(message)
        {
        }

        public UnableToConnectToHostException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
