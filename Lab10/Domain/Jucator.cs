namespace Lab10.Domain;

public class Jucator : Elev
{
    public Echipa echipa { get; set; }
    public Jucator() { }

    public Jucator(long id, string name, string school, Echipa echipa) : base(id, name, school)
    {
        this.echipa = echipa;
    }
}