namespace boss_monter.Controllers;

public class HeroController : ControllerBase
{
    private readonly Auth0Provider _auth0Provider;
    private readonly HeroService _heroService;

    public HeroController(HeroService heroService, Auth0Provider auth0Provider)
    {
        _heroService = heroService;
        _auth0Provider = auth0Provider;
    }


    [HttpGet]
    public ActionResult<List<Hero>> GetAllHero()
    {
        try
        {
            List<Hero> heros = _heroService.GetAllHeros();
            return Ok(heros);

        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }
}
