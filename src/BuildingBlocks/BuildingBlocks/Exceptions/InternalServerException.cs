namespace BuildingBlocks.Exceptions;

public class InternalServerException : Exception
{
    public InternalServerException(string message) : base(message)
    { 
    }

    public InternalServerException(string message, String details) : base(message)
    {
        Details = details;
    }

    public String? Details { get; set; }
}
