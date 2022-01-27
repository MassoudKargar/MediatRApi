namespace Common.Commands; 
public record InsertPersonCommand(string FirstName, string LastName) : IRequest<Person>;