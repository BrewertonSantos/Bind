namespace Shared.Entities;

public abstract class Entity
{
    /// <summary>
    /// Generates a new unique identifier when referenced
    /// </summary>
    public Entity() => Id = Guid.NewGuid();
    
    /// <summary>
    /// A unique entity identifier
    /// </summary>
    public Guid Id { get; }
}