namespace Common.Handlers;
public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, Person>
{
    private IDataAccess DataAccess { get; }

    public InsertPersonHandler(IDataAccess dataAccess)
    {
        DataAccess = dataAccess;
    }
    Task<Person> IRequestHandler<InsertPersonCommand, Person>.Handle(InsertPersonCommand request, CancellationToken cancellationToken) => 
        Task.FromResult(DataAccess.InsertPerson(request.FirstName, request.LastName));
}

