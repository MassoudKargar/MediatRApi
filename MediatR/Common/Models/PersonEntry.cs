namespace Common.Models;

public class PersonEntry
{
    public PersonEntry(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}