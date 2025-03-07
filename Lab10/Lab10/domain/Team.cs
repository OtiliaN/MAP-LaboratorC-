namespace Lab10.domain;

public class Team : Entity<int>
{
    public string Name {get; set;}

    public Team() { }

    public Team(int id, string name): base(id)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Id.ToString() + ";" + Name;
    }
}