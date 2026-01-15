namespace Ordering.Domain.Exceptions;

public class DomainException : Exception
{
    public DomainException(string message)
        : base($"Domain Excpetion: \"{message}\" throws from Domain Layer.")
    { }
}
