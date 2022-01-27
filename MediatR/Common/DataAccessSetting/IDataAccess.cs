namespace Common.DataAccessSetting
{
    public interface IDataAccess
    {
        List<Person> GetPeople();
        Person InsertPerson(string firstName, string lastName);
    }
}
