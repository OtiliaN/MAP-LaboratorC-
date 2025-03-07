using Lab10.Domain;

namespace Lab10.Repository.FileRepository;

public class MeciFromFile : FileRepo<Meci>
{
    private IRepository<long, Echipa> echipe;

    public MeciFromFile(IRepository<long, Echipa> echipe, string filePath)
    {
        this.echipe = echipe;
        readFromFile(filePath);
    }

    protected override Meci entityFromString(string data)
    {
        string[] properties = data.Split(';');
        long echipa1 = long.Parse(properties[1]);
        long echipa2 = long.Parse(properties[2]);
        
        return new Meci(long.Parse(properties[0]), echipe.FindOne(echipa1), echipe.FindOne(echipa2), DateTime.Parse(properties[3]));
    }
}