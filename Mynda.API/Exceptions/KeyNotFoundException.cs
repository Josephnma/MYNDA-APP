namespace Mynda.API.Exceptions;

public class KeyNotFoundException : NotFoundException
{
    public KeyNotFoundException(string message): base(message) {}
}