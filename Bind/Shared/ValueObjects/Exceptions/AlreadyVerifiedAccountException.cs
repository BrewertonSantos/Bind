namespace Shared.ValueObjects.Exceptions;

/// <summary>
/// The Exception that is thrown for already verified account
/// </summary>
public class AlreadyVerifiedAccountException : Exception
{
    public AlreadyVerifiedAccountException(string message = "Already verified account.") : base(message)
    {
    }

    public static void ThrowIfIsVerified(bool isVerified)
    {
        if (isVerified)
            throw new AlreadyVerifiedAccountException();
    }
}