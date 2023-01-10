namespace Shared.ValueObjects.Exceptions;

/// <summary>
/// The Exception that is thrown for expired activation code
/// </summary>
public class ActivationCodeExpiredException : Exception
{
    #region Constructors

    public ActivationCodeExpiredException(string message = "Expired activation code.") : base(message)
    {
    }

    #endregion

    #region Methods

    public static void ThrowIfIsExpired(DateTime expireDate)
    {
        if (expireDate < DateTime.UtcNow)
            throw new ActivationCodeExpiredException();
    }

    #endregion
}