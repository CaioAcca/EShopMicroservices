namespace BuildingBlocks.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    { 
    }

    public BadRequestException(string message, String details) : base(message)
    {
        Details = details;
    }

    public String? Details { get; set; }
}
