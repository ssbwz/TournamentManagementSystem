

namespace DataAccess.ExceptionModels
{
    public class TeamAlreadyRegisteredException : Exception
    {
        public TeamAlreadyRegisteredException(string? message) : base(message)
        {
        }
    }
}
