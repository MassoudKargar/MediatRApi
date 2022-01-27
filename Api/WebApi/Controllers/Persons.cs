namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Persons : ControllerBase
{
    public Persons(IMediator mediator)
    {
        Mediator = mediator;
    }

    private IMediator Mediator { get; }

    // GET: api/<Persons>
    [HttpGet]
    public async Task<List<Person>> Get()
    {
        return await Mediator.Send(new GetPersonListQuery());
    }

    // GET api/<Persons>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<Persons>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }
}
