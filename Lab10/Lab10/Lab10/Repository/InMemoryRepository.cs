using Lab10.Domain;

namespace Lab10.Repository;

public class InMemoryRepository<E> : IRepository<long, E> where E : Entity<long>, new()
{
    private Dictionary<long, E> entities;
    
    public InMemoryRepository() => entities = new Dictionary<long, E>();

    public IEnumerable<E> FindAll() => entities.Values;

    public E FindOne(long id)
    {
        return entities[id];
    }

    public E Save(E entity)
    {
        entities[entity.id] = entity;
        return entity;
    }

    public bool Delete(long id)
    {
        return entities.Remove(id);
    }
}