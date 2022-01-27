using Common.Commands;

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
    public async Task<List<Person>> Get(CancellationToken token) => 
        await Mediator.Send(new GetPersonListQuery(),token);

    // GET api/<Persons>/5
    [HttpGet("{id}")]
    public async Task<Person> Get(int id,CancellationToken token) => 
        await Mediator.Send(new GetPersonByIdQuery(id), token);

    // POST api/<Persons>
    [HttpPost]
    public async Task<Person> Post([FromBody] PersonEntry dto,CancellationToken token) => 
        await Mediator.Send(new InsertPersonCommand(dto.FirstName, dto.LastName),token);
}
