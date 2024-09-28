namespace boss_monter.Repositories;

public class HeroRepository
{
    private readonly IDbConnection _db;

    public HeroRepository(IDbConnection db)
    {
        _db = db;
    }
}

