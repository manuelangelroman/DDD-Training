namespace Wpm.Management.Domain;

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; set; }

    public bool Equals(Entity? obj)
    {
        return Equals(obj as Entity);
    }


    public bool Equals(Pet? other)
    {
        return other?.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    public static bool operator ==(Entity? left, Entity? right)
    {
        return left?.Id == right?.Id;
    }

    public static bool operator !=(Entity? left, Entity? right)
    {
        return left?.Id != right?.Id;
    }
}
