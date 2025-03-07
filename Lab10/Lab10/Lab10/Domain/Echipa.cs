namespace Lab10.Domain;

public class Echipa : Entity<long>
{
    public string name { get; set; }
    public Echipa() { }

    public Echipa(long id, string name) : base(id)
    {
        this.name = name;
    }
}