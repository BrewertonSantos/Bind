using Shared.ValueObjects.Exceptions;

namespace Shared.ValueObjects;

/// <summary>
/// A value object to aggregate properties and validations of verification process
/// </summary>
public class Verification
{
    #region Constructors

    /// <summary>
    /// Create a new instance of Verification with default configuration
    /// </summary>
    protected Verification()
    {
    }

    /// <summary>
    /// Create a new instance of Verification with personalized configuration
    /// </summary>
    /// <param name="len">Lenght of verification code</param>
    /// <param name="expireInMinutes">Time in minutes to expire the verification code</param>
    public Verification(short len = 8, int expireInMinutes = 30)
    {
        IsVerified = false;
        Code = GenerateVerificationCode(len);
        CodeExpireDate = DateTime.UtcNow.AddMinutes(expireInMinutes);
    }

    #endregion

    #region Properties

    public bool IsVerified { get; private set; }
    public string Code { get; } = string.Empty;
    public DateTime CodeExpireDate { get; private set; } = DateTime.UtcNow.AddMinutes(30);

    #endregion

    #region Methods

    /// <summary>
    /// Verify if verification is valid, already used or expired
    /// </summary>
    /// <param name="verificationCode">Verification code to be verified</param>
    public void Verify(string verificationCode)
    {
        AlreadyVerifiedAccountException.ThrowIfIsVerified(IsVerified);
        InvalidActivationCodeException.ThrowIfIsInvalid(Code, verificationCode);
        ActivationCodeExpiredException.ThrowIfIsExpired(CodeExpireDate);
    }

    /// <summary>
    /// Set verification as unverified
    /// </summary>
    public void InValidate() => IsVerified = false;

    /// <summary>
    /// Return a new verification code
    /// </summary>
    /// <param name="len"></param>
    /// <returns></returns>
    private static string GenerateVerificationCode(short len = 8)
        => Guid.NewGuid().ToString().ToUpper()[..len];

    #endregion

    #region OverLoads

    /// <summary>
    /// Return verification code from inputted verification
    /// </summary>
    /// <param name="verification">Verification type to extract verification code</param>
    /// <returns></returns>
    public static implicit operator string(Verification verification)
        => verification.Code;

    #endregion
}