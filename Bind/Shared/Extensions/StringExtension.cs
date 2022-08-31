using System.Text.RegularExpressions;

namespace Shared.Extensions;

public static class StringExtension
{
    public static string ToNumbersOnly(this string? input) =>
        string.IsNullOrEmpty(input) ? string.Empty : Regex.Replace(input, "[^0-9]", "");


}