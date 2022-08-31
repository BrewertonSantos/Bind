namespace Shared.UseCases.Contracts;

public class IResponse
{
    public IReadOnlyCollection<Error> Errors { get; }
    public int StatusCode { get; }
    public bool IsSuccess { get; set; }
}