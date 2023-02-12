using System;

public class NameNotFoundException : Exception
{
    public NameNotFoundException()
    {
    }

    public NameNotFoundException(string message)
        : base(message)
    {
    }

    public NameNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}