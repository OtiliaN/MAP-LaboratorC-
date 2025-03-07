namespace Lab10.domain;

public class Match: Entity<int>
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public DateTime Date { get; set; }
    
    public Match() { }

    public Match(int id, Team team1, Team team2, DateTime date) : base(id)
    {
        Team1 = team1;
        Team2 = team2;
        Date = date;
    }
    
}