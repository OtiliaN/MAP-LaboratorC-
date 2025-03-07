using Lab10.Repository.FileRepository;
using Lab10.Service;
using Lab10.UI;

internal class Program
{
    static void Main(string[] args)
    {
        ElevFromFile elevFile = new ElevFromFile("C:\\Users\\otili\\Desktop\\Lab10\\Lab10\\Lab10\\elevi.txt");
        EchipaFromFile echipaFile = new EchipaFromFile("C:\\Users\\otili\\Desktop\\Lab10\\Lab10\\Lab10\\echipe.txt");
        JucatorFromFile jucatorFile = new JucatorFromFile(echipaFile, "C:\\Users\\otili\\Desktop\\Lab10\\Lab10\\Lab10\\jucatori.txt");
        MeciFromFile meciFile = new MeciFromFile(echipaFile, "C:\\Users\\otili\\Desktop\\Lab10\\Lab10\\Lab10\\meciuri.txt");
        JucatorActivFromFile jucatorActivFile = new JucatorActivFromFile("C:\\Users\\otili\\Desktop\\Lab10\\Lab10\\Lab10\\jucatoriActivi.txt");
        
        Service service = new Service(echipaFile, elevFile, jucatorFile, meciFile, jucatorActivFile);
        
        UI console = new UI(service);
        console.run();
    }
}