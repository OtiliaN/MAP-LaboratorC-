namespace Lab10.domain;

public class Entity<TID>
{
    public TID Id { get; set; }
    
    public Entity() { }

    public Entity(TID id)
    {
        Id = id;
    }
}