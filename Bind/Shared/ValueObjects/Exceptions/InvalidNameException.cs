namespace Shared.ValueObjects.Exceptions;

/// <summary>
/// The Exception that is thrown for invalid name exception
/// </summary>
public class InvalidNameException : Exception
{
    #region Constructors

    public InvalidNameException(string message = "Invalid name.") : base(message)
    {
    }

    public static void ThrowIfIsInvalid(string? firstName, string? lastName)
    {
        if (string.IsNullOrEmpty(firstName))
            throw new InvalidNameException();

        if (string.IsNullOrEmpty(lastName))
            throw new InvalidNameException();

        firstName = firstName.Trim();
        lastName = lastName.Trim();

        if (firstName.Length < 3 || lastName.Length < 3)
            throw new InvalidNameException();
    }

    #endregion

    #region Methods

    public static void ThrowIfIsInvalid(string? part)
    {
        if (string.IsNullOrEmpty(part))
            throw new InvalidNameException();

        part = part.Trim();

        if (part.Length < 3)
            throw new InvalidNameException();
    }

    #endregion
}