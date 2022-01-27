namespace Common.Queries;
public record GetPersonByIdQuery(int id) : IRequest<Person>;