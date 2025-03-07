namespace Lab10.domain;
public enum Tip
{
    REZERVA, PARTICIPANT
}

public class ActivePlayer : Entity<int>
{
    public int IdJucator { get; set; }
    public int IdMeci { get; set; }
    public int NrPuncteInscrise { get; set; }
    public Tip Tip { get; set; }

    public ActivePlayer() { }

    public ActivePlayer(int id, int idJucator, int idMeci, int nrPuncteInscrise, Tip tip) : base(id)
    {
        IdJucator = idJucator;
        IdMeci = idMeci;
        NrPuncteInscrise = nrPuncteInscrise;
        Tip = tip;
    }
}