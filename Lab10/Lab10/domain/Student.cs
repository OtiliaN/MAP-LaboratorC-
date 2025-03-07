namespace Lab10.domain;

public class Student: Entity<int>
{
    public string Name { get; set; }
    public string School { get; set; }
    
    public Student() { }
    public Student(int id, string name, string school) : base(id)
    {
        Name = name;
        School = school;
    }

    public override string ToString()
    {
        return Id.ToString() + ";" + Name + ";" + School;
    }
}