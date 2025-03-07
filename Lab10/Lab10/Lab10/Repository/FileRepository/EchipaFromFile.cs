using Lab10.Domain;

namespace Lab10.Repository.FileRepository;

public class EchipaFromFile : FileRepo<Echipa>
{
    public EchipaFromFile(string filePath) : base(filePath) { }

    protected override Echipa entityFromString(string data)
    {
        string[] properties = data.Split(';');
        return new Echipa(long.Parse(properties[0]), properties[1]);
    }
}