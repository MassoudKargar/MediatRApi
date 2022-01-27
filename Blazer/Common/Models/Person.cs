namespace Common.Models;
public class Person
{
    public Person(int id, string firstName, string lastName) : this()
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public Person()
    {

    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}