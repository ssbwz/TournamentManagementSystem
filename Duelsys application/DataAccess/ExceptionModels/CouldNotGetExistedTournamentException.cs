

namespace DataAccess.ExceptionModels
{
    internal class CouldNotGetExistedTournamentException : Exception
    {
        public CouldNotGetExistedTournamentException(string? message) : base(message)
        {
        }
    }
}
