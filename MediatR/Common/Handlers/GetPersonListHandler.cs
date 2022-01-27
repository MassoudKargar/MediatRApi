using Common.DataAccessSetting;

namespace Common.Handlers;
public class GetPersonListHandler : IRequestHandler<GetPersonListQuery,List<Person>>
{
    public GetPersonListHandler(IDataAccess dataAccess)
    {
        DataAccess = dataAccess;
    }

    private IDataAccess DataAccess { get; }
    public Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(result: DataAccess.GetPeople());
    }
}

