using Lab10.Domain;

namespace Lab10.Repository.FileRepository;

public class ElevFromFile : FileRepo<Elev>
{
    public ElevFromFile(string filePath) : base(filePath) { }

    protected override Elev entityFromString(string data)
    {
        string[] properties = data.Split(';');
        return new Elev(long.Parse(properties[0]), properties[1], properties[2]);
    }
}