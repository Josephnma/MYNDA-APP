﻿namespace Mynda.API.Exceptions;

public class UnauthorizedAccessException : Exception
{
    public UnauthorizedAccessException(string message): base(message) {}
}