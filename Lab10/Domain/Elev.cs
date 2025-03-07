using System.Data.Common;

namespace Lab10.Domain;

public class Elev : Entity<long>
{
    public string name { get; set; }
    public string school { get; set; }

    public Elev() { }

    public Elev(long id, string name, string school) : base(id)
    {
        this.name = name;
        this.school = school;
    }

    public override string ToString()
    {
        return id.ToString() + ";" + name + ";" + school;
    }
}