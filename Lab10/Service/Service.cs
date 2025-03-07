using Lab10.Domain;
using Lab10.Repository;

namespace Lab10.Service;

public class Service
{
    private IRepository<long, Echipa> echipe;
    private IRepository<long, Elev> elevi;
    private IRepository<long, Jucator> jucator;
    private IRepository<long, Meci> meciuri;
    private IRepository<long, JucatorActiv> jucatoriActivi;

    public Service(IRepository<long, Echipa> echipe, IRepository<long, Elev> elevi, IRepository<long, Jucator> jucatori,
        IRepository<long, Meci> meciuri, IRepository<long, JucatorActiv> jucatoriActivi)
    {
        this.echipe = echipe;
        this.elevi = elevi;
        this.jucator = jucatori;
        this.meciuri = meciuri;
        this.jucatoriActivi = jucatoriActivi;
    }

    public IEnumerable<Jucator> JucatoriiUneiEchipe(Echipa echipa)
    {
        return jucator.FindAll().Where(j =>
        {
            Jucator jucator = (Jucator)j;
            return j.echipa.Equals(echipa);
        });
    }

    public IEnumerable<Jucator> JucatoriiActiviAiUneiEchipeDeLaUnMeci(Echipa echipa, Meci meci)
    {
        return
            from jucatorActiv in jucatoriActivi.FindAll()
            join jucator in jucator.FindAll()
                on jucatorActiv.idJucator equals jucator.id
                where jucatorActiv.idMeci == meci.id && jucator.echipa.id == echipa.id
                select jucator;
    }

    public IEnumerable<Meci> MeciuriDinPerioada(DateTime beginingDate, DateTime endingDate)
    {
        return
            from meci in meciuri.FindAll()
            where meci.date >= beginingDate && meci.date <= endingDate
                select meci;
    }

    public string ScorulUnuiMeci(Meci meci)
    {
        int scorEchipa1 = 0;
        try
        {
            scorEchipa1 =
                (from jucatorActiv in jucatoriActivi.FindAll()
                    join jucator in jucator.FindAll()
                        on jucatorActiv.idJucator equals jucator.id
                    join echipa in echipe.FindAll()
                        on jucator.echipa.id equals echipa.id
                    where jucatorActiv.idMeci == meci.id && meci.echipa1.id == echipa.id
                    select jucatorActiv.nrPuncteInscrise).Sum();
        }
        catch { }
        
        int scorEchipa2 = 0;
        try
        {
            scorEchipa2 =
                (from jucatorActiv in jucatoriActivi.FindAll()
                    join jucator in jucator.FindAll()
                        on jucatorActiv.idJucator equals jucator.id
                    join echipa in echipe.FindAll()
                        on jucator.echipa.id equals echipa.id
                    where jucatorActiv.idMeci == meci.id && meci.echipa2.id == echipa.id
                    select jucatorActiv.nrPuncteInscrise).Sum();
        }
        catch { }
        
        return scorEchipa1.ToString() + " - " + scorEchipa2.ToString();
    }

    public Echipa findEchipa(long id)
    {
        return echipe.FindOne(id);
    }

    public Meci findMeci(long id)
    {
        return meciuri.FindOne(id);
    }
}