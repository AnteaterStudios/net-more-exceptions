namespace MoreExceptions;

public class EmptyCollectionException : ArgumentException {
    public EmptyCollectionException()
    {
    }

    public EmptyCollectionException(string message) : base(message)
    {
    }

    public EmptyCollectionException(string message, string paramName) : base(message, paramName)
    {
    }
}