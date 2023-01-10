namespace Shared.ValueObjects.Exceptions;

/// <summary>
/// The Exception that is thrown for invalid activation code
/// </summary>
public class InvalidActivationCodeException : Exception
{
    public InvalidActivationCodeException(string message = "Invalid activation code") : base(message)
    {
    }

    public static void ThrowIfIsInvalid(string? code, string? challenger)
    {
        if (string.IsNullOrEmpty(code) ||
            string.IsNullOrEmpty(challenger) ||
            code != challenger)
            throw new InvalidActivationCodeException();
    }
}