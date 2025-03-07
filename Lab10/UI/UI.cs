using Lab10.Domain;

namespace Lab10.UI;
using Lab10.Service;

public class UI
{
    private Service service;

    public UI(Service service)
    {
        this.service = service;
    }

    private long readId()
    {
        Console.WriteLine("Id-ul: ");
        return long.Parse(Console.ReadLine());
    }

    private DateTime readDate()
    {
        Console.WriteLine("Data: ");
        return DateTime.Parse(Console.ReadLine());
    }

    public void run()
    {
        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("----------------");
            Console.WriteLine("Comenzile sunt: ");
            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - afisarea tuturor jucatorilor unei echipe date");
            Console.WriteLine("2 - afisarea tuturor jucatorilor activi ai unei echipe de la un anumit meci");
            Console.WriteLine("3 - afisarea tuturor meciurilor dintr-o anumita perioada calendaristica");
            Console.WriteLine("4 - afisarea scorului de la un anumit meci");
            Console.WriteLine("----------------");
            Console.WriteLine("\n");
            
            Console.WriteLine("Dati o comanda: ");
            try
            {
                int cmd = int.Parse(Console.ReadLine());
                Echipa e;
                Meci m;
                switch (cmd)
                {
                    case 0:
                        return;
                    case 1:
                        e = service.findEchipa(readId());
                        Console.WriteLine($"Jucatorii echipei {e.name} sunt: ");
                        foreach (var jucator in service.JucatoriiUneiEchipe(e))
                            Console.WriteLine(jucator.name + " , " + jucator.school);
                        break;
                    case 2:
                        e = service.findEchipa(readId());
                        m = service.findMeci(readId());
                        Console.WriteLine($"Jucatorii activi ai echipei {e.name}  din meciul din {m.date} sunt: ");
                        foreach (var jucator in service.JucatoriiActiviAiUneiEchipeDeLaUnMeci(e, m))
                            Console.WriteLine(jucator.name + " , " + jucator.school);
                        break;
                    case 3:
                        DateTime d1 = readDate();
                        DateTime d2 = readDate();
                        foreach (var meci in service.MeciuriDinPerioada(d1, d2))
                            Console.WriteLine(meci.echipa1.name + " vs " + meci.echipa2.name + " din " + meci.date);
                        break;
                    case 4:
                        m = service.findMeci(readId());
                        Console.WriteLine($"Scorul meciului dintre {m.echipa1.name} si {m.echipa2.name} din {m.date} este: " +
                                          service.ScorulUnuiMeci(m));
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Comanda invalida!");
            }
        }
    }
}