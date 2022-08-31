using Shared.Extensions;

namespace Shared.ValueObjects;

public record Error
{
    public Error(string value, string key = "")
    {
        Key = Guid.NewGuid().ToCodePattern();
        Value = value;
    }

    public string Key { get; } = string.Empty;
    public string Value { get; set; }
}