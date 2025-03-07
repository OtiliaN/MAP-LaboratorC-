using Lab10.Domain;

namespace Lab10.Repository.FileRepository;

public class JucatorFromFile : FileRepo<Jucator>
{
    private IRepository<long, Echipa> echipe;

    public JucatorFromFile(IRepository<long, Echipa> echipe, string filePath)
    {
        this.echipe = echipe;
        readFromFile(filePath);
    }

    protected override Jucator entityFromString(string data)
    {
        string[] proprieties = data.Split(';');
        long idEchipa = long.Parse(proprieties[3]);
        
        return new Jucator(long.Parse(proprieties[0]), proprieties[1], proprieties[2], echipe.FindOne(idEchipa));
    }
}