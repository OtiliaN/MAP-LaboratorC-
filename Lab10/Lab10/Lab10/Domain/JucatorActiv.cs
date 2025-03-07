namespace Lab10.Domain;

public enum Tip
{
    REZERVA, PARTICIPANT
}
public class JucatorActiv : Entity<long>
{
    public long idJucator { get; set; }
    public long idMeci { get; set; }
    public int nrPuncteInscrise { get; set; }
    public Tip tip { get; set; }

    public JucatorActiv() { }

    public JucatorActiv(long id, long idJucator, long idMeci, int nrPuncteInscrise, Tip tip) : base(id)
    {
        this.idJucator = idJucator;
        this.idMeci = idMeci;
        this.nrPuncteInscrise = nrPuncteInscrise;
        this.tip = tip;
    }
}