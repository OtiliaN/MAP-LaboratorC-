using Lab10.Domain;

namespace Lab10.Repository.FileRepository;

public abstract class FileRepo<E> : InMemoryRepository<E> where E : Entity<long>, new()
{
    protected abstract E entityFromString(string data);
    protected FileRepo() {}

    public FileRepo(string filename)
    {
        readFromFile(filename);
    }

    protected void readFromFile(string filename)
    {
        StreamReader streamReader = new StreamReader(filename);
        string data;
        while (true)
        {
            data = streamReader.ReadLine();
            if (data == null)
                break;
            Save(entityFromString(data));
        }
    }
}