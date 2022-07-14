using System.Reflection.Metadata.Ecma335;

namespace Shared;

public class PersonException : Exception
{
    public PersonException() : base() { }
    public PersonException(string message) : base(message) { }
    public PersonException(string message
        , Exception innerException) : 
        base(message, innerException) { }

    public PersonException(string message
        , string jobId
        , Exception innerException) :
        base(message + " JobId:" + jobId, innerException)
    {
        // log exception
    }
}