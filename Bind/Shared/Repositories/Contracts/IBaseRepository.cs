using Shared.UseCases.Contracts;

namespace Shared.Repositories.Contracts;

public interface IBaseRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot
{
}