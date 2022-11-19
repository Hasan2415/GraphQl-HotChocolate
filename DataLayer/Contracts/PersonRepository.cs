namespace DataLayer.Contracts;

public interface PersonRepository
{
    Task<List<Person>> GetAll();
    Task<Person?> Find(int id);
}