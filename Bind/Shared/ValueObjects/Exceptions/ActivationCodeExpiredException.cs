namespace Shared.ValueObjects.Exceptions;

/// <summary>
/// The Exception that is thrown for expired activation code
/// </summary>
public class ActivationCodeExpiredException : Exception
{
    public ActivationCodeExpiredException(string message = "Expired activation code.") : base(message)
    {
    }

    public static void ThrowIfIsExpired(DateTime expireDate)
    {
        if (expireDate < DateTime.UtcNow)
            throw new ActivationCodeExpiredException();
    }
}