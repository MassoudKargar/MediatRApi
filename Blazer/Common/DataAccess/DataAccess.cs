namespace Common.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private readonly List<Person> _people = new();

        public DataAccess()
        {
            _people.Add(new(1, "Masoud", "Kargar"));
            _people.Add(new(2, "Ali", "Kargar"));
        }
        List<Person> IDataAccess.GetPeople() => _people;
        Person IDataAccess.InsertPerson(string firstName, string lastName)
        {
            Person p = new(_people.Max(m => m.Id)+1,firstName, lastName);
            _people.Add(p);  
            return p;
        }
    }
}
