using System;

public class NotAvailableException : Exception
{
    public NotAvailableException() : base("The room is not available for reservation.")
    {
    }
}
