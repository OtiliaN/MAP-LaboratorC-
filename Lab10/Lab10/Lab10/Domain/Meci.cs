using System.Runtime.InteropServices.JavaScript;

namespace Lab10.Domain;

public class Meci : Entity<long>
{
    public Echipa echipa1 { get; set; }
    public Echipa echipa2 { get; set; }
    public DateTime date { get; set; }
    
    public Meci() { }

    public Meci(long id, Echipa echipa1, Echipa echipa2, DateTime date) : base(id)
    {
        this.echipa1 = echipa1;
        this.echipa2 = echipa2;
        this.date = date;
    }
}