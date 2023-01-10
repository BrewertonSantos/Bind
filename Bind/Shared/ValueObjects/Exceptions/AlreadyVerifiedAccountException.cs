namespace Shared.ValueObjects.Exceptions;

/// <summary>
/// The Exception that is thrown for already verified account
/// </summary>
public class AlreadyVerifiedAccountException : Exception
{
    #region Constructors

    public AlreadyVerifiedAccountException(string message = "Already verified account.") : base(message)
    {
    }

    #endregion

    #region Methods

    public static void ThrowIfIsVerified(bool isVerified)
    {
        if (isVerified)
            throw new AlreadyVerifiedAccountException();
    }

    #endregion
}