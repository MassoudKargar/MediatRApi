namespace Common.Handlers;
public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, Person>
{
    public GetPersonByIdHandler(IMediator mediator)
    {
        Mediator = mediator;
    }
    private IMediator Mediator { get; }

    async Task<Person?> IRequestHandler<GetPersonByIdQuery, Person>.Handle(GetPersonByIdQuery request, CancellationToken cancellationToken) => 
        (await Mediator.Send(new GetPersonListQuery(), cancellationToken)).FirstOrDefault(f => f.Id == request.id);
}