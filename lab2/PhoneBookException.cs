using System;

public class PhoneBookException : Exception
{
    public PhoneBookException()
    {
    }

    public PhoneBookException(string message)
        : base(message)
    {
    }

    public PhoneBookException(string message, Exception inner)
        : base(message, inner)
    {
    }
}