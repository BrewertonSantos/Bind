namespace Shared.Extensions;

public static class GuidExtension
{
    /// <summary>
    /// Transforms a unique identifier into a code with a default 8 characters and a minimum of 2 characters and a maximum of 32 characters
    /// </summary>
    /// <param name="input">It accepts a Guid that, if it is null, will receive the value of a new Guid</param>
    /// <param name="codeLenght">Defines the number of return characters in the code</param>
    /// <returns>Return a string code with a minimum of 2 characters and a maximum of 32 characters</returns>
    public static string ToCodePattern(this Guid input, int codeLenght = 8)
    {
        if (input.ToString()!.Length is < 2 or > 32)
            throw new ArgumentException("O tamanho do código não deve ser menor que 2 ou maior 32 caracteres.");

        if (string.IsNullOrEmpty(input.ToString()))
            return Guid.NewGuid().ToString().Replace("-", "")[..codeLenght];

        return input.ToString().Replace("-", "")[..codeLenght];
    }
}