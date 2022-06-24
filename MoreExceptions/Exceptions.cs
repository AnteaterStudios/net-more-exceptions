namespace MoreExceptions;

public class EmptyCollectionException : ArgumentException {
    public EmptyCollectionException() { }
    public EmptyCollectionException(string message) : base(message) { }
    public EmptyCollectionException(string message, string paramName) : base(message, paramName) { }
}

public class StringEmptyOrWhiteSpaceException : ArgumentException {
    public StringEmptyOrWhiteSpaceException() { }
    public StringEmptyOrWhiteSpaceException(string message) : base(message) { }
    public StringEmptyOrWhiteSpaceException(string message, string paramName) : base(message, paramName) { }
}