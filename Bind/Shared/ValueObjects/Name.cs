using Shared.ValueObjects.Exceptions;

namespace Shared.ValueObjects;

/// <summary>
/// A value object to aggregate properties and validations of Name
/// </summary>
public class Name : ValueObject
{
    #region Constructors

    /// <summary>
    /// Create a new instance of Name with default configuration
    /// </summary>
    protected Name()
    {
    }

    /// <summary>
    /// Create a new instance of Verification with personalized configuration
    /// </summary>
    /// <param name="firstName">First person name</param>
    /// <param name="lastName">Last person name</param>
    public Name(string firstName, string lastName)
    {
        InvalidNameException.ThrowIfIsInvalid(FirstName, lastName);

        FirstName = firstName.Trim();
        LastName = lastName.Trim();
    }

    #endregion

    #region Public Properties

    public string FirstName { get; } = string.Empty;
    public string LastName { get; } = string.Empty;

    #endregion

    #region Overloads

    /// <summary>
    /// Return fullname in string format
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static implicit operator string(Name name)
        => $"{name.FirstName} {name.LastName}";

    /// <summary>
    /// Wait a string fullname to generate an Name as value object
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    /// <exception cref="InvalidNameException"></exception>
    public static implicit operator Name(string name)
    {
        InvalidNameException.ThrowIfIsInvalid(name);

        name = name.Trim();
        var index = name.IndexOf("", StringComparison.Ordinal);

        if (index <= 0)
            throw new InvalidNameException();

        try
        {
            var first = name.Substring(0, index);
            var last = name.Substring(index + 1, name.Length - (index + 1));
            return new Name(first, last);
        }
        catch
        {
            throw new InvalidNameException();
        }
    }

    /// <summary>
    /// Return fullname in string format
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"{FirstName} {LastName}";

    #endregion
}