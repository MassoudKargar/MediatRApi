namespace Common.Handlers;
public class GetPersonListHandler : IRequestHandler<GetPersonListQuery,List<Person>>
{
    public GetPersonListHandler(IDataAccess dataAccess)
    {
        DataAccess = dataAccess;
    }
    private IDataAccess DataAccess { get; }
    Task<List<Person>> IRequestHandler<GetPersonListQuery, List<Person>>.Handle(GetPersonListQuery request, CancellationToken cancellationToken) => 
        Task.FromResult(result: DataAccess.GetPeople());
}

