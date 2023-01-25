namespace DataAccess.ExceptionModels
{
    public class DALException : Exception
    {
        public DALException(string? message) : base(message) 
        {
        }

        public DALException(string? message, Exception e) : base(message, e)
        {
        }
    }
}
