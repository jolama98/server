
namespace boss_monter.Services;

public class HeroService
{
    private readonly HeroRepository _heroRepository;

    public HeroService(HeroRepository heroRepository)
    {
        _heroRepository = heroRepository;
    }

    internal List<Hero> GetAllHeros()
    {
        throw new NotImplementedException();
    }
}
