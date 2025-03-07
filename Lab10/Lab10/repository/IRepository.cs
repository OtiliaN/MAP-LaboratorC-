namespace Lab10.repository;

public interface IRepository<ID, E>
{
    List<E> findAll();
    E findOne(ID id);
}