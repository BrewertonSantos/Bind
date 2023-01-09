using Shared.ValueObjects;

namespace Shared.UseCases.Contracts;

public interface IResponse
{
    public IReadOnlyCollection<Error> Errors { get; }
    public int StatusCode { get; }
    public bool IsSuccess { get; }
}