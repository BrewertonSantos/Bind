namespace Shared.ValueObjects;

/// <summary>
/// A value object to aggregate properties of UTM (Urchin traffic monitor) classifier to marketing campaign
/// </summary>
public class Utm : ValueObject
{
    #region Constructors

    /// <summary>
    /// Create a new instance of Urchin Traffic Monitor
    /// </summary>
    /// <param name="source">Source origin</param>
    /// <param name="campaign">Name of the compaign</param>
    /// <param name="content">Content of the campaign</param>
    /// <param name="medium">Medium in which the campaign is being broadcast</param>
    /// <param name="term">Campaign keyword</param>
    public Utm(
        string? source = null,
        string? campaign = null,
        string? content = null,
        string? medium = null,
        string? term = null)
    {
        Source = source;
        Campaign = campaign;
        Content = content;
        Medium = medium;
        Term = term;
    }

    #endregion

    #region Properties

    public string? Source { get; }

    public string? Campaign { get; }

    public string? Content { get; }

    public string? Medium { get; }

    public string? Term { get; }

    #endregion
}