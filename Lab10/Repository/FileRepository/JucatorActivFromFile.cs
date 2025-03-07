using Lab10.Domain;

namespace Lab10.Repository.FileRepository;

public class JucatorActivFromFile : FileRepo<JucatorActiv>
{
    public JucatorActivFromFile(string filePath) : base(filePath) {}

    protected override JucatorActiv entityFromString(string data)
    {
        string[] properties = data.Split(';');
        return new JucatorActiv(long.Parse(properties[0]), long.Parse(properties[1]), long.Parse(properties[2]), int.Parse(properties[3]), Tip.PARTICIPANT);
    }
}